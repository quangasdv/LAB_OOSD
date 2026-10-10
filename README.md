# HỆ THỐNG CÁC BÀI THỰC HÀNH PHÂN TÍCH THIẾT KẾ HƯỚNG ĐỐI TƯỢNG (LAB OOSD)

## 1. TỔNG QUAN HỌC PHẦN
Thư mục `LAB_OOSD` lưu trữ toàn bộ các bài thực hành thuộc học phần Phát triển Phần mềm Hướng đối tượng (PTPMHDT / OOSD). Chuỗi bài tập được thiết kế và triển khai bám sát quy trình phát triển phần mềm chuẩn mực: từ khảo sát nghiệp vụ, phân tích yêu cầu, mô hình hóa các sơ đồ UML (Use Case Diagram, Activity Diagram, Class Diagram, Sequence Diagram), thiết kế cơ sở dữ liệu quan hệ trên Microsoft SQL Server, đến lập trình ứng dụng Windows Forms (.NET Framework 4.7.2) theo kiến trúc 3 lớp (UI - Service - Data).

---

## 2. DANH MỤC VÀ CHI TIẾT CÁC BÀI THỰC HÀNH

### LAB01: Đặc tả yêu cầu nghiệp vụ và Mô hình Use Case
- **Nội dung thực hiện**:
  - Khảo sát bối cảnh bài toán, xác định các tác nhân (Actor) và danh mục Use Case của hệ thống.
  - Xây dựng sơ đồ Use Case tổng quát và sơ đồ Use Case phân rã chi tiết.
  - Lập tài liệu đặc tả Use Case đầy đủ các luồng sự kiện: luồng cơ bản (Basic Flow), luồng rẽ nhánh (Alternative Flow) và luồng ngoại lệ (Exception Flow).
- **Tài liệu và sản phẩm bàn giao**:
  - `lab1.drawio`: Tệp thiết kế sơ đồ Use Case trên diagrams.net.
  - `LAB1_Bai1_*.docx`, `LAB1_Bai2_*.docx`: Tài liệu báo cáo đặc tả yêu cầu chi tiết.

### LAB02: Hệ thống Quản lý Thư viện (QuanLyThuVien)
- **Nội dung thực hiện**:
  - Nghiệp vụ: Quản lý danh mục đầu sách, quản lý độc giả và thẻ thư viện, lập phiếu mượn sách, nhận trả sách, xử lý vi phạm/phạt và thống kê lượt mượn.
  - Kiến trúc: Hiện thực ứng dụng WinForms theo kiến trúc 3 lớp. Xây dựng màn hình quản lý sách (CRUD), tìm kiếm tức thời và hiển thị danh sách trên DataGridView.
- **Thành phần dự án**:
  - `QuanLyThuVien.sln`, `QuanLyThuVien/`: Mã nguồn dự án C# WinForms (.NET Framework 4.7.2).
  - `QuanLyThuVien.sql`: Kịch bản tạo cơ sở dữ liệu và dữ liệu thử nghiệm.
  - `lab2.drawio`, `Bao cao LAB02.docx`: Sơ đồ thiết kế hệ thống và báo cáo học phần.

### LAB03: Hệ thống Quản lý Khách sạn (QuanLyKhachSan)
- **Nội dung thực hiện**:
  - Nghiệp vụ: Quản lý danh mục phòng và tiện nghi, đặt phòng theo mô hình Master-Detail (cho phép chọn nhiều phòng trong cùng một phiếu đặt), làm thủ tục nhận phòng, sử dụng dịch vụ phát sinh, trả phòng và xuất hóa đơn thanh toán.
  - Kỹ thuật: Sử dụng `BindingList<T>` để liên kết và cập nhật động danh sách phòng được chọn trên DataGridView; áp dụng `SqlTransaction` để bảo đảm tính toàn vẹn dữ liệu khi ghi đồng thời phiếu đặt và chi tiết phòng.
- **Thành phần dự án**:
  - `QuanLyKhachSan.sln`, `QuanLyKhachSan/`: Mã nguồn dự án C# WinForms.
  - `QuanLyKhachSan.sql`: Kịch bản tạo cấu trúc bảng và dữ liệu phòng, dịch vụ.

### LAB04: Hệ thống Thương mại Điện tử (HeThongeShopping)
- **Nội dung thực hiện**:
  - Nghiệp vụ: Khách hàng duyệt sản phẩm, quản lý giỏ hàng trực tuyến, lựa chọn hình thức vận chuyển, nhập thông tin giao nhận và thanh toán trực tuyến qua thẻ tín dụng quốc tế.
  - Giao diện: Thiết kế màn hình đặt hàng và thanh toán, tự động tính tổng tiền hàng, chi phí vận chuyển và kiểm tra định dạng số thẻ.
- **Thành phần dự án**:
  - `HeThongeShopping.sln`, `HeThongeShopping/`: Mã nguồn ứng dụng C# WinForms.
  - `eShopping database.sql`: Kịch bản tạo cơ sở dữ liệu khách hàng, đơn hàng và giao dịch thanh toán.
  - `eshopping.drawio`, `baocaolab4.docx`: Mô hình phân tích Use Case, Activity, Sequence và báo cáo chi tiết.

### LAB05: Hệ thống Quản lý Công ty Du lịch Văn Hóa Việt TP.HCM (QuanLyDuLich)
- **Nội dung thực hiện**:
  - Nghiệp vụ trọng tâm: Đăng ký tour du lịch theo đoàn với các quy tắc nghiệp vụ chặt chẽ:
    - Quy định khách đoàn: Đoàn phải có số lượng tối thiểu từ 12 người trở lên (khách dưới 12 người bắt buộc đăng ký mua vé theo chuyến lẻ định sẵn).
    - Quyền lợi khách đoàn: Được quyền chọn ngày khởi hành tùy ý, có xe đón riêng tại địa điểm hẹn của đoàn.
    - Quy định đặt cọc: Bắt buộc đặt cọc trước 30% tổng kinh phí dự kiến; cam kết mất 100% tiền cọc nếu đoàn tự ý hủy tour.
    - Quy định bảo hiểm du lịch: Đoàn có tham gia bảo hiểm bắt buộc phải cung cấp đầy đủ danh sách thành viên cùng đi (Họ tên, Ngày sinh, CCCD).
    - Ghi nhận biên nhận cọc: Tự động phát hành mã biên nhận thu tiền cọc ngay khi lưu phiếu thành công.
  - Màn hình quản lý danh mục: Quản lý đầy đủ thông tin Tour du lịch (Mã tour, Tên tour, Số ngày, Số đêm, Đơn giá, Điểm xuất phát) với các chức năng thêm, sửa, xóa, làm mới và tìm kiếm.
- **Thành phần dự án**:
  - `QuanLyDuLich.sln`, `QuanLyDuLich/`: Mã nguồn ứng dụng C# WinForms.
    - `Forms/FrmMain.cs`: Màn hình điều hướng chính của hệ thống.
    - `Forms/FrmDangKyTourDoan.cs`: Màn hình lập phiếu đăng ký tour đoàn và thu tiền cọc.
    - `Forms/FrmTour.cs`: Màn hình quản lý danh mục tour du lịch.
    - `Services/DangKyTourService.cs`: Tầng nghiệp vụ xử lý đăng ký đoàn, ràng buộc số người, bảo hiểm và giao dịch cọc 30%.
    - `Services/TourService.cs`: Tầng nghiệp vụ xử lý tra cứu và cập nhật dữ liệu tour.
    - `Data/Db.cs`: Tầng truy xuất dữ liệu ADO.NET trực tiếp tới SQL Server.
  - `QuanLyDuLich.sql`: Kịch bản tạo cơ sở dữ liệu gồm 10 bảng quan hệ và nạp dữ liệu mẫu ban đầu.
  - `class lab05.drawio`, `class_lab05.png`, `baocaolab05.docx`: Sơ đồ lớp chi tiết và báo cáo thực hành.

---

## 3. KIẾN TRÚC PHẦN MỀM VÀ NGUYÊN TẮC THIẾT KẾ

Các dự án trong chuỗi bài thực hành được xây dựng thống nhất theo Kiến trúc 3 tầng (Three-Layer Architecture):

```text
[ Tầng Giao diện (Presentation Layer - WinForms) ]
                     |
                     | (Gọi phương thức nghiệp vụ)
                     v
[ Tầng Dịch vụ (Business Logic Layer - Services) ]
                     |
                     | (Truy vấn dữ liệu / Thực thi câu lệnh)
                     v
[ Tầng Truy xuất dữ liệu (Data Access Layer - Db.cs) ]
                     |
                     | (Kết nối ADO.NET qua SqlConnection)
                     v
[ Cơ sở dữ liệu (Database - Microsoft SQL Server) ]
```

### Nguyên tắc phân chia trách nhiệm:
1. **Tầng Giao diện (Presentation Layer - UI)**:
   - Đảm nhiệm việc hiển thị dữ liệu và tiếp nhận tương tác của người dùng.
   - Kiểm tra các ràng buộc giao diện cơ bản trên Form Controls (TextBox, ComboBox, NumericUpDown, DataGridView).
   - Tuyệt đối không nhúng mã truy vấn SQL trực tiếp trong các sự kiện giao diện (Event Handler).
   - Tiếp nhận kết quả xử lý trả về từ tầng Service thông qua đối tượng `KetQuaXuLy` để hiển thị thông báo phù hợp.

2. **Tầng Nghiệp vụ (Business Logic Layer - Services)**:
   - Chịu trách nhiệm kiểm tra toàn bộ các quy tắc nghiệp vụ (Business Rules) trước khi xử lý dữ liệu.
   - Thực hiện tính toán chi phí, tiền đặt cọc, thẩm định tính hợp lệ của danh sách con.
   - Quản lý giao dịch cấp hệ thống bằng `SqlTransaction` để bảo đảm tính trọn vẹn (Atomicity, Consistency) khi ghi dữ liệu đồng thời vào nhiều bảng liên kết.

3. **Tầng Truy xuất Dữ liệu (Data Access Layer - Data / Db.cs)**:
   - Đóng gói các hàm thực thi ADO.NET chuẩn: `OpenConnection()`, `Query()` (trả về DataTable), `Execute()` (thực thi ExecuteNonQuery), `Scalar()` (thực thi ExecuteScalar).
   - Toàn bộ các câu lệnh SQL đều sử dụng `SqlParameter` nhằm loại bỏ hoàn toàn nguy cơ tấn công SQL Injection.

---

## 4. HƯỚNG DẪN CÀI ĐẶT VÀ VẬN HÀNH

### 4.1. Yêu cầu hệ thống
- Hệ điều hành: Microsoft Windows 10 hoặc Windows 11.
- Môi trường phát triển: Microsoft Visual Studio 2019 hoặc Visual Studio 2022 (đã cài đặt workload .NET desktop development).
- Nền tảng: .NET Framework phiên bản 4.7.2.
- Hệ quản trị cơ sở dữ liệu: Microsoft SQL Server (bản Express, Developer) hoặc SQL Server LocalDB (`(localdb)\mssqllocaldb`).

### 4.2. Khởi tạo Cơ sở dữ liệu
Trước khi biên dịch và chạy ứng dụng, cần khởi tạo cơ sở dữ liệu tương ứng bằng SQL Server Management Studio (SSMS) hoặc công cụ dòng lệnh `sqlcmd`:

- Ví dụ khởi tạo cơ sở dữ liệu cho LAB05:
  ```cmd
  sqlcmd -S "(localdb)\mssqllocaldb" -E -f 65001 -i "F:\PTPMHDT\LAB_OOSD\LAB05\QuanLyDuLich.sql"
  ```

### 4.3. Cấu hình Chuỗi kết nối (App.config)
Chuỗi kết nối cơ sở dữ liệu được đặt tại tệp `App.config` của mỗi dự án:
```xml
<connectionStrings>
    <add name="QuanLyDuLichDb" 
         connectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyDuLichDB;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```
*Ghi chú: Nếu hệ thống máy tính sử dụng instance SQL Server khác (chẳng hạn `.\SQLEXPRESS` hoặc tên máy chủ cụ thể), chỉ cần cập nhật lại giá trị tương ứng tại thuộc tính `Data Source`.*

### 4.4. Biên dịch và Thực thi
1. Mở tệp giải pháp `.sln` bằng Visual Studio (ví dụ: `F:\PTPMHDT\LAB_OOSD\LAB05\QuanLyDuLich\QuanLyDuLich.sln`).
2. Trên thanh menu, chọn `Build` -> `Rebuild Solution` để kiểm tra biên dịch (đạt trạng thái 0 Errors, 0 Warnings).
3. Nhấn phím `F5` (hoặc nút `Start`) để khởi chạy chương trình và tiến hành kiểm thử các chức năng nghiệp vụ.