namespace GUI.Components
{
	partial class Comp_ThePhong
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel_ThePhong = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_MaPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbl_GiaThue = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbl_TrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txt_SLNguoiHienTai = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbl_DienTich = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel_ThePhong.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
			this.flowLayoutPanel1.Controls.Add(this.lbl_GiaThue);
			this.flowLayoutPanel1.Controls.Add(this.txt_SLNguoiHienTai);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 48);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 25);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel_ThePhong
			// 
			this.panel_ThePhong.AutoSize = true;
			this.panel_ThePhong.BackColor = System.Drawing.Color.White;
			this.panel_ThePhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.panel_ThePhong.BorderRadius = 10;
			this.panel_ThePhong.BorderThickness = 1;
			this.panel_ThePhong.Controls.Add(this.lbl_DienTich);
			this.panel_ThePhong.Controls.Add(this.lbl_TrangThai);
			this.panel_ThePhong.Controls.Add(this.flowLayoutPanel1);
			this.panel_ThePhong.Controls.Add(this.lbl_MaPhong);
			this.panel_ThePhong.CustomBorderColor = System.Drawing.Color.Lime;
			this.panel_ThePhong.Location = new System.Drawing.Point(4, 4);
			this.panel_ThePhong.Name = "panel_ThePhong";
			this.panel_ThePhong.Size = new System.Drawing.Size(146, 73);
			this.panel_ThePhong.TabIndex = 0;
			// 
			// lbl_MaPhong
			// 
			this.lbl_MaPhong.BackColor = System.Drawing.Color.Transparent;
			this.lbl_MaPhong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_MaPhong.Location = new System.Drawing.Point(4, 3);
			this.lbl_MaPhong.Name = "lbl_MaPhong";
			this.lbl_MaPhong.Size = new System.Drawing.Size(48, 32);
			this.lbl_MaPhong.TabIndex = 1;
			this.lbl_MaPhong.Text = "A.01";
			// 
			// lbl_GiaThue
			// 
			this.lbl_GiaThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_GiaThue.BackColor = System.Drawing.Color.Transparent;
			this.lbl_GiaThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GiaThue.Location = new System.Drawing.Point(79, 4);
			this.lbl_GiaThue.Name = "lbl_GiaThue";
			this.lbl_GiaThue.Size = new System.Drawing.Size(64, 19);
			this.lbl_GiaThue.TabIndex = 0;
			this.lbl_GiaThue.Text = "1500000 đ";
			// 
			// lbl_TrangThai
			// 
			this.lbl_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_TrangThai.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TrangThai.Location = new System.Drawing.Point(59, 4);
			this.lbl_TrangThai.Name = "lbl_TrangThai";
			this.lbl_TrangThai.Size = new System.Drawing.Size(81, 19);
			this.lbl_TrangThai.TabIndex = 0;
			this.lbl_TrangThai.Text = "Phòng trống";
			// 
			// txt_SLNguoiHienTai
			// 
			this.txt_SLNguoiHienTai.BackColor = System.Drawing.Color.Transparent;
			this.txt_SLNguoiHienTai.BorderColor = System.Drawing.Color.White;
			this.txt_SLNguoiHienTai.BorderThickness = 0;
			this.txt_SLNguoiHienTai.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SLNguoiHienTai.DefaultText = "0";
			this.txt_SLNguoiHienTai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_SLNguoiHienTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_SLNguoiHienTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SLNguoiHienTai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_SLNguoiHienTai.FillColor = System.Drawing.Color.LightGray;
			this.txt_SLNguoiHienTai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SLNguoiHienTai.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_SLNguoiHienTai.ForeColor = System.Drawing.Color.Black;
			this.txt_SLNguoiHienTai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_SLNguoiHienTai.IconLeft = global::GUI.Properties.Resources.userad;
			this.txt_SLNguoiHienTai.IconLeftSize = new System.Drawing.Size(15, 15);
			this.txt_SLNguoiHienTai.Location = new System.Drawing.Point(3, 3);
			this.txt_SLNguoiHienTai.Name = "txt_SLNguoiHienTai";
			this.txt_SLNguoiHienTai.PlaceholderForeColor = System.Drawing.Color.Transparent;
			this.txt_SLNguoiHienTai.PlaceholderText = "";
			this.txt_SLNguoiHienTai.SelectedText = "";
			this.txt_SLNguoiHienTai.Size = new System.Drawing.Size(70, 20);
			this.txt_SLNguoiHienTai.TabIndex = 1;
			// 
			// lbl_DienTich
			// 
			this.lbl_DienTich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_DienTich.BackColor = System.Drawing.Color.Transparent;
			this.lbl_DienTich.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DienTich.Location = new System.Drawing.Point(79, 23);
			this.lbl_DienTich.Name = "lbl_DienTich";
			this.lbl_DienTich.Size = new System.Drawing.Size(58, 19);
			this.lbl_DienTich.TabIndex = 0;
			this.lbl_DienTich.Text = "DT: 20m2";
			// 
			// Comp_ThePhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel_ThePhong);
			this.Name = "Comp_ThePhong";
			this.Size = new System.Drawing.Size(153, 80);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel_ThePhong.ResumeLayout(false);
			this.panel_ThePhong.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl_GiaThue;
		public Guna.UI2.WinForms.Guna2Panel panel_ThePhong;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl_TrangThai;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl_MaPhong;
		private Guna.UI2.WinForms.Guna2TextBox txt_SLNguoiHienTai;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl_DienTich;
	}
}
