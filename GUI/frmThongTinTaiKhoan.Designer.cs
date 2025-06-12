namespace GUI
{
	partial class frmThongTinTaiKhoan
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pane = new Guna.UI2.WinForms.Guna2Panel();
			this.btn_DoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
			this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
			this.pic_Avata = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.grb_ThongTinTaiKhoan = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txt_VaiTro = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_SĐT = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_TenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btn_ThemAVT = new Guna.UI2.WinForms.Guna2Button();
			this.pane.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Avata)).BeginInit();
			this.grb_ThongTinTaiKhoan.SuspendLayout();
			this.SuspendLayout();
			// 
			// pane
			// 
			this.pane.AutoSize = true;
			this.pane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.pane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pane.BorderRadius = 30;
			this.pane.Controls.Add(this.btn_DoiMatKhau);
			this.pane.Controls.Add(this.btn_CapNhat);
			this.pane.Controls.Add(this.pic_Avata);
			this.pane.Controls.Add(this.grb_ThongTinTaiKhoan);
			this.pane.Controls.Add(this.btn_ThemAVT);
			this.pane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pane.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pane.Location = new System.Drawing.Point(0, 0);
			this.pane.Name = "pane";
			this.pane.Size = new System.Drawing.Size(1059, 662);
			this.pane.TabIndex = 10;
			// 
			// btn_DoiMatKhau
			// 
			this.btn_DoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_DoiMatKhau.BorderRadius = 10;
			this.btn_DoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_DoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_DoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_DoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_DoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White;
			this.btn_DoiMatKhau.Image = global::GUI.Properties.Resources.refresh;
			this.btn_DoiMatKhau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_DoiMatKhau.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_DoiMatKhau.Location = new System.Drawing.Point(705, 476);
			this.btn_DoiMatKhau.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
			this.btn_DoiMatKhau.Size = new System.Drawing.Size(164, 43);
			this.btn_DoiMatKhau.TabIndex = 3;
			this.btn_DoiMatKhau.Text = "    Đổi mật khẩu";
			this.btn_DoiMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
			// 
			// btn_CapNhat
			// 
			this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_CapNhat.BorderRadius = 10;
			this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_CapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
			this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
			this.btn_CapNhat.Image = global::GUI.Properties.Resources.edit;
			this.btn_CapNhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_CapNhat.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_CapNhat.Location = new System.Drawing.Point(502, 476);
			this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_CapNhat.Name = "btn_CapNhat";
			this.btn_CapNhat.Size = new System.Drawing.Size(155, 43);
			this.btn_CapNhat.TabIndex = 1;
			this.btn_CapNhat.Text = "    Cập nhật";
			this.btn_CapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
			// 
			// pic_Avata
			// 
			this.pic_Avata.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_Avata.BackColor = System.Drawing.Color.Transparent;
			this.pic_Avata.ImageRotate = 0F;
			this.pic_Avata.Location = new System.Drawing.Point(114, 79);
			this.pic_Avata.Name = "pic_Avata";
			this.pic_Avata.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.pic_Avata.Size = new System.Drawing.Size(250, 250);
			this.pic_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Avata.TabIndex = 18;
			this.pic_Avata.TabStop = false;
			// 
			// grb_ThongTinTaiKhoan
			// 
			this.grb_ThongTinTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.grb_ThongTinTaiKhoan.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinTaiKhoan.BorderRadius = 15;
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_VaiTro);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label3);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_SĐT);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label4);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_TenDangNhap);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label1);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_HoTen);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label8);
			this.grb_ThongTinTaiKhoan.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grb_ThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_ThongTinTaiKhoan.Location = new System.Drawing.Point(430, 79);
			this.grb_ThongTinTaiKhoan.Name = "grb_ThongTinTaiKhoan";
			this.grb_ThongTinTaiKhoan.Size = new System.Drawing.Size(507, 362);
			this.grb_ThongTinTaiKhoan.TabIndex = 17;
			this.grb_ThongTinTaiKhoan.Text = "Thông tin Tài khoản";
			// 
			// txt_VaiTro
			// 
			this.txt_VaiTro.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_VaiTro.DefaultText = "";
			this.txt_VaiTro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_VaiTro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_VaiTro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_VaiTro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_VaiTro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_VaiTro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_VaiTro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_VaiTro.Location = new System.Drawing.Point(196, 282);
			this.txt_VaiTro.Name = "txt_VaiTro";
			this.txt_VaiTro.PlaceholderText = "";
			this.txt_VaiTro.SelectedText = "";
			this.txt_VaiTro.Size = new System.Drawing.Size(216, 27);
			this.txt_VaiTro.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Vai trò:";
			// 
			// txt_SĐT
			// 
			this.txt_SĐT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SĐT.DefaultText = "";
			this.txt_SĐT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_SĐT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_SĐT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SĐT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SĐT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SĐT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SĐT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SĐT.Location = new System.Drawing.Point(196, 217);
			this.txt_SĐT.Name = "txt_SĐT";
			this.txt_SĐT.PlaceholderText = "";
			this.txt_SĐT.SelectedText = "";
			this.txt_SĐT.Size = new System.Drawing.Size(216, 27);
			this.txt_SĐT.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 217);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "SĐT:";
			// 
			// txt_TenDangNhap
			// 
			this.txt_TenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TenDangNhap.DefaultText = "";
			this.txt_TenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDangNhap.Location = new System.Drawing.Point(196, 152);
			this.txt_TenDangNhap.Name = "txt_TenDangNhap";
			this.txt_TenDangNhap.PlaceholderText = "";
			this.txt_TenDangNhap.SelectedText = "";
			this.txt_TenDangNhap.Size = new System.Drawing.Size(216, 27);
			this.txt_TenDangNhap.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// txt_HoTen
			// 
			this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_HoTen.DefaultText = "";
			this.txt_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_HoTen.Location = new System.Drawing.Point(196, 87);
			this.txt_HoTen.Name = "txt_HoTen";
			this.txt_HoTen.PlaceholderText = "";
			this.txt_HoTen.SelectedText = "";
			this.txt_HoTen.Size = new System.Drawing.Size(216, 27);
			this.txt_HoTen.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(69, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Họ Tên:";
			// 
			// btn_ThemAVT
			// 
			this.btn_ThemAVT.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_ThemAVT.BorderRadius = 10;
			this.btn_ThemAVT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemAVT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_ThemAVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_ThemAVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_ThemAVT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btn_ThemAVT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemAVT.ForeColor = System.Drawing.Color.White;
			this.btn_ThemAVT.Image = global::GUI.Properties.Resources.add;
			this.btn_ThemAVT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_ThemAVT.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_ThemAVT.Location = new System.Drawing.Point(145, 362);
			this.btn_ThemAVT.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_ThemAVT.Name = "btn_ThemAVT";
			this.btn_ThemAVT.Size = new System.Drawing.Size(176, 43);
			this.btn_ThemAVT.TabIndex = 0;
			this.btn_ThemAVT.Text = "    Thay đổi ảnh";
			this.btn_ThemAVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_ThemAVT.Click += new System.EventHandler(this.btn_ThemAVT_Click);
			// 
			// frmThongTinTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.pane);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmThongTinTaiKhoan";
			this.Text = "frmThongTinTaiKhoan";
			this.pane.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_Avata)).EndInit();
			this.grb_ThongTinTaiKhoan.ResumeLayout(false);
			this.grb_ThongTinTaiKhoan.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel pane;
		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinTaiKhoan;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenDangNhap;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2Button btn_DoiMatKhau;
		private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
		private Guna.UI2.WinForms.Guna2Button btn_ThemAVT;
		private Guna.UI2.WinForms.Guna2TextBox txt_VaiTro;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txt_SĐT;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Avata;
	}
}