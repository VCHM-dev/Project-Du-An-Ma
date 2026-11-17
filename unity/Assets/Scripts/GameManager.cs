using UnityEngine;
using MoPhongNhanSinh.Core;
using MoPhongNhanSinh.Services;

namespace MoPhongNhanSinh
{
    public class GameManager : MonoBehaviour
    {
        [Header("Trạng thái nhân vật hiện tại")]
        public PlayerState Player;
        public ComputedStats CurrentStats;
        [TextArea(2, 6)]
        public string LastLog;

        private void Awake()
        {
            GameDatabase.Instance.LoadAll();
            Player = SaveService.LoadOrCreate("Hàn Lập");
            RefreshStats();
        }

        public void RefreshStats()
        {
            CurrentStats = CharacterStatsService.Compute(Player);
        }

        [ContextMenu("1. Bế Quan 1 Năm")]
        public void ActionTrainOneYear()
        {
            LastLog = CultivationService.TrainOneYear(Player);
            RefreshStats();
            SaveService.Save(Player);
            Debug.Log($"[Bế Quan] {LastLog}");
        }

        [ContextMenu("2. Thử Đột Phá")]
        public void ActionBreakthrough()
        {
            LastLog = CultivationService.TryBreakthrough(Player);
            RefreshStats();
            SaveService.Save(Player);
            Debug.Log($"[Đột Phá] {LastLog}");
        }

        [ContextMenu("3. Đánh Boss Ải 1 (Rừng Hắc Phong)")]
        public void ActionFightStage0()
        {
            LastLog = AdventureService.SimulateBattle(Player, 0);
            RefreshStats();
            SaveService.Save(Player);
            Debug.Log($"[Lịch Luyện] {LastLog}");
        }

        [ContextMenu("4. Reset Save Mới")]
        public void ActionResetSave()
        {
            Player = SaveService.CreateNew("Hàn Lập");
            RefreshStats();
            SaveService.Save(Player);
            LastLog = "Đã khởi tạo nhân vật mới!";
            Debug.Log($"[Save] {LastLog}");
        }
    }
}
