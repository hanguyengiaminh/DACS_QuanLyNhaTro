namespace GUI
{
	partial class frmQLHopDong
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dgv_DSHopDong = new Guna.UI2.WinForms.Guna2DataGridView();
			this.col_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelMainQuanLyHopDong = new Guna.UI2.WinForms.Guna2Panel();
			this.grb_ThongTinHopDong = new Guna.UI2.WinForms.Guna2GroupBox();
			this.date_NgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.date_NgayVao = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbo_MaPhong = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txt_GhiChuHopDong = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_MaHopDong = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_NgayBatDau = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSHopDong)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.panelMainQuanLyHopDong.SuspendLayout();
			this.grb_ThongTinHopDong.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_LamMoi
			// 
			this.btn_LamMoi.BorderRadius = 10;
			this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_LamMoi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
			this.btn_LamMoi.Image = global::GUI.Properties.Resources.refresh;
			this.btn_LamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_LamMoi.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_LamMoi.Location = new System.Drawing.Point(33, 178);
			this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(185, 43);
			this.btn_LamMoi.TabIndex = 3;
			this.btn_LamMoi.Text = "      Làm mới";
			this.btn_LamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.BorderRadius = 10;
			this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
			this.btn_Sua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_Sua.ForeColor = System.Drawing.Color.White;
			this.btn_Sua.Image = global::GUI.Properties.Resources.edit;
			this.btn_Sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Sua.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Sua.Location = new System.Drawing.Point(33, 120);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(185, 43);
			this.btn_Sua.TabIndex = 1;
			this.btn_Sua.Text = "      Sửa Hợp đồng";
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
			this.btn_Them.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_Them.ForeColor = System.Drawing.Color.White;
			this.btn_Them.Image = global::GUI.Properties.Resources.add;
			this.btn_Them.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Them.Location = new System.Drawing.Point(33, 63);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(185, 43);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "      Thêm Hợp đồng";
			this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 323);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(147, 20);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Danh sách Hợp đồng";
			// 
			// dgv_DSHopDong
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.dgv_DSHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgv_DSHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_DSHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgv_DSHopDong.ColumnHeadersHeight = 19;
			this.dgv_DSHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHD,
            this.col_TenKH,
            this.col_Phong,
            this.col_NgayBatDau,
            this.col_NgayKetThuc,
            this.col_GhiChu});
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_DSHopDong.DefaultCellStyle = dataGridViewCellStyle12;
			this.dgv_DSHopDong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSHopDong.Location = new System.Drawing.Point(38, 357);
			this.dgv_DSHopDong.Name = "dgv_DSHopDong";
			this.dgv_DSHopDong.RowHeadersVisible = false;
			this.dgv_DSHopDong.RowTemplate.Height = 40;
			this.dgv_DSHopDong.Size = new System.Drawing.Size(985, 277);
			this.dgv_DSHopDong.TabIndex = 14;
			this.dgv_DSHopDong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSHopDong.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_DSHopDong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_DSHopDong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_DSHopDong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_DSHopDong.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSHopDong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSHopDong.ThemeStyle.HeaderStyle.Height = 19;
			this.dgv_DSHopDong.ThemeStyle.ReadOnly = false;
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.Height = 40;
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSHopDong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// col_MaHD
			// 
			this.col_MaHD.HeaderText = "Mã HĐ";
			this.col_MaHD.Name = "col_MaHD";
			// 
			// col_TenKH
			// 
			this.col_TenKH.HeaderText = "Họ Tên";
			this.col_TenKH.Name = "col_TenKH";
			// 
			// col_Phong
			// 
			this.col_Phong.HeaderText = "Phòng";
			this.col_Phong.Name = "col_Phong";
			// 
			// col_NgayBatDau
			// 
			this.col_NgayBatDau.HeaderText = "Ngày BĐ";
			this.col_NgayBatDau.Name = "col_NgayBatDau";
			// 
			// col_NgayKetThuc
			// 
			this.col_NgayKetThuc.HeaderText = "Ngày KT";
			this.col_NgayKetThuc.Name = "col_NgayKetThuc";
			// 
			// col_GhiChu
			// 
			this.col_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_GhiChu.HeaderText = "Ghi chú";
			this.col_GhiChu.Name = "col_GhiChu";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.White;
			this.guna2Panel1.BorderRadius = 30;
			this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.guna2Panel1.Controls.Add(this.btn_LamMoi);
			this.guna2Panel1.Controls.Add(this.btn_Sua);
			this.guna2Panel1.Controls.Add(this.btn_Them);
			this.guna2Panel1.Location = new System.Drawing.Point(778, 33);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(245, 274);
			this.guna2Panel1.TabIndex = 13;
			// 
			// panelMainQuanLyHopDong
			// 
			this.panelMainQuanLyHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelMainQuanLyHopDong.AutoSize = true;
			this.panelMainQuanLyHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panelMainQuanLyHopDong.BorderRadius = 30;
			this.panelMainQuanLyHopDong.Controls.Add(this.grb_ThongTinHopDong);
			this.panelMainQuanLyHopDong.Controls.Add(this.guna2HtmlLabel1);
			this.panelMainQuanLyHopDong.Controls.Add(this.dgv_DSHopDong);
			this.panelMainQuanLyHopDong.Controls.Add(this.guna2Panel1);
			this.panelMainQuanLyHopDong.Location = new System.Drawing.Point(0, -2);
			this.panelMainQuanLyHopDong.Name = "panelMainQuanLyHopDong";
			this.panelMainQuanLyHopDong.Size = new System.Drawing.Size(1059, 667);
			this.panelMainQuanLyHopDong.TabIndex = 7;
			// 
			// grb_ThongTinHopDong
			// 
			this.grb_ThongTinHopDong.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinHopDong.BorderRadius = 15;
			this.grb_ThongTinHopDong.Controls.Add(this.date_NgayKetThuc);
			this.grb_ThongTinHopDong.Controls.Add(this.date_NgayVao);
			this.grb_ThongTinHopDong.Controls.Add(this.cbo_MaPhong);
			this.grb_ThongTinHopDong.Controls.Add(this.txt_GhiChuHopDong);
			this.grb_ThongTinHopDong.Controls.Add(this.txt_MaHopDong);
			this.grb_ThongTinHopDong.Controls.Add(this.label5);
			this.grb_ThongTinHopDong.Controls.Add(this.txt_CCCD);
			this.grb_ThongTinHopDong.Controls.Add(this.label6);
			this.grb_ThongTinHopDong.Controls.Add(this.txt_HoTen);
			this.grb_ThongTinHopDong.Controls.Add(this.txt_NgayBatDau);
			this.grb_ThongTinHopDong.Controls.Add(this.label4);
			this.grb_ThongTinHopDong.Controls.Add(this.label2);
			this.grb_ThongTinHopDong.Controls.Add(this.label1);
			this.grb_ThongTinHopDong.Controls.Add(this.label3);
			this.grb_ThongTinHopDong.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinHopDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grb_ThongTinHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_ThongTinHopDong.Location = new System.Drawing.Point(38, 33);
			this.grb_ThongTinHopDong.Name = "grb_ThongTinHopDong";
			this.grb_ThongTinHopDong.Size = new System.Drawing.Size(718, 274);
			this.grb_ThongTinHopDong.TabIndex = 17;
			this.grb_ThongTinHopDong.Text = "Thông tin Hợp đồng";
			// 
			// date_NgayKetThuc
			// 
			this.date_NgayKetThuc.Checked = true;
			this.date_NgayKetThuc.FillColor = System.Drawing.Color.Transparent;
			this.date_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.date_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.date_NgayKetThuc.Location = new System.Drawing.Point(462, 220);
			this.date_NgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.date_NgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.date_NgayKetThuc.Name = "date_NgayKetThuc";
			this.date_NgayKetThuc.Size = new System.Drawing.Size(224, 27);
			this.date_NgayKetThuc.TabIndex = 13;
			this.date_NgayKetThuc.Value = new System.DateTime(2025, 6, 2, 0, 23, 32, 727);
			// 
			// date_NgayVao
			// 
			this.date_NgayVao.Checked = true;
			this.date_NgayVao.FillColor = System.Drawing.Color.Transparent;
			this.date_NgayVao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.date_NgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.date_NgayVao.Location = new System.Drawing.Point(124, 216);
			this.date_NgayVao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.date_NgayVao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.date_NgayVao.Name = "date_NgayVao";
			this.date_NgayVao.Size = new System.Drawing.Size(217, 27);
			this.date_NgayVao.TabIndex = 13;
			this.date_NgayVao.Value = new System.DateTime(2025, 6, 2, 0, 23, 32, 727);
			// 
			// cbo_MaPhong
			// 
			this.cbo_MaPhong.BackColor = System.Drawing.Color.Transparent;
			this.cbo_MaPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbo_MaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_MaPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_MaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_MaPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbo_MaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbo_MaPhong.ItemHeight = 21;
			this.cbo_MaPhong.Location = new System.Drawing.Point(462, 72);
			this.cbo_MaPhong.Name = "cbo_MaPhong";
			this.cbo_MaPhong.Size = new System.Drawing.Size(224, 27);
			this.cbo_MaPhong.TabIndex = 12;
			// 
			// txt_GhiChuHopDong
			// 
			this.txt_GhiChuHopDong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_GhiChuHopDong.DefaultText = "";
			this.txt_GhiChuHopDong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_GhiChuHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_GhiChuHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuHopDong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuHopDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuHopDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_GhiChuHopDong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuHopDong.Location = new System.Drawing.Point(462, 120);
			this.txt_GhiChuHopDong.Name = "txt_GhiChuHopDong";
			this.txt_GhiChuHopDong.PlaceholderText = "";
			this.txt_GhiChuHopDong.SelectedText = "";
			this.txt_GhiChuHopDong.Size = new System.Drawing.Size(224, 77);
			this.txt_GhiChuHopDong.TabIndex = 11;
			// 
			// txt_MaHopDong
			// 
			this.txt_MaHopDong.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaHopDong.DefaultText = "";
			this.txt_MaHopDong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaHopDong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaHopDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaHopDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaHopDong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaHopDong.Location = new System.Drawing.Point(124, 72);
			this.txt_MaHopDong.Name = "txt_MaHopDong";
			this.txt_MaHopDong.PlaceholderText = "";
			this.txt_MaHopDong.SelectedText = "";
			this.txt_MaHopDong.Size = new System.Drawing.Size(217, 27);
			this.txt_MaHopDong.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(368, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Mã phòng:";
			// 
			// txt_CCCD
			// 
			this.txt_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_CCCD.DefaultText = "";
			this.txt_CCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_CCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_CCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CCCD.Enabled = false;
			this.txt_CCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_CCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CCCD.Location = new System.Drawing.Point(124, 168);
			this.txt_CCCD.Name = "txt_CCCD";
			this.txt_CCCD.PlaceholderText = "";
			this.txt_CCCD.SelectedText = "";
			this.txt_CCCD.Size = new System.Drawing.Size(217, 27);
			this.txt_CCCD.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(368, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Ngày kết thúc:";
			// 
			// txt_HoTen
			// 
			this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_HoTen.DefaultText = "";
			this.txt_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_HoTen.Enabled = false;
			this.txt_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txt_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_HoTen.Location = new System.Drawing.Point(124, 120);
			this.txt_HoTen.Name = "txt_HoTen";
			this.txt_HoTen.PlaceholderText = "";
			this.txt_HoTen.SelectedText = "";
			this.txt_HoTen.Size = new System.Drawing.Size(217, 27);
			this.txt_HoTen.TabIndex = 9;
			// 
			// txt_NgayBatDau
			// 
			this.txt_NgayBatDau.AutoSize = true;
			this.txt_NgayBatDau.Location = new System.Drawing.Point(28, 216);
			this.txt_NgayBatDau.Name = "txt_NgayBatDau";
			this.txt_NgayBatDau.Size = new System.Drawing.Size(91, 17);
			this.txt_NgayBatDau.TabIndex = 6;
			this.txt_NgayBatDau.Text = "Ngày bắt đầu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mã hợp đồng:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "CCCD:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Họ tên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(368, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ghi chú";
			// 
			// frmQLHopDong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.panelMainQuanLyHopDong);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmQLHopDong";
			this.Text = "frmQLHopDong";
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSHopDong)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.panelMainQuanLyHopDong.ResumeLayout(false);
			this.panelMainQuanLyHopDong.PerformLayout();
			this.grb_ThongTinHopDong.ResumeLayout(false);
			this.grb_ThongTinHopDong.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
		private Guna.UI2.WinForms.Guna2Button btn_Sua;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSHopDong;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel panelMainQuanLyHopDong;
		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinHopDong;
		private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayVao;
		private Guna.UI2.WinForms.Guna2ComboBox cbo_MaPhong;
		private Guna.UI2.WinForms.Guna2TextBox txt_GhiChuHopDong;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaHopDong;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txt_CCCD;
		private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
		private System.Windows.Forms.Label txt_NgayBatDau;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayKetThuc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Phong;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBatDau;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKetThuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
	}
}