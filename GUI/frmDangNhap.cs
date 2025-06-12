using BLL.Services;
using DAL.Repositories;
using DAL.Interfaces;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmDangNhap : Form
	{
		private NguoiDungService nguoiDungService;

		public frmDangNhap()
		{
			InitializeComponent();
			var nguoiDungRepo = new NguoiDungRepository();
			var logRepo = new LogHoatDongRepository();
			nguoiDungService = new NguoiDungService(nguoiDungRepo, logRepo);

			// Tạo tài khoản admin mặc định nếu chưa có
			if (!nguoiDungRepo.CheckTenDangNhapExists("admin"))
			{
				var admin = new DTO.NguoiDung
				{
					TenDangNhap = "admin",
					MatKhau = "Admin@123",
					HoTen = "Administrator",
					Email = "admin@example.com",
					SoDienThoai = "0123456789",
					VaiTro = "Admin",
					TrangThai = true,
					NgayTao = DateTime.Now
				};
				nguoiDungService.Add(admin);
			}

			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
		}

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			string tenDangNhap = txtUsername.Text.Trim();
			string matKhau = txtPassword.Text.Trim();

			if (nguoiDungService.DangNhap(tenDangNhap, matKhau))
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				var user = nguoiDungService.GetByTenDangNhap(tenDangNhap);
				// Điều hướng giao diện theo vai trò
				if (user.VaiTro == "Admin")
				{
					frmMain frm = new frmMain(user.MaNguoiDung);
					frm.Show();
				}
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();

		}
	}
}
