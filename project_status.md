# PROJECT STATUS — MÔ PHỎNG NHÂN SINH: NHÂN VẬT CHÍNH

> **Phiên bản hiện tại:** v5.35 (`index.html`)  
> **Cập nhật lần cuối:** 2026-11-19  
> **File chạy chính:** `index.html`  

---

## 1. ĐÃ HOÀN THÀNH (DONE)
- **Phủ Kín 100% Biểu Tượng 16-bit Pixel Art Toàn Dự Án — Đợt 1B, Đợt 2 & Đợt 3 (`v5.35` · `ITEM_ART`, `TAL_ART`, `PATH_ART`, `SECT_ART`, `DAO_ART`, `artIco`, `vCreate`, `vChar`, `vTal`, `vInv`, `vKt`, `vShop`, `vSect`, `brkModal`, `buildDet`):**
  - **Đợt 1B — Hoàn Thiện 73/73 Vật Phẩm (`ITEM_ART`):** Bổ sung 28 biểu tượng Pixel Art WebP `96×96` còn lại (9 Đan dược `d9`–`d17`, 12 Nguyên liệu `m1`–`m12` và 7 Kỳ vật Đạo Lộ `bm_linh_*`, `bm_the_*`, `bm_hon_*`, `bm_nho_t`), đạt **73/73 (100%)** Kho Đồ & Trang Bị.
  - **Đợt 2 — 43/43 Thiên Phú (`TAL_ART`, `talIconHtml`):** Tạo và nhúng offline trọn bộ **43/43** biểu tượng 16-bit Pixel Art cho toàn bộ Thiên Phú (`t1`–`t43`), hiển thị đồng bộ tại tab **Thiên Phú (`vTal`)**, khung **Thiên phú kích hoạt (`vChar`)**, **6 Thiên phú khởi đầu Mô Phỏng (`vKt`)**, **Phường Thị / Đấu Giá (`vShop`)** và **Tooltip/Modal chi tiết (`buildDet`)**.
  - **Đợt 3 — 8 Đạo Lộ, 4 Tông Môn & 24 Đạo Ấn (`PATH_ART`, `SECT_ART`, `DAO_ART`):** Tạo và nhúng offline **8/8 Đạo Lộ** (`vCreate`, `vChar`, `brkModal`), **4/4 Tông Huy** (`vSect`, kèm ảnh vật phẩm Bảo Khố) và **24/24 Đạo Ấn Nghịch Thiên Cải Mệnh** (`brkModal`, `vChar`).
  - **Tổng Cộng 213 Ảnh WebP Offline-First:** Phủ **100%** mọi thực thể trong game (`9 Avatar + 4 Linh Thú + 4 Đạo Lữ + 3 Kiến Trúc + 14 Boss + 27 Công Pháp + 73 Vật Phẩm + 43 Thiên Phú + 8 Đạo Lộ + 4 Tông Môn + 24 Đạo Ấn`), giữ nguyên 100% file đơn `index.html` (~1.65 MB).
- **45 Biểu Tượng Pixel Art Kho Đồ & Trang Bị — Đợt 1A (`v5.34` · `ITEM_ART`, `itemIconHtml`, `vInv`, `vChar`, `buildDet`, `vShop`):**
  - **Nhúng Offline 45/73 Vật Phẩm (`ITEM_ART`, ~82.4 KB WebP `96×96`):** Phủ 100% **Trang bị** (8/8 Vũ khí `w1`–`w8`, 5/5 Giáp `a1`–`a5`, 5/5 Trang sức `p1`–`p5`, 7/7 Pháp bảo `f1`–`f7`), 100% **Trận Bàn** (`b1`, `b2`), **Thiên Đạo Lệnh** (`s1`), **8 Đan dược** (`d1`–`d8`) và **9 Kỳ vật Đạo Lộ** (`bm_quy_*`, `bm_kiem_*`, `bm_nghe_*`, `bm_yeu_*`, `bm_nho_d`).
  - **Hiển Thị Đồng Bộ Toàn Giao Diện:** Tích hợp `itemIconHtml(id, mode)` vào thẻ **Kho Đồ (`vInv`)**, **4 ô Trang Bị (`vChar`)**, **Hover Tooltip & Modal chi tiết (`buildDet`)**, và **Phường Thị / Đấu Giá Hội Vạn Bảo Lâu (`vShop`)**.
- **8 Icon Pixel Art & 8 Hoạt Ảnh VFX Độc Bản cho Thái Cổ Tuyệt Học · Huy Hiệu Song Hợp (`v5.33` · `TECH_ART`, `.c-ico-fuse`, `techIconHtml`, `fusionService.genName`, `BTL_VFX`, `vTec`, `buildDet`, `btlModal`):**
  - **8 Ảnh Pixel Art WebP Độc Bản (`TECH_ART['fu_*']`):** Tạo mới và nhúng offline 8 biểu tượng Pixel Art `96×96` WebP (~24 KB tổng) cho toàn bộ 8 *Thái Cổ Tuyệt Học* (`fu_amduong` .. `fu_vantien`), hiển thị đồng bộ trên thẻ Công pháp, Đồ Giám, Tooltip/Modal chi tiết và nút Tuyệt kỹ trong Chiến Trường.
  - **Huy Hiệu Song Hợp (`.c-ico-fuse`, `techIconHtml`):** Công pháp Diễn Hóa Tự Do hiển thị biểu tượng cắt chéo 2 icon gốc kèm đường sáng phân cách phát sáng theo màu Hệ Ngũ Hành và dấu `☯` (có đủ 3 cỡ: thẻ `34×34`, nút chiến đấu `18×18`, modal chi tiết `46×46`).
  - **Sinh Danh Xưng Tiên Hiệp Chuẩn (`fusionService.genName`):** Nâng cấp ghép tên theo cấu trúc *Tiền tố Hệ Ngũ Hành + Lõi Hiệu Ứng + Hậu tố Phẩm Cấp* (`Quyết` → `Đế Điển`), chống lặp từ và đồng bộ giữa Xem Trước và kết quả.
  - **8 Hoạt Ảnh Canvas 2D Additive Riêng Biệt (`BTL_VFX.spawn`, `BTL_VFX.sync`):** Thiết kế 8 hoạt ảnh riêng cho 8 *Thái Cổ Tuyệt Học* (kèm hào quang hộ thân trên bản thể cho *Thái Cổ Bất Diệt Đạo Thể*, *Thanh Mộc Tạo Hóa Tiên Kinh*, *Hỗn Độn Vạn Pháp Đế Kinh*), đồng thời giữ nguyên Combo VFX kép cho Diễn Hóa Tự Do.
