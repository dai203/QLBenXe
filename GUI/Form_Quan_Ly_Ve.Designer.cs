namespace GUI
{
    partial class Form_Quan_Ly_Ve
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
            this.txtGiaVe = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboLoaiVe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lsvHienThi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuaVe = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTiemKiemVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemVe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenVe = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboMaXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaVe.DefaultText = "";
            this.txtGiaVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.ForeColor = System.Drawing.Color.Black;
            this.txtGiaVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaVe.Location = new System.Drawing.Point(124, 187);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.PasswordChar = '\0';
            this.txtGiaVe.PlaceholderText = "";
            this.txtGiaVe.SelectedText = "";
            this.txtGiaVe.Size = new System.Drawing.Size(235, 31);
            this.txtGiaVe.TabIndex = 54;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(21, 188);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(56, 22);
            this.guna2HtmlLabel6.TabIndex = 51;
            this.guna2HtmlLabel6.Text = "Giá Vé:";
            this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel6_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 123);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(61, 22);
            this.guna2HtmlLabel5.TabIndex = 50;
            this.guna2HtmlLabel5.Text = "Loại Vé:";
            this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
            // 
            // comboLoaiVe
            // 
            this.comboLoaiVe.BackColor = System.Drawing.Color.Transparent;
            this.comboLoaiVe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLoaiVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiVe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoaiVe.ForeColor = System.Drawing.Color.Black;
            this.comboLoaiVe.ItemHeight = 30;
            this.comboLoaiVe.Location = new System.Drawing.Point(124, 115);
            this.comboLoaiVe.Name = "comboLoaiVe";
            this.comboLoaiVe.Size = new System.Drawing.Size(235, 36);
            this.comboLoaiVe.TabIndex = 49;
            this.comboLoaiVe.SelectedIndexChanged += new System.EventHandler(this.comboLoaiVe_SelectedIndexChanged);
            // 
            // lsvHienThi
            // 
            this.lsvHienThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader13});
            this.lsvHienThi.FullRowSelect = true;
            this.lsvHienThi.GridLines = true;
            this.lsvHienThi.HideSelection = false;
            this.lsvHienThi.Location = new System.Drawing.Point(9, 328);
            this.lsvHienThi.Name = "lsvHienThi";
            this.lsvHienThi.Size = new System.Drawing.Size(982, 222);
            this.lsvHienThi.TabIndex = 36;
            this.lsvHienThi.UseCompatibleStateImageBehavior = false;
            this.lsvHienThi.View = System.Windows.Forms.View.Details;
            this.lsvHienThi.SelectedIndexChanged += new System.EventHandler(this.lsvHienThi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Vé";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Vé";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại Vé";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Giá Vé";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã Xe";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 150;
            // 
            // btnSuaVe
            // 
            this.btnSuaVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaVe.FillColor = System.Drawing.Color.White;
            this.btnSuaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaVe.ForeColor = System.Drawing.Color.Black;
            this.btnSuaVe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSuaVe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnSuaVe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSuaVe.Location = new System.Drawing.Point(198, 264);
            this.btnSuaVe.Name = "btnSuaVe";
            this.btnSuaVe.Size = new System.Drawing.Size(161, 45);
            this.btnSuaVe.TabIndex = 41;
            this.btnSuaVe.Text = "Sửa Vé";
            this.btnSuaVe.Click += new System.EventHandler(this.btnSuaVe_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(641, 261);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập Tên Vé";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(158, 48);
            this.txtTimKiem.TabIndex = 46;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(533, 63);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(53, 22);
            this.guna2HtmlLabel3.TabIndex = 45;
            this.guna2HtmlLabel3.Text = "Mã Xe:";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 63);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 22);
            this.guna2HtmlLabel2.TabIndex = 43;
            this.guna2HtmlLabel2.Text = "Tên Vé:";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // btnTiemKiemVe
            // 
            this.btnTiemKiemVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiemKiemVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiemKiemVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTiemKiemVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTiemKiemVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTiemKiemVe.FillColor = System.Drawing.Color.White;
            this.btnTiemKiemVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiemKiemVe.ForeColor = System.Drawing.Color.Black;
            this.btnTiemKiemVe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTiemKiemVe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnTiemKiemVe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTiemKiemVe.Location = new System.Drawing.Point(810, 261);
            this.btnTiemKiemVe.Name = "btnTiemKiemVe";
            this.btnTiemKiemVe.Size = new System.Drawing.Size(178, 45);
            this.btnTiemKiemVe.TabIndex = 42;
            this.btnTiemKiemVe.Text = "Tìm Vé";
            this.btnTiemKiemVe.Click += new System.EventHandler(this.btnTiemKiemVe_Click);
            // 
            // btnXoaVe
            // 
            this.btnXoaVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaVe.FillColor = System.Drawing.Color.White;
            this.btnXoaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVe.ForeColor = System.Drawing.Color.Black;
            this.btnXoaVe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnXoaVe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnXoaVe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaVe.Location = new System.Drawing.Point(434, 264);
            this.btnXoaVe.Name = "btnXoaVe";
            this.btnXoaVe.Size = new System.Drawing.Size(157, 45);
            this.btnXoaVe.TabIndex = 40;
            this.btnXoaVe.Text = "Xóa Vé";
            this.btnXoaVe.Click += new System.EventHandler(this.btnXoaVe_Click);
            // 
            // btnThemVe
            // 
            this.btnThemVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVe.FillColor = System.Drawing.Color.White;
            this.btnThemVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVe.ForeColor = System.Drawing.Color.Black;
            this.btnThemVe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnThemVe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnThemVe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemVe.Location = new System.Drawing.Point(12, 264);
            this.btnThemVe.Name = "btnThemVe";
            this.btnThemVe.Size = new System.Drawing.Size(155, 45);
            this.btnThemVe.TabIndex = 39;
            this.btnThemVe.Text = "Thêm Vé";
            this.btnThemVe.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(405, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(126, 27);
            this.guna2HtmlLabel1.TabIndex = 38;
            this.guna2HtmlLabel1.Text = "Quản Lý Vé";
            // 
            // txtTenVe
            // 
            this.txtTenVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenVe.DefaultText = "";
            this.txtTenVe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenVe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenVe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVe.ForeColor = System.Drawing.Color.Black;
            this.txtTenVe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenVe.Location = new System.Drawing.Point(124, 63);
            this.txtTenVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenVe.Name = "txtTenVe";
            this.txtTenVe.PasswordChar = '\0';
            this.txtTenVe.PlaceholderText = "";
            this.txtTenVe.SelectedText = "";
            this.txtTenVe.Size = new System.Drawing.Size(235, 31);
            this.txtTenVe.TabIndex = 37;
            // 
            // comboMaXe
            // 
            this.comboMaXe.BackColor = System.Drawing.Color.Transparent;
            this.comboMaXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMaXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMaXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboMaXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaXe.ForeColor = System.Drawing.Color.Black;
            this.comboMaXe.ItemHeight = 30;
            this.comboMaXe.Location = new System.Drawing.Point(641, 57);
            this.comboMaXe.Name = "comboMaXe";
            this.comboMaXe.Size = new System.Drawing.Size(235, 36);
            this.comboMaXe.TabIndex = 55;
            this.comboMaXe.SelectedIndexChanged += new System.EventHandler(this.comboMaXe_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.Icons8_Ios7_Arrows_Back_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 56;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Form_Quan_Ly_Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.comboMaXe);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.comboLoaiVe);
            this.Controls.Add(this.lsvHienThi);
            this.Controls.Add(this.btnSuaVe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnTiemKiemVe);
            this.Controls.Add(this.btnXoaVe);
            this.Controls.Add(this.btnThemVe);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtTenVe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Quan_Ly_Ve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Quan_Ly_Ve";
            this.Load += new System.EventHandler(this.Form_Quan_Ly_Ve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtGiaVe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox comboLoaiVe;
        private System.Windows.Forms.ListView lsvHienThi;
        private Guna.UI2.WinForms.Guna2Button btnSuaVe;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnTiemKiemVe;
        private Guna.UI2.WinForms.Guna2Button btnXoaVe;
        private Guna.UI2.WinForms.Guna2Button btnThemVe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenVe;
        private Guna.UI2.WinForms.Guna2ComboBox comboMaXe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}