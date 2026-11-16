# PROJECT STRUCTURE & CODE MAP — MÔ PHỎNG NHÂN SINH

## 1. Cấu trúc thư mục & File
Dự án tuân thủ kiến trúc **Single-File Web Application** (chạy trực tiếp không cần server/build tool):
- `Mô Phỏng Nhân Sinhtest_2.html` — File mã nguồn duy nhất chứa toàn bộ HTML, CSS và JavaScript (phiên bản v5.9 — tích hợp Thiên Cơ AI, Đồng Bộ Vân Đạo, Chiến Trường Chiến Thuật & Bách Nghệ Thực Chiến).
- `project_status.md` — Nhật ký tiến độ (Đã làm / Đang làm / Sắp làm). Cập nhật sau mỗi lần sửa code.
- `project_structure.md` — Bản đồ mã nguồn (file này) giúp AI định vị chính xác vị trí các hàm/dữ liệu.
- `project_rules.md` — Bộ quy tắc kỹ thuật, tầm nhìn game và cách xử lý tình huống mập mờ.

---

## 2. Bản đồ Mã Nguồn bên trong `Mô Phỏng Nhân Sinhtest_2.html`
Khi cần chỉnh sửa tính năng nào, AI hãy tìm đúng khu vực comment `/* ===== ... ===== */` tương ứng trong thẻ `<script>`:

| Khu vực / Biến chính | Chức năng & Vị trí cần sửa |
| :--- | :--- |
| `<style>` | Toàn bộ CSS, biến màu `:root`, hiệu ứng thẻ `.r4/.r5/.r6`, layout `.g3`, toast, modal. |
| `/* ===== DỮ LIỆU TĨNH ===== */` | `APP_VERSION`, `GUIDE_DATA` (`onboardingSteps`, `patchNotes`, `codexTopics`) và mảng hằng số: `REALMS` (14 cảnh giới), `LIFE`, `BODIES`, `ROOTS`, `TAL` (43 thiên phú), `ITEMS`, `TECH` (19 công pháp), `TD/ID/QD`. |
| `/* ===== TIỆN ÍCH ===== */` | `store` (`localStorage` key `msns_main_v1`), `say()`, `fx()`, `log()`, `hasT()`, `talMul()`, `eqMul()`. |
| `/* ===== DỮ LIỆU BÁCH NGHỆ... ===== */` | Công thức chế tạo: `DR` (Luyện đan), `KR` (Luyện khí), `QU` (Nâng phẩm), `AR` (7 Trận pháp), `TR` (2 Trận Bàn thực chiến), `PT` (Đan độc), `PE` (Hiệu ứng dùng đan). |
| `/* ===== SERVICES HỢP NHẤT ===== */` | Logic nghiệp vụ lõi: `characterService`, `techniqueService`, `inventoryService`, `equipmentService`, `talentInventoryService`, `characterStatsService` (`realmMul = 2.1^realm`), `cultivationService` (có `pity`, `auto` tự lên tầng), `destinyService`. |
| `/* ===== LỊCH LUYỆN & CHIẾN ĐẤU... ===== */` | `ADV` (14 ải), `STANCES` (3 Tâm pháp giao chiến), `MUTS` (4 hệ Yêu Thú Biến Dị), `skillOf()`, `foeOf()`, `calcSup()` (Uy Áp Cảnh Giới), `adventureService` (`initBattle`, `step`, `autoPick`, `simBattle`, `resolve`, `fight`, `act`, `sweep`). |
| `/* ===== PHƯỜNG THỊ ===== */` | `shopService`: sinh gian hàng 5 năm/lần, mua/bán vật phẩm (có kiểm tra khóa `it.lk`). |
| `/* ===== DỮ LIỆU & SERVICE MÔ PHỎNG... ===== */` | `EVT` (kho sự kiện), `CAL/CE/CL` (Kiếp nạn), `NP` (8 NPC), `CH` (chuỗi sự kiện 3 hồi), `rewardIntegrationService` (`start`, `act`, `choose`, `finish`, `claim`, `aiGen`, `aiResolve`, `aiApply`). |
| `/* ===== THIÊN CƠ AI (LLM BYOK...) ===== */` | `thienCoAI` (lưu `localStorage` riêng `'msns_ai_cfg'`, gọi Gemini / OpenAI-compatible, `parse` auto-repair JSON, `ctx` đóng gói Context State, nén trí nhớ `m.aiSummary` mỗi 3 lượt). |
| `/* ===== THÀNH TỰU, SAO LƯU & MIGRATE ===== */` | `ACH`, `achievementService`, `migrate()` (lọc dữ liệu rác, khởi tạo `s.saveId`, `s.rev`, `s.updatedAt` & nâng cấp save cũ). |
| `/* ===== HỆ THỐNG LƯU TRỮ THỐNG NHẤT (SAVE SERVICE) ===== */` | `saveService` (Adapter-ready: `IndexedDB` `msns_saves_v1`, 1-click `quickSave`, xuất/nhập file `.msns`, `showSaveFilePicker`, link chuyển máy `#s=` nén `gzip`), `savePanel()`, `svPreviewModal()`. |
| `/* ===== HỆ THỐNG HƯỚNG DẪN TÂN THỦ & WHAT'S NEW (GUIDE SERVICE) ===== */` | `guideService` (lưu `msns_guide_v1`, `checkAuto()`, spotlight tour `positionTour()`, `renderLayer()` cho Welcome / What's New / Cẩm Nang 3 tab). |
| `/* ===== GIAO DIỆN CÁC TAB ===== */` | Các hàm render giao diện: `vChar`, `vTal`, `vCul`, `vInv` (lọc kép phẩm chất + loại, khóa đồ, bán hàng loạt), `vTec`, `vKt`, `aiPanel`, `runUI`, `legacyUI`, `btlModal` (chiến trường trực quan), `vAdv` (`BOSS_ART`), `vShop`, `vCraft`, `vCreate`. |
| `/* ===== TÙY BIẾN GIAO DIỆN & NHẠC NỀN ===== */` | `applyTheme()`, `profileCard()`, `apHTML()`, `imgFile()` (nén ảnh Canvas), `idb()` (IndexedDB), bộ tổng hợp âm thanh Web Audio `BG`. |
| `/* ===== BẢO MẬT ADMIN PANEL ===== */` | `ADMIN_HASH`, `sha256Fallback()`, `openAdminPrompt()`, `verifyAdminPwd()`, `vAdmin()`. |
| `/* ===== BALANCE LAB ===== */` | `runLab()`, `labUI()`, `bulkSell(maxR)` — Giả lập bot tự chơi trên bản sao dữ liệu và hàm bán trang bị hàng loạt. |
| `/* ===== ĐIỀU HƯỚNG & BẢNG LỆNH A ===== */` | Mảng `TABS`, hàm `render()`, đối tượng `A` (chứa toàn bộ handler cho `data-a="..."`), và các `addEventListener` toàn cục. |