- **Đại Nâng Cấp Diễn Hóa Công Pháp: 8 Thái Cổ Tuyệt Học, Song Hiệu Ứng, Combo VFX & Đồ Giám (`v5.32` · `FUSION_RECIPES`, `fusionService`, `skillOf`, `adventureService.step`, `BTL_VFX.sync`, `vTec`, `A.fuse`, `A.fuse_safe`):**
  - **8 Công Thức Ẩn Danh (`FUSION_RECIPES`) & Đồ Giám (`s.fuCodex`):** Ghép đúng cặp công pháp duyên phận mở khóa 8 *Thái Cổ Tuyệt Học* (chỉ số `×1.26–×1.35`, mô tả riêng); mỗi bộ khai mở trong Đồ Giám cộng vĩnh viễn `+2%` hiệu lực toàn bộ công pháp; ghép tự do tự sinh tên tiên hiệp (`×1.15`).
  - **Song Hiệu Ứng Thực Chiến (`k1` + `k2`), Combo VFX & Giữ Icon:** Công pháp diễn hóa kích hoạt đồng thời cả hiệu ứng chính và phụ trong chiến đấu, giữ nguyên icon Pixel Art (`TECH_ART`), bắn nối tiếp hiệu ứng Canvas 2D của cả 2 công pháp gốc (`BTL_VFX.sync`), cho phép chọn **Hệ Ngũ Hành**.
  - **Bảng Xem Trước Trực Tiếp & An Toàn (`vTec`, `fuse_safe`):** Hiển thị trực tiếp dự báo kết quả, cảm ứng Thiên Cơ khi trúng công thức ẩn, tỷ lệ thành công, tùy chọn **Diễn Hóa Đảm Bảo 100%** và loại bỏ hình phạt trừ vĩnh viễn 2 điểm Ngộ Tính gốc.
- **Giao Diện Thẻ Tinh Gọn, Hover Tooltip & Modal Chi Tiết (`v5.31` · `cCard`, `buildDet`, `detModalHTML`, `showHoverTip`, `vTal`, `vTec`, `vInv`, `vChar`):**
  - **Thẻ Tinh Gọn (`.c-card`):** Gọn hóa toàn bộ danh sách **Thiên Phú**, **Công Pháp** (kèm biểu tượng Pixel Art `TECH_ART`), **Kho Đồ** và khung **Thiên phú kích hoạt** trong tab Nhân Vật: chỉ giữ Tên (kèm viền màu phẩm chất), 1 dòng trạng thái ngắn và 1 nút thao tác nhanh (`Bật/Tắt`, `Dùng/Tháo`, `Mặc/Tháo`).
  - **Trỏ Chuột Hiện Mô Tả (`#hover-tip`):** Rê chuột vào thẻ bất kỳ sẽ bật ngay bảng tooltip bám theo con trỏ (tự kẹp trong khung màn hình) hiển thị đầy đủ chỉ số, hệ số, mô tả, điều kiện và nguồn.
  - **Click Mở Modal Thao Tác (`#det-modal`, `det_open`/`det_cls`):** Bấm vào thẻ (hỗ trợ cả mobile/touch) mở modal chi tiết với đầy đủ nút `Nâng cấp`, `Tu luyện`, `Dùng ×5`, `Bán`, `♻ Rã`, `🔒/🔓 Khóa`, cập nhật trực tiếp và hỗ trợ đóng bằng `Esc`.
- **19 Ảnh Minh Họa Pixel Art Công Pháp (`v5.30` · `TECH_ART`, `vTec`, `btlModal`):**
  - **Nhúng Offline 19/19 Công Pháp (`q1`–`q19`):** Chuyển đổi và nhúng trực tiếp bộ 19 ảnh Pixel Art WebP lossless (`96×96`) vào hằng số `TECH_ART` trong `index.html`.
  - **Hiển Thị Trực Quan:** Hiển thị biểu tượng công pháp trong từng thẻ ở tab **Công pháp (`vTec`)** và biểu tượng mini (`18×18`) trên các nút Tuyệt kỹ trong **Chiến Trường (`btlModal`)**.
  - **Cập nhật Cẩm Nang (`APP_VERSION = '5.30'`, `GUIDE_DATA`):** Bổ sung `patchNotes` `v5.30`.
- **Chiến Trường Trực Quan, Khắc Hệ Ngũ Hành & 19 Hiệu Ứng Tuyệt Kỹ Độc Bản (`v5.29` · `BTL_VFX`, `btlModal`, `skillOf`, `adventureService.step`, `adventureService.skMatch`):**
  - **Sân Đấu Trực Quan (`#btlStage`):** Hiển thị ảnh Nhân vật, Linh Thú, Boss kèm thanh HP/Thuẫn/MP, dự báo Ý Đồ Địch (`fIntent`), số sát thương nổi và nút kỹ năng tinh giản kèm nhãn **Khắc Hệ (+25%) / Bị Kháng (-15%) / Cộng Hưởng (+20%)**.
  - **19 Hiệu Ứng Canvas 2D Additive (`BTL_VFX`):** Trình render 60fps (`globalCompositeOperation = 'lighter'`) phong cách *Quỷ Cốc Bát Hoang*, tách riêng hoàn toàn hiệu ứng cho từng công pháp trong 19 công pháp (`q1`–`q19`) đúng theo tên gọi.
  - **Cập nhật Cẩm Nang (`APP_VERSION = '5.29'`, `GUIDE_DATA`):** Bổ sung `patchNotes` `v5.29` và chủ đề Chiến Trường & 19 Tuyệt Kỹ trong `codexTopics`.
- **Tái Cân Bằng Sức Mạnh, Thọ Nguyên, Chống Spam & Khóa Đột Phá 8 Nhánh (`v5.28` · `LIFE`, `QI_STATES`, `PATH_MATS`, `characterStatsService`, `cultivationService`, `adventureService`, `destinyService`, `vCul`, `vAdv`, `sbar`):**
  - **Khóa Đột Phá & Nguyên Liệu Đặc Biệt (`PATH_MATS`):** Mọi đột phá đại cảnh giới đều yêu cầu hạ Boss Lịch Luyện cùng cảnh giới (`advWins`); **Địa Phẩm** cần & tiêu hao `1` Đạo dẫn Địa Phẩm, **Thiên Phẩm** cần & tiêu hao thêm `1` Kỳ vật Thiên Phẩm đúng nhánh (16 nguyên liệu mới, không bán ở Phường Thị; rơi hiếm từ Boss/Cơ duyên, hỗ trợ ngưng luyện `3 Địa → 1 Thiên`).
  - **Soft-Cap & Siết Uy Áp Cảnh Giới (`characterStatsService.compute`, `calcSup`):** Áp dụng hiệu suất giảm dần cho tổng buff công/thủ/tốc độ tu (`tc`) & `daoMul`; hạ trần kháng Uy Áp (`supMit`) xuống `50%`; điều chỉnh đường cong `need` và `foeOf`.
  - **Thọ Nguyên, Thời Gian & Giới Hạn Đan Dược:** Thu gọn `LIFE` (`90 / 160 / 300 / 550 / 1000...`); `pathTrain`, `seek`, `fight` và chế đồ bậc cao (`≥ Tứ Giai`) tốn `1` năm tuổi qua `advanceTime`; giới hạn hấp thụ Đan dược tối đa `45%` tu vi/tầng; cho phép **Binh Giải Chuyển Thế** ngay khi cạn thọ nguyên.
  - **Ám Thương Kinh Mạch, Thiên Thời & Cảnh Giác:** Thua trận hoặc đột phá thất bại dính **Ám Thương (0–3)** giảm Công/Thủ/Bế quan và khóa càn quét/đột phá ở tầng 3 (chữa bằng *Liệu Thương Đan* `d17` hoặc *Tĩnh Dưỡng*); thế giới có chu kỳ **Linh Khí (`QI_STATES`)**; thắng liên tiếp cùng 1 ải tăng **Cảnh Giác (`advStreak`)**.
  - **Cập nhật Cẩm Nang (`APP_VERSION = '5.28'`, `GUIDE_DATA`):** Bổ sung `patchNotes` `v5.27`/`v5.28` và cập nhật `codexTopics`.
