namespace GUI
{
	partial class frmQLKhachThue
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dgv_DSKhachThue = new Guna.UI2.WinForms.Guna2DataGridView();
			this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelMainQuanLyKhachThue = new Guna.UI2.WinForms.Guna2Panel();
			this.txt_TimKhachThue = new Guna.UI2.WinForms.Guna2TextBox();
			this.grb_ThongTinKhachThue = new Guna.UI2.WinForms.Guna2GroupBox();
			this.date_NgayVao = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.date_NgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbo_MaPhong = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbo_VaiTro = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txt_GhiChuKH = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_QueQuan = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_CongViec = new Guna.UI2.WinForms.Guna2TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_NgayVao = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhachThue)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.panelMainQuanLyKhachThue.SuspendLayout();
			this.grb_ThongTinKhachThue.SuspendLayout();
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
			this.btn_LamMoi.Location = new System.Drawing.Point(22, 217);
			this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(196, 43);
			this.btn_LamMoi.TabIndex = 3;
			this.btn_LamMoi.Text = "      Làm mới";
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
			this.btn_Xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_Xoa.ForeColor = System.Drawing.Color.White;
			this.btn_Xoa.Image = global::GUI.Properties.Resources.delete;
			this.btn_Xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Xoa.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Xoa.Location = new System.Drawing.Point(22, 160);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(196, 43);
			this.btn_Xoa.TabIndex = 2;
			this.btn_Xoa.Text = "      Xóa Khách thuê";
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
			this.btn_Sua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_Sua.ForeColor = System.Drawing.Color.White;
			this.btn_Sua.Image = global::GUI.Properties.Resources.edit;
			this.btn_Sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Sua.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Sua.Location = new System.Drawing.Point(22, 103);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(196, 43);
			this.btn_Sua.TabIndex = 1;
			this.btn_Sua.Text = "      Sửa Khách thuê";
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
			this.btn_Them.Location = new System.Drawing.Point(22, 46);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(196, 43);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "      Thêm Khách thuê";
			this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 373);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(158, 20);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Danh sách khách thuê";
			// 
			// dgv_DSKhachThue
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhachThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgv_DSKhachThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_DSKhachThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgv_DSKhachThue.ColumnHeadersHeight = 19;
			this.dgv_DSKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSKhachThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_TenKH,
            this.col_CCCD,
            this.col_SDT,
            this.col_VaiTro,
            this.col_GhiChu});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_DSKhachThue.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgv_DSKhachThue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhachThue.Location = new System.Drawing.Point(38, 399);
			this.dgv_DSKhachThue.Name = "dgv_DSKhachThue";
			this.dgv_DSKhachThue.RowHeadersVisible = false;
			this.dgv_DSKhachThue.RowTemplate.Height = 40;
			this.dgv_DSKhachThue.Size = new System.Drawing.Size(985, 237);
			this.dgv_DSKhachThue.TabIndex = 14;
			this.dgv_DSKhachThue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhachThue.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_DSKhachThue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_DSKhachThue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_DSKhachThue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_DSKhachThue.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhachThue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSKhachThue.ThemeStyle.HeaderStyle.Height = 19;
			this.dgv_DSKhachThue.ThemeStyle.ReadOnly = false;
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.Height = 40;
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhachThue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// col_STT
			// 
			this.col_STT.HeaderText = "STT";
			this.col_STT.Name = "col_STT";
			// 
			// col_TenKH
			// 
			this.col_TenKH.HeaderText = "Họ tên";
			this.col_TenKH.Name = "col_TenKH";
			// 
			// col_CCCD
			// 
			this.col_CCCD.HeaderText = "CCCD";
			this.col_CCCD.Name = "col_CCCD";
			// 
			// col_SDT
			// 
			this.col_SDT.HeaderText = "SĐT";
			this.col_SDT.Name = "col_SDT";
			// 
			// col_VaiTro
			// 
			this.col_VaiTro.HeaderText = "Vai trò";
			this.col_VaiTro.Name = "col_VaiTro";
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
			this.guna2Panel1.Controls.Add(this.btn_Xoa);
			this.guna2Panel1.Controls.Add(this.btn_Sua);
			this.guna2Panel1.Controls.Add(this.btn_Them);
			this.guna2Panel1.Location = new System.Drawing.Point(784, 33);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(239, 301);
			this.guna2Panel1.TabIndex = 13;
			// 
			// panelMainQuanLyKhachThue
			// 
			this.panelMainQuanLyKhachThue.AutoSize = true;
			this.panelMainQuanLyKhachThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panelMainQuanLyKhachThue.BorderRadius = 30;
			this.panelMainQuanLyKhachThue.Controls.Add(this.txt_TimKhachThue);
			this.panelMainQuanLyKhachThue.Controls.Add(this.grb_ThongTinKhachThue);
			this.panelMainQuanLyKhachThue.Controls.Add(this.guna2HtmlLabel1);
			this.panelMainQuanLyKhachThue.Controls.Add(this.dgv_DSKhachThue);
			this.panelMainQuanLyKhachThue.Controls.Add(this.guna2Panel1);
			this.panelMainQuanLyKhachThue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainQuanLyKhachThue.Location = new System.Drawing.Point(0, 0);
			this.panelMainQuanLyKhachThue.Name = "panelMainQuanLyKhachThue";
			this.panelMainQuanLyKhachThue.Size = new System.Drawing.Size(1059, 662);
			this.panelMainQuanLyKhachThue.TabIndex = 7;
			// 
			// txt_TimKhachThue
			// 
			this.txt_TimKhachThue.BackColor = System.Drawing.Color.White;
			this.txt_TimKhachThue.BorderRadius = 45;
			this.txt_TimKhachThue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TimKhachThue.DefaultText = "";
			this.txt_TimKhachThue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TimKhachThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TimKhachThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TimKhachThue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TimKhachThue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TimKhachThue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_TimKhachThue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TimKhachThue.IconRight = global::GUI.Properties.Resources.magnifying_glass;
			this.txt_TimKhachThue.Location = new System.Drawing.Point(784, 366);
			this.txt_TimKhachThue.Name = "txt_TimKhachThue";
			this.txt_TimKhachThue.PlaceholderText = "Tìm khách thuê...";
			this.txt_TimKhachThue.SelectedText = "";
			this.txt_TimKhachThue.Size = new System.Drawing.Size(239, 27);
			this.txt_TimKhachThue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txt_TimKhachThue.TabIndex = 17;
			this.txt_TimKhachThue.UseSystemPasswordChar = true;
			this.txt_TimKhachThue.TextChanged += new System.EventHandler(this.txt_TimKhachThue_TextChanged);
			// 
			// grb_ThongTinKhachThue
			// 
			this.grb_ThongTinKhachThue.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinKhachThue.BorderRadius = 15;
			this.grb_ThongTinKhachThue.Controls.Add(this.date_NgayVao);
			this.grb_ThongTinKhachThue.Controls.Add(this.date_NgaySinh);
			this.grb_ThongTinKhachThue.Controls.Add(this.cbo_MaPhong);
			this.grb_ThongTinKhachThue.Controls.Add(this.cbo_VaiTro);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_GhiChuKH);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_QueQuan);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_CongViec);
			this.grb_ThongTinKhachThue.Controls.Add(this.label9);
			this.grb_ThongTinKhachThue.Controls.Add(this.label5);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_CCCD);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_HoTen);
			this.grb_ThongTinKhachThue.Controls.Add(this.label7);
			this.grb_ThongTinKhachThue.Controls.Add(this.txt_NgayVao);
			this.grb_ThongTinKhachThue.Controls.Add(this.label4);
			this.grb_ThongTinKhachThue.Controls.Add(this.label6);
			this.grb_ThongTinKhachThue.Controls.Add(this.label2);
			this.grb_ThongTinKhachThue.Controls.Add(this.label1);
			this.grb_ThongTinKhachThue.Controls.Add(this.label3);
			this.grb_ThongTinKhachThue.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinKhachThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grb_ThongTinKhachThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_ThongTinKhachThue.Location = new System.Drawing.Point(38, 33);
			this.grb_ThongTinKhachThue.Name = "grb_ThongTinKhachThue";
			this.grb_ThongTinKhachThue.Size = new System.Drawing.Size(722, 301);
			this.grb_ThongTinKhachThue.TabIndex = 16;
			this.grb_ThongTinKhachThue.Text = "Thông tin khách thuê";
			// 
			// date_NgayVao
			// 
			this.date_NgayVao.Checked = true;
			this.date_NgayVao.FillColor = System.Drawing.Color.Transparent;
			this.date_NgayVao.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.date_NgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.date_NgayVao.Location = new System.Drawing.Point(113, 247);
			this.date_NgayVao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.date_NgayVao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.date_NgayVao.Name = "date_NgayVao";
			this.date_NgayVao.Size = new System.Drawing.Size(248, 27);
			this.date_NgayVao.TabIndex = 13;
			this.date_NgayVao.Value = new System.DateTime(2025, 6, 2, 0, 23, 32, 727);
			// 
			// date_NgaySinh
			// 
			this.date_NgaySinh.Checked = true;
			this.date_NgaySinh.FillColor = System.Drawing.Color.Transparent;
			this.date_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.date_NgaySinh.Location = new System.Drawing.Point(113, 152);
			this.date_NgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.date_NgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.date_NgaySinh.Name = "date_NgaySinh";
			this.date_NgaySinh.Size = new System.Drawing.Size(248, 27);
			this.date_NgaySinh.TabIndex = 13;
			this.date_NgaySinh.Value = new System.DateTime(2025, 6, 2, 0, 23, 32, 727);
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
			this.cbo_MaPhong.Location = new System.Drawing.Point(468, 106);
			this.cbo_MaPhong.Name = "cbo_MaPhong";
			this.cbo_MaPhong.Size = new System.Drawing.Size(206, 27);
			this.cbo_MaPhong.TabIndex = 12;
			// 
			// cbo_VaiTro
			// 
			this.cbo_VaiTro.BackColor = System.Drawing.Color.Transparent;
			this.cbo_VaiTro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbo_VaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_VaiTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_VaiTro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_VaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbo_VaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbo_VaiTro.ItemHeight = 21;
			this.cbo_VaiTro.Location = new System.Drawing.Point(468, 151);
			this.cbo_VaiTro.Name = "cbo_VaiTro";
			this.cbo_VaiTro.Size = new System.Drawing.Size(206, 27);
			this.cbo_VaiTro.TabIndex = 12;
			// 
			// txt_GhiChuKH
			// 
			this.txt_GhiChuKH.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_GhiChuKH.DefaultText = "";
			this.txt_GhiChuKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_GhiChuKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_GhiChuKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_GhiChuKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuKH.Location = new System.Drawing.Point(468, 197);
			this.txt_GhiChuKH.Name = "txt_GhiChuKH";
			this.txt_GhiChuKH.PlaceholderText = "";
			this.txt_GhiChuKH.SelectedText = "";
			this.txt_GhiChuKH.Size = new System.Drawing.Size(206, 77);
			this.txt_GhiChuKH.TabIndex = 11;
			// 
			// txt_QueQuan
			// 
			this.txt_QueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_QueQuan.DefaultText = "";
			this.txt_QueQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_QueQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_QueQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_QueQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_QueQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_QueQuan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_QueQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_QueQuan.Location = new System.Drawing.Point(113, 198);
			this.txt_QueQuan.Name = "txt_QueQuan";
			this.txt_QueQuan.PlaceholderText = "";
			this.txt_QueQuan.SelectedText = "";
			this.txt_QueQuan.Size = new System.Drawing.Size(248, 27);
			this.txt_QueQuan.TabIndex = 10;
			// 
			// txt_CongViec
			// 
			this.txt_CongViec.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_CongViec.DefaultText = "";
			this.txt_CongViec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_CongViec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_CongViec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CongViec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_CongViec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CongViec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_CongViec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_CongViec.Location = new System.Drawing.Point(468, 61);
			this.txt_CongViec.Name = "txt_CongViec";
			this.txt_CongViec.PlaceholderText = "";
			this.txt_CongViec.SelectedText = "";
			this.txt_CongViec.Size = new System.Drawing.Size(206, 27);
			this.txt_CongViec.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(393, 151);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 17);
			this.label9.TabIndex = 7;
			this.label9.Text = "Vai trò:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(393, 106);
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
			this.txt_CCCD.Location = new System.Drawing.Point(113, 107);
			this.txt_CCCD.Name = "txt_CCCD";
			this.txt_CCCD.PlaceholderText = "";
			this.txt_CCCD.SelectedText = "";
			this.txt_CCCD.Size = new System.Drawing.Size(248, 27);
			this.txt_CCCD.TabIndex = 9;
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
			this.txt_HoTen.Location = new System.Drawing.Point(113, 62);
			this.txt_HoTen.Name = "txt_HoTen";
			this.txt_HoTen.PlaceholderText = "";
			this.txt_HoTen.SelectedText = "";
			this.txt_HoTen.Size = new System.Drawing.Size(248, 27);
			this.txt_HoTen.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(33, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "Quê quán:";
			// 
			// txt_NgayVao
			// 
			this.txt_NgayVao.AutoSize = true;
			this.txt_NgayVao.Location = new System.Drawing.Point(33, 244);
			this.txt_NgayVao.Name = "txt_NgayVao";
			this.txt_NgayVao.Size = new System.Drawing.Size(67, 17);
			this.txt_NgayVao.TabIndex = 6;
			this.txt_NgayVao.Text = "Ngày vào:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(393, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Công việc:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Ngày sinh:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "CCCD:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Họ tên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(393, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ghi chú";
			// 
			// frmQLKhachThue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.panelMainQuanLyKhachThue);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmQLKhachThue";
			this.Text = "frm_QLKhachThue";
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhachThue)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.panelMainQuanLyKhachThue.ResumeLayout(false);
			this.panelMainQuanLyKhachThue.PerformLayout();
			this.grb_ThongTinKhachThue.ResumeLayout(false);
			this.grb_ThongTinKhachThue.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
		private Guna.UI2.WinForms.Guna2Button btn_Xoa;
		private Guna.UI2.WinForms.Guna2Button btn_Sua;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSKhachThue;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel panelMainQuanLyKhachThue;
		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinKhachThue;
		private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayVao;
		private Guna.UI2.WinForms.Guna2DateTimePicker date_NgaySinh;
		private Guna.UI2.WinForms.Guna2ComboBox cbo_MaPhong;
		private Guna.UI2.WinForms.Guna2ComboBox cbo_VaiTro;
		private Guna.UI2.WinForms.Guna2TextBox txt_GhiChuKH;
		private Guna.UI2.WinForms.Guna2TextBox txt_QueQuan;
		private Guna.UI2.WinForms.Guna2TextBox txt_CongViec;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txt_CCCD;
		private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label txt_NgayVao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		public Guna.UI2.WinForms.Guna2TextBox txt_TimKhachThue;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_CCCD;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_VaiTro;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
	}
}