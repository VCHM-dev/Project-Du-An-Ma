# PROJECT STATUS — MÔ PHỎNG NHÂN SINH: NHÂN VẬT CHÍNH

> **Phiên bản hiện tại:** v5.16 (`Mô Phỏng Nhân Sinhtest_2.html`)  
> **Cập nhật lần cuối:** 2026-11-16  
> **File chạy chính:** `Mô Phỏng Nhân Sinhtest_2.html`  

---

## 1. ĐÃ HOÀN THÀNH (DONE)
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
- [ ] **Hệ thống Tông Môn & Khai Tông Lập Phái (Bản thể ngoài đời thực):** Gia nhập 4 đại thế lực làm nhiệm vụ cống hiến (giai đoạn đầu) và tự lập sơn môn thu nhận đệ tử, nâng cấp Linh Mạch (từ Nguyên Anh trở lên).
- [ ] **Đấu Giá Hội Vạn Bảo Lâu:** Sự kiện định kỳ mỗi 10 năm tuổi tại tab Phường Thị, cạnh tranh trả giá với NPC đại năng và sự kiện bị chặn đường cướp bảo.
- [ ] **Linh Thú & Đạo Lữ thực chiến:** Thu phục linh thú tiến hóa bằng Yêu Đan, kết giao Đạo Lữ để mở khóa Song Tu và hỗ trợ vượt Thiên Kiếp.
- [ ] **Tối ưu thao tác nhanh (QoL):** Thêm nút "Rèn nhanh / Luyện đan ×5" trong tab Bách Nghệ.