- **Hệ Thống Đột Phá Đạo Lộ 3 Phẩm Chất & Nghịch Thiên Cải Mệnh (`v5.27` · `BRK_TIERS`, `PATH_BRK`, `DAO_AN`, `cultivationService`, `brkModal`, `vCul`):**
  - **8 Nghi Thức & Kiếp Nạn Độc Bản:** Mỗi Đạo Lộ có điều kiện thuộc tính, tiêu hao tài nguyên và công thức vượt kiếp riêng (*Ngưng Đan Trúc Đài*, *Dĩ Lôi Tôi Thân*, *Trảm Tam Thi · Vấn Tâm*, *Mở Quỷ Môn · Huyết Tế*, *Trảm Kiếp Vấn Kiếm*, *Dĩ Khí Chứng Đạo*, *Huyết Mạch Phản Tổ*, *Lập Ngôn Chứng Thánh*).
  - **3 Phẩm Chất Đạo Cơ (`Phàm Phẩm`, `Địa Phẩm`, `Thiên Phẩm`):** Cho phép chọn bậc đột phá ngay tại tab Tu Luyện để nhận `+2/+4/+6` thuộc tính bản mệnh và `+0%/+6%/+12%` Căn Cơ vĩnh viễn.
  - **24 Đạo Ấn (Nghịch Thiên Cải Mệnh):** Khi đột phá từ Địa Phẩm trở lên, người chơi chọn 1 trong 3 Đạo Ấn đặc trưng của nhánh trong `brkModal` để nhận hiệu ứng thực chiến/tu luyện vĩnh viễn.
- **Hệ Thống 8 Nhánh Tu Luyện (Đạo Lộ) — Pha 2 (`v5.26` · `PATHS`, `characterStatsService`, `cultivationService`, `adventureService`, `vChar`, `vCul`):**
  - **Liên Kết Thuộc Tính & Gọn Hóa Bảng Thuộc Tính:** Mỗi Đạo Lộ có **2 Thuộc Tính Bản Mệnh (★)** quyết định công thức `Sức mạnh`, `Phòng ngự`, `Tốc độ`, `Sinh mệnh` và `Linh lực`. Bảng Thuộc Tính trong `vChar` được tách gọn thành **Cốt Cách (6 thuộc tính gốc)**, **Thực Chiến (8 chỉ số)** và **Cộng Hưởng Đạo Lộ**.
  - **Nội Tại Thực Chiến & Tu Luyện Đặc Thù:** Thể Tu (phản 15% ST, kháng Uy Áp +15%, giảm 60% Đan độc, *Tôi Thể* không tốn tuổi), Hồn Tu (+20% Choáng/Ngắt tụ lực, tích *Hồn Tinh Ngộ Đạo*), Quỷ Tu (hút máu 12%, *Âm Binh* mỗi 3 hiệp, tích *Âm Khí Huyết Tế*), Kiếm Tu (tích *Kiếm Ý* cường hóa Tuyệt kỹ +75% ST), Bách Nghệ Tu (dùng Đan/Trận không tốn lượt 2 lần/trận, chế đồ nhận Tu vi), Yêu Tu (+60% ST Linh Thú, *Luyện Yêu* không tăng Đan độc), Nho Tu (hồi 4% HP & giảm 10% ST địch khi Thiện ≥ Ác).
  - **Kiêm Tu (Song Tu Đạo Lộ):** Mở khóa ở **Nguyên Anh**, cho phép chọn 1 **Phó Đạo Lộ** để hưởng 45% chỉ số và nội tại bổ trợ.
- **Hệ Thống 8 Nhánh Tu Luyện (Đạo Lộ) — Pha 1 (`v5.25` · `PATHS`, `PD`, `realmName`, `characterService`, `characterStatsService`, `migrate`, `vCreate`, `vChar`, `vCul`, `vAdmin`):**
  - **8 Đạo Lộ Độc Đáo:** *Linh Tu, Thể Tu, Hồn Tu, Quỷ Tu, Kiếm Tu, Bách Nghệ Tu, Yêu Tu, Nho Tu* — mỗi nhánh sở hữu hệ số chỉ số thực chiến riêng (`maxHp`, `maxMp`, `luc`, `thu`, `toc`, `pen`, `crit`, `critDmg`, `dodge`, `tc`, `pb`, `sup`, `pet`), ưu nhược điểm cân bằng và **14 danh xưng cảnh giới song song**.
  - **Tích hợp Tạo Nhân Vật, Bảng Chỉ Số & Admin:** Chọn Đạo Lộ ngay tại `vCreate`, hiển thị rõ Đạo Lộ & danh xưng cảnh giới tại `vChar`/`vCul`, hỗ trợ **Kiêm Tu (Phó Đạo Lộ 45% hiệu lực)** trong `characterStatsService`, tương thích ngược save cũ qua `migrate()` và chuyển đổi thử nghiệm trong `vAdmin`.
