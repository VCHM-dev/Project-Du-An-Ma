# PROJECT RULES & VISION — QUY TẮC & TẦM NHÌN DỰ ÁN

## 1. Tầm Nhìn Dự Án (Project Vision)
- Xây dựng một tựa game **Tu Tiên Mô Phỏng Nhân Sinh (Text-Based Roguelike RPG)** đậm chất tiểu thuyết convert trên **SangTacViet**, chạy thuần trên trình duyệt (client-side), nhẹ, mượt, không cần cài đặt hay backend.
- Cốt lõi trải nghiệm: **Tự do lựa chọn — Chuỗi nhân quả liên kết — Vòng lặp tài nguyên khép kín** giữa các hệ thống (Bế quan, Mô phỏng, Lịch luyện, Bách nghệ, Phi thăng & Luân hồi).

---

## 2. Quy Tắc Kỹ Thuật Bắt Buộc (Hard Constraints)
1. **Kiến trúc Single-File HTML:** Tuyệt đối giữ toàn bộ HTML, CSS và JavaScript trong 1 file `.html` duy nhất (`Mô Phỏng Nhân Sinhtest_2.html`, đồng bộ sang `index.html` để chạy GitHub Pages). Không tách file rời, không dùng thư viện ngoài (React, Vue, jQuery, Tailwind CDN...) để đảm bảo chạy offline 100%.
2. **Tương thích ngược dữ liệu (Save Compatibility):**
   - Key lưu trữ cố định là `msns_main_v1` (cấu hình nhạy cảm như API Key của Thiên Cơ AI và Cloud Sync tách riêng ở `msns_ai_cfg` và `msns_cloud_cfg`, tuyệt đối không lưu vào object `s`).
   - Mọi trường dữ liệu mới thêm vào nhân vật `s` **BẮT BUỘC** phải được khởi tạo giá trị mặc định trong hàm `migrate()` để người chơi cũ không bị lỗi khi cập nhật file mới.
3. **Không bọc hàm chồng chéo (No Monkey-Patching):** Khi sửa hoặc mở rộng logic của một service (`cultivationService`, `adventureService`, `rewardIntegrationService`...), phải sửa trực tiếp bên trong định nghĩa của service đó, không viết đoạn code ghi đè nối đuôi ở cuối file.
4. **Cơ chế điều phối sự kiện chuẩn:**
   - Mọi nút bấm tương tác phải dùng thuộc tính `data-a="tên_lệnh"` và `data-x="tham_số"`, đồng thời khai báo hàm xử lý tương ứng bên trong đối tượng `A`.
   - Mọi thẻ `<input>` / `<select>` thay đổi giá trị dùng `data-chg="..."`.
5. **Bảo vệ vật phẩm & Cân bằng:**
   - Mọi tính năng bán hàng loạt hoặc tiêu hao trang bị tự động phải tôn trọng cờ khóa `i.lk`, trạng thái đang trang bị `s.eq`, phẩm chất Cực phẩm `i.ex` và `s.bmWeapon`.
   - Giữ nguyên công cụ `Balance Lab` trong tab Admin để kiểm thử cân bằng.
6. **Xuất code đầy đủ:** Khi xuất file HTML cập nhật, luôn xuất toàn bộ mã nguồn hoàn chỉnh từ `<!DOCTYPE html>` đến `</html>`, tuyệt đối không viết tắt kiểu `// ... giữ nguyên phần còn lại ...`.

---

## 3. Quy Tắc Xử Lý Tình Huống Mập Mờ (Ambiguity Resolution)
- **Khi yêu cầu thêm tính năng mới nhưng chưa rõ chỉ số/công thức:** Tự động cân bằng dựa trên đường cong tăng trưởng hiện tại của game (Cảnh giới nhân theo hàm mũ `1.75^realm` đến `2.2^realm`; Linh thạch rơi ra và chi phí chế tạo phải tương xứng với cảnh giới) và kiểm chứng qua `Balance Lab`.
- **Khi yêu cầu nâng cấp hệ thống cũ nhưng không nhắc đến phần phụ trợ:** Tự động kiểm tra và cập nhật đồng bộ cả 3 nơi: (1) Logic tính toán trong Service, (2) Hiển thị chỉ số trực quan trên thẻ bài UI, và (3) Nút buff/test nhanh trong `vAdmin`.
- **Khi giao diện có nguy cơ bị dài hoặc rối:** Chủ động thêm bộ lọc (chip filter) hoặc gom nhóm hợp lý, giữ nguyên phong cách tối giản, hỗ trợ tốt cả màn hình máy tính lẫn điện thoại.

---

## 4. Quy Trình Bàn Giao Cuối Mỗi Phiên Làm Việc (Handoff Protocol)
Sau khi hoàn thành bất kỳ yêu cầu sửa đổi hoặc thêm tính năng nào, AI **BẮT BUỘC** phải xuất kèm một khối cập nhật ngắn gọn để người dùng dán vào cuối file `project_status.md` theo đúng định dạng:
- **Đã hoàn thành:** Liệt kê các tính năng/lỗi vừa xử lý.
- **File/Hàm đã sửa:** Ghi rõ tên service hoặc hàm vừa thay đổi (cập nhật `project_structure.md` nếu có thêm service/tab mới).
- **Bước tiếp theo gợi ý:** Đề xuất 1–2 hướng phát triển hợp lý tiếp theo.
