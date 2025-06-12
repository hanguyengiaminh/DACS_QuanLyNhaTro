namespace GUI
{
	partial class frmQLDichVu
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
			this.panelMainQuanLyDichVu = new Guna.UI2.WinForms.Guna2Panel();
			this.txt_TimDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.grb_ThongTinDichVu = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txt_MoTaDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_GiaDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_LoaiDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TenDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_MaDichVu = new Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dgv_DSDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
			this.col_MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_ChucNang = new Guna.UI2.WinForms.Guna2Panel();
			this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
			this.panelMainQuanLyDichVu.SuspendLayout();
			this.grb_ThongTinDichVu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSDichVu)).BeginInit();
			this.panel_ChucNang.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainQuanLyDichVu
			// 
			this.panelMainQuanLyDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelMainQuanLyDichVu.AutoSize = true;
			this.panelMainQuanLyDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panelMainQuanLyDichVu.BorderRadius = 30;
			this.panelMainQuanLyDichVu.Controls.Add(this.txt_TimDichVu);
			this.panelMainQuanLyDichVu.Controls.Add(this.grb_ThongTinDichVu);
			this.panelMainQuanLyDichVu.Controls.Add(this.guna2HtmlLabel1);
			this.panelMainQuanLyDichVu.Controls.Add(this.dgv_DSDichVu);
			this.panelMainQuanLyDichVu.Controls.Add(this.panel_ChucNang);
			this.panelMainQuanLyDichVu.Location = new System.Drawing.Point(0, 1);
			this.panelMainQuanLyDichVu.Name = "panelMainQuanLyDichVu";
			this.panelMainQuanLyDichVu.Size = new System.Drawing.Size(1059, 662);
			this.panelMainQuanLyDichVu.TabIndex = 9;
			// 
			// txt_TimDichVu
			// 
			this.txt_TimDichVu.BackColor = System.Drawing.Color.White;
			this.txt_TimDichVu.BorderRadius = 30;
			this.txt_TimDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TimDichVu.DefaultText = "";
			this.txt_TimDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TimDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TimDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TimDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TimDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TimDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_TimDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TimDichVu.IconRight = global::GUI.Properties.Resources.magnifying_glass;
			this.txt_TimDichVu.Location = new System.Drawing.Point(819, 274);
			this.txt_TimDichVu.Name = "txt_TimDichVu";
			this.txt_TimDichVu.PlaceholderText = "Tìm dịch vụ...";
			this.txt_TimDichVu.SelectedText = "";
			this.txt_TimDichVu.Size = new System.Drawing.Size(212, 27);
			this.txt_TimDichVu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txt_TimDichVu.TabIndex = 18;
			this.txt_TimDichVu.UseSystemPasswordChar = true;
			this.txt_TimDichVu.MouseEnter += new System.EventHandler(this.txt_TimDichVu_MouseEnter);
			// 
			// grb_ThongTinDichVu
			// 
			this.grb_ThongTinDichVu.BackColor = System.Drawing.Color.White;
			this.grb_ThongTinDichVu.BorderRadius = 15;
			this.grb_ThongTinDichVu.Controls.Add(this.txt_MoTaDichVu);
			this.grb_ThongTinDichVu.Controls.Add(this.txt_GiaDichVu);
			this.grb_ThongTinDichVu.Controls.Add(this.label3);
			this.grb_ThongTinDichVu.Controls.Add(this.txt_LoaiDichVu);
			this.grb_ThongTinDichVu.Controls.Add(this.label2);
			this.grb_ThongTinDichVu.Controls.Add(this.txt_TenDichVu);
			this.grb_ThongTinDichVu.Controls.Add(this.label1);
			this.grb_ThongTinDichVu.Controls.Add(this.txt_MaDichVu);
			this.grb_ThongTinDichVu.Controls.Add(this.label8);
			this.grb_ThongTinDichVu.Controls.Add(this.label9);
			this.grb_ThongTinDichVu.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.grb_ThongTinDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grb_ThongTinDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.grb_ThongTinDichVu.Location = new System.Drawing.Point(38, 23);
			this.grb_ThongTinDichVu.Name = "grb_ThongTinDichVu";
			this.grb_ThongTinDichVu.Size = new System.Drawing.Size(755, 235);
			this.grb_ThongTinDichVu.TabIndex = 17;
			this.grb_ThongTinDichVu.Text = "Thông tin Dịch vụ";
			// 
			// txt_MoTaDichVu
			// 
			this.txt_MoTaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MoTaDichVu.DefaultText = "";
			this.txt_MoTaDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MoTaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MoTaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MoTaDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MoTaDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MoTaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MoTaDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MoTaDichVu.Location = new System.Drawing.Point(492, 120);
			this.txt_MoTaDichVu.Name = "txt_MoTaDichVu";
			this.txt_MoTaDichVu.PlaceholderText = "";
			this.txt_MoTaDichVu.SelectedText = "";
			this.txt_MoTaDichVu.Size = new System.Drawing.Size(211, 79);
			this.txt_MoTaDichVu.TabIndex = 11;
			// 
			// txt_GiaDichVu
			// 
			this.txt_GiaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_GiaDichVu.DefaultText = "";
			this.txt_GiaDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_GiaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_GiaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GiaDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_GiaDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GiaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_GiaDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_GiaDichVu.Location = new System.Drawing.Point(492, 69);
			this.txt_GiaDichVu.Name = "txt_GiaDichVu";
			this.txt_GiaDichVu.PlaceholderText = "";
			this.txt_GiaDichVu.SelectedText = "";
			this.txt_GiaDichVu.Size = new System.Drawing.Size(211, 27);
			this.txt_GiaDichVu.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(395, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Giá dịch vụ:";
			// 
			// txt_LoaiDichVu
			// 
			this.txt_LoaiDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_LoaiDichVu.DefaultText = "";
			this.txt_LoaiDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_LoaiDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_LoaiDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LoaiDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_LoaiDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LoaiDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LoaiDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_LoaiDichVu.Location = new System.Drawing.Point(144, 172);
			this.txt_LoaiDichVu.Name = "txt_LoaiDichVu";
			this.txt_LoaiDichVu.PlaceholderText = "";
			this.txt_LoaiDichVu.SelectedText = "";
			this.txt_LoaiDichVu.Size = new System.Drawing.Size(201, 27);
			this.txt_LoaiDichVu.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Loại dịch vụ:";
			// 
			// txt_TenDichVu
			// 
			this.txt_TenDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TenDichVu.DefaultText = "";
			this.txt_TenDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TenDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TenDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDichVu.Location = new System.Drawing.Point(144, 120);
			this.txt_TenDichVu.Name = "txt_TenDichVu";
			this.txt_TenDichVu.PlaceholderText = "";
			this.txt_TenDichVu.SelectedText = "";
			this.txt_TenDichVu.Size = new System.Drawing.Size(201, 27);
			this.txt_TenDichVu.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên dịch vụ:";
			// 
			// txt_MaDichVu
			// 
			this.txt_MaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaDichVu.DefaultText = "";
			this.txt_MaDichVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaDichVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaDichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MaDichVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaDichVu.Location = new System.Drawing.Point(144, 69);
			this.txt_MaDichVu.Name = "txt_MaDichVu";
			this.txt_MaDichVu.PlaceholderText = "";
			this.txt_MaDichVu.SelectedText = "";
			this.txt_MaDichVu.Size = new System.Drawing.Size(201, 27);
			this.txt_MaDichVu.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(47, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mã dịch vụ:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(395, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Mô tả:";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 281);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(133, 20);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Danh sách Dịch vụ";
			// 
			// dgv_DSDichVu
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgv_DSDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_DSDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_DSDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_DSDichVu.ColumnHeadersHeight = 19;
			this.dgv_DSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaDV,
            this.col_TenDichVu,
            this.col_LoaiDV,
            this.col_GiaDV,
            this.col_Mota});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_DSDichVu.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_DSDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSDichVu.Location = new System.Drawing.Point(38, 306);
			this.dgv_DSDichVu.Name = "dgv_DSDichVu";
			this.dgv_DSDichVu.RowHeadersVisible = false;
			this.dgv_DSDichVu.RowTemplate.Height = 40;
			this.dgv_DSDichVu.Size = new System.Drawing.Size(993, 323);
			this.dgv_DSDichVu.TabIndex = 14;
			this.dgv_DSDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSDichVu.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_DSDichVu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_DSDichVu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_DSDichVu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_DSDichVu.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSDichVu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_DSDichVu.ThemeStyle.HeaderStyle.Height = 19;
			this.dgv_DSDichVu.ThemeStyle.ReadOnly = false;
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.Height = 40;
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_DSDichVu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// col_MaDV
			// 
			this.col_MaDV.HeaderText = "Mã Dịch vụ";
			this.col_MaDV.Name = "col_MaDV";
			// 
			// col_TenDichVu
			// 
			this.col_TenDichVu.HeaderText = "Tên dịch vụ";
			this.col_TenDichVu.Name = "col_TenDichVu";
			// 
			// col_LoaiDV
			// 
			this.col_LoaiDV.HeaderText = "Loại DV";
			this.col_LoaiDV.Name = "col_LoaiDV";
			// 
			// col_GiaDV
			// 
			this.col_GiaDV.HeaderText = "Giá DV";
			this.col_GiaDV.Name = "col_GiaDV";
			// 
			// col_Mota
			// 
			this.col_Mota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_Mota.HeaderText = "Mô tả";
			this.col_Mota.Name = "col_Mota";
			// 
			// panel_ChucNang
			// 
			this.panel_ChucNang.BackColor = System.Drawing.Color.White;
			this.panel_ChucNang.BorderRadius = 30;
			this.panel_ChucNang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.panel_ChucNang.Controls.Add(this.btn_LamMoi);
			this.panel_ChucNang.Controls.Add(this.btn_Xoa);
			this.panel_ChucNang.Controls.Add(this.btn_Sua);
			this.panel_ChucNang.Controls.Add(this.btn_Them);
			this.panel_ChucNang.Location = new System.Drawing.Point(819, 23);
			this.panel_ChucNang.Name = "panel_ChucNang";
			this.panel_ChucNang.Size = new System.Drawing.Size(212, 235);
			this.panel_ChucNang.TabIndex = 13;
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
			this.btn_LamMoi.Location = new System.Drawing.Point(29, 174);
			this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(155, 43);
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
			this.btn_Xoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_Xoa.ForeColor = System.Drawing.Color.White;
			this.btn_Xoa.Image = global::GUI.Properties.Resources.delete;
			this.btn_Xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Xoa.ImageOffset = new System.Drawing.Point(10, 0);
			this.btn_Xoa.Location = new System.Drawing.Point(29, 120);
			this.btn_Xoa.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(155, 43);
			this.btn_Xoa.TabIndex = 2;
			this.btn_Xoa.Text = "    Xóa Dịch vụ";
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
			this.btn_Sua.Location = new System.Drawing.Point(29, 66);
			this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(155, 43);
			this.btn_Sua.TabIndex = 1;
			this.btn_Sua.Text = "    Sửa Dịch vụ";
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
			this.btn_Them.Location = new System.Drawing.Point(29, 12);
			this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(155, 43);
			this.btn_Them.TabIndex = 0;
			this.btn_Them.Text = "    Thêm Dịch vụ";
			this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// frmQLDichVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1059, 662);
			this.Controls.Add(this.panelMainQuanLyDichVu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmQLDichVu";
			this.Text = "frmQLDichVu";
			this.panelMainQuanLyDichVu.ResumeLayout(false);
			this.panelMainQuanLyDichVu.PerformLayout();
			this.grb_ThongTinDichVu.ResumeLayout(false);
			this.grb_ThongTinDichVu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSDichVu)).EndInit();
			this.panel_ChucNang.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panelMainQuanLyDichVu;
		public Guna.UI2.WinForms.Guna2TextBox txt_TimDichVu;
		private Guna.UI2.WinForms.Guna2GroupBox grb_ThongTinDichVu;
		private Guna.UI2.WinForms.Guna2TextBox txt_MoTaDichVu;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaDichVu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2DataGridView dgv_DSDichVu;
		private Guna.UI2.WinForms.Guna2Panel panel_ChucNang;
		private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
		private Guna.UI2.WinForms.Guna2Button btn_Xoa;
		private Guna.UI2.WinForms.Guna2Button btn_Sua;
		private Guna.UI2.WinForms.Guna2Button btn_Them;
		private Guna.UI2.WinForms.Guna2TextBox txt_GiaDichVu;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txt_LoaiDichVu;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenDichVu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_MaDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDichVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Mota;
	}
}