using BLL.Services;
using DAL.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmThongTinTaiKhoan : Form
	{
		private NguoiDungService nguoiDungService;
		private int maNguoiDung;
		private string defaultAvatarPath = "GUI\\Properties\\Resources\\Avatar\\default_avatar.png"; // Đường dẫn đến ảnh đại diện mặc định

		public frmThongTinTaiKhoan(int maNguoiDung)
		{
			InitializeComponent();
			this.maNguoiDung = maNguoiDung;
			var nguoiDungRepo = new NguoiDungRepository();
			var logRepo = new LogHoatDongRepository();
			nguoiDungService = new NguoiDungService(nguoiDungRepo, logRepo);
			LoadThongTinTaiKhoan();

			// Ẩn trường mật khẩu
		//	txt_MatKhau.Visible = false;
			//label2.Visible = false;
		}

		private void LoadThongTinTaiKhoan()
		{
			try
			{
				var nguoiDung = nguoiDungService.GetById(maNguoiDung);
				if (nguoiDung != null)
				{
					txt_HoTen.Text = nguoiDung.HoTen;
					txt_TenDangNhap.Text = nguoiDung.TenDangNhap;
					txt_SĐT.Text = nguoiDung.SoDienThoai;
					txt_VaiTro.Text = nguoiDung.VaiTro;

					// Hiển thị ảnh đại diện
					if (!string.IsNullOrEmpty(nguoiDung.Avatar) && File.Exists(nguoiDung.Avatar))
					{
						pic_Avata.Image = Image.FromFile(nguoiDung.Avatar);
					}
					else
					{
						// Load ảnh mặc định từ đường dẫn được cung cấp
						if (File.Exists(defaultAvatarPath))
						{
							pic_Avata.Image = Image.FromFile(defaultAvatarPath);
						}
						else
						{
							// Fallback nếu ảnh mặc định không tồn tại
							pic_Avata.Image = Properties.Resources.default_avatar; // Hoặc một ảnh mặc định khác nếu có
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi tải thông tin tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_ThemAVT_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedImagePath = openFileDialog.FileName;
				string newAvatarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Avatars", Path.GetFileName(selectedImagePath));

				// Tạo thư mục Avatars nếu chưa tồn tại
				if (!Directory.Exists(Path.GetDirectoryName(newAvatarPath)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(newAvatarPath));
				}

				File.Copy(selectedImagePath, newAvatarPath, true);

				var nguoiDung = nguoiDungService.GetById(maNguoiDung);
				if (nguoiDung != null)
				{
					nguoiDung.Avatar = newAvatarPath;
					nguoiDungService.CapNhatThongTin(new DTO.ViewModels.ThongTinTaiKhoanViewModel
					{
						MaNguoiDung = nguoiDung.MaNguoiDung,
						HoTen = nguoiDung.HoTen,
						Email = nguoiDung.Email,
						SoDienThoai = nguoiDung.SoDienThoai,
						Avatar = nguoiDung.Avatar
					});
					pic_Avata.Image = Image.FromFile(newAvatarPath);
					MessageBox.Show("Cập nhật ảnh đại diện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void btn_CapNhat_Click(object sender, EventArgs e)
		{
			try
			{
				var nguoiDung = nguoiDungService.GetById(maNguoiDung);
				if (nguoiDung != null)
				{
					// Cập nhật thông tin từ các trường input
					nguoiDung.HoTen = txt_HoTen.Text.Trim();
					nguoiDung.SoDienThoai = txt_SĐT.Text.Trim();

					// Vì Email không có trên form này, giữ nguyên Email từ database

					nguoiDungService.CapNhatThongTin(new DTO.ViewModels.ThongTinTaiKhoanViewModel
					{
						MaNguoiDung = nguoiDung.MaNguoiDung,
						HoTen = nguoiDung.HoTen,
						Email = nguoiDung.Email, // Giữ nguyên Email
						SoDienThoai = nguoiDung.SoDienThoai,
						Avatar = nguoiDung.Avatar
					});

					MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadThongTinTaiKhoan(); // Tải lại thông tin sau khi cập nhật
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_DoiMatKhau_Click(object sender, EventArgs e)
		{
			// Mở form đổi mật khẩu và truyền MaNguoiDung
			frmDoiMatKhau frm = new frmDoiMatKhau(maNguoiDung);
			frm.ShowDialog();
			LoadThongTinTaiKhoan(); // Tải lại thông tin sau khi đổi mật khẩu (nếu có thay đổi liên quan)
		}
	}
}
