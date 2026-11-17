using System;
using UnityEngine;
using MoPhongNhanSinh.Core;

namespace MoPhongNhanSinh.Services
{
    public static class CultivationService
    {
        public static long NeedXp(PlayerState x)
            => (long)Math.Round(100.0 * Math.Pow(2.2, x.realm) * (1.0 + x.layer * 0.35));

        public static int MaxLife(PlayerState x)
        {
            var lifeArr = GameDatabase.Instance.Meta?.life;
            int baseLife = (lifeArr != null && x.realm < lifeArr.Length) ? lifeArr[x.realm] : 100;
            return baseLife + x.lifeBonus;
        }

        public static long BreakthroughCost(PlayerState x)
        {
            long sq = 50L * (x.realm + 1) * (x.realm + 1);
            long exp = (long)Math.Round(55.0 * Math.Pow(1.75, x.realm));
            return Math.Max(sq, exp);
        }

        public static int RequiredTam(PlayerState x) => 15 + x.realm * 8;

        public static float BreakthroughChance(PlayerState x)
        {
            var st = CharacterStatsService.Compute(x);
            float chance = 0.55f + (st.tam - RequiredTam(x)) * 0.01f + x.pb + x.pity + st.pb - 0.004f * x.toxin;
            return Mathf.Clamp(chance, 0.10f, 0.95f);
        }

        public static string TrainOneYear(PlayerState x)
        {
            if (x.age >= MaxLife(x))
                return "Thọ nguyên cạn kiệt, cần đột phá hoặc dùng Thọ Nguyên Đan!";

            var db = GameDatabase.Instance;
            var st = CharacterStatsService.Compute(x);
            float bodyC = (db.Meta.bodies != null && x.body < db.Meta.bodies.Length) ? db.Meta.bodies[x.body].c : 1f;
            float rootC = (db.Meta.roots != null && x.root < db.Meta.roots.Length) ? db.Meta.roots[x.root].c : 1f;

            double raw = 0.9 * 22.0 * Math.Pow(1.95, x.realm) * (1.0 + st.ngo / 25.0) * bodyC * rootC * (1.0 + st.tc);
            long gain = Math.Max(1L, (long)Math.Round(raw * (1.0 - 0.004 * x.toxin)));

            x.age++;
            x.xp += gain;
            x.totalXp += gain;
            if (x.toxin > 0) x.toxin = Mathf.Max(0, x.toxin - 1);

            return $"Bế quan 1 năm, thu được {gain:N0} tu vi.";
        }

        public static string TryBreakthrough(PlayerState x)
        {
            long need = NeedXp(x);
            if (x.xp < need) return $"Chưa đủ tu vi ({x.xp:N0}/{need:N0}).";

            var realms = GameDatabase.Instance.Meta?.realms;
            if (x.layer < 8)
            {
                x.xp -= need;
                x.layer++;
                string rName = (realms != null && x.realm < realms.Length) ? realms[x.realm] : $"Cảnh giới {x.realm}";
                return $"Đột phá thành công: {rName} tầng {x.layer + 1}!";
            }

            if (realms != null && x.realm >= realms.Length - 1)
                return "Đã đạt Hỗn Nguyên viên mãn!";

            var st = CharacterStatsService.Compute(x);
            if (st.tam < RequiredTam(x)) return $"Cần Tâm cảnh >= {RequiredTam(x)} (hiện {st.tam}).";
            if (x.tm) return "Đang nhiễm Tâm Ma, cần thanh tẩy trước khi đột phá.";
            long cost = BreakthroughCost(x);
            if (x.stones < cost) return $"Cần {cost:N0} linh thạch (hiện {x.stones:N0}).";
            if (x.realm == 8 && st.thu < 150000) return $"Cần Phòng ngự >= 150.000 để gánh Phi Thăng Tiên Kiếp (hiện {st.thu:N0}).";

            x.stones -= cost;
            float p = BreakthroughChance(x);
            x.pb = 0f;

            if (UnityEngine.Random.value > p)
            {
                x.pity = Mathf.Min(0.20f, x.pity + 0.04f);
                x.xp = Math.Max(0L, x.xp - (long)Math.Round(need * 0.25));
                if (UnityEngine.Random.value < 0.5f) x.tm = true;
                return "Đột phá đại cảnh giới thất bại, tổn thất tu vi!";
            }

            int nextRealm = x.realm + 1;
            if (nextRealm >= 2)
            {
                double k = 190.0 * Math.Pow(2.15, nextRealm);
                float tribChance = Mathf.Clamp((float)(st.thu / k), 0.15f, 0.95f);
                if (UnityEngine.Random.value > tribChance)
                {
                    x.pity = Mathf.Min(0.20f, x.pity + 0.04f);
                    x.xp = Math.Max(0L, x.xp - (long)Math.Round(need * 0.35));
                    x.tm = true;
                    return "Thiên kiếp giáng xuống, vượt kiếp thất bại và nhiễm tâm ma!";
                }
            }

            x.xp -= need;
            x.realm = nextRealm;
            x.layer = 0;
            x.pity = 0f;
            x.tm = false;
            x.toxin = Mathf.Max(0, x.toxin - (15 + nextRealm * 2));
            x.van += 2;
            if (nextRealm == 9) x.ascended++;

            string nextName = (realms != null && nextRealm < realms.Length) ? realms[nextRealm] : $"Cảnh giới {nextRealm}";
            return $"Đột phá thành công: {nextName}! Tẩy kinh phạt tủy (+2 Khí vận).";
        }
    }
}