- **Đồng Bộ 100% Mỹ Thuật Pixel Art Cổ Trang Tiên Hiệp (`v5.24` · `QCBH_AVATARS`, `PET_IMG`, `PARTNER_IMG`, `ARCH_IMG`, `BOSS_IMG`, `avatar`, `petArt`, `partnerArt`, `archBanner`, `bossBanner`, `profileEdit`):**
  - **34/34 Ảnh WebP Pixel Art Nhúng Offline (Không Trùng Lặp):** Toàn bộ **9 Avatar (4 Nam + 5 Nữ)**, **4 Linh Thú** (*Huyền Giác Tê, Xích Diễm Kỳ Lân, Thanh Loan Thần Điểu, Bạch Hổ Sát Thần*), **4 Đạo Lữ** (*Tô Vãn Tình, Lâm Như Yên, Mạc Vân Tiêu, Nguyệt Ly Tiên Tử*), **3 Banner Kiến Trúc** (*Tông Môn, Sơn Môn Tự Lập, Vạn Bảo Lâu*) và **14/14 Boss Lịch Luyện** đều sử dụng ảnh 16-bit Pixel Art nén WebP nhúng trực tiếp vào `index.html`, chạy offline 100%, không phụ thuộc link ngoài.
  - **Gỡ Bỏ Ảnh Bìa QCBH & Tự Động Migrate Save Cũ (`migrate`):** Xóa `QCBH_BG` và `qpickBg`, tự động làm sạch URL QCBH cũ trong `s.uiCfg` của người chơi cũ để đồng bộ về bộ Pixel Art mới.
- **Chuẩn Hóa Ảnh 14 Boss Thần Thoại & Banner Kiến Trúc Toàn Chiều Rộng (`v5.23` · `BOSS_IMG`, `ARCH_IMG`, `.arch-bn`, `.bimg`):**
  - **14 Boss Lịch Luyện (`BOSS_IMG[0..13]`):** Thay thế toàn bộ ảnh Boss bị lệch chủ đề hoặc dính chữ UI/bảng chỉ số bằng tranh thủy mặc, điêu khắc và tác phẩm thần thoại thế giới từ Wikimedia Commons (*Hắc Phong Lang, Huyền Quy, Xích Hổ, Giao Long, Diêm La Vương, Lôi Long, Kraken, Ma Viên, Lôi Thần Thor, Thiên Tướng, Kim Ô Ba Chân, Xi Vưu, Quan Vũ, Tam Thanh*), giữ nguyên `BOSS_ART` SVG làm fallback `onerror`.
  - **Sửa Banner Kiến Trúc (`ARCH_IMG.own`, `ARCH_IMG.auc`, `.arch-bn`):** Thay thế banner *Khai Tông Lập Phái* và *Đấu Giá Hội Vạn Bảo Lâu* bằng ảnh phong cảnh Đạo quán & Cung điện cổ ban đêm chuẩn tỷ lệ rộng (`?width=1280`), đồng thời tăng chiều cao `.arch-bn` lên `108px` với `object-fit: cover; object-position: center` để phủ kín toàn bộ chiều rộng panel.
- **Tích Hợp Bộ Hình Ảnh Chính Thức Quỷ Cốc Bát Hoang (`v5.22` · `QCBH_AVATARS`, `QCBH_BG`, `BOSS_IMG`, `ARCH_IMG`, `avatar`, `bossBanner`, `archBanner`, `profileEdit`, `mediaHTML`):**
  - **Avatar Tu Tiên (Nam / Nữ):** Bổ sung 4 chân dung Nam Tu Tiên và 5 chân dung Nữ Tu Tiên từ *Quỷ Cốc Bát Hoang* vào bộ chọn nhanh trong `profileEdit` và `mediaHTML` (`qav`), kèm `referrerpolicy="no-referrer"` và `onerror` tự lùi về SVG Thủy Mặc khi offline.
  - **14 Boss & Yêu Thú Lịch Luyện (`BOSS_IMG`):** Gắn ảnh chính thức cho toàn bộ 14 ải (`ADV[0..13]`) trong `bossBanner()`, giữ nguyên `BOSS_ART` SVG làm lớp nền fallback khi mất mạng.
  - **Kiến Trúc, Ảnh Bìa & Hình Nền Động Phủ (`ARCH_IMG`, `QCBH_BG`):** Cập nhật ảnh cho *Tông Môn*, *Sơn Môn Tự Lập*, *Vạn Bảo Lâu* trong `archBanner()` và 7 mẫu Ảnh bìa / Hình nền chọn nhanh (`qbn`, `qwp`).
- **Đại Trùng Tu Mỹ Thuật Thủy Mặc Quỷ Cốc Bát Hoang (`v5.21` · `avatar`, `petArt`, `partnerArt`, `archBanner`, `bossBanner`):**
  - Thiết kế lại toàn bộ minh họa SVG theo phong cách **Thủy Mặc Sơn Thủy (Ink-Wash)** lấy cảm hứng từ *Quỷ Cốc Bát Hoang*: sơn phong ẩn hiện trong sương mù, tùng cổ bên vách đá, vòng hào quang cảnh giới và viền kim mực.
  - **Avatar Tu Sĩ (`avatar`):** Kiếm tu đứng trên đỉnh núi với nón đấu lạp (Nam) hoặc trâm ngọc (Nữ), dải lụa bay, kiếm sau lưng và hào quang linh khí theo cảnh giới.
  - **Linh Thú & Đạo Lữ (`petArt`, `partnerArt`):** Chân dung thủy mặc riêng cho từng Linh Thú (có vòng tiến hóa) và từng Đạo Lữ.
  - **Kiến Trúc & Yêu Thú (`archBanner`, `bossBanner`):** Banner sơn thủy cho *Sơn Môn Tự Lập, Đại Tông Môn, Vạn Bảo Lâu* và lớp phủ thủy mặc đồng bộ cho 14 Boss ải Lịch Luyện.
- **Linh Thú Tiến Hóa & Đạo Lữ Song Tu Thực Chiến (`v5.20` · `compService`, `vComp`, `adventureService`, `cultivationService`):**
  - **Linh Thú Thực Chiến (`PETS`, `PET_STAGES`):** Thu phục 4 Linh Thú (*Huyền Giác Tê, Xích Diễm Kỳ Lân, Thanh Loan Thần Điểu, Bạch Hổ Sát Thần*), tiến hóa 7 bậc bằng **Yêu Đan (`m4/m5/m6`)**, cộng chỉ số và trực tiếp trợ chiến mỗi hiệp trong Chiến Trường Lịch Luyện.
  - **Đạo Lữ & Song Tu (`PARTNERS`):** Tặng lễ vật tăng Hảo cảm để kết thành Đạo Lữ, mở khóa **Song Tu** (nhận `×2.2~2.6` Tu vi, giải Đan độc/tăng chỉ số) và tự động **Hộ Pháp vượt Thiên Kiếp** (`+8% ~ +12%` gốc).
- **Đấu Giá Hội Vạn Bảo Lâu & Sự Kiện Cướp Bảo (`v5.19` · `shopService`, `vShop`):**
  - Định kỳ mỗi **10 năm tuổi** tại tab Phường Thị (hoặc mở sớm với 200 linh thạch), đấu giá 3 bảo vật hiếm với các NPC đại năng (`AUC_NPCS`).
  - Trúng đấu giá bảo vật quý có cơ hội kích hoạt sự kiện **Phục Kích Chặn Đường Cướp Bảo** với 3 lựa chọn (*Nghênh Chiến, Bỏ Chạy theo Thân Pháp, Nộp Lộ Phí*).
