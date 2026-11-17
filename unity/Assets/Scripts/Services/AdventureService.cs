using System;
using UnityEngine;
using MoPhongNhanSinh.Core;

namespace MoPhongNhanSinh.Services
{
    public static class AdventureService
    {
        public static FoeStats CreateFoe(int stageIndex)
        {
            var stages = GameDatabase.Instance.Adventures?.stages;
            var stage = (stages != null && stageIndex < stages.Length)
                ? stages[stageIndex]
                : new AdventureStageDef { index = stageIndex, boss = $"Yêu Thú Ải {stageIndex + 1}", element = "hoa" };

            double L = Math.Round(22.0 * Math.Pow(2.18, stageIndex));
            return new FoeStats
            {
                stageIndex = stageIndex,
                name = stage.boss,
                element = stage.element,
                maxHp = (long)Math.Round(L * 9.5),
                hp = (long)Math.Round(L * 9.5),
                luc = (long)Math.Round(L * 1.45),
                thu = (long)Math.Round(L * 1.15),
                toc = (long)Math.Round(L * 1.05)
            };
        }

        public static (float atkMul, float defMul) CalcRealmSuppression(PlayerState x, int foeRealm)
        {
            int diff = foeRealm - x.realm;
            if (diff <= 0) return (1f, 1f);

            float bmResist = Math.Min(0.25f, x.bmLevel * 0.025f);
            float totalResist = Mathf.Clamp(bmResist + x.gfSup, 0f, 0.75f);

            float atkPenalty = Math.Min(0.75f, diff * 0.22f) * (1f - totalResist);
            float dmgTakenBonus = diff * 0.25f * (1f - totalResist);
            return (1f - atkPenalty, 1f + dmgTakenBonus);
        }

        public static string SimulateBattle(PlayerState x, int stageIndex)
        {
            var st = CharacterStatsService.Compute(x);
            var foe = CreateFoe(stageIndex);
            var (atkMul, defMul) = CalcRealmSuppression(x, stageIndex);

            long playerHp = st.maxHp;
            int turn = 0;

            while (playerHp > 0 && foe.hp > 0 && turn < 40)
            {
                turn++;
                // Player turn
                long effectiveFoeDef = (long)Math.Round(foe.thu * (1f - st.pen));
                long pDmg = Math.Max(1L, (long)Math.Round((st.luc - effectiveFoeDef * 0.45) * atkMul));
                if (UnityEngine.Random.value < st.crit)
                    pDmg = (long)Math.Round(pDmg * st.critDmg);
                foe.hp -= pDmg;
                if (foe.hp <= 0) break;

                // Foe turn
                if (UnityEngine.Random.value >= st.dodge)
                {
                    long eDmg = Math.Max(1L, (long)Math.Round((foe.luc - st.thu * 0.45) * defMul));
                    playerHp -= eDmg;
                }
            }

            if (foe.hp <= 0)
            {
                long stoneReward = (long)Math.Round(18.0 * Math.Pow(1.8, stageIndex));
                long xpReward = (long)Math.Round(25.0 * Math.Pow(1.9, stageIndex));
                x.stones += stoneReward;
                x.xp += xpReward;
                x.totalXp += xpReward;
                return $"Chiến thắng {foe.name} sau {turn} hiệp! Nhận +{stoneReward:N0} linh thạch, +{xpReward:N0} tu vi.";
            }

            return $"Thất bại trước {foe.name} ở hiệp {turn} (Boss còn {Math.Max(0, foe.hp):N0}/{foe.maxHp:N0} HP).";
        }
    }
}
