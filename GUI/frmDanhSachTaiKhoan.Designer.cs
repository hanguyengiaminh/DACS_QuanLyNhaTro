namespace GUI
{
	partial class frmDanhSachTaiKhoan
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.dgv_DSTaiKhoan = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelMainQuanLyKhuVuc = new Guna.UI2.WinForms.Guna2Panel();
			this.col_idTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grb_ThongTinTaiKhoan = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txt_VaiTro = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_SĐT = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_TenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.pic_Avata = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.panelMainQuanLyKhuVuc.SuspendLayout();
			this.grb_ThongTinTaiKhoan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Avata)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_LamMoi
			// 
			this.btn_LamMoi.BorderRadius = 10;
			this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
			this.btn_LamMoi.Image = global::GUI.Properties.Resources.refresh;
			this.btn_LamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_LamMoi.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_LamMoi.Location = new System.Drawing.Point(16, 203);
			this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(143, 43);
			this.btn_LamMoi.TabIndex = 3;
			this.btn_LamMoi.Text = "    Làm mới";
			this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.BorderRadius = 10;
			this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
			this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Xoa.ForeColor = System.Drawing.Color.White;
			this.btn_Xoa.Image = global::GUI.Properties.Resources.delete;
			this.btn_Xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Xoa.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Xoa.Location = new System.Drawing.Point(16, 146);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(143, 43);
			this.btn_Xoa.TabIndex = 2;
			this.btn_Xoa.Text = "    Xóa";
			this.btn_Xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.BorderRadius = 10;
			this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
			this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sua.ForeColor = System.Drawing.Color.White;
			this.btn_Sua.Image = global::GUI.Properties.Resources.edit;
			this.btn_Sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Sua.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Sua.Location = new System.Drawing.Point(16, 89);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(143, 43);
			this.btn_Sua.TabIndex = 1;
			this.btn_Sua.Text = "    Sửa";
			this.btn_Sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.BorderRadius = 10;
			this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
			this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Them.ForeColor = System.Drawing.Color.White;
			this.btn_Them.Image = global::GUI.Properties.Resources.add;
			this.btn_Them.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Them.Location = new System.Drawing.Point(16, 32);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(143, 43);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "    Thêm";
			this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// dgv_DSTaiKhoan
			// 
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
			this.dgv_DSTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
			this.dgv_DSTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_DSTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dgv_DSTaiKhoan.ColumnHeadersHeight = 19;
			this.dgv_DSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idTaiKhoan,
            this.col_HoTen,
            this.col_TenDangNhap,
            this.col_SDT,
            this.col_VaiTro});
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_DSTaiKhoan.DefaultCellStyle = dataGridViewCellStyle21;
			this.dgv_DSTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSTaiKhoan.Location = new System.Drawing.Point(30, 287);
			this.dgv_DSTaiKhoan.Name = "dgv_DSTaiKhoan";
			this.dgv_DSTaiKhoan.RowHeadersVisible = false;
			this.dgv_DSTaiKhoan.RowTemplate.Height = 40;
			this.dgv_DSTaiKhoan.Size = new System.Drawing.Size(797, 349);
			this.dgv_DSTaiKhoan.TabIndex = 14;
			this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_DSTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_DSTaiKhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSTaiKhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSTaiKhoan.ThemeStyle.HeaderStyle.Height = 19;
			this.dgv_DSTaiKhoan.ThemeStyle.ReadOnly = false;
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.Height = 40;
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Panel1.BackColor = System.Drawing.Color.White;
			this.guna2Panel1.BorderRadius = 30;
			this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.guna2Panel1.Controls.Add(this.btn_LamMoi);
			this.guna2Panel1.Controls.Add(this.btn_Xoa);
			this.guna2Panel1.Controls.Add(this.btn_Sua);
			this.guna2Panel1.Controls.Add(this.btn_Them);
			this.guna2Panel1.Location = new System.Drawing.Point(851, 33);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(172, 274);
			this.guna2Panel1.TabIndex = 13;
			// 
			// panelMainQuanLyKhuVuc
			// 
			this.panelMainQuanLyKhuVuc.AutoSize = true;
			this.panelMainQuanLyKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panelMainQuanLyKhuVuc.BorderRadius = 30;
			this.panelMainQuanLyKhuVuc.Controls.Add(this.guna2HtmlLabel1);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.grb_ThongTinTaiKhoan);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.dgv_DSTaiKhoan);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.guna2Panel1);
			this.panelMainQuanLyKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainQuanLyKhuVuc.Location = new System.Drawing.Point(0, 0);
			this.panelMainQuanLyKhuVuc.Name = "panelMainQuanLyKhuVuc";
			this.panelMainQuanLyKhuVuc.Size = new System.Drawing.Size(1059, 662);
			this.panelMainQuanLyKhuVuc.TabIndex = 7;
			// 
			// col_idTaiKhoan
			// 
			this.col_idTaiKhoan.HeaderText = "ID";
			this.col_idTaiKhoan.Name = "col_idTaiKhoan";
			// 
			// col_HoTen
			// 
			this.col_HoTen.HeaderText = "Họ Tên";
			this.col_HoTen.Name = "col_HoTen";
			// 
			// col_TenDangNhap
			// 
			this.col_TenDangNhap.HeaderText = "Tên đăng nhập";
			this.col_TenDangNhap.Name = "col_TenDangNhap";
			// 
			// col_SDT
			// 
			this.col_SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_SDT.HeaderText = "SĐT";
			this.col_SDT.Name = "col_SDT";
			// 
			// col_VaiTro
			// 
			this.col_VaiTro.HeaderText = "Vai Trò";
			this.col_VaiTro.Name = "col_VaiTro";
			// 
			// grb_ThongTinTaiKhoan
			// 
			this.grb_ThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grb_ThongTinTaiKhoan.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinTaiKhoan.BorderRadius = 15;
			this.grb_ThongTinTaiKhoan.Controls.Add(this.pic_Avata);
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
			this.grb_ThongTinTaiKhoan.Location = new System.Drawing.Point(30, 33);
			this.grb_ThongTinTaiKhoan.Name = "grb_ThongTinTaiKhoan";
			this.grb_ThongTinTaiKhoan.Size = new System.Drawing.Size(797, 205);
			this.grb_ThongTinTaiKhoan.TabIndex = 18;
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
			this.txt_VaiTro.Location = new System.Drawing.Point(599, 140);
			this.txt_VaiTro.Name = "txt_VaiTro";
			this.txt_VaiTro.PlaceholderText = "";
			this.txt_VaiTro.SelectedText = "";
			this.txt_VaiTro.Size = new System.Drawing.Size(135, 27);
			this.txt_VaiTro.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(544, 140);
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
			this.txt_SĐT.Location = new System.Drawing.Point(599, 83);
			this.txt_SĐT.Name = "txt_SĐT";
			this.txt_SĐT.PlaceholderText = "";
			this.txt_SĐT.SelectedText = "";
			this.txt_SĐT.Size = new System.Drawing.Size(135, 27);
			this.txt_SĐT.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(544, 83);
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
			this.txt_TenDangNhap.Location = new System.Drawing.Point(327, 140);
			this.txt_TenDangNhap.Name = "txt_TenDangNhap";
			this.txt_TenDangNhap.PlaceholderText = "";
			this.txt_TenDangNhap.SelectedText = "";
			this.txt_TenDangNhap.Size = new System.Drawing.Size(196, 27);
			this.txt_TenDangNhap.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên Đăng nhập:";
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
			this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_HoTen.Location = new System.Drawing.Point(327, 83);
			this.txt_HoTen.Name = "txt_HoTen";
			this.txt_HoTen.PlaceholderText = "";
			this.txt_HoTen.SelectedText = "";
			this.txt_HoTen.Size = new System.Drawing.Size(196, 27);
			this.txt_HoTen.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(219, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Họ Tên:";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 261);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(146, 20);
			this.guna2HtmlLabel1.TabIndex = 19;
			this.guna2HtmlLabel1.Text = "Danh sách Tài khoản";
			// 
			// pic_Avata
			// 
			this.pic_Avata.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pic_Avata.BackColor = System.Drawing.Color.Transparent;
			this.pic_Avata.Image = global::GUI.Properties.Resources.userad;
			this.pic_Avata.ImageRotate = 0F;
			this.pic_Avata.Location = new System.Drawing.Point(56, 64);
			this.pic_Avata.Name = "pic_Avata";
			this.pic_Avata.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.pic_Avata.Size = new System.Drawing.Size(100, 100);
			this.pic_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_Avata.TabIndex = 19;
			this.pic_Avata.TabStop = false;
			// 
			// frmDanhSachTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.panelMainQuanLyKhuVuc);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDanhSachTaiKhoan";
			this.Text = "frmDanhSachTaiKhoan";
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.panelMainQuanLyKhuVuc.ResumeLayout(false);
			this.panelMainQuanLyKhuVuc.PerformLayout();
			this.grb_ThongTinTaiKhoan.ResumeLayout(false);
			this.grb_ThongTinTaiKhoan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_Avata)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
		private Guna.UI2.WinForms.Guna2Button btn_Xoa;
		private Guna.UI2.WinForms.Guna2Button btn_Sua;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSTaiKhoan;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel panelMainQuanLyKhuVuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_idTaiKhoan;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDangNhap;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_VaiTro;
		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinTaiKhoan;
		private Guna.UI2.WinForms.Guna2TextBox txt_VaiTro;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txt_SĐT;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenDangNhap;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Avata;
	}
}