- **Hệ Thống Tông Môn & Khai Tông Lập Phái (`v5.18` · `sectService`, `vSect`):**
  - **Gia nhập 4 Đại Thế Lực:** *Thanh Vân Kiếm Tông, Đan Đỉnh Các, Huyền Âm Ma Tông, Vạn Pháp Thư Viện* với 5 cấp bậc (`SECT_RANKS`), nhiệm vụ Cống hiến và Bảo Khố Tông Môn (`SECT_SHOP`).
  - **Khai Tông Lập Phái (từ Nguyên Anh):** Tự lập Sơn Môn, nâng cấp **Linh Mạch (Cấp 1–7)** tăng tốc độ tu luyện (`+8%/cấp`), chiêu mộ & bồi dưỡng Đệ tử tự động sản sinh Linh thạch và Tu vi mỗi năm khi Bế quan.
- **Xử Lý Trang Bị Dư Thừa: Phân Giải & Dung Luyện 3 Đổi 1 (`salvageYield`, `salvageItem`, `bulkSalvage`, `smeltEquip`, `A.salv`, `A.bsalv`, `A.smelt`):**
  - **Phân giải trang bị (`♻ Rã`):** Phân giải trang bị dư thừa lấy khoáng thạch tinh luyện (`Khoáng Thạch`, `Tinh Thiết`, `Ngũ Sắc Thần Kim`) theo phẩm chất, đồng thời hoàn trả `60%` nguyên liệu tinh luyện nếu trang bị đã cường hóa (`★+X`). Hỗ trợ **Rã hàng loạt** (`≤ Bạch sắc`, `≤ Lục sắc`, `≤ Lam sắc`) trong `vInv`, tự động bỏ qua đồ đang mặc, đã khóa (`🔒`), Cực phẩm và Bản Mệnh Pháp Bảo.
  - **Dung luyện 3 đổi 1 (`🔥 Dung luyện`):** Nấu 3 trang bị cùng phẩm chất (`Bạch sắc → Hồng sắc`) chưa mặc & chưa khóa + linh thạch để đúc ngẫu nhiên 1 trang bị bậc kế tiếp (`15%` cơ hội nổ phẩm chất Cực phẩm) trong tab Bách Nghệ → Luyện Khí (`vCraft`).
  - Đã cập nhật `APP_VERSION = '5.17'` và `GUIDE_DATA` (`onboardingSteps`, `patchNotes`, `codexTopics`).
- **Tinh Luyện Trang Bị (`+1 → +10`, `rfCost`, `eqMul`, `vCraft`, `vInv`, `A.rf` / `A.rf5`):**
  - Cho phép tinh luyện mọi loại trang bị (Vũ khí, Pháp bảo, Giáp, Phụ kiện) trong tab Bách Nghệ → Luyện Khí (`+10%` chỉ số mỗi cấp, tối đa `+100%` ở `★+10`, nhân cộng hưởng với Phẩm chất & Bản Mệnh Pháp Bảo).
  - Hỗ trợ nút **Tinh luyện ×5**, hiển thị `★+X` trên Kho đồ & danh sách chọn, thất bại không vỡ/tụt cấp và vẫn nhận kinh nghiệm Luyện Khí Sư.
  - Đã cập nhật `APP_VERSION = '5.16'` và `GUIDE_DATA` (`patchNotes`, `codexTopics`, `onboardingSteps`).
- **Hệ thống Hướng Dẫn Tân Thủ, Auto What's New & Cẩm Nang (`guideService`, `APP_VERSION`, `GUIDE_DATA`):**
  - Lưu trạng thái độc lập tại `localStorage` (`msns_guide_v1` gồm `{ onboarded, seenVersion }`), không phình object `s` và không bị reset khi Binh Giải Chuyển Thế.
  - **Tour Tân Thủ Tương Tác (Interactive Spotlight):** 9 bước tự động chuyển tab, cuộn mượt tới mục tiêu, khoanh sáng vùng chọn và đặt hộp thoại giải thích thông minh (tự fallback giữa màn hình nếu không thấy selector).
  - **Auto What's New:** Tự động bật modal giới thiệu tính năng mới khi người chơi cũ cập nhật phiên bản (`seenVersion !== APP_VERSION`), gom cả các bản bị bỏ lỡ nếu nhảy cóc nhiều phiên bản và hỗ trợ chạy mini-tour tính năng mới.
  - **Nút `📖 Cẩm Nang` trên Header:** Mở modal 3 tab con (*Tour Tân Thủ*, *Tra Cứu Cơ Chế*, *Lịch Sử Cập Nhật*).
- **Kiến trúc cốt lõi & Lưu trữ (`saveService` · Offline-First, Adapter-Ready):**
  - Single-file HTML (`Vanilla JS + CSS + SVG`), lưu dữ liệu hiện tại qua `localStorage` (`msns_main_v1`), lưu tối đa 15 mốc sao lưu qua `IndexedDB` (`msns_saves_v1`, fallback `msns_slots_fb`) và nhạc cá nhân qua `IndexedDB` (`msns_bgm`).
  - **Thay thế hoàn toàn Đồng Bộ Vân Đạo & Xuất/Nhập Base64 rườm rà bằng Hệ thống Lưu 1 Chạm (`💾 Lưu` + `📂 Kho Save`):**
    - Bấm **`💾 Lưu`** để chụp ngay mốc lưu vào `IndexedDB` (và tự động ghi đè file `.msns` nếu đã liên kết qua `File System Access API`).
    - **`📂 Kho Save` (`savePanel`)**: Tải/nạp file `.msns` (`.json`/`.txt`), tạo **Link Chuyển Máy (`#s=...`)** nén `gzip` qua `CompressionStream`, tùy chọn file gọn (lược ảnh Base64), quản lý danh sách mốc lưu trong trình duyệt, và mục nhập mã Base64/JSON cũ thu gọn.
    - **Modal Xem Trước (`svPreviewModal`):** So sánh nhân vật hiện tại và bản save sắp nạp trước khi ghi đè.
    - **Chuẩn bị sẵn cho Online tương lai:** Bổ sung `s.saveId` và `s.rev` trong `characterService.create()` & `migrate()`, tách `saveService` theo mô hình Adapter.
  - Hàm `migrate()` tự động lọc bỏ ID thiên phú/vật phẩm rác (`TD[t.id]`, `ID[i.id]`), giới hạn `s.realm` an toàn; khối `try/catch` khi khởi động tự động sao lưu raw JSON vào `msns_main_backup` trước khi reset để chống mất dữ liệu.
  - Bộ điều phối click kiểm tra an toàn `if(A[a]) A[a](t.dataset.x)`.
