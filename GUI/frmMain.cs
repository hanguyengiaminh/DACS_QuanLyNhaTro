using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BLL.Services;
using DAL.Repositories;
using DTO;
using System.IO;

namespace GUI
{
	public partial class frmMain : Form
	{
		private int maNguoiDung;
		private NguoiDungService nguoiDungService;

		public frmMain(int maNguoiDung)
		{
			InitializeComponent();
			this.maNguoiDung = maNguoiDung;
			var nguoiDungRepo = new NguoiDungRepository();
			var logRepo = new LogHoatDongRepository();
			nguoiDungService = new NguoiDungService(nguoiDungRepo, logRepo);
			LoadResources();
			LoadUserInfo();
		}

		bool menuExpan = false;
		bool menuExpan2 = false;

		private void LoadResources()
		{
			
			
		}

		private void LoadUserInfo()
		{
			try
			{
				var nguoiDung = nguoiDungService.GetById(maNguoiDung);
				if (nguoiDung != null)
				{
					lbl_ChaoUser.Text = $"Chào {nguoiDung.HoTen}!"; // Giả định có lbl_ChaoUser trên frmMain

					// Hiển thị ảnh đại diện
					if (!string.IsNullOrEmpty(nguoiDung.Avatar) && File.Exists(nguoiDung.Avatar))
					{
						//pic_Avata.Image = Image.FromFile(nguoiDung.Avatar);
					}
					else
					{
						// Load ảnh mặc định từ Resources nếu không có ảnh hoặc ảnh không tồn tại
						//pic_Avata.Image = Properties.Resources.default_avatar; // Thay thế default_avatar bằng tên ảnh mặc định của bạn trong Resources
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi tải thông tin người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void timeMenuQLPhong_Tick(object sender, EventArgs e)
		{
			if (menuExpan == false)
			{
				flMenuPhong.Height += 10;
				if (flMenuPhong.Height >= 168)
				{
					timeMenuQLPhong.Stop();
					menuExpan = true;
				}
			}
			else
			{
				flMenuPhong.Height -= 10;
				if (flMenuPhong.Height <= 42)
				{
					timeMenuQLPhong.Stop();
					menuExpan = false;
				}
			}
		}

		private void timeMenuQLCauHinh_Tick(object sender, EventArgs e)
		{
			if (menuExpan2 == false)
			{
				flMenuCauHinh.Height += 10;
				if (flMenuCauHinh.Height >= 168)
				{
					timeMenuQLCauHinh.Stop();
					menuExpan2 = true;
				}
			}
			else
			{
				flMenuCauHinh.Height -= 10;
				if (flMenuCauHinh.Height <= 42)
				{
					timeMenuQLCauHinh.Stop();
					menuExpan2 = false;
				}
			}

		}


		// Xử lý sự kiện gọi form khi click cho các nút Chuc năng trong menu chính
		private Form currentFormChild;

		private void OpenChildForm(Form childForm)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			currentFormChild = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panel_MainContent.Controls.Add(childForm);
			panel_MainContent.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}


		private void btnTrangChu_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			lbl_TenChucNang.Text = "Trang chủ";
		}

		// -- Các sự kiện cho các nút trong menu quản lý phòng ---
		private void btnPhongTro_Click(object sender, EventArgs e)
		{
			timeMenuQLPhong.Start();
		}

		private void btnDSPhong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmDanhSachPhongTro());
			lbl_TenChucNang.Text = "Phòng trọ / Danh sách Phòng trọ";
		}

		private void btnQLPhongTro_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmQuanLyPhong());
			lbl_TenChucNang.Text = "Phòng trọ / Quản lý Phòng trọ";
		}

		private void btnQLKhuVuc_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmQuanLyKhuVuc());
			lbl_TenChucNang.Text = "Phòng trọ / Quản lý Khu vực";
		}
		//- end các sự kiện cho các nút trong menu quản lý phòng ---

		private void btnHoaDon_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmQLHoaDon());
			lbl_TenChucNang.Text = "Quản lý Hóa Đơn";
		}

		private void btnDichVu_Click(object sender, EventArgs e)
		{
			// chỉ hiện form quản lý dịch vụ nếu người dùng có quyền quản trị
			
			OpenChildForm(new frmQLDichVu());
			lbl_TenChucNang.Text = "Quản lý Dịch vụ";
		}

		private void btnHopDong_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmQLHopDong());
			lbl_TenChucNang.Text = "Quản lý Hợp đồng";
		}

		private void btnKhachThue_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmQLKhachThue());
			lbl_TenChucNang.Text = "Quản lý Khách thuê";
		}

		// -- Các sự kiện cho các nút trong menu quản lý cấu hình ---
		private void btnCauHinh_Click(object sender, EventArgs e)
		{
			timeMenuQLCauHinh.Start();
		}

		private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
		{
			// Hiện form thông tin tài khoản của tài khoản đang đăng nhập
			OpenChildForm(new frmThongTinTaiKhoan(maNguoiDung));
			lbl_TenChucNang.Text = "Thông tin tài khoản";
		}

		private void btnDanhSachTaiKhoan_Click(object sender, EventArgs e)
		{
			// chỉ hiện form danh sách tài khoản nếu người dùng có quyền quản trị
	


			OpenChildForm(new frmDanhSachTaiKhoan());
			lbl_TenChucNang.Text = "Danh sách tài khoản";
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			//Đăng xuất ra khỏi ứng dụng và hiện trang đăng nhập
			this.Hide();
			frmDangNhap frmDangNhap = new frmDangNhap();
			frmDangNhap.ShowDialog();
			this.Close();

		}

		private void picLogo_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			lbl_TenChucNang.Text = "Trang chủ";
		}
	}
}
