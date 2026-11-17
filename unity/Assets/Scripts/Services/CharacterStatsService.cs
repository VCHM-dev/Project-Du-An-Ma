using System;
using System.Collections.Generic;
using UnityEngine;
using MoPhongNhanSinh.Core;

namespace MoPhongNhanSinh.Services
{
    public static class CharacterStatsService
    {
        private static void AddMod(StatBlock m, StatBlock src, float scale)
        {
            if (src == null) return;
            m.the += src.the * scale;
            m.linh += src.linh * scale;
            m.ngo += src.ngo * scale;
            m.than += src.than * scale;
            m.tam += src.tam * scale;
            m.van += src.van * scale;
            m.luc += src.luc * scale;
            m.thu += src.thu * scale;
            m.toc += src.toc * scale;
            m.tc += src.tc * scale;
            m.pb += src.pb * scale;
        }

        public static float EquipMultiplier(PlayerState x, OwnedItem it)
        {
            float qlMul = 1f + it.ql * 0.25f + (it.ex ? 0.35f : 0f);
            float rfMul = 1f + it.rf * 0.1f;
            float bmMul = (!string.IsNullOrEmpty(x.bmWeaponUid) && x.bmWeaponUid == it.u)
                ? (1f + x.bmLevel * 0.15f)
                : 1f;
            return qlMul * rfMul * bmMul;
        }

        public static ComputedStats Compute(PlayerState x)
        {
            var db = GameDatabase.Instance;
            var body = (db.Meta.bodies != null && x.body < db.Meta.bodies.Length) ? db.Meta.bodies[x.body] : new BodyDef { c = 1f, a = 0 };
            var root = (db.Meta.roots != null && x.root < db.Meta.roots.Length) ? db.Meta.roots[x.root] : new RootDef { c = 1f };

            int rank = x.realm * 9 + x.layer;
            float k = 8f + rank * 1.5f;
            var m = new StatBlock();

            if (x.talents != null)
            {
                foreach (var t in x.talents)
                {
                    if (!t.on || !db.Talents.TryGetValue(t.id, out var def)) continue;
                    float scale = (1f + 0.25f * (t.lv - 1)) * (1f + 0.08f * x.body);
                    AddMod(m, def.e, scale);
                }
            }

            var eqItems = new List<OwnedItem>();
            string[] eqUids = { x.eq?.weapon, x.eq?.armor, x.eq?.accessory, x.eq?.artifact };
            foreach (var uid in eqUids)
            {
                if (string.IsNullOrEmpty(uid) || x.inv == null) continue;
                var it = x.inv.Find(i => i.u == uid);
                if (it != null && db.Items.TryGetValue(it.id, out var idef))
                {
                    eqItems.Add(it);
                    AddMod(m, idef.s, EquipMultiplier(x, it));
                }
            }

            bool hasBurstTech = false;
            if (x.techs != null)
            {
                foreach (var qt in x.techs)
                {
                    if (!qt.eq || !db.Techs.TryGetValue(qt.id, out var qdef)) continue;
                    float power = 1f + 0.2f * (qt.lv - 1);
                    AddMod(m, qdef.e, power);
                    if (qdef.sp != null && Array.IndexOf(qdef.sp, "burst") >= 0)
                        hasBurstTech = true;
                }
            }

            if (x.tm) m.tam -= 8f;

            float ab = 2f * x.achCount + 10f * x.reborn;
            int aThe = Mathf.RoundToInt(k + body.a + ab + m.the);
            int aLinh = Mathf.RoundToInt(k + Mathf.Round(root.c * 4f) + ab + m.linh);
            int aNgo = Mathf.RoundToInt(k + ab + m.ngo);
            int aThan = Mathf.RoundToInt(k + ab + m.than);
            int aTam = Mathf.RoundToInt(k + ab + m.tam);
            int aVan = Mathf.RoundToInt(k + x.van + ab + m.van);

            double flatMul = Math.Pow(1.85, x.realm);
            double realmMul = Math.Pow(2.05, x.realm) * (1.0 + x.layer * 0.1);
            double gfMul = 1.0 + x.gfBuff;

            long luc = (long)Math.Round((aThe * 1.4 + aLinh * 1.1 + aNgo * 0.7 + m.luc * flatMul) * realmMul * gfMul);
            long thu = (long)Math.Round((aThe * 2.2 + aTam * 1.0 + m.thu * flatMul) * realmMul * gfMul);
            long toc = (long)Math.Round((aLinh * 1.3 + aThan * 0.9 + m.toc * flatMul) * realmMul * gfMul);

            long maxHp = (long)Math.Round((aThe * 8.5 + aThan * 3.5 + 100.0) * realmMul * gfMul);
            long maxMp = (long)Math.Round((aLinh * 6.0 + aThan * 5.0 + 60.0) * realmMul * gfMul);

            float eqPen = 0f;
            foreach (var it in eqItems)
                eqPen += it.ql == 2 ? 15f : it.ql == 3 ? 30f : 0f;

            float rawPen = aNgo * 0.25f + eqPen;
            float pen = 0.80f * rawPen / (rawPen + 60f);

            float rawCrit = 10f + aVan * 0.25f + (hasBurstTech ? 15f : 0f);
            float crit = 0.70f * rawCrit / (rawCrit + 55f);
            float critDmg = 1.5f + 0.80f * aThan / (aThan + 150f);

            float dRaw = aVan * 0.6f + aLinh * 0.4f;
            float dodge = 0.40f * dRaw / (dRaw + 180f);

            return new ComputedStats
            {
                the = aThe, linh = aLinh, ngo = aNgo, than = aThan, tam = aTam, van = aVan,
                luc = luc, thu = thu, toc = toc, maxHp = maxHp, maxMp = maxMp,
                pen = pen, crit = crit, critDmg = critDmg, dodge = dodge,
                tc = m.tc, pb = m.pb, realmMul = realmMul
            };
        }
    }
}