- **Hệ thống Nhân vật & Tu luyện (`vChar`, `vCul`, `vTal`, `vTec`):**
  - 14 cảnh giới đầy đủ từ Phàm Giới đến Tiên Giới: *Luyện Khí → Độ Kiếp → Chân Tiên → Kim Tiên → Thái Ất → Đại La → Hỗn Nguyên* (mỗi cảnh giới 9 tầng).
  - **Cơ chế Bảo Hiểm Đột Phá (`s.pity`) & Cân bằng Độ Kiếp:** Mỗi lần đột phá cảnh giới lớn thất bại tự động tích lũy `+5%` tỷ lệ thành công cho lần sau (tối đa `+30%`, reset về 0 khi đột phá thành công); điều chỉnh độ khó Thiên kiếp (`160 * 2.1^t`) và giảm tổn thất tu vi khi thất bại (`20%–30%`).
  - **Bế quan liên tục thông minh (`cultivationService.auto`):** Tự động đột phá các tầng nhỏ (`1 → 9`) trong lúc bế quan và chỉ dừng lại khi chạm cửa đột phá cảnh giới lớn hoặc thọ nguyên còn dưới 5 năm.
  - 43 Thiên phú (7 phẩm chất từ Bạch sắc đến Thất thải), nâng cấp Lv1–Lv5 (chi phí hàm mũ), hiệu ứng đặc biệt tăng theo cấp độ.
  - 19 Công pháp + **Diễn Hóa Công Pháp** (kết hợp 2 công pháp Viên mãn thành bộ mới giữ nguyên hiệu ứng chiến đấu đặc biệt và có thể đột phá lên Thất thải).
  - Cơ chế **Đan Độc (`s.toxin`)** tích tụ khi dùng đan dược và giảm dần khi Bế quan hoặc uống Tịnh Tâm Đan / Tẩy Tủy Đan.
- **Hệ thống Kho Đồ & Quản Lý Trang Bị Thông Minh (`vInv`, `bulkSell`, `shopService`):**
  - Bộ lọc kép trong Kho đồ: lọc đồng thời theo **Phẩm chất** (`Bạch sắc → Thất thải`) và **Loại vật phẩm** (`Vũ khí, Pháp bảo, Giáp, Phụ kiện, Đan dược, Vật phẩm đặc biệt, Nguyên liệu`).
  - **Khóa vật phẩm (`i.lk` · nút 🔒/🔓):** Bảo vệ trang bị quan trọng khỏi thao tác bán lẻ và bán hàng loạt.
  - **Bán trang bị hàng loạt (`bulkSell`):** Các nút bán nhanh đồ `≤ Bạch sắc`, `≤ Lục sắc`, `≤ Lam sắc` (tự động bỏ qua đồ đã khóa, đang trang bị, Cực phẩm và Bản Mệnh Pháp Bảo).
- **Hệ thống Bách Nghệ & Trang bị (`vCraft`):**
  - 3 nghề phụ (Nhất Giai → Cửu Giai): **Luyện Đan Sư** (tỷ lệ nổ ra Đan Văn Cực Phẩm x2 hiệu quả), **Luyện Khí Sư** (tỷ lệ Thần Binh Xuất Thế, nâng phẩm chất 4 bậc), **Trận Pháp Sư** (7 đại trận động phủ).
  - **Bản Mệnh Pháp Bảo:** Ôn dưỡng `+1` đến `+10` và tính năng **Chuyển Di Bản Mệnh** (giữ lại 70% cấp độ khi đổi vũ khí/pháp bảo).
- **Kim Thủ Chỉ — Mô Phỏng Nhân Sinh (`vKt`, `thienCoAI`, `rewardIntegrationService`):**
  - Lối chơi tự do theo từng năm tuổi với 4 hành động chủ động (*Bế Quan, Nhập Thế Lịch Luyện, Du Ngoạn Hồng Trần, Thăm Dò Bí Cảnh*), Dấu ấn nhân quả (`m.flags`), Chuỗi sự kiện 3 hồi (`CH`), 8 NPC định mệnh (`NP`), Kiếp Nạn Định Mệnh động và Chọn Di Sản sau khi chết.
  - **Động Cơ Rẽ Nhánh Nhân Quả Động — Thiên Cơ AI (`thienCoAI`):** Hỗ trợ BYOK (`Google Gemini` & `OpenAI-compatible`), lưu cấu hình và API Key độc lập tại `localStorage` (`msns_ai_cfg`), tách hoàn toàn khỏi `enc(s)` khi Xuất save. Tự động chuyển về **Chế độ Cổ Điển (Offline Fallback)** nếu không có key, mất mạng hoặc API lỗi 3 lần liên tiếp.
  - **Context State & Hành động tự do:** Gửi trạng thái đời mô phỏng (tuổi, cảnh giới, thiên phú, thiện/ác, thể trạng, `m.flags`, `m.bond`, 5 sự kiện gần nhất + `m.aiSummary`) để sinh biến cố văn phong SangTacViet với 2–3 lựa chọn đối lập kèm ô nhập **Hành động tự do**; có JSON parser tự sửa lỗi markdown/dấu phẩy/cắt cụt, clamp chống lạm phát chỉ số và nén trí nhớ nhân quả sau mỗi 3 lượt.
  - Phần thưởng mô phỏng tự động nhân theo cảnh giới thực tế của bản thể (`1.75^realm`).
- **Chiến đấu, Càn Quét Tùy Chỉnh & Phường Thị (`vAdv`, `vShop`):**
  - **14 ải Lịch Luyện & Chiến Trường Chiến Thuật (`btlModal`, `adventureService`):** Phủ trọn 14 cảnh giới với tranh minh họa riêng (`BOSS_ART`), thanh **Linh Lực (MP)**, **3 Tâm Pháp Giao Chiến (`STANCES`)**, **Tuyệt Kỹ Chủ Động (`skillOf`)** theo công pháp trang bị (*Phá Giáp, Phong Ấn/Choáng ngắt tụ lực, Trảm Sát, Thiêu Đốt, Hút Máu, Hộ Thể Kim Quang*), dùng Linh Đan khẩn cấp và Rút Lui.
  - **Yêu Thú Biến Dị (`MUTS`):** 4 biến thể (*Huyết Sát, Thiết Giáp, Cuồng Lôi, Độc Chướng*) với nội tại đặc biệt và phần thưởng gấp đôi nguyên liệu.
  - **Cơ chế Giảm Dần Lợi Tức Lịch Luyện (`s.farm`):** Đánh quái liên tục trong chu kỳ 10 năm tuổi sẽ giảm dần lượng linh thạch & tu vi rơi ra (`0.92^n`, tối thiểu `30%`).
  - **Càn quét nâng cao (`adventureService.sweep`):** Cho phép chọn số năm càn quét (`10 / 25 / 50 / 100 năm`) và tùy chọn **Dừng khi rơi đồ hiếm (`ui.swr`)**.
