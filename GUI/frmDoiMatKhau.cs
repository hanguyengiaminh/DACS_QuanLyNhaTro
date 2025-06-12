using BLL.Services;
using DAL.Repositories;
using DAL.Interfaces;
using System;
using System.Windows.Forms;


namespace GUI
{
	public partial class frmDoiMatKhau : Form
	{
		private NguoiDungService nguoiDungService;
		private int maNguoiDung;

		public frmDoiMatKhau(int maNguoiDung)
		{
			InitializeComponent();
			this.maNguoiDung = maNguoiDung;
			var nguoiDungRepo = new NguoiDungRepository();
			var logRepo = new LogHoatDongRepository();
			nguoiDungService = new NguoiDungService(nguoiDungRepo, logRepo);
		}

		private void btn_Luu_Click(object sender, EventArgs e)
		{
			try
			{
				string matKhauCu = txt_MatKhauCu.Text.Trim();
				string matKhauMoi = txt_MatKhauMoi.Text.Trim();
				string xacNhanMatKhau = txt_XacNhanMatKhau.Text.Trim();

				// Validate
				if (string.IsNullOrEmpty(matKhauCu))
				{
					MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrEmpty(matKhauMoi))
				{
					MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrEmpty(xacNhanMatKhau))
				{
					MessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (matKhauMoi != xacNhanMatKhau)
				{
					MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Đổi mật khẩu
				nguoiDungService.DoiMatKhau(maNguoiDung, matKhauCu, matKhauMoi);
				MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
