using System;
using System.Collections.Generic;
using UnityEngine;

namespace MoPhongNhanSinh.Core
{
    public class GameDatabase
    {
        private static GameDatabase _instance;
        public static GameDatabase Instance => _instance ?? (_instance = new GameDatabase());

        public MetaData Meta { get; private set; }
        public Dictionary<string, TalentDef> Talents { get; private set; } = new Dictionary<string, TalentDef>();
        public Dictionary<string, ItemDef> Items { get; private set; } = new Dictionary<string, ItemDef>();
        public Dictionary<string, TechDef> Techs { get; private set; } = new Dictionary<string, TechDef>();
        public AdventureData Adventures { get; private set; }
        public bool IsLoaded { get; private set; }

        [Serializable]
        private class ArrayWrapper<T>
        {
            public T[] items;
        }

        private T[] LoadArray<T>(string resourcePath)
        {
            var asset = Resources.Load<TextAsset>(resourcePath);
            if (asset == null)
            {
                Debug.LogWarning($"[GameDatabase] Missing resource: {resourcePath}");
                return Array.Empty<T>();
            }
            string wrapped = "{\"items\":" + asset.text + "}";
            return JsonUtility.FromJson<ArrayWrapper<T>>(wrapped)?.items ?? Array.Empty<T>();
        }

        private T LoadObject<T>(string resourcePath) where T : new()
        {
            var asset = Resources.Load<TextAsset>(resourcePath);
            if (asset == null)
            {
                Debug.LogWarning($"[GameDatabase] Missing resource: {resourcePath}");
                return new T();
            }
            return JsonUtility.FromJson<T>(asset.text);
        }

        public void LoadAll()
        {
            if (IsLoaded) return;

            Meta = LoadObject<MetaData>("Data/meta");
            Adventures = LoadObject<AdventureData>("Data/adventures");

            Talents.Clear();
            foreach (var t in LoadArray<TalentDef>("Data/talents"))
                if (!string.IsNullOrEmpty(t.id)) Talents[t.id] = t;

            Items.Clear();
            foreach (var it in LoadArray<ItemDef>("Data/items"))
                if (!string.IsNullOrEmpty(it.id)) Items[it.id] = it;

            Techs.Clear();
            foreach (var q in LoadArray<TechDef>("Data/techs"))
                if (!string.IsNullOrEmpty(q.id)) Techs[q.id] = q;

            IsLoaded = true;
            Debug.Log($"[GameDatabase] Loaded v{Meta.appVersion}: {Meta.realms?.Length ?? 0} realms, {Talents.Count} talents, {Items.Count} items, {Techs.Count} techs.");
        }
    }
}