- **Tái cân bằng đường cong chỉ số & Bách Nghệ thực chiến (`characterStatsService`, `foeOf`, `adventureService`, `cultivationService`):**
  - Nhân chỉ số chiến đấu (`luc`, `thu`, `toc`, `maxHp`, `maxMp`) theo `realmMul = 2.1^realm * (1 + layer * 0.1)`, quy đổi chỉ số cộng phẳng từ Trang bị/Công pháp/Thiên phú theo `1.6^realm`.
  - Cập nhật đường cong quái `foeOf(i)` (`L = round(18 * 2.15^i)`) và **Uy Áp Cảnh Giới** (`-22%` sát thương gây ra, `+25%` sát thương nhận vào mỗi cảnh giới chênh lệch; giảm trừ bởi Ngũ hành tương khắc `50%`, Bản Mệnh Pháp Bảo `+2.5%/cấp` tối đa `25%`, và Trận Bàn).
  - **Bách Nghệ hỗ trợ thực chiến:** Luyện Khí (`ql=2` +15%, `ql=3` +30% Xuyên Giáp); Luyện Đan (3 đan thực chiến `d14` Bạo Nguyên Đan, `d15` Kim Cang Hộ Tâm Đan, `d16` Bách Thảo Giải Độc Đan; phẩm chất Cực phẩm `ex` dùng không tốn lượt); Trận Pháp (2 Trận Bàn tiêu hao `b1` Ngũ Hành Nghịch Chuyển Bàn & `b2` Tứ Tượng Tỏa Linh Bàn chế tạo trong `vCraft` và kích hoạt trong `btlModal`).
  - Đồng bộ ngưỡng Độ Kiếp (`160 * 2.1^t`) và ngưỡng Phi Thăng (`thu >= 150.000` ở Độ Kiếp).
- **Nâng cấp Đột Phá Cảnh Giới & Bảng Thuộc Tính (`characterStatsService`, `cultivationService`, `vChar`, `vCul`, `brkModal`):**
  - Mở rộng bảng Thuộc tính `vChar` từ 3 chỉ số lên **6 chỉ số thực chiến** (*Sinh mệnh, Linh lực, Sức mạnh, Phòng ngự, Tốc độ, Bạo kích / Xuyên giáp*) kèm **Hệ số cảnh giới (`×realmMul`)**.
  - Chỉnh hệ số 6 thuộc tính gốc (`Thể chất, Linh căn, Ngộ tính, Thần hồn, Tâm cảnh, Khí vận`) theo cấp số cộng đều đặn với cấp bậc tu vi (`rank = 9*realm + layer`, `k = 10 + 2*rank`), giúp cả 2 hàng trên (bao gồm `Khí vận`) tăng đều +2 mỗi lần đột phá tầng hoặc cảnh giới.
  - Thêm hiệu ứng **Tẩy Kinh Phạt Tủy** khi đột phá đại cảnh giới thành công (`cultivationService.go`): tự động xóa Tâm Ma, giảm mạnh Đan Độc, cộng `+2 Khí vận`, đồng thời hiển thị **Dự báo tăng tiến** trong `vCul` và **Popup Tổng Kết Đột Phá (`brkModal`)** so sánh Trước → Sau chi tiết.
- **Tối ưu chiến đấu tự động, Bách Nghệ & Hiệu năng UI (`autoPick`, `vCraft`, `render`, `runLab`, `resolve`):**
  - Nâng cấp `adventureService.autoPick(b, x)` tự động ưu tiên kích hoạt Trận Bàn (`b1`, `b2`), giải độc (`d16`), uống đan hồi phục (`d1/d3/d12`), bật `Kim Cang Hộ Tâm Đan` (`d15`) khi boss tụ lực và `Bạo Nguyên Đan` (`d14`) khi vượt cấp.
  - Thêm nút chế tạo nhanh **×5** (`dc5`, `kc5`, `tc5`) trong `vCraft` cho cả 3 nghề (Luyện Đan, Luyện Khí, Khắc Trận Bàn).
  - Bảo toàn vị trí cuộn trang (`window.scrollY` và `.modal-box` `scrollTop`) khi `render()` cập nhật giao diện trên cùng một tab.
  - Nâng cấp bot `runLab()` tự trang bị đồ mạnh hơn và dùng đan hợp lý, đồng thời sửa lỗi rớt nguyên liệu ở ải cấp cao (`i >= 9`, `mtTier = Math.min(5, ...)`), giúp `runLab()` giả lập thông suốt từ **Luyện Khí → Hỗn Nguyên (13/13 đại cảnh giới)**.
- **Endgame, Giao diện Discord & Admin Balance Lab (`vAdmin`):**
  - **Phi Thăng Tiên Giới** & **Binh Giải Chuyển Thế (New Game+)**.
  - Tùy biến Profile Card, 5 bộ Theme + Nitro Custom Color, đổi ảnh Avatar/Banner/Wallpaper (tự nén Canvas JPEG 0.8), trình phát nhạc ngũ cung Web Audio API.
  - **Admin Panel + Balance Lab (`runLab`):** Mở khóa ẩn bằng `/thiendao` hoặc `Alt + Shift + ~` (SHA-256 trên RAM), tích hợp công cụ giả lập cân bằng trên bản sao.

- **Tái thiết kế Chỉ Số, Độ Khó & Kim Thủ Chỉ "Bàn Tay Vàng" (`characterStatsService`, `cultivationService`, `foeOf`, `calcSup`, `rewardIntegrationService`, `vChar`, `vKt`):**
  - **Phân tách 6 thuộc tính gốc & Soft Cap:** `Thể` (HP/Thủ), `Linh` (Lực/Tốc/MP), `Ngộ` (Xuyên giáp), `Thần` (ST Bạo kích), `Tâm` (Thủ/Đột phá), `Vận` (Bạo kích/Né tránh); nâng `flatMul` từ `1.6^realm` lên `1.85^realm`; áp dụng Soft Cap cho `crit`, `pen`, `dodge`, `critDmg` và tích hợp `dodge`/`critDmg` vào `adventureService.step`.
  - **Cân bằng độ khó Bản thể:** Quái `foeOf` tăng `+25%–30%` (`22 * 2.18^i`), `k = 8 + rank*1.5`, `realmMul = 2.05^realm`, tốc độ bế quan ngoài đời `0.9×`, `pity` tối đa `20%` và không cộng vào Thiên Kiếp (`k = 190 * 2.15^t`).
  - **Kim Thủ Chỉ chuẩn Bàn Tay Vàng SangTacViet:** Phí mở mô phỏng `35%` chi phí đột phá (`simFee`), không tốn thọ nguyên bản thể; thêm di sản thứ 4 **`Đạo Quả Bàn Tay Vàng`** (`+gfBuff` toàn chỉ số, `+gfSup` kháng Uy Áp Cảnh Giới tới `50%`, cơ hội **Tẩy Cốt Hoán Thai** nâng Linh Căn/Đạo Thể ở hạng `S+`), cho phép chọn `2` di sản khi đạt hạng `S+` hoặc Kim Thủ Chỉ cấp `3+`; tương thích ngược qua `migrate()`.

---

## 2. ĐANG THỰC HIỆN (IN PROGRESS)
- Kiểm thử cân bằng đường cong tăng trưởng từ Luyện Khí đến Hỗn Nguyên thông qua **Balance Lab** trong bảng Admin.

---

## 3. KẾ HOẠCH TIẾP THEO (TODO / BACKLOG)
- [x] **Hệ thống Tông Môn & Khai Tông Lập Phái (Bản thể ngoài đời thực):** Gia nhập 4 đại thế lực làm nhiệm vụ cống hiến (giai đoạn đầu) và tự lập sơn môn thu nhận đệ tử, nâng cấp Linh Mạch (từ Nguyên Anh trở lên). *(v5.18)*
- [x] **Đấu Giá Hội Vạn Bảo Lâu:** Sự kiện định kỳ mỗi 10 năm tuổi tại tab Phường Thị, cạnh tranh trả giá với NPC đại năng và sự kiện bị chặn đường cướp bảo. *(v5.19)*
- [x] **Linh Thú & Đạo Lữ thực chiến:** Thu phục linh thú tiến hóa bằng Yêu Đan, kết giao Đạo Lữ để mở khóa Song Tu và hỗ trợ vượt Thiên Kiếp. *(v5.20)*
- [x] **Tối ưu thao tác nhanh (QoL):** Thêm nút "Rèn nhanh / Luyện đan ×5" trong tab Bách Nghệ.
- [ ] **Đồng bộ Mỹ thuật AI 16-bit Pixel Art (Nâng cấp 107 ảnh vẽ tự động ở `v5.35`):** Thay thế các bộ icon vẽ bằng Python Pillow (Đợt 1B, Đợt 2, Đợt 3) sang ảnh AI Pixel Art (`generate_image`) để đồng bộ 100% nét vẽ với `TECH_ART` (`v5.30`/`v5.33`) và 45 vật phẩm Đợt 1A (`v5.34`).

---

## 4. LƯU Ý NÂNG CẤP MỸ THUẬT (ART UPGRADE NOTES)

Để dự án đồng bộ hoàn toàn 100% nét vẽ **AI 16-bit Pixel Art** (`96×96` WebP trên nền tối `#050812`), dưới đây là danh sách phân tách rõ phần **đã dùng ảnh AI** và phần **đang dùng ảnh Python 16-bit Pixel Art tạm thời ở `v5.35`** cần nâng cấp sau:

### Đã đồng bộ ảnh AI Pixel Art (Không cần làm lại)
- **Avatar, Linh Thú, Đạo Lữ, Kiến Trúc, Boss (`v5.24`):** 34/34 ảnh (`QCBH_AVATARS` 9, `PET_IMG` 4, `PARTNER_IMG` 4, `ARCH_IMG` 3, `BOSS_IMG` 14).
- **Công Pháp & Thái Cổ Tuyệt Học (`TECH_ART` · `v5.30`, `v5.33`):** 27/27 ảnh (`q1`–`q19` + 8 `fu_*`).
- **Vật Phẩm Đợt 1A (`ITEM_ART` · `v5.34`):** 45/73 ảnh:
  - Trang bị (25): `w1`–`w8` (Vũ khí), `a1`–`a5` (Giáp), `p1`–`p5` (Trang sức), `f1`–`f7` (Pháp bảo).
  - Trận bàn & Lệnh bài (3): `b1`, `b2`, `s1`.
  - Đan dược (8): `d1`–`d8`.
  - Kỳ vật Đạo Lộ (9): `bm_quy_d`, `bm_quy_t`, `bm_kiem_d`, `bm_kiem_t`, `bm_nghe_d`, `bm_nghe_t`, `bm_yeu_d`, `bm_yeu_t`, `bm_nho_d`.

### Cần nâng cấp từ Python Pixel Art sang AI Pixel Art (107 ảnh ở `v5.35`)
1. **Đợt 1B — `ITEM_ART` còn lại (28 ảnh):**
   - **9 Đan dược (`d9`–`d17`):** `d9` (Tẩy Tủy Đan), `d10` (Tụ Linh Đan), `d11` (Huyền Hoàng Đan), `d12` (Cửu Chuyển Hoàn Hồn Đan), `d13` (Phá Cảnh Đan), `d14` (Bạo Nguyên Đan), `d15` (Kim Cang Hộ Tâm Đan), `d16` (Bách Thảo Giải Độc Đan), `d17` (Liệu Thương Đan).
   - **12 Nguyên liệu (`m1`–`m12`):** `m1`–`m3` (Thảo dược bậc 1–3), `m4`–`m6` (Yêu Đan bậc 1–3), `m7`–`m9` (Khoáng thạch bậc 1–3), `m10`–`m12` (Trận kỳ/Linh ngọc).
   - **7 Kỳ vật Đạo Lộ:** `bm_linh_d`, `bm_linh_t`, `bm_the_d`, `bm_the_t`, `bm_hon_d`, `bm_hon_t`, `bm_nho_t`.
2. **Đợt 2 — `TAL_ART` (43 ảnh):** Toàn bộ 43 Thiên phú (`t1`–`t43`).
3. **Đợt 3 — `PATH_ART`, `SECT_ART`, `DAO_ART` (36 ảnh):**
   - **8 Đạo Lộ (`PATH_ART`):** `linh`, `the`, `hon`, `quy`, `kiem`, `nghe`, `yeu`, `nho`.
   - **4 Tông Môn (`SECT_ART`):** `s1` (Thanh Vân Kiếm Tông), `s2` (Đan Đỉnh Các), `s3` (Huyền Âm Ma Tông), `s4` (Vạn Pháp Thư Viện).
   - **24 Đạo Ấn (`DAO_ART`):** Mỗi Đạo Lộ 3 ấn (`li1..li3`, `th1..th3`, `ho1..ho3`, `qu1..qu3`, `ki1..ki3`, `ng1..ng3`, `ye1..ye3`, `nh1..nh3`).

> **Gợi ý quy trình khi nâng cấp sau này:** Chỉ cần tạo sprite sheet lưới `3×3` (9 icon/ảnh, nền đen `#050812`, phong cách *16-bit dark xianxia RPG pixel art*) bằng `generate_image`, cắt ô `96×96` WebP và ghi đè trực tiếp các key tương ứng trong `ITEM_ART`, `TAL_ART`, `PATH_ART`, `SECT_ART`, `DAO_ART` trong `index.html` — không cần sửa code giao diện vì toàn bộ UI đã nối sẵn.

