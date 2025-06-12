using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace GUI
{
	public partial class frmMain : Form
	{
		private System.ComponentModel.IContainer components = null;
		//private DTO_NguoiDung user;
		private string username;
		private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ChaoUser;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Guna.UI2.WinForms.Guna2CirclePictureBox pic_Avata;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbl_ChaoUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbl_TenChucNang = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.timeMenuQLPhong = new System.Windows.Forms.Timer(this.components);
			this.timeMenuQLCauHinh = new System.Windows.Forms.Timer(this.components);
			this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
			this.flMenuCauHinh = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCauHinh = new Guna.UI2.WinForms.Guna2Button();
			this.btnThongTinTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
			this.btnDanhSachTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
			this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
			this.btnKhachThue = new Guna.UI2.WinForms.Guna2Button();
			this.btnHopDong = new Guna.UI2.WinForms.Guna2Button();
			this.btnDichVu = new Guna.UI2.WinForms.Guna2Button();
			this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
			this.flMenuPhong = new System.Windows.Forms.FlowLayoutPanel();
			this.btnPhongTro = new Guna.UI2.WinForms.Guna2Button();
			this.btnDSPhong = new Guna.UI2.WinForms.Guna2Button();
			this.btnQLPhongTro = new Guna.UI2.WinForms.Guna2Button();
			this.btnQLKhuVuc = new Guna.UI2.WinForms.Guna2Button();
			this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
			this.palLogo = new Guna.UI2.WinForms.Guna2Panel();
			this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
			this.panel_MainContent = new Guna.UI2.WinForms.Guna2Panel();
			this.panel_Charts = new Guna.UI2.WinForms.Guna2Panel();
			this.panel_BieuDo = new Guna.UI2.WinForms.Guna2Panel();
			this.cbo_ThangBieuDo = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.Chart_BieuDoThuNhap = new LiveCharts.WinForms.CartesianChart();
			this.panel_TongBieuDo = new Guna.UI2.WinForms.Guna2Panel();
			this.cbo_ThangDoanhThu = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_TongThanhToan = new System.Windows.Forms.Label();
			this.lbl_TongChuaThu = new System.Windows.Forms.Label();
			this.lbl_TongDoanhThu = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelBoxThongKe = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.lbl_BoxTongKhachThue = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.lbl_BoxTyLeLapDay = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.lbl_BoxPhongDaThue = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.lbl_BoxPhongTrong = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			pic_Avata = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			((System.ComponentModel.ISupportInitialize)(pic_Avata)).BeginInit();
			this.panelHeader.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.panelSidebar.SuspendLayout();
			this.flMenuCauHinh.SuspendLayout();
			this.flMenuPhong.SuspendLayout();
			this.palLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.panel_MainContent.SuspendLayout();
			this.panel_Charts.SuspendLayout();
			this.panel_BieuDo.SuspendLayout();
			this.panel_TongBieuDo.SuspendLayout();
			this.panelBoxThongKe.SuspendLayout();
			this.guna2GradientPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
			this.guna2GradientPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
			this.guna2GradientPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_Avata
			// 
			pic_Avata.BackColor = System.Drawing.Color.Transparent;
			pic_Avata.Image = global::GUI.Properties.Resources.default_avatar;
			pic_Avata.ImageRotate = 0F;
			pic_Avata.InitialImage = null;
			pic_Avata.Location = new System.Drawing.Point(144, 7);
			pic_Avata.Name = "pic_Avata";
			pic_Avata.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			pic_Avata.Size = new System.Drawing.Size(45, 45);
			pic_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pic_Avata.TabIndex = 2;
			pic_Avata.TabStop = false;
			pic_Avata.UseTransparentBackground = true;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
			this.panelHeader.Controls.Add(this.guna2Panel1);
			this.panelHeader.Controls.Add(this.lbl_TenChucNang);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(241, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1059, 58);
			this.panelHeader.TabIndex = 1;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Panel1.Controls.Add(this.lbl_ChaoUser);
			this.guna2Panel1.Controls.Add(pic_Avata);
			this.guna2Panel1.Location = new System.Drawing.Point(829, 1);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(200, 57);
			this.guna2Panel1.TabIndex = 5;
			// 
			// lbl_ChaoUser
			// 
			this.lbl_ChaoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_ChaoUser.BackColor = System.Drawing.Color.Transparent;
			this.lbl_ChaoUser.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ChaoUser.Location = new System.Drawing.Point(12, 14);
			this.lbl_ChaoUser.Name = "lbl_ChaoUser";
			this.lbl_ChaoUser.Size = new System.Drawing.Size(109, 28);
			this.lbl_ChaoUser.TabIndex = 4;
			this.lbl_ChaoUser.Text = "Chào User!";
			this.lbl_ChaoUser.TextAlignment = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbl_TenChucNang
			// 
			this.lbl_TenChucNang.BackColor = System.Drawing.Color.Transparent;
			this.lbl_TenChucNang.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TenChucNang.Location = new System.Drawing.Point(30, 14);
			this.lbl_TenChucNang.Name = "lbl_TenChucNang";
			this.lbl_TenChucNang.Size = new System.Drawing.Size(106, 28);
			this.lbl_TenChucNang.TabIndex = 3;
			this.lbl_TenChucNang.Text = "Trang Chủ";
			// 
			// timeMenuQLPhong
			// 
			this.timeMenuQLPhong.Interval = 10;
			this.timeMenuQLPhong.Tick += new System.EventHandler(this.timeMenuQLPhong_Tick);
			// 
			// timeMenuQLCauHinh
			// 
			this.timeMenuQLCauHinh.Interval = 10;
			this.timeMenuQLCauHinh.Tick += new System.EventHandler(this.timeMenuQLCauHinh_Tick);
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
			this.panelSidebar.Controls.Add(this.flMenuCauHinh);
			this.panelSidebar.Controls.Add(this.btnKhachThue);
			this.panelSidebar.Controls.Add(this.btnHopDong);
			this.panelSidebar.Controls.Add(this.btnDichVu);
			this.panelSidebar.Controls.Add(this.btnHoaDon);
			this.panelSidebar.Controls.Add(this.flMenuPhong);
			this.panelSidebar.Controls.Add(this.btnTrangChu);
			this.panelSidebar.Controls.Add(this.palLogo);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(241, 720);
			this.panelSidebar.TabIndex = 2;
			// 
			// flMenuCauHinh
			// 
			this.flMenuCauHinh.Controls.Add(this.btnCauHinh);
			this.flMenuCauHinh.Controls.Add(this.btnThongTinTaiKhoan);
			this.flMenuCauHinh.Controls.Add(this.btnDanhSachTaiKhoan);
			this.flMenuCauHinh.Controls.Add(this.btnDangXuat);
			this.flMenuCauHinh.Dock = System.Windows.Forms.DockStyle.Top;
			this.flMenuCauHinh.Location = new System.Drawing.Point(0, 391);
			this.flMenuCauHinh.Margin = new System.Windows.Forms.Padding(0);
			this.flMenuCauHinh.Name = "flMenuCauHinh";
			this.flMenuCauHinh.Size = new System.Drawing.Size(241, 42);
			this.flMenuCauHinh.TabIndex = 13;
			// 
			// btnCauHinh
			// 
			this.btnCauHinh.BackColor = System.Drawing.Color.Transparent;
			this.btnCauHinh.BorderColor = System.Drawing.Color.Lime;
			this.btnCauHinh.BorderRadius = 2;
			this.btnCauHinh.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnCauHinh.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnCauHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCauHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCauHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCauHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCauHinh.FillColor = System.Drawing.Color.Transparent;
			this.btnCauHinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnCauHinh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnCauHinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnCauHinh.Image = global::GUI.Properties.Resources.gear;
			this.btnCauHinh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCauHinh.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnCauHinh.Location = new System.Drawing.Point(0, 0);
			this.btnCauHinh.Margin = new System.Windows.Forms.Padding(0);
			this.btnCauHinh.Name = "btnCauHinh";
			this.btnCauHinh.PressedColor = System.Drawing.Color.Lime;
			this.btnCauHinh.Size = new System.Drawing.Size(241, 42);
			this.btnCauHinh.TabIndex = 12;
			this.btnCauHinh.Text = "         Cấu hình";
			this.btnCauHinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
			// 
			// btnThongTinTaiKhoan
			// 
			this.btnThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
			this.btnThongTinTaiKhoan.BorderColor = System.Drawing.Color.Lime;
			this.btnThongTinTaiKhoan.BorderRadius = 2;
			this.btnThongTinTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnThongTinTaiKhoan.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnThongTinTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThongTinTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThongTinTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThongTinTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThongTinTaiKhoan.FillColor = System.Drawing.Color.Transparent;
			this.btnThongTinTaiKhoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnThongTinTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnThongTinTaiKhoan.Image = global::GUI.Properties.Resources.degree;
			this.btnThongTinTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnThongTinTaiKhoan.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnThongTinTaiKhoan.ImageSize = new System.Drawing.Size(25, 25);
			this.btnThongTinTaiKhoan.Location = new System.Drawing.Point(0, 42);
			this.btnThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
			this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
			this.btnThongTinTaiKhoan.PressedColor = System.Drawing.Color.Lime;
			this.btnThongTinTaiKhoan.Size = new System.Drawing.Size(241, 42);
			this.btnThongTinTaiKhoan.TabIndex = 11;
			this.btnThongTinTaiKhoan.Text = "         Thông tin tài khoản";
			this.btnThongTinTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnThongTinTaiKhoan.Click += new System.EventHandler(this.btnThongTinTaiKhoan_Click);
			// 
			// btnDanhSachTaiKhoan
			// 
			this.btnDanhSachTaiKhoan.BackColor = System.Drawing.Color.Transparent;
			this.btnDanhSachTaiKhoan.BorderColor = System.Drawing.Color.Lime;
			this.btnDanhSachTaiKhoan.BorderRadius = 2;
			this.btnDanhSachTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnDanhSachTaiKhoan.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnDanhSachTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDanhSachTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDanhSachTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDanhSachTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDanhSachTaiKhoan.FillColor = System.Drawing.Color.Transparent;
			this.btnDanhSachTaiKhoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDanhSachTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDanhSachTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDanhSachTaiKhoan.Image = global::GUI.Properties.Resources.degree;
			this.btnDanhSachTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDanhSachTaiKhoan.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnDanhSachTaiKhoan.ImageSize = new System.Drawing.Size(25, 25);
			this.btnDanhSachTaiKhoan.Location = new System.Drawing.Point(0, 84);
			this.btnDanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
			this.btnDanhSachTaiKhoan.Name = "btnDanhSachTaiKhoan";
			this.btnDanhSachTaiKhoan.PressedColor = System.Drawing.Color.Lime;
			this.btnDanhSachTaiKhoan.Size = new System.Drawing.Size(241, 42);
			this.btnDanhSachTaiKhoan.TabIndex = 10;
			this.btnDanhSachTaiKhoan.Text = "         Danh sách tài khoản";
			this.btnDanhSachTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDanhSachTaiKhoan.Click += new System.EventHandler(this.btnDanhSachTaiKhoan_Click);
			// 
			// btnDangXuat
			// 
			this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
			this.btnDangXuat.BorderColor = System.Drawing.Color.Lime;
			this.btnDangXuat.BorderRadius = 2;
			this.btnDangXuat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnDangXuat.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
			this.btnDangXuat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDangXuat.Image = global::GUI.Properties.Resources.degree;
			this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDangXuat.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnDangXuat.ImageSize = new System.Drawing.Size(25, 25);
			this.btnDangXuat.Location = new System.Drawing.Point(0, 126);
			this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0);
			this.btnDangXuat.Name = "btnDangXuat";
			this.btnDangXuat.PressedColor = System.Drawing.Color.Lime;
			this.btnDangXuat.Size = new System.Drawing.Size(241, 42);
			this.btnDangXuat.TabIndex = 15;
			this.btnDangXuat.Text = "         Đăng Xuất";
			this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
			// 
			// btnKhachThue
			// 
			this.btnKhachThue.BackColor = System.Drawing.Color.Transparent;
			this.btnKhachThue.BorderColor = System.Drawing.Color.Lime;
			this.btnKhachThue.BorderRadius = 2;
			this.btnKhachThue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnKhachThue.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnKhachThue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnKhachThue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnKhachThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnKhachThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnKhachThue.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKhachThue.FillColor = System.Drawing.Color.Transparent;
			this.btnKhachThue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnKhachThue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnKhachThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnKhachThue.Image = global::GUI.Properties.Resources.testate;
			this.btnKhachThue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnKhachThue.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnKhachThue.Location = new System.Drawing.Point(0, 349);
			this.btnKhachThue.Name = "btnKhachThue";
			this.btnKhachThue.PressedColor = System.Drawing.Color.Lime;
			this.btnKhachThue.Size = new System.Drawing.Size(241, 42);
			this.btnKhachThue.TabIndex = 4;
			this.btnKhachThue.Text = "         Khách thuê";
			this.btnKhachThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnKhachThue.Click += new System.EventHandler(this.btnKhachThue_Click);
			// 
			// btnHopDong
			// 
			this.btnHopDong.BackColor = System.Drawing.Color.Transparent;
			this.btnHopDong.BorderColor = System.Drawing.Color.Lime;
			this.btnHopDong.BorderRadius = 2;
			this.btnHopDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHopDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHopDong.FillColor = System.Drawing.Color.Transparent;
			this.btnHopDong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnHopDong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnHopDong.Image = global::GUI.Properties.Resources.contracts;
			this.btnHopDong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHopDong.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnHopDong.Location = new System.Drawing.Point(0, 307);
			this.btnHopDong.Name = "btnHopDong";
			this.btnHopDong.PressedColor = System.Drawing.Color.Lime;
			this.btnHopDong.Size = new System.Drawing.Size(241, 42);
			this.btnHopDong.TabIndex = 10;
			this.btnHopDong.Text = "         Hợp đồng";
			this.btnHopDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
			// 
			// btnDichVu
			// 
			this.btnDichVu.BackColor = System.Drawing.Color.Transparent;
			this.btnDichVu.BorderColor = System.Drawing.Color.Lime;
			this.btnDichVu.BorderRadius = 2;
			this.btnDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDichVu.FillColor = System.Drawing.Color.Transparent;
			this.btnDichVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDichVu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDichVu.Image = global::GUI.Properties.Resources.invoice;
			this.btnDichVu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDichVu.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnDichVu.Location = new System.Drawing.Point(0, 265);
			this.btnDichVu.Name = "btnDichVu";
			this.btnDichVu.PressedColor = System.Drawing.Color.Lime;
			this.btnDichVu.Size = new System.Drawing.Size(241, 42);
			this.btnDichVu.TabIndex = 9;
			this.btnDichVu.Text = "         Dịch vụ";
			this.btnDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
			// 
			// btnHoaDon
			// 
			this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
			this.btnHoaDon.BorderColor = System.Drawing.Color.Lime;
			this.btnHoaDon.BorderRadius = 2;
			this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHoaDon.FillColor = System.Drawing.Color.Transparent;
			this.btnHoaDon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnHoaDon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnHoaDon.Image = global::GUI.Properties.Resources.contract;
			this.btnHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHoaDon.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnHoaDon.Location = new System.Drawing.Point(0, 223);
			this.btnHoaDon.Name = "btnHoaDon";
			this.btnHoaDon.PressedColor = System.Drawing.Color.Lime;
			this.btnHoaDon.Size = new System.Drawing.Size(241, 42);
			this.btnHoaDon.TabIndex = 8;
			this.btnHoaDon.Text = "         Hóa đơn";
			this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
			// 
			// flMenuPhong
			// 
			this.flMenuPhong.BackColor = System.Drawing.Color.Transparent;
			this.flMenuPhong.Controls.Add(this.btnPhongTro);
			this.flMenuPhong.Controls.Add(this.btnDSPhong);
			this.flMenuPhong.Controls.Add(this.btnQLPhongTro);
			this.flMenuPhong.Controls.Add(this.btnQLKhuVuc);
			this.flMenuPhong.Dock = System.Windows.Forms.DockStyle.Top;
			this.flMenuPhong.Location = new System.Drawing.Point(0, 181);
			this.flMenuPhong.Name = "flMenuPhong";
			this.flMenuPhong.Size = new System.Drawing.Size(241, 42);
			this.flMenuPhong.TabIndex = 0;
			// 
			// btnPhongTro
			// 
			this.btnPhongTro.BackColor = System.Drawing.Color.Transparent;
			this.btnPhongTro.BorderColor = System.Drawing.Color.Lime;
			this.btnPhongTro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPhongTro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnPhongTro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnPhongTro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnPhongTro.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPhongTro.FillColor = System.Drawing.Color.Transparent;
			this.btnPhongTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnPhongTro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnPhongTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnPhongTro.Image = global::GUI.Properties.Resources.home;
			this.btnPhongTro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnPhongTro.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnPhongTro.Location = new System.Drawing.Point(0, 0);
			this.btnPhongTro.Margin = new System.Windows.Forms.Padding(0);
			this.btnPhongTro.Name = "btnPhongTro";
			this.btnPhongTro.PressedColor = System.Drawing.Color.Lime;
			this.btnPhongTro.Size = new System.Drawing.Size(241, 43);
			this.btnPhongTro.TabIndex = 3;
			this.btnPhongTro.Text = "         Phòng trọ";
			this.btnPhongTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnPhongTro.Click += new System.EventHandler(this.btnPhongTro_Click);
			// 
			// btnDSPhong
			// 
			this.btnDSPhong.BackColor = System.Drawing.Color.Transparent;
			this.btnDSPhong.BorderColor = System.Drawing.Color.Lime;
			this.btnDSPhong.BorderRadius = 2;
			this.btnDSPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDSPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDSPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDSPhong.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDSPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(246)))), ((int)(((byte)(146)))));
			this.btnDSPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDSPhong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDSPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnDSPhong.Image = global::GUI.Properties.Resources.degree;
			this.btnDSPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDSPhong.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnDSPhong.ImageSize = new System.Drawing.Size(25, 25);
			this.btnDSPhong.Location = new System.Drawing.Point(0, 43);
			this.btnDSPhong.Margin = new System.Windows.Forms.Padding(0);
			this.btnDSPhong.Name = "btnDSPhong";
			this.btnDSPhong.PressedColor = System.Drawing.Color.Lime;
			this.btnDSPhong.Size = new System.Drawing.Size(240, 42);
			this.btnDSPhong.TabIndex = 4;
			this.btnDSPhong.Text = "         Danh sách phòng";
			this.btnDSPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDSPhong.Click += new System.EventHandler(this.btnDSPhong_Click);
			// 
			// btnQLPhongTro
			// 
			this.btnQLPhongTro.BackColor = System.Drawing.Color.Transparent;
			this.btnQLPhongTro.BorderColor = System.Drawing.Color.Lime;
			this.btnQLPhongTro.BorderRadius = 2;
			this.btnQLPhongTro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnQLPhongTro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnQLPhongTro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnQLPhongTro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnQLPhongTro.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQLPhongTro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(246)))), ((int)(((byte)(146)))));
			this.btnQLPhongTro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnQLPhongTro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnQLPhongTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnQLPhongTro.Image = global::GUI.Properties.Resources.degree;
			this.btnQLPhongTro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnQLPhongTro.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnQLPhongTro.ImageSize = new System.Drawing.Size(25, 25);
			this.btnQLPhongTro.Location = new System.Drawing.Point(0, 85);
			this.btnQLPhongTro.Margin = new System.Windows.Forms.Padding(0);
			this.btnQLPhongTro.Name = "btnQLPhongTro";
			this.btnQLPhongTro.PressedColor = System.Drawing.Color.Lime;
			this.btnQLPhongTro.Size = new System.Drawing.Size(240, 42);
			this.btnQLPhongTro.TabIndex = 5;
			this.btnQLPhongTro.Text = "         Quản lý Phòng trọ";
			this.btnQLPhongTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnQLPhongTro.Click += new System.EventHandler(this.btnQLPhongTro_Click);
			// 
			// btnQLKhuVuc
			// 
			this.btnQLKhuVuc.BackColor = System.Drawing.Color.Transparent;
			this.btnQLKhuVuc.BorderColor = System.Drawing.Color.Lime;
			this.btnQLKhuVuc.BorderRadius = 2;
			this.btnQLKhuVuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnQLKhuVuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnQLKhuVuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnQLKhuVuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnQLKhuVuc.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnQLKhuVuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(246)))), ((int)(((byte)(146)))));
			this.btnQLKhuVuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnQLKhuVuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnQLKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnQLKhuVuc.Image = global::GUI.Properties.Resources.degree;
			this.btnQLKhuVuc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnQLKhuVuc.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnQLKhuVuc.ImageSize = new System.Drawing.Size(25, 25);
			this.btnQLKhuVuc.Location = new System.Drawing.Point(0, 127);
			this.btnQLKhuVuc.Margin = new System.Windows.Forms.Padding(0);
			this.btnQLKhuVuc.Name = "btnQLKhuVuc";
			this.btnQLKhuVuc.PressedColor = System.Drawing.Color.Lime;
			this.btnQLKhuVuc.Size = new System.Drawing.Size(240, 44);
			this.btnQLKhuVuc.TabIndex = 6;
			this.btnQLKhuVuc.Text = "         Quản lý Khu vực";
			this.btnQLKhuVuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnQLKhuVuc.Click += new System.EventHandler(this.btnQLKhuVuc_Click);
			// 
			// btnTrangChu
			// 
			this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
			this.btnTrangChu.BorderColor = System.Drawing.Color.Lime;
			this.btnTrangChu.BorderRadius = 2;
			this.btnTrangChu.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnTrangChu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTrangChu.FillColor = System.Drawing.Color.Transparent;
			this.btnTrangChu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnTrangChu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.btnTrangChu.Image = global::GUI.Properties.Resources.dashboard;
			this.btnTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnTrangChu.ImageOffset = new System.Drawing.Point(15, 0);
			this.btnTrangChu.Location = new System.Drawing.Point(0, 139);
			this.btnTrangChu.Name = "btnTrangChu";
			this.btnTrangChu.PressedColor = System.Drawing.Color.Lime;
			this.btnTrangChu.Size = new System.Drawing.Size(241, 42);
			this.btnTrangChu.TabIndex = 1;
			this.btnTrangChu.Text = "         Trang chủ";
			this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
			// 
			// palLogo
			// 
			this.palLogo.BackColor = System.Drawing.Color.Transparent;
			this.palLogo.Controls.Add(this.picLogo);
			this.palLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.palLogo.Location = new System.Drawing.Point(0, 0);
			this.palLogo.Name = "palLogo";
			this.palLogo.Size = new System.Drawing.Size(241, 139);
			this.palLogo.TabIndex = 0;
			// 
			// picLogo
			// 
			this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picLogo.Image = global::GUI.Properties.Resources.Logofull;
			this.picLogo.ImageRotate = 0F;
			this.picLogo.Location = new System.Drawing.Point(32, 21);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(175, 96);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
			// 
			// panel_MainContent
			// 
			this.panel_MainContent.AutoSize = true;
			this.panel_MainContent.BackColor = System.Drawing.Color.White;
			this.panel_MainContent.BorderColor = System.Drawing.Color.Silver;
			this.panel_MainContent.BorderRadius = 15;
			this.panel_MainContent.Controls.Add(this.panel_Charts);
			this.panel_MainContent.Controls.Add(this.panelBoxThongKe);
			this.panel_MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_MainContent.Location = new System.Drawing.Point(241, 58);
			this.panel_MainContent.Name = "panel_MainContent";
			this.panel_MainContent.Size = new System.Drawing.Size(1059, 662);
			this.panel_MainContent.TabIndex = 3;
			// 
			// panel_Charts
			// 
			this.panel_Charts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel_Charts.AutoSize = true;
			this.panel_Charts.Controls.Add(this.panel_BieuDo);
			this.panel_Charts.Controls.Add(this.panel_TongBieuDo);
			this.panel_Charts.Location = new System.Drawing.Point(30, 186);
			this.panel_Charts.Name = "panel_Charts";
			this.panel_Charts.Size = new System.Drawing.Size(1002, 459);
			this.panel_Charts.TabIndex = 6;
			// 
			// panel_BieuDo
			// 
			this.panel_BieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panel_BieuDo.Controls.Add(this.cbo_ThangBieuDo);
			this.panel_BieuDo.Controls.Add(this.guna2HtmlLabel1);
			this.panel_BieuDo.Controls.Add(this.Chart_BieuDoThuNhap);
			this.panel_BieuDo.Location = new System.Drawing.Point(0, 0);
			this.panel_BieuDo.Name = "panel_BieuDo";
			this.panel_BieuDo.Size = new System.Drawing.Size(610, 456);
			this.panel_BieuDo.TabIndex = 3;
			// 
			// cbo_ThangBieuDo
			// 
			this.cbo_ThangBieuDo.AutoRoundedCorners = true;
			this.cbo_ThangBieuDo.BackColor = System.Drawing.Color.Transparent;
			this.cbo_ThangBieuDo.BorderRadius = 17;
			this.cbo_ThangBieuDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbo_ThangBieuDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_ThangBieuDo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_ThangBieuDo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_ThangBieuDo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbo_ThangBieuDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbo_ThangBieuDo.ItemHeight = 30;
			this.cbo_ThangBieuDo.Location = new System.Drawing.Point(392, 23);
			this.cbo_ThangBieuDo.Name = "cbo_ThangBieuDo";
			this.cbo_ThangBieuDo.Size = new System.Drawing.Size(187, 36);
			this.cbo_ThangBieuDo.TabIndex = 4;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 23);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(151, 23);
			this.guna2HtmlLabel1.TabIndex = 2;
			this.guna2HtmlLabel1.Text = "Biểu Đồ Doanh Thu";
			// 
			// Chart_BieuDoThuNhap
			// 
			this.Chart_BieuDoThuNhap.Location = new System.Drawing.Point(24, 115);
			this.Chart_BieuDoThuNhap.Name = "Chart_BieuDoThuNhap";
			this.Chart_BieuDoThuNhap.Size = new System.Drawing.Size(555, 324);
			this.Chart_BieuDoThuNhap.TabIndex = 1;
			this.Chart_BieuDoThuNhap.Text = "Biểu đồ doanh thu";
			// 
			// panel_TongBieuDo
			// 
			this.panel_TongBieuDo.AutoSize = true;
			this.panel_TongBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.panel_TongBieuDo.Controls.Add(this.cbo_ThangDoanhThu);
			this.panel_TongBieuDo.Controls.Add(this.label2);
			this.panel_TongBieuDo.Controls.Add(this.label5);
			this.panel_TongBieuDo.Controls.Add(this.label6);
			this.panel_TongBieuDo.Controls.Add(this.lbl_TongThanhToan);
			this.panel_TongBieuDo.Controls.Add(this.lbl_TongChuaThu);
			this.panel_TongBieuDo.Controls.Add(this.lbl_TongDoanhThu);
			this.panel_TongBieuDo.Controls.Add(this.label4);
			this.panel_TongBieuDo.Controls.Add(this.label3);
			this.panel_TongBieuDo.Controls.Add(this.label1);
			this.panel_TongBieuDo.Controls.Add(this.guna2HtmlLabel2);
			this.panel_TongBieuDo.Location = new System.Drawing.Point(641, 0);
			this.panel_TongBieuDo.Name = "panel_TongBieuDo";
			this.panel_TongBieuDo.Size = new System.Drawing.Size(358, 453);
			this.panel_TongBieuDo.TabIndex = 2;
			// 
			// cbo_ThangDoanhThu
			// 
			this.cbo_ThangDoanhThu.AutoRoundedCorners = true;
			this.cbo_ThangDoanhThu.BackColor = System.Drawing.Color.Transparent;
			this.cbo_ThangDoanhThu.BorderRadius = 17;
			this.cbo_ThangDoanhThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbo_ThangDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_ThangDoanhThu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_ThangDoanhThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbo_ThangDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbo_ThangDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbo_ThangDoanhThu.ItemHeight = 30;
			this.cbo_ThangDoanhThu.Location = new System.Drawing.Point(211, 23);
			this.cbo_ThangDoanhThu.Name = "cbo_ThangDoanhThu";
			this.cbo_ThangDoanhThu.Size = new System.Drawing.Size(131, 36);
			this.cbo_ThangDoanhThu.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(286, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "vnđ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(286, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "vnđ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(286, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "vnđ";
			// 
			// lbl_TongThanhToan
			// 
			this.lbl_TongThanhToan.AutoSize = true;
			this.lbl_TongThanhToan.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TongThanhToan.Location = new System.Drawing.Point(190, 124);
			this.lbl_TongThanhToan.Name = "lbl_TongThanhToan";
			this.lbl_TongThanhToan.Size = new System.Drawing.Size(38, 21);
			this.lbl_TongThanhToan.TabIndex = 10;
			this.lbl_TongThanhToan.Text = "234";
			this.lbl_TongThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_TongChuaThu
			// 
			this.lbl_TongChuaThu.AutoSize = true;
			this.lbl_TongChuaThu.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TongChuaThu.Location = new System.Drawing.Point(190, 165);
			this.lbl_TongChuaThu.Name = "lbl_TongChuaThu";
			this.lbl_TongChuaThu.Size = new System.Drawing.Size(38, 21);
			this.lbl_TongChuaThu.TabIndex = 9;
			this.lbl_TongChuaThu.Text = "234";
			this.lbl_TongChuaThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_TongDoanhThu
			// 
			this.lbl_TongDoanhThu.AutoSize = true;
			this.lbl_TongDoanhThu.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TongDoanhThu.Location = new System.Drawing.Point(190, 83);
			this.lbl_TongDoanhThu.Name = "lbl_TongDoanhThu";
			this.lbl_TongDoanhThu.Size = new System.Drawing.Size(38, 21);
			this.lbl_TongDoanhThu.TabIndex = 8;
			this.lbl_TongDoanhThu.Text = "234";
			this.lbl_TongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(43, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "- Tổng Thanh Toán:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(43, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "- Tổng Chưa Thu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "- Tổng Doanh Thu:";
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(22, 23);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(149, 23);
			this.guna2HtmlLabel2.TabIndex = 3;
			this.guna2HtmlLabel2.Text = "Chi Tiết Doanh Thu";
			// 
			// panelBoxThongKe
			// 
			this.panelBoxThongKe.AllowDrop = true;
			this.panelBoxThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelBoxThongKe.AutoSize = true;
			this.panelBoxThongKe.Controls.Add(this.guna2GradientPanel4);
			this.panelBoxThongKe.Controls.Add(this.guna2GradientPanel3);
			this.panelBoxThongKe.Controls.Add(this.guna2GradientPanel2);
			this.panelBoxThongKe.Controls.Add(this.guna2GradientPanel1);
			this.panelBoxThongKe.Location = new System.Drawing.Point(30, 9);
			this.panelBoxThongKe.Name = "panelBoxThongKe";
			this.panelBoxThongKe.Size = new System.Drawing.Size(1000, 174);
			this.panelBoxThongKe.TabIndex = 5;
			// 
			// guna2GradientPanel4
			// 
			this.guna2GradientPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2GradientPanel4.AutoSize = true;
			this.guna2GradientPanel4.BorderRadius = 15;
			this.guna2GradientPanel4.Controls.Add(this.guna2PictureBox4);
			this.guna2GradientPanel4.Controls.Add(this.lbl_BoxTongKhachThue);
			this.guna2GradientPanel4.Controls.Add(this.label13);
			this.guna2GradientPanel4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(74)))), ((int)(((byte)(26)))));
			this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(51)))));
			this.guna2GradientPanel4.Location = new System.Drawing.Point(768, 31);
			this.guna2GradientPanel4.Name = "guna2GradientPanel4";
			this.guna2GradientPanel4.Size = new System.Drawing.Size(231, 133);
			this.guna2GradientPanel4.TabIndex = 3;
			// 
			// guna2PictureBox4
			// 
			this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox4.Image = global::GUI.Properties.Resources.userss;
			this.guna2PictureBox4.ImageRotate = 0F;
			this.guna2PictureBox4.Location = new System.Drawing.Point(19, 21);
			this.guna2PictureBox4.Name = "guna2PictureBox4";
			this.guna2PictureBox4.Size = new System.Drawing.Size(35, 35);
			this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox4.TabIndex = 5;
			this.guna2PictureBox4.TabStop = false;
			this.guna2PictureBox4.UseTransparentBackground = true;
			// 
			// lbl_BoxTongKhachThue
			// 
			this.lbl_BoxTongKhachThue.AutoSize = true;
			this.lbl_BoxTongKhachThue.BackColor = System.Drawing.Color.Transparent;
			this.lbl_BoxTongKhachThue.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_BoxTongKhachThue.ForeColor = System.Drawing.Color.White;
			this.lbl_BoxTongKhachThue.Location = new System.Drawing.Point(14, 85);
			this.lbl_BoxTongKhachThue.Name = "lbl_BoxTongKhachThue";
			this.lbl_BoxTongKhachThue.Size = new System.Drawing.Size(186, 26);
			this.lbl_BoxTongKhachThue.TabIndex = 4;
			this.lbl_BoxTongKhachThue.Text = "Tổng khách thuê";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(62, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(135, 26);
			this.label13.TabIndex = 3;
			this.label13.Text = "Khách thuê";
			// 
			// guna2GradientPanel3
			// 
			this.guna2GradientPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2GradientPanel3.AutoSize = true;
			this.guna2GradientPanel3.BorderRadius = 15;
			this.guna2GradientPanel3.Controls.Add(this.guna2PictureBox3);
			this.guna2GradientPanel3.Controls.Add(this.lbl_BoxTyLeLapDay);
			this.guna2GradientPanel3.Controls.Add(this.label11);
			this.guna2GradientPanel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
			this.guna2GradientPanel3.Location = new System.Drawing.Point(512, 31);
			this.guna2GradientPanel3.Name = "guna2GradientPanel3";
			this.guna2GradientPanel3.Size = new System.Drawing.Size(231, 133);
			this.guna2GradientPanel3.TabIndex = 3;
			// 
			// guna2PictureBox3
			// 
			this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox3.Image = global::GUI.Properties.Resources.chart;
			this.guna2PictureBox3.ImageRotate = 0F;
			this.guna2PictureBox3.Location = new System.Drawing.Point(19, 21);
			this.guna2PictureBox3.Name = "guna2PictureBox3";
			this.guna2PictureBox3.Size = new System.Drawing.Size(35, 35);
			this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox3.TabIndex = 5;
			this.guna2PictureBox3.TabStop = false;
			this.guna2PictureBox3.UseTransparentBackground = true;
			// 
			// lbl_BoxTyLeLapDay
			// 
			this.lbl_BoxTyLeLapDay.AutoSize = true;
			this.lbl_BoxTyLeLapDay.BackColor = System.Drawing.Color.Transparent;
			this.lbl_BoxTyLeLapDay.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_BoxTyLeLapDay.ForeColor = System.Drawing.Color.White;
			this.lbl_BoxTyLeLapDay.Location = new System.Drawing.Point(14, 85);
			this.lbl_BoxTyLeLapDay.Name = "lbl_BoxTyLeLapDay";
			this.lbl_BoxTyLeLapDay.Size = new System.Drawing.Size(145, 26);
			this.lbl_BoxTyLeLapDay.TabIndex = 4;
			this.lbl_BoxTyLeLapDay.Text = "Tỷ lệ Lấp đầy";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(62, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(142, 26);
			this.label11.TabIndex = 3;
			this.label11.Text = "Tỷ lệ lấp đầy";
			// 
			// guna2GradientPanel2
			// 
			this.guna2GradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2GradientPanel2.AutoSize = true;
			this.guna2GradientPanel2.BorderRadius = 15;
			this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox2);
			this.guna2GradientPanel2.Controls.Add(this.lbl_BoxPhongDaThue);
			this.guna2GradientPanel2.Controls.Add(this.label9);
			this.guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel2.FillColor = System.Drawing.Color.Lime;
			this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.GreenYellow;
			this.guna2GradientPanel2.Location = new System.Drawing.Point(256, 31);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new System.Drawing.Size(249, 133);
			this.guna2GradientPanel2.TabIndex = 3;
			// 
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox2.Image = global::GUI.Properties.Resources.room;
			this.guna2PictureBox2.ImageRotate = 0F;
			this.guna2PictureBox2.Location = new System.Drawing.Point(19, 21);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.Size = new System.Drawing.Size(35, 35);
			this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox2.TabIndex = 5;
			this.guna2PictureBox2.TabStop = false;
			// 
			// lbl_BoxPhongDaThue
			// 
			this.lbl_BoxPhongDaThue.AutoSize = true;
			this.lbl_BoxPhongDaThue.BackColor = System.Drawing.Color.Transparent;
			this.lbl_BoxPhongDaThue.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_BoxPhongDaThue.ForeColor = System.Drawing.Color.White;
			this.lbl_BoxPhongDaThue.Location = new System.Drawing.Point(14, 85);
			this.lbl_BoxPhongDaThue.Name = "lbl_BoxPhongDaThue";
			this.lbl_BoxPhongDaThue.Size = new System.Drawing.Size(166, 26);
			this.lbl_BoxPhongDaThue.TabIndex = 4;
			this.lbl_BoxPhongDaThue.Text = "Phòng đã Thuê";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(62, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(170, 26);
			this.label9.TabIndex = 3;
			this.label9.Text = "Phòng đã thuê";
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2GradientPanel1.AutoSize = true;
			this.guna2GradientPanel1.BorderRadius = 15;
			this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
			this.guna2GradientPanel1.Controls.Add(this.lbl_BoxPhongTrong);
			this.guna2GradientPanel1.Controls.Add(this.label7);
			this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.Blue;
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Cyan;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 31);
			this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(231, 133);
			this.guna2GradientPanel1.TabIndex = 2;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::GUI.Properties.Resources.homes2;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(20, 21);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(35, 35);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 2;
			this.guna2PictureBox1.TabStop = false;
			// 
			// lbl_BoxPhongTrong
			// 
			this.lbl_BoxPhongTrong.AutoSize = true;
			this.lbl_BoxPhongTrong.BackColor = System.Drawing.Color.Transparent;
			this.lbl_BoxPhongTrong.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_BoxPhongTrong.ForeColor = System.Drawing.Color.White;
			this.lbl_BoxPhongTrong.Location = new System.Drawing.Point(15, 85);
			this.lbl_BoxPhongTrong.Name = "lbl_BoxPhongTrong";
			this.lbl_BoxPhongTrong.Size = new System.Drawing.Size(165, 26);
			this.lbl_BoxPhongTrong.TabIndex = 1;
			this.lbl_BoxPhongTrong.Text = "Tổng số phòng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(61, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(147, 26);
			this.label7.TabIndex = 0;
			this.label7.Text = "Phòng trống";
			// 
			// frmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1300, 720);
			this.Controls.Add(this.panel_MainContent);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelSidebar);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý Nhà Trọ";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(pic_Avata)).EndInit();
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.panelSidebar.ResumeLayout(false);
			this.flMenuCauHinh.ResumeLayout(false);
			this.flMenuPhong.ResumeLayout(false);
			this.palLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.panel_MainContent.ResumeLayout(false);
			this.panel_MainContent.PerformLayout();
			this.panel_Charts.ResumeLayout(false);
			this.panel_Charts.PerformLayout();
			this.panel_BieuDo.ResumeLayout(false);
			this.panel_BieuDo.PerformLayout();
			this.panel_TongBieuDo.ResumeLayout(false);
			this.panel_TongBieuDo.PerformLayout();
			this.panelBoxThongKe.ResumeLayout(false);
			this.panelBoxThongKe.PerformLayout();
			this.guna2GradientPanel4.ResumeLayout(false);
			this.guna2GradientPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
			this.guna2GradientPanel3.ResumeLayout(false);
			this.guna2GradientPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public frmMain(string username)
		{
			InitializeComponent();
			this.username = username;
			KhoiTaoHeader();
		}

		private void KhoiTaoHeader()
		{
			// Avatar
			var avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			// avatar.Image = Image.FromFile("duongdan/avatar.png"); // Nếu có ảnh
			avatar.Size = new Size(50, 50);
			avatar.Location = new Point(panelHeader.Width - 70, 10);
			avatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			panelHeader.Controls.Add(avatar);

			// Chào Username
			var lblChao = new Label();
			lblChao.Text = $"Chào, {username}!";
			lblChao.Font = new Font("Segoe UI", 12, FontStyle.Bold);
			lblChao.Location = new Point(panelHeader.Width - 220, 25);
			lblChao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			panelHeader.Controls.Add(lblChao);

			// Ô tìm kiếm
			var txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
			txtSearch.PlaceholderText = "Tìm kiếm...";
			txtSearch.Size = new Size(250, 36);
			txtSearch.Location = new Point(300, 18);
			panelHeader.Controls.Add(txtSearch);

			// Đồng hồ thời gian thực
			var lblClock = new Label();
			lblClock.Font = new Font("Segoe UI", 12, FontStyle.Regular);
			lblClock.Location = new Point(600, 25);
			panelHeader.Controls.Add(lblClock);

			var timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += (s, e) => { lblClock.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"); };
			timer.Start();
		}

		#endregion

		private Guna2Panel panelHeader;
		private Timer timeMenuQLPhong;
		private Timer timeMenuQLCauHinh;
		private Guna2Panel panelSidebar;
		private FlowLayoutPanel flMenuCauHinh;
		private Guna2Button btnCauHinh;
		private Guna2Button btnThongTinTaiKhoan;
		private Guna2Button btnDanhSachTaiKhoan;
		private Guna2Button btnDangXuat;
		private Guna2Button btnKhachThue;
		private Guna2Button btnHopDong;
		private Guna2Button btnDichVu;
		private Guna2Button btnHoaDon;
		private FlowLayoutPanel flMenuPhong;
		private Guna2Button btnPhongTro;
		private Guna2Button btnDSPhong;
		private Guna2Button btnQLPhongTro;
		private Guna2Button btnQLKhuVuc;
		private Guna2Button btnTrangChu;
		private Guna2Panel palLogo;
		private Guna2PictureBox picLogo;
		private Guna2HtmlLabel lbl_Chao;
		private Guna2HtmlLabel lbl_TenChucNang;
		private Guna2Panel panel_Charts;
		private Guna2Panel panelBoxThongKe;
		private Guna2GradientPanel guna2GradientPanel4;
		private Guna2GradientPanel guna2GradientPanel3;
		private Guna2GradientPanel guna2GradientPanel2;
		private Guna2GradientPanel guna2GradientPanel1;
		private Guna2Panel panel_BieuDo;
		private LiveCharts.WinForms.CartesianChart Chart_BieuDoThuNhap;
		private Guna2Panel panel_TongBieuDo;
		private Guna2HtmlLabel guna2HtmlLabel1;
		private Label label1;
		private Guna2HtmlLabel guna2HtmlLabel2;
		private Label lbl_TongThanhToan;
		private Label lbl_TongChuaThu;
		private Label lbl_TongDoanhThu;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label5;
		private Label label6;
		private Guna2Panel panel_MainContent;
		private Label label7;
		private Label lbl_BoxPhongTrong;
		private Guna2PictureBox guna2PictureBox1;
		private Guna2PictureBox guna2PictureBox4;
		private Label lbl_BoxTongKhachThue;
		private Label label13;
		private Guna2PictureBox guna2PictureBox3;
		private Label lbl_BoxTyLeLapDay;
		private Label label11;
		private Label lbl_BoxPhongDaThue;
		private Label label9;
		private Guna2PictureBox guna2PictureBox2;
		private Guna2ComboBox cbo_ThangBieuDo;
		private Guna2ComboBox cbo_ThangDoanhThu;
		private Guna2Panel guna2Panel1;
	}
}