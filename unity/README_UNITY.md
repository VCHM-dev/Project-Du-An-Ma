# Hướng dẫn mở & chạy bản Unity (`v5.24`) trên máy cá nhân

Thư mục `unity/` chứa toàn bộ **dữ liệu JSON** trích xuất từ `index.html` (`v5.24`) và **mã nguồn C# Core** sẵn sàng nạp vào Unity Editor (không cần cài thêm thư viện ngoài).

## 1. Cấu trúc thư mục
- `Assets/Resources/Data/` — 9 file JSON dữ liệu game (`meta.json`, `talents.json`, `items.json`, `techs.json`, `adventures.json`, `companions.json`, `sects.json`, `simulation.json`, `achievements.json`).
- `Assets/Scripts/Core/` — `GameModels.cs`, `GameDatabase.cs`, `SaveService.cs`.
- `Assets/Scripts/Services/` — `CharacterStatsService.cs`, `CultivationService.cs`, `AdventureService.cs`, `ThienCoAIService.cs`.
- `Assets/Scripts/GameManager.cs` — Script `MonoBehaviour` điều phối chính để test ngay trong Scene.

## 2. Cách tạo Project Unity trên máy của bạn
1. Mở **Unity Hub** → **New Project** → chọn template **2D (URP)** (Unity 2022.3 LTS hoặc Unity 6).
2. Copy toàn bộ thư mục `Resources/` và `Scripts/` bên trong `unity/Assets/` vào thư mục `Assets/` của project Unity bạn vừa tạo.
3. Mở Scene mặc định (`SampleScene`), tạo một **Empty GameObject** đặt tên `GameManager`.
4. Kéo script `GameManager.cs` gắn vào `GameManager`.
5. Bấm **Play ▶** trong Unity Editor:
   - Nhấn chuột phải vào component **GameManager** trong Inspector (hoặc bấm biểu tượng `⋮`) để chạy thử các lệnh `[ContextMenu]`:
     - `1. Bế Quan 1 Năm`
     - `2. Thử Đột Phá`
     - `3. Đánh Boss Ải 1 (Rừng Hắc Phong)`
     - `4. Reset Save Mới`
   - Theo dõi chỉ số `Player`, `CurrentStats` và `LastLog` cập nhật trực tiếp trên Inspector & Console.

## 3. Bước tiếp theo để dựng đồ họa kiểu Quỷ Cốc Bát Hoang
1. Dựng Canvas UI (UGUI / UI Toolkit) kết nối với `GameManager.Player` và `CurrentStats`.
2. Cài **2D Animation** (miễn phí từ Unity Package Manager) hoặc **Spine 2D** để gắn xương cho nhân vật, Đạo lữ, Linh thú, Boss.
3. Tạo Tilemap thủy mặc 2D cho các ải Lịch Luyện và kết nối va chạm/tung chiêu với `AdventureService`.
