using System;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace MoPhongNhanSinh.Services
{
    public class ThienCoAIService
    {
        public string Provider = "gemini"; // "gemini" or "openai"
        public string ApiKey = "";
        public string Model = "gemini-2.0-flash";
        public string BaseUrl = "https://api.openai.com/v1";

        [Serializable]
        private class GeminiRequest
        {
            public GeminiContent[] contents;
        }

        [Serializable]
        private class GeminiContent
        {
            public GeminiPart[] parts;
        }

        [Serializable]
        private class GeminiPart
        {
            public string text;
        }

        public IEnumerator GenerateEvent(string prompt, Action<string> onSuccess, Action<string> onError)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                onError?.Invoke("Chưa cấu hình API Key Thiên Cơ AI (chế độ Offline).");
                yield break;
            }

            string url = Provider == "gemini"
                ? $"https://generativelanguage.googleapis.com/v1beta/models/{Model}:generateContent?key={ApiKey}"
                : $"{BaseUrl.TrimEnd('/')}/chat/completions";

            string body = Provider == "gemini"
                ? JsonUtility.ToJson(new GeminiRequest
                {
                    contents = new[] { new GeminiContent { parts = new[] { new GeminiPart { text = prompt } } } }
                })
                : $"{{\"model\":\"{Model}\",\"messages\":[{{\"role\":\"user\",\"content\":\"{EscapeJson(prompt)}\"}}]}}";

            using (var req = new UnityWebRequest(url, "POST"))
            {
                byte[] bodyRaw = Encoding.UTF8.GetBytes(body);
                req.uploadHandler = new UploadHandlerRaw(bodyRaw);
                req.downloadHandler = new DownloadHandlerBuffer();
                req.SetRequestHeader("Content-Type", "application/json");
                if (Provider != "gemini")
                    req.SetRequestHeader("Authorization", $"Bearer {ApiKey}");

                yield return req.SendWebRequest();

                if (req.result == UnityWebRequest.Result.Success)
                    onSuccess?.Invoke(req.downloadHandler.text);
                else
                    onError?.Invoke($"Lỗi Thiên Cơ AI: {req.error}");
            }
        }

        private static string EscapeJson(string s)
            => (s ?? "").Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "");
    }
}
