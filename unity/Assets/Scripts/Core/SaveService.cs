using System;
using System.IO;
using UnityEngine;

namespace MoPhongNhanSinh.Core
{
    public static class SaveService
    {
        private static string SavePath => Path.Combine(Application.persistentDataPath, "msns_save.json");
        private static string BackupPath => Path.Combine(Application.persistentDataPath, "msns_save_backup.json");

        public static void Save(PlayerState state)
        {
            if (state == null) return;
            state.rev++;
            string json = JsonUtility.ToJson(state, true);
            if (File.Exists(SavePath))
                File.Copy(SavePath, BackupPath, true);
            File.WriteAllText(SavePath, json);
        }

        public static PlayerState LoadOrCreate(string defaultName = "Hàn Lập")
        {
            if (File.Exists(SavePath))
            {
                try
                {
                    string json = File.ReadAllText(SavePath);
                    var state = JsonUtility.FromJson<PlayerState>(json);
                    if (state != null) return Migrate(state);
                }
                catch (Exception ex)
                {
                    Debug.LogError($"[SaveService] Load failed, creating new save: {ex.Message}");
                }
            }

            return CreateNew(defaultName);
        }

        public static PlayerState CreateNew(string name)
        {
            return new PlayerState
            {
                saveId = Guid.NewGuid().ToString("N"),
                rev = 1,
                name = name,
                age = 16,
                stones = 100
            };
        }

        public static PlayerState Migrate(PlayerState s)
        {
            var db = GameDatabase.Instance;
            int maxRealm = (db.Meta?.realms?.Length ?? 14) - 1;
            s.realm = Mathf.Clamp(s.realm, 0, maxRealm);
            s.layer = Mathf.Clamp(s.layer, 0, 8);
            if (s.talents == null) s.talents = new System.Collections.Generic.List<OwnedTalent>();
            if (s.inv == null) s.inv = new System.Collections.Generic.List<OwnedItem>();
            if (s.techs == null) s.techs = new System.Collections.Generic.List<OwnedTech>();
            return s;
        }
    }
}
