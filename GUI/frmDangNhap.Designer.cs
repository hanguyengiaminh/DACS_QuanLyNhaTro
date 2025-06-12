using System.Drawing;

namespace GUI
{
	partial class frmDangNhap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private Guna.UI2.WinForms.Guna2Panel panelGlass;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2Button btnSignIn;
		private Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

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
			this.panelGlass = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
			this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
			this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
			this.panelGlass.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelGlass
			// 
			this.panelGlass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panelGlass.BorderRadius = 30;
			this.panelGlass.Controls.Add(this.lblTitle);
			this.panelGlass.Controls.Add(this.txtUsername);
			this.panelGlass.Controls.Add(this.txtPassword);
			this.panelGlass.Controls.Add(this.chkShowPassword);
			this.panelGlass.Controls.Add(this.btnSignIn);
			this.panelGlass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panelGlass.Location = new System.Drawing.Point(267, 105);
			this.panelGlass.Margin = new System.Windows.Forms.Padding(4);
			this.panelGlass.Name = "panelGlass";
			this.panelGlass.Size = new System.Drawing.Size(533, 392);
			this.panelGlass.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(160, 26);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(164, 39);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Please Login";
			// 
			// txtUsername
			// 
			this.txtUsername.BorderRadius = 10;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUsername.Location = new System.Drawing.Point(67, 92);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.Size = new System.Drawing.Size(400, 52);
			this.txtUsername.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderRadius = 10;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.Location = new System.Drawing.Point(67, 157);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PlaceholderText = "Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(400, 52);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.CheckedState.BorderRadius = 0;
			this.chkShowPassword.CheckedState.BorderThickness = 0;
			this.chkShowPassword.Location = new System.Drawing.Point(67, 222);
			this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(139, 31);
			this.chkShowPassword.TabIndex = 3;
			this.chkShowPassword.Text = "Show password";
			this.chkShowPassword.UncheckedState.BorderRadius = 0;
			this.chkShowPassword.UncheckedState.BorderThickness = 0;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
			// 
			// btnSignIn
			// 
			this.btnSignIn.BorderRadius = 20;
			this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
			this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSignIn.ForeColor = System.Drawing.Color.White;
			this.btnSignIn.Location = new System.Drawing.Point(67, 275);
			this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(400, 59);
			this.btnSignIn.TabIndex = 4;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThoat.BackColor = System.Drawing.Color.Transparent;
			this.btnThoat.BorderColor = System.Drawing.Color.Transparent;
			this.btnThoat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThoat.FillColor = System.Drawing.Color.Transparent;
			this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Image = global::GUI.Properties.Resources.cross_circle;
			this.btnThoat.Location = new System.Drawing.Point(1017, 3);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(45, 44);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::GUI.Properties.Resources.br1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1067, 588);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.panelGlass);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DangNhap";
			this.panelGlass.ResumeLayout(false);
			this.panelGlass.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btnThoat;
	}
}