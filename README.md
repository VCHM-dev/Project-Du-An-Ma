# Mô Phỏng Nhân Sinh: Nhân Vật Chính (`v5.35`)

Tựa game **Tu Tiên Mô Phỏng Nhân Sinh (Text-Based Roguelike RPG)** đậm chất tiểu thuyết convert trên *SangTacViet*, chạy thuần trên trình duyệt (client-side, offline-first 100%) không cần cài đặt hay backend.

## Tính năng nổi bật

- **8 Nhánh Tu Luyện & Đột Phá 3 Phẩm Chất (`v5.35`):** *Linh, Thể, Hồn, Quỷ, Kiếm, Bách Nghệ, Yêu, Nho Tu* với 14 danh xưng riêng, nội tại thực chiến, Kiêm Tu ở Nguyên Anh, Đột Phá Phàm/Địa/Thiên Phẩm kèm **24 Đạo Ấn (Nghịch Thiên Cải Mệnh)** và nguyên liệu Đạo dẫn riêng — tất cả đều có huy hiệu Pixel Art WebP riêng (`PATH_ART` 8/8, `DAO_ART` 24/24).
- **14 Đại Cảnh Giới (126 bậc) & Cân Bằng Nhịp Độ:** Từ *Luyện Khí → Độ Kiếp → Chân Tiên → Hỗn Nguyên*, áp lực Thọ nguyên, Thiên Thời Linh Khí, Ám Thương Kinh Mạch, Giới hạn hấp thụ Đan dược và Binh Giải Chuyển Thế.
- **Nhân vật, Công pháp & Diễn Hóa (`v5.33–v5.35`):** **43 Thiên phú** (7 phẩm chất, Lv1–Lv5, 43/43 ảnh `TAL_ART`), 19 Công pháp gốc + **8 Thái Cổ Tuyệt Học ẩn danh** (27/27 ảnh `TECH_ART`), Đồ Giám (+2%/bộ), **Huy Hiệu Song Hợp** cắt chéo phát sáng theo hệ Ngũ Hành và bộ sinh danh xưng Hán-Việt cho Diễn Hóa Tự Do, Song Hiệu Ứng chiến đấu và bảng Xem Trước.
- **Giao Diện Tinh Gọn (`v5.31`):** Thẻ Thiên Phú, Công Pháp và Kho Đồ chỉ hiển thị Tên + Trạng thái ngắn + nút bật/dùng nhanh; **rê chuột** để hiện tooltip mô tả đầy đủ và **click** để mở modal nâng cấp/tu luyện/bán rã.
- **Kim Thủ Chỉ (Mô phỏng nhân sinh):** Chơi tự do theo năm tuổi, 8 NPC định mệnh, 10 Chuỗi sự kiện 3 hồi, 4 Di sản (*Đạo Quả Bàn Tay Vàng*), tích hợp **Thiên Cơ AI (BYOK)** hỗ trợ Gemini / OpenAI-compatible kèm fallback offline.
- **Chiến Trường Ngũ Hành Trực Quan (`v5.33`):** 14 ải Lịch luyện với sân đấu đối kháng (hiển thị Nhân vật, Linh thú, Boss, Ý Đồ Địch), 3 Tâm pháp giao chiến, Tuyệt kỹ có nhãn Khắc Hệ / Cộng Hưởng Ngũ Hành, **27 hiệu ứng Canvas 2D Additive độc bản** (`q1`–`q19` + 8 *Thái Cổ Tuyệt Học* + Combo VFX kép cho Diễn Hóa Tự Do), 4 biến thể Yêu Thú Biến Dị, Cảnh Giác và Uy áp cảnh giới.
- **Bách Nghệ & Trang bị (`v5.35`):** 3 nghề (Luyện Đan, Luyện Khí, Trận Pháp) cấp 1–9; Tinh luyện `+1 → +10`, Phân giải, Dung luyện 3 đổi 1 và Bản Mệnh Pháp Bảo; **73/73 biểu tượng Pixel Art WebP nhúng offline (`ITEM_ART`)** phủ 100% Trang bị, Đan dược, Nguyên liệu, Trận Bàn và Kỳ vật Đạo Lộ.
- **Tông Môn & Đồng Hành (`v5.35`):** Gia nhập **4 Đại Tông Môn** (4/4 tông huy `SECT_ART`) hoặc Khai Tông Lập Phái (Linh Mạch cấp 1–7, chiêu mộ Đệ tử); thu phục 4 Linh Thú tiến hóa trợ chiến và kết giao 4 Đạo Lữ Song Tu.
- **Phường Thị & Đấu Giá Hội:** Giao dịch định kỳ và Đấu Giá Hội Vạn Bảo Lâu mỗi 10 năm tuổi.
- **Mỹ thuật 100% Pixel Art & Lưu trữ Offline (`v5.35`):** **213 ảnh 16-bit Pixel Art WebP** nhúng trực tiếp phủ 100% thực thể toàn dự án (Avatar, Linh Thú, Đạo Lữ, Kiến trúc, Boss, Công pháp, Vật phẩm, Thiên phú, Đạo lộ, Tông môn, Đạo ấn) kèm SVG thủy mặc fallback; Kho Save 1 chạm (`localStorage` + `IndexedDB` + file `.msns` + link `#s=` nén `gzip`).

## Cách chơi

1. Mở trực tiếp file `index.html` trên bất kỳ trình duyệt hiện đại nào, hoặc truy cập qua GitHub Pages của repository.
2. Không yêu cầu server, build tool hay kết nối mạng (trừ khi bật chế độ **Thiên Cơ AI** với API key cá nhân).

## Cấu trúc dự án

- `index.html` — Toàn bộ mã nguồn game (HTML + CSS + Vanilla JS + tài nguyên đồ họa WebP/SVG nhúng).
- `project_status.md` — Nhật ký tiến độ và lịch sử phiên bản.
- `project_structure.md` — Bản đồ mã nguồn và các service bên trong `index.html`.
- `project_rules.md` — Quy tắc kỹ thuật, tầm nhìn và quy trình phát triển dự án.