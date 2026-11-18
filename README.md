# Mô Phỏng Nhân Sinh: Nhân Vật Chính (`v5.28`)

Tựa game **Tu Tiên Mô Phỏng Nhân Sinh (Text-Based Roguelike RPG)** đậm chất tiểu thuyết convert trên *SangTacViet*, chạy thuần trên trình duyệt (client-side, offline-first 100%) không cần cài đặt hay backend.

## Tính năng nổi bật

- **8 Nhánh Tu Luyện & Đột Phá 3 Phẩm Chất:** *Linh, Thể, Hồn, Quỷ, Kiếm, Bách Nghệ, Yêu, Nho Tu* với 14 danh xưng riêng, nội tại thực chiến, Kiêm Tu ở Nguyên Anh, Đột Phá Phàm/Địa/Thiên Phẩm kèm **24 Đạo Ấn (Nghịch Thiên Cải Mệnh)** và nguyên liệu Đạo dẫn riêng.
- **14 Đại Cảnh Giới (126 bậc) & Cân Bằng Nhịp Độ:** Từ *Luyện Khí → Độ Kiếp → Chân Tiên → Hỗn Nguyên*, áp lực Thọ nguyên, Thiên Thời Linh Khí, Ám Thương Kinh Mạch, Giới hạn hấp thụ Đan dược và Binh Giải Chuyển Thế.
- **Nhân vật & Tu luyện:** 43 Thiên phú (7 phẩm chất, Lv1–Lv5), 19 Công pháp + Diễn Hóa Công Pháp, cơ chế Đan Độc.
- **Kim Thủ Chỉ (Mô phỏng nhân sinh):** Chơi tự do theo năm tuổi, 8 NPC định mệnh, 10 Chuỗi sự kiện 3 hồi, 4 Di sản (*Đạo Quả Bàn Tay Vàng*), tích hợp **Thiên Cơ AI (BYOK)** hỗ trợ Gemini / OpenAI-compatible kèm fallback offline.
- **Chiến Trường Ngũ Hành:** 14 ải Lịch luyện với 3 Tâm pháp giao chiến, Tuyệt kỹ chủ động, 4 biến thể Yêu Thú Biến Dị, Cảnh Giác chiến đấu, Càn quét tùy chỉnh và Uy áp cảnh giới.
- **Bách Nghệ & Trang bị:** 3 nghề (Luyện Đan, Luyện Khí, Trận Pháp) cấp 1–9; Tinh luyện `+1 → +10`, Phân giải, Dung luyện 3 đổi 1 và Bản Mệnh Pháp Bảo.
- **Tông Môn & Đồng Hành:** Gia nhập 4 Đại Tông Môn hoặc Khai Tông Lập Phái (Linh Mạch cấp 1–7, chiêu mộ Đệ tử); thu phục 4 Linh Thú tiến hóa trợ chiến và kết giao 4 Đạo Lữ Song Tu.
- **Phường Thị & Đấu Giá Hội:** Giao dịch định kỳ và Đấu Giá Hội Vạn Bảo Lâu mỗi 10 năm tuổi.
- **Mỹ thuật & Lưu trữ Offline:** 34/34 ảnh 16-bit Pixel Art WebP nhúng trực tiếp kèm SVG thủy mặc fallback; Kho Save 1 chạm (`localStorage` + `IndexedDB` + file `.msns` + link `#s=` nén `gzip`).

## Cách chơi

1. Mở trực tiếp file `index.html` trên bất kỳ trình duyệt hiện đại nào, hoặc truy cập qua GitHub Pages của repository.
2. Không yêu cầu server, build tool hay kết nối mạng (trừ khi bật chế độ **Thiên Cơ AI** với API key cá nhân).

## Cấu trúc dự án

- `index.html` — Toàn bộ mã nguồn game (HTML + CSS + Vanilla JS + tài nguyên đồ họa WebP/SVG nhúng).
- `project_status.md` — Nhật ký tiến độ và lịch sử phiên bản.
- `project_structure.md` — Bản đồ mã nguồn và các service bên trong `index.html`.
- `project_rules.md` — Quy tắc kỹ thuật, tầm nhìn và quy trình phát triển dự án.