namespace GUI
{
	partial class frmDoiMatKhau
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
			this.grb_ThongTinTaiKhoan = new Guna.UI2.WinForms.Guna2GroupBox();
			this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
			this.txt_NhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_MatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_MatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
			this.txt_XacNhanMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.grb_ThongTinTaiKhoan.SuspendLayout();
			this.SuspendLayout();
			// 
			// grb_ThongTinTaiKhoan
			// 
			this.grb_ThongTinTaiKhoan.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinTaiKhoan.BorderRadius = 15;
			this.grb_ThongTinTaiKhoan.BorderThickness = 2;
			this.grb_ThongTinTaiKhoan.Controls.Add(this.chkShowPassword);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.btn_Luu);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.btn_Thoat);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_NhapLaiMatKhau);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label2);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_MatKhauMoi);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label1);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_MatKhauCu);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.label8);
			this.grb_ThongTinTaiKhoan.Controls.Add(this.txt_XacNhanMatKhau);
			this.grb_ThongTinTaiKhoan.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grb_ThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grb_ThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_ThongTinTaiKhoan.Location = new System.Drawing.Point(0, 0);
			this.grb_ThongTinTaiKhoan.Name = "grb_ThongTinTaiKhoan";
			this.grb_ThongTinTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.grb_ThongTinTaiKhoan.Size = new System.Drawing.Size(502, 366);
			this.grb_ThongTinTaiKhoan.TabIndex = 18;
			this.grb_ThongTinTaiKhoan.Text = "Đổi mật khẩu";
			this.grb_ThongTinTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_Luu
			// 
			this.btn_Luu.BorderRadius = 10;
			this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
			this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Luu.ForeColor = System.Drawing.Color.White;
			this.btn_Luu.Image = global::GUI.Properties.Resources.save;
			this.btn_Luu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Luu.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Luu.Location = new System.Drawing.Point(94, 278);
			this.btn_Luu.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Luu.Name = "btn_Luu";
			this.btn_Luu.Size = new System.Drawing.Size(111, 43);
			this.btn_Luu.TabIndex = 13;
			this.btn_Luu.Text = "    Lưu";
			this.btn_Luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.BorderRadius = 10;
			this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
			this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Thoat.ForeColor = System.Drawing.Color.White;
			this.btn_Thoat.Image = global::GUI.Properties.Resources.logout1;
			this.btn_Thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Thoat.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Thoat.Location = new System.Drawing.Point(269, 278);
			this.btn_Thoat.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(119, 43);
			this.btn_Thoat.TabIndex = 11;
			this.btn_Thoat.Text = "    Thoát";
			this.btn_Thoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// txt_NhapLaiMatKhau
			// 
			this.txt_NhapLaiMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_NhapLaiMatKhau.DefaultText = "";
			this.txt_NhapLaiMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_NhapLaiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_NhapLaiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_NhapLaiMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_NhapLaiMatKhau.Enabled = false;
			this.txt_NhapLaiMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_NhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_NhapLaiMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(206, 185);
			this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
			this.txt_NhapLaiMatKhau.PasswordChar = '*';
			this.txt_NhapLaiMatKhau.PlaceholderText = "Nhập lại mật khẩu mới...";
			this.txt_NhapLaiMatKhau.SelectedText = "";
			this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(216, 27);
			this.txt_NhapLaiMatKhau.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nhập lại Mật khẩu:";
			// 
			// txt_MatKhauMoi
			// 
			this.txt_MatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MatKhauMoi.DefaultText = "";
			this.txt_MatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhauMoi.Location = new System.Drawing.Point(206, 136);
			this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
			this.txt_MatKhauMoi.PasswordChar = '*';
			this.txt_MatKhauMoi.PlaceholderText = "Nhập mật khẩu mới...";
			this.txt_MatKhauMoi.SelectedText = "";
			this.txt_MatKhauMoi.Size = new System.Drawing.Size(216, 27);
			this.txt_MatKhauMoi.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mật khẩu mới:";
			// 
			// txt_MatKhauCu
			// 
			this.txt_MatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MatKhauCu.DefaultText = "";
			this.txt_MatKhauCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MatKhauCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MatKhauCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhauCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhauCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhauCu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_MatKhauCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhauCu.Location = new System.Drawing.Point(206, 87);
			this.txt_MatKhauCu.Name = "txt_MatKhauCu";
			this.txt_MatKhauCu.PasswordChar = '*';
			this.txt_MatKhauCu.PlaceholderText = "Nhập mật khẩu cũ..";
			this.txt_MatKhauCu.SelectedText = "";
			this.txt_MatKhauCu.Size = new System.Drawing.Size(216, 27);
			this.txt_MatKhauCu.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(69, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mật khẩu cũ:";
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.CheckedState.BorderRadius = 0;
			this.chkShowPassword.CheckedState.BorderThickness = 0;
			this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowPassword.Location = new System.Drawing.Point(206, 219);
			this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(196, 31);
			this.chkShowPassword.TabIndex = 14;
			this.chkShowPassword.Text = "Show password";
			this.chkShowPassword.UncheckedState.BorderRadius = 0;
			this.chkShowPassword.UncheckedState.BorderThickness = 0;
			// 
			// txt_XacNhanMatKhau
			// 
			this.txt_XacNhanMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_XacNhanMatKhau.DefaultText = "";
			this.txt_XacNhanMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_XacNhanMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_XacNhanMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_XacNhanMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_XacNhanMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_XacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_XacNhanMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(206, 189);
			this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
			this.txt_XacNhanMatKhau.PasswordChar = '*';
			this.txt_XacNhanMatKhau.PlaceholderText = "Nhập lại mật khẩu...";
			this.txt_XacNhanMatKhau.SelectedText = "";
			this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(216, 27);
			this.txt_XacNhanMatKhau.TabIndex = 15;
			// 
			// frmDoiMatKhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(502, 366);
			this.Controls.Add(this.grb_ThongTinTaiKhoan);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDoiMatKhau";
			this.Text = "frmDoiMatKhau";
			this.grb_ThongTinTaiKhoan.ResumeLayout(false);
			this.grb_ThongTinTaiKhoan.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinTaiKhoan;
		private Guna.UI2.WinForms.Guna2TextBox txt_NhapLaiMatKhau;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txt_MatKhauMoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2Button btn_Thoat;
		private Guna.UI2.WinForms.Guna2Button btn_Luu;
		public Guna.UI2.WinForms.Guna2TextBox txt_MatKhauCu;
		private Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
		private Guna.UI2.WinForms.Guna2TextBox txt_XacNhanMatKhau;
	}
}