namespace GUI
{
	partial class frmQuanLyKhuVuc
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelMainQuanLyKhuVuc = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dgv_DSKhuVuc = new Guna.UI2.WinForms.Guna2DataGridView();
			this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TenKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.grb_NhapKhuVuc = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txt_GhiChuKhuVuc = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_TenKhuVuc = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_MaKhuVuc = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelMainQuanLyKhuVuc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhuVuc)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			this.grb_NhapKhuVuc.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainQuanLyKhuVuc
			// 
			this.panelMainQuanLyKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelMainQuanLyKhuVuc.AutoSize = true;
			this.panelMainQuanLyKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panelMainQuanLyKhuVuc.BorderRadius = 30;
			this.panelMainQuanLyKhuVuc.Controls.Add(this.guna2HtmlLabel1);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.dgv_DSKhuVuc);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.guna2Panel1);
			this.panelMainQuanLyKhuVuc.Controls.Add(this.grb_NhapKhuVuc);
			this.panelMainQuanLyKhuVuc.Location = new System.Drawing.Point(0, -2);
			this.panelMainQuanLyKhuVuc.Name = "panelMainQuanLyKhuVuc";
			this.panelMainQuanLyKhuVuc.Size = new System.Drawing.Size(1059, 662);
			this.panelMainQuanLyKhuVuc.TabIndex = 6;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 323);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(135, 20);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Danh sách khu vực";
			// 
			// dgv_DSKhuVuc
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhuVuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_DSKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_DSKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_DSKhuVuc.ColumnHeadersHeight = 19;
			this.dgv_DSKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_MaKV,
            this.col_TenKV,
            this.col_GhiChu});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_DSKhuVuc.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_DSKhuVuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhuVuc.Location = new System.Drawing.Point(38, 357);
			this.dgv_DSKhuVuc.Name = "dgv_DSKhuVuc";
			this.dgv_DSKhuVuc.RowHeadersVisible = false;
			this.dgv_DSKhuVuc.RowTemplate.Height = 40;
			this.dgv_DSKhuVuc.Size = new System.Drawing.Size(985, 263);
			this.dgv_DSKhuVuc.TabIndex = 14;
			this.dgv_DSKhuVuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhuVuc.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_DSKhuVuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_DSKhuVuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_DSKhuVuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_DSKhuVuc.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhuVuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSKhuVuc.ThemeStyle.HeaderStyle.Height = 19;
			this.dgv_DSKhuVuc.ThemeStyle.ReadOnly = false;
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.Height = 40;
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSKhuVuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// col_STT
			// 
			this.col_STT.HeaderText = "STT";
			this.col_STT.Name = "col_STT";
			// 
			// col_MaKV
			// 
			this.col_MaKV.HeaderText = "Mã KV";
			this.col_MaKV.Name = "col_MaKV";
			// 
			// col_TenKV
			// 
			this.col_TenKV.HeaderText = "Tên KV";
			this.col_TenKV.Name = "col_TenKV";
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
			this.guna2Panel1.Location = new System.Drawing.Point(739, 33);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(284, 274);
			this.guna2Panel1.TabIndex = 13;
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
			this.btn_LamMoi.Location = new System.Drawing.Point(59, 197);
			this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(172, 43);
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
			this.btn_Xoa.Location = new System.Drawing.Point(59, 140);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(172, 43);
			this.btn_Xoa.TabIndex = 2;
			this.btn_Xoa.Text = "      Xóa Khu Vực";
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
			this.btn_Sua.Location = new System.Drawing.Point(59, 83);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(172, 43);
			this.btn_Sua.TabIndex = 1;
			this.btn_Sua.Text = "      Sửa Khu Vực";
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
			this.btn_Them.Location = new System.Drawing.Point(59, 26);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(172, 43);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "      Thêm Khu Vực";
			this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// grb_NhapKhuVuc
			// 
			this.grb_NhapKhuVuc.BackColor = System.Drawing.Color.White;
			this.grb_NhapKhuVuc.BorderRadius = 15;
			this.grb_NhapKhuVuc.Controls.Add(this.txt_GhiChuKhuVuc);
			this.grb_NhapKhuVuc.Controls.Add(this.txt_TenKhuVuc);
			this.grb_NhapKhuVuc.Controls.Add(this.txt_MaKhuVuc);
			this.grb_NhapKhuVuc.Controls.Add(this.label2);
			this.grb_NhapKhuVuc.Controls.Add(this.label1);
			this.grb_NhapKhuVuc.Controls.Add(this.label3);
			this.grb_NhapKhuVuc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_NhapKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.grb_NhapKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_NhapKhuVuc.Location = new System.Drawing.Point(38, 32);
			this.grb_NhapKhuVuc.Name = "grb_NhapKhuVuc";
			this.grb_NhapKhuVuc.Size = new System.Drawing.Size(663, 275);
			this.grb_NhapKhuVuc.TabIndex = 12;
			this.grb_NhapKhuVuc.Text = "Thông tin khu vực";
			// 
			// txt_GhiChuKhuVuc
			// 
			this.txt_GhiChuKhuVuc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_GhiChuKhuVuc.DefaultText = "";
			this.txt_GhiChuKhuVuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_GhiChuKhuVuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_GhiChuKhuVuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuKhuVuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GhiChuKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuKhuVuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_GhiChuKhuVuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GhiChuKhuVuc.Location = new System.Drawing.Point(238, 180);
			this.txt_GhiChuKhuVuc.Name = "txt_GhiChuKhuVuc";
			this.txt_GhiChuKhuVuc.PlaceholderText = "";
			this.txt_GhiChuKhuVuc.SelectedText = "";
			this.txt_GhiChuKhuVuc.Size = new System.Drawing.Size(293, 70);
			this.txt_GhiChuKhuVuc.TabIndex = 11;
			// 
			// txt_TenKhuVuc
			// 
			this.txt_TenKhuVuc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TenKhuVuc.DefaultText = "";
			this.txt_TenKhuVuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TenKhuVuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TenKhuVuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenKhuVuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenKhuVuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenKhuVuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenKhuVuc.Location = new System.Drawing.Point(238, 120);
			this.txt_TenKhuVuc.Name = "txt_TenKhuVuc";
			this.txt_TenKhuVuc.PlaceholderText = "";
			this.txt_TenKhuVuc.SelectedText = "";
			this.txt_TenKhuVuc.Size = new System.Drawing.Size(293, 37);
			this.txt_TenKhuVuc.TabIndex = 10;
			// 
			// txt_MaKhuVuc
			// 
			this.txt_MaKhuVuc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaKhuVuc.DefaultText = "";
			this.txt_MaKhuVuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaKhuVuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaKhuVuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaKhuVuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaKhuVuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaKhuVuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaKhuVuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaKhuVuc.Location = new System.Drawing.Point(238, 60);
			this.txt_MaKhuVuc.Name = "txt_MaKhuVuc";
			this.txt_MaKhuVuc.PlaceholderText = "";
			this.txt_MaKhuVuc.SelectedText = "";
			this.txt_MaKhuVuc.Size = new System.Drawing.Size(293, 37);
			this.txt_MaKhuVuc.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(130, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên Khu Vực";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(129, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mã khu vực:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(157, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ghi chú";
			// 
			// frmQuanLyKhuVuc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.panelMainQuanLyKhuVuc);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmQuanLyKhuVuc";
			this.Text = "frmQuanLyKhuVuc";
			this.panelMainQuanLyKhuVuc.ResumeLayout(false);
			this.panelMainQuanLyKhuVuc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhuVuc)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.grb_NhapKhuVuc.ResumeLayout(false);
			this.grb_NhapKhuVuc.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panelMainQuanLyKhuVuc;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenKhuVuc;
		private Guna.UI2.WinForms.Guna2TextBox txt_GhiChuKhuVuc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaKhuVuc;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2GroupBox grb_NhapKhuVuc;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
		private Guna.UI2.WinForms.Guna2Button btn_Xoa;
		private Guna.UI2.WinForms.Guna2Button btn_Sua;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSKhuVuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKV;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKV;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}