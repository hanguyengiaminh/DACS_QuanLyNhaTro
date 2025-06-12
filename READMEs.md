# Quản Lý Nhà Trọ

Ứng dụng quản lý nhà trọ được phát triển bằng WinForms, giúp chủ nhà trọ quản lý hiệu quả các hoạt động kinh doanh của mình.

## 📋 Mục lục
- [Yêu cầu hệ thống](#yêu-cầu-hệ-thống)
- [Cài đặt](#cài-đặt)
- [Cấu trúc dự án](#cấu-trúc-dự-án)
- [Quy tắc phát triển](#quy-tắc-phát-triển)
- [Hướng dẫn sử dụng](#hướng-dẫn-sử-dụng)

## 💻 Yêu cầu hệ thống
- Windows 10 trở lên
- .NET Framework 4.8
- SQL Server 2022 trở lên
- Visual Studio 2022 trở lên

## 🚀 Cài đặt
1. Clone repository:
```bash
git clone https://github.com/your-username/QuanLyNhaTro.git
```

2. Khôi phục database:
- Mở SQL Server Management Studio
- Chạy file `sql/init.sql` để tạo database và bảng dữ liệu

3. Cấu hình kết nối:
- Mở file `Data/ConnectionString.cs`
- Cập nhật chuỗi kết nối theo cấu hình SQL Server của bạn

4. Build và chạy:
- Mở solution trong Visual Studio
- Build solution (Ctrl + Shift + B)
- Chạy ứng dụng (F5)

## 📁 Cấu trúc dự án
```
QuanLyNhaTro/
├── GUI/           # Form và UserControl
├── DAL/           # Data Access Layer
├── BUS/           # Business Logic Layer
├── DTO/           # Data Transfer Objects
├── Data/          # Database Context
├── Utils/         # Tiện ích dùng chung
├── sql/           # Script database
└── docs/          # Tài liệu
```

## 📝 Quy tắc phát triển

### 1. Quy tắc đặt tên
- **Class**: PascalCase (ví dụ: `FormPhongTro`, `HopDongService`)
- **Biến**: camelCase (ví dụ: `tenNguoiDung`, `soPhong`)
- **Control UI**: prefix + tên + kiểu control (ví dụ: `btnLuuPhong`, `txtGiaPhong`)
- **Property**: PascalCase, giống tên cột DB (ví dụ: `MaPhong`, `TinhTrang`)

### 2. Quy ước mã hóa
- **Mã hợp đồng**: HDYYYY-XXXX (ví dụ: HD2024-0001)
- **Mã người thuê**: NT-XXXX (ví dụ: NT-0010)
- **Mã phòng**: A101, B202 (theo tầng/khu)

### 3. Giao diện người dùng
- **Màu sắc chính**:
  - Xanh lam đậm: #1A5FB4 (nút chính, tiêu đề)
  - Xanh lá: #008749 (thành công, trạng thái "Trống")
  - Nền phụ: #F1F1F1
  - Chữ chính: #333333
  - Text phụ: #888888

- **Font chữ**:
  - Font: Segoe UI, Roboto, Inter
  - Tiêu đề: 20-24px, Bold
  - Label: 12-14px, Regular
  - Nút: 14-16px, Semibold

### 4. Xử lý nghiệp vụ
- **Thêm mới**: Kiểm tra rỗng, trùng lặp
- **Cập nhật**: Chỉ khi chưa kết thúc hợp đồng
- **Xóa**: Xác nhận trước, xóa mềm nếu có ràng buộc
- **Trả phòng**: Cập nhật trạng thái, tạo hóa đơn cuối
- **Tìm kiếm**: Tìm kiếm nâng cao



## 👥 Tài khoản mẫu
- **Admin**:
  - Username: admin
  - Password: admin123

- **Quản lý**:
  - Username: manager
  - Password: manager123

## 📞 Hỗ trợ
Nếu bạn gặp vấn đề hoặc cần hỗ trợ, vui lòng:
1. Kiểm tra [Issues](https://github.com/your-username/QuanLyNhaTro/issues)
2. Tạo issue mới nếu chưa có
3. Liên hệ qua email: support@example.com

## 📄 Giấy phép
Dự án này được phát hành dưới giấy phép MIT. Xem file [LICENSE](LICENSE) để biết thêm chi tiết.

# Quy Tắc Phát Triển Dự Án Quản Lý Nhà Trọ

## 1. Quy Tắc Đặt Tên

### 1.1. Entity (Bảng dữ liệu & Class)
- **Người dùng**: `NguoiDung` / `User`
Khu vực:
- **Phòng trọ**: `PhongTro` / `Room`
- **Người thuê**: `NguoiThue` / `Tenant`
- **Hợp đồng thuê**: `HopDongThue` / `RentalContract`
- **Hóa đơn**: `HoaDon` / `Invoice`
- **Dịch vụ**: `DichVu` / `Service`
- **Chi tiết dịch vụ**: `ChiTietDichVu` / `RoomServiceDetail`
- **Chi tiết hóa đơn**: `ChiTietHoaDon` / `InvoiceDetail`
- **Lịch sử thuê**: `LichSuThue` / `RentalHistory`

### 1.2. Quy ước đặt tên
- **Class**: PascalCase
  ```csharp
  public class PhongTroService { }
  public class HopDongThueRepository { }
  ```

- **Biến**: camelCase
  ```csharp
  private string tenNguoiDung;
  private decimal giaPhong;
  ```

- **Control UI**: prefix + tên + kiểu control
  ```csharp
  private Button btnLuuPhong;
  private TextBox txtGiaPhong;
  private Label lblTenPhong;
  private PictureBox picLogo;
  ```

- **Property**: PascalCase, giống tên cột DB
  ```csharp
  public string MaPhong { get; set; }
  public string TinhTrang { get; set; }
  ```

## 2. Cấu Trúc Thư Mục

```
QuanLyNhaTro/
├── GUI/                    # Form và UserControl
│   ├── Forms/             # Các form chính
│   │   ├── frmMain.cs     # Form chính
│   │   ├── frmPhongTro.cs # Form quản lý phòng
│   │   └── frmHopDong.cs  # Form hợp đồng
│   ├── Controls/          # UserControl tái sử dụng
│   └── Resources/         # Hình ảnh, icon
├── DAL/                   # Data Access Layer
│   ├── Repositories/      # Repository pattern
│   └── Context/          # Database context
├── BUS/                   # Business Logic Layer
│   ├── Services/         # Service classes
│   └── Interfaces/       # Interface definitions
├── DTO/                   # Data Transfer Objects
│   ├── Models/           # Entity models
│   └── ViewModels/       # View models
├── Data/                  # Database
│   ├── Connection/       # Connection string
│   └── Scripts/         # SQL scripts
├── Utils/                 # Tiện ích
│   ├── Helpers/         # Helper functions
│   ├── Constants/       # Constants
│   └── Extensions/      # Extension methods
└── Tests/                # Unit tests
```

## 3. Quy Tắc Code

### 3.1. Code Style
- Sử dụng dấu `{}` xuống dòng riêng
- Comment bằng tiếng Việt, ngắn gọn
- Mỗi class phải có comment mô tả đầu file
- Sử dụng try-catch cho mọi thao tác với DB
- Đặt tên biến có ý nghĩa, dễ hiểu

```csharp
/// <summary>
/// Service xử lý nghiệp vụ phòng trọ
/// </summary>
public class PhongTroService
{
    private readonly IPhongTroRepository _phongTroRepository;
    
    public PhongTroService(IPhongTroRepository phongTroRepository)
    {
        _phongTroRepository = phongTroRepository;
    }

    // Tính tổng tiền hóa đơn tháng này
    public decimal TinhTongTienHoaDon(int thang, int nam)
    {
        try
        {
            // Code xử lý
        }
        catch (Exception ex)
        {
            // Xử lý lỗi
            throw new BusinessException("Lỗi khi tính tổng tiền hóa đơn", ex);
        }
    }
}
```

### 3.2. Xử Lý Nghiệp Vụ

#### Thêm mới
- Kiểm tra dữ liệu rỗng
- Kiểm tra trùng lặp
- Validate dữ liệu đầu vào
- Thông báo kết quả rõ ràng
- Log lại thao tác

#### Cập nhật
- Chỉ cho phép cập nhật khi chưa kết thúc hợp đồng
- Kiểm tra quyền cập nhật
- Lưu lịch sử thay đổi
- Validate dữ liệu trước khi cập nhật

#### Xóa
- Xác nhận trước khi xóa
- Xóa mềm nếu có ràng buộc
- Cập nhật trạng thái liên quan
- Log lại thao tác xóa

#### Trả phòng
1. Cập nhật hợp đồng:
   - `NgayKetThuc` = ngày hiện tại
   - `TrangThai` = 'Đã kết thúc'
   - `LyDoKetThuc` = lý do trả phòng
2. Cập nhật phòng:
   - `TrangThai` = 'Trống'
   - `NgayTrong` = ngày hiện tại
3. Tạo hóa đơn cuối nếu cần
4. Lưu lịch sử thuê
5. Thông báo kết quả

### 3.3. Mã Hóa Dữ Liệu

#### Mã hợp đồng
- Format: `HDYYYY-XXXX`
- Ví dụ: `HD2024-0001`
- Tự động tăng theo năm

#### Mã người thuê
- Format: `NT-XXXX`
- Ví dụ: `NT-0010`
- Tự động tăng

#### Mã phòng
- Format: `[Khu][Tầng][Số]`
- Ví dụ: `A101`, `B202`
- Khu: A, B, C...
- Tầng: 1-9
- Số: 01-99

## 4. Giao Diện Người Dùng

### 4.1. Màu Sắc
- Xanh lam đậm: `#1A5FB4` (nút chính, tiêu đề)
- Xanh lá: `#008749` (thành công, trạng thái "Trống")
- Đỏ: `#DC3545` (lỗi, cảnh báo)
- Nền phụ: `#F1F1F1`
- Chữ chính: `#333333`
- Text phụ: `#888888`

### 4.2. Font Chữ
- Font chính: Segoe UI, Roboto, Inter
- Tiêu đề: 20-24px, Bold
- Label: 12-14px, Regular
- Nút: 14-16px, Semibold
- Input: 13px, Regular

### 4.3. Layout
- Sidebar trái: 240px
- Header trên: 60px
- Khu nội dung: responsive
- Padding chuẩn: 16px
- Margin giữa các control: 8px

## 5. Bảo Mật

### 5.1. Xác Thực
- Sử dụng JWT token
- Mã hóa mật khẩu với BCrypt
- Phân quyền chi tiết
- Session timeout: 30 phút

### 5.2. Dữ Liệu
- Validate dữ liệu đầu vào
- Escape SQL injection
- Mã hóa dữ liệu nhạy cảm
- Backup dữ liệu định kỳ

## 6. Kiểm Thử

### 6.1. Unit Test
- Test các service
- Test các repository
- Test các helper function
- Độ phủ test > 80%

### 6.2. UI Test
- Test các form chính
- Test luồng nghiệp vụ
- Test xử lý lỗi
- Test responsive

## 7. Quản Lý Phiên Bản

### 7.1. Version
- Format: `vX.Y.Z`
- X: Major version (thay đổi lớn)
- Y: Minor version (tính năng mới)
- Z: Patch version (sửa lỗi)

### 7.2. Commit Message
- Format: `[Type] Description`
- Type: 
  - feat: tính năng mới
  - fix: sửa lỗi
  - docs: cập nhật tài liệu
  - style: định dạng code
  - refactor: tái cấu trúc
  - test: thêm test
  - chore: cập nhật build
- Ví dụ: `[feat] Thêm chức năng tìm kiếm nâng cao` 

Những thay đổi chính trong cấu trúc database:
Thêm bảng KhuVuc để quản lý các khu vực của nhà trọ
Thêm các trường theo dõi thời gian (NgayTao, NgayCapNhat)
Thêm các trường trạng thái để quản lý hoạt động
Thêm các ràng buộc khóa ngoại để đảm bảo tính toàn vẹn dữ liệu
Thêm các index để tối ưu hiệu suất truy vấn
Thêm các trường ghi chú để lưu thông tin bổ sung
Thêm các trường theo dõi người thực hiện các thao tác
Các luồng hoạt động chính:
Quản lý khu vực:
Thêm/sửa/xóa khu vực
Xem danh sách khu vực
Quản lý phòng trọ:
Thêm/sửa/xóa phòng
Cập nhật trạng thái phòng
Gán dịch vụ cho phòng
Tìm kiếm phòng
Quản lý người thuê:
Thêm/sửa/xóa thông tin người thuê
Xem lịch sử thuê
Tìm kiếm người thuê
Quản lý hợp đồng:
Tạo hợp đồng mới
Gia hạn hợp đồng
Kết thúc hợp đồng
Xem danh sách hợp đồng
Quản lý hóa đơn:
Tạo hóa đơn định kỳ
Tính tiền dịch vụ
Thanh toán hóa đơn
In hóa đơn
Xem báo cáo doanh thu
Quản lý dịch vụ:
Thêm/sửa/xóa dịch vụ
Cập nhật đơn giá
Theo dõi sử dụng dịch vụ
Quản lý tài khoản:
Thêm/sửa/xóa tài khoản
Phân quyền người dùng
Đổi mật khẩu

## 4. Thứ tự triển khai các chức năng:
# Chức năng cơ bản:
Đăng nhập/Đăng xuất
Quản lý tài khoản
Quản lý khu vực
# Chức năng quản lý phòng:
Thêm/sửa/xóa phòng
Xem danh sách phòng
Tìm kiếm phòng
# Chức năng quản lý người thuê:
Thêm/sửa/xóa người thuê
Xem danh sách người thuê
Tìm kiếm người thuê
# Chức năng quản lý hợp đồng:
Tạo hợp đồng mới
Gia hạn hợp đồng
Kết thúc hợp đồng
# Chức năng quản lý hóa đơn:
Tạo hóa đơn
Thanh toán hóa đơn
In hóa đơn
# Chức năng quản lý dịch vụ:
Thêm/sửa/xóa dịch vụ
Gán dịch vụ cho phòng
Tính tiền dịch vụ
# Chức năng báo cáo:
Báo cáo doanh thu
Báo cáo phòng trống
Báo cáo hợp đồng

## Các lưu ý khi triển khai:
# Xử lý lỗi:
Sử dụng try-catch để bắt lỗi
Log lỗi để debug
Hiển thị thông báo lỗi thân thiện
# Validation:
Kiểm tra dữ liệu đầu vào
Validate các ràng buộc nghiệp vụ
Hiển thị thông báo lỗi
# Performance:
Sử dụng async/await cho các thao tác I/O
Tối ưu câu truy vấn
Sử dụng caching khi cần
# Security:
Mã hóa mật khẩu
Phân quyền người dùng
Validate input để tránh SQL injection
# UI/UX:
Thiết kế giao diện thân thiện
Responsive design
Thông báo rõ ràng

## Các thành phần :
Các stored procedure
Các class DTO
Các interface và class DAL
Các interface và class BLL
Các form GUI
Các helper class và utility