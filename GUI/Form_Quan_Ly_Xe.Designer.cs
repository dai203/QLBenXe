namespace GUI
{
    partial class Form_Quan_Ly_Xe
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
            this.lsvHienThi = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtThoiGianDiChuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTiemKiemXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboSoCho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboLoaiXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBienSoXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNguoiLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDienThoaiNguoiLai = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvHienThi
            // 
            this.lsvHienThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvHienThi.FullRowSelect = true;
            this.lsvHienThi.GridLines = true;
            this.lsvHienThi.HideSelection = false;
            this.lsvHienThi.Location = new System.Drawing.Point(9, 328);
            this.lsvHienThi.Name = "lsvHienThi";
            this.lsvHienThi.Size = new System.Drawing.Size(982, 222);
            this.lsvHienThi.TabIndex = 12;
            this.lsvHienThi.UseCompatibleStateImageBehavior = false;
            this.lsvHienThi.View = System.Windows.Forms.View.Details;
            this.lsvHienThi.SelectedIndexChanged += new System.EventHandler(this.lsvHienThi_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Xe";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Xe";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Chỗ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại Xe";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Biển Số Xe";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thời Gian Di Chuyển";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên Người Lái";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SĐT Người Lái";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 150;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.White;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(617, 258);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập Tên XE";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 48);
            this.txtTimKiem.TabIndex = 22;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(482, 71);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(152, 22);
            this.guna2HtmlLabel3.TabIndex = 21;
            this.guna2HtmlLabel3.Text = "Thời Gian Di Chuyển:";
            // 
            // txtThoiGianDiChuyen
            // 
            this.txtThoiGianDiChuyen.BorderColor = System.Drawing.Color.White;
            this.txtThoiGianDiChuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGianDiChuyen.DefaultText = "";
            this.txtThoiGianDiChuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThoiGianDiChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThoiGianDiChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThoiGianDiChuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThoiGianDiChuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThoiGianDiChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianDiChuyen.ForeColor = System.Drawing.Color.Black;
            this.txtThoiGianDiChuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThoiGianDiChuyen.Location = new System.Drawing.Point(709, 64);
            this.txtThoiGianDiChuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiGianDiChuyen.Name = "txtThoiGianDiChuyen";
            this.txtThoiGianDiChuyen.PasswordChar = '\0';
            this.txtThoiGianDiChuyen.PlaceholderText = "";
            this.txtThoiGianDiChuyen.SelectedText = "";
            this.txtThoiGianDiChuyen.Size = new System.Drawing.Size(245, 30);
            this.txtThoiGianDiChuyen.TabIndex = 20;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 71);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 22);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Tên Xe:";
            // 
            // btnTiemKiemXe
            // 
            this.btnTiemKiemXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiemKiemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiemKiemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTiemKiemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTiemKiemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTiemKiemXe.FillColor = System.Drawing.Color.White;
            this.btnTiemKiemXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiemKiemXe.ForeColor = System.Drawing.Color.Black;
            this.btnTiemKiemXe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTiemKiemXe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnTiemKiemXe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTiemKiemXe.Location = new System.Drawing.Point(810, 261);
            this.btnTiemKiemXe.Name = "btnTiemKiemXe";
            this.btnTiemKiemXe.Size = new System.Drawing.Size(178, 45);
            this.btnTiemKiemXe.TabIndex = 18;
            this.btnTiemKiemXe.Text = "Tìm Kiếm Xe";
            this.btnTiemKiemXe.Click += new System.EventHandler(this.btnTiemKiemXe_Click);
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaXe.FillColor = System.Drawing.Color.White;
            this.btnSuaXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaXe.ForeColor = System.Drawing.Color.Black;
            this.btnSuaXe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSuaXe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnSuaXe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSuaXe.Location = new System.Drawing.Point(198, 264);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(161, 45);
            this.btnSuaXe.TabIndex = 17;
            this.btnSuaXe.Text = "Sửa Xe";
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaXe.FillColor = System.Drawing.Color.White;
            this.btnXoaXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.ForeColor = System.Drawing.Color.Black;
            this.btnXoaXe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnXoaXe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnXoaXe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnXoaXe.Location = new System.Drawing.Point(434, 264);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(157, 45);
            this.btnXoaXe.TabIndex = 16;
            this.btnXoaXe.Text = "Xóa Xe";
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemXe.FillColor = System.Drawing.Color.White;
            this.btnThemXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.ForeColor = System.Drawing.Color.Black;
            this.btnThemXe.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnThemXe.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnThemXe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThemXe.Location = new System.Drawing.Point(12, 264);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(155, 45);
            this.btnThemXe.TabIndex = 15;
            this.btnThemXe.Text = "Thêm Xe";
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(411, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 24);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Quản Lý Xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderColor = System.Drawing.Color.White;
            this.txtTenXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenXe.DefaultText = "";
            this.txtTenXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.ForeColor = System.Drawing.Color.Black;
            this.txtTenXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Location = new System.Drawing.Point(136, 63);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.PasswordChar = '\0';
            this.txtTenXe.PlaceholderText = "";
            this.txtTenXe.SelectedText = "";
            this.txtTenXe.Size = new System.Drawing.Size(235, 31);
            this.txtTenXe.TabIndex = 13;
            this.txtTenXe.TextChanged += new System.EventHandler(this.txtTenXe_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 115);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "Số Chỗ:";
            // 
            // comboSoCho
            // 
            this.comboSoCho.BackColor = System.Drawing.Color.Transparent;
            this.comboSoCho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSoCho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSoCho.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoCho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSoCho.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSoCho.ForeColor = System.Drawing.Color.Black;
            this.comboSoCho.ItemHeight = 30;
            this.comboSoCho.Location = new System.Drawing.Point(136, 107);
            this.comboSoCho.Name = "comboSoCho";
            this.comboSoCho.Size = new System.Drawing.Size(235, 36);
            this.comboSoCho.TabIndex = 24;
            this.comboSoCho.SelectedIndexChanged += new System.EventHandler(this.comboSoCho_SelectedIndexChanged);
            // 
            // comboLoaiXe
            // 
            this.comboLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.comboLoaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboLoaiXe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLoaiXe.ForeColor = System.Drawing.Color.Black;
            this.comboLoaiXe.ItemHeight = 30;
            this.comboLoaiXe.Location = new System.Drawing.Point(136, 153);
            this.comboLoaiXe.Name = "comboLoaiXe";
            this.comboLoaiXe.Size = new System.Drawing.Size(235, 36);
            this.comboLoaiXe.TabIndex = 26;
            this.comboLoaiXe.SelectedIndexChanged += new System.EventHandler(this.comboLoaiXe_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(23, 167);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(61, 22);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "Loại Xe:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(23, 205);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel6.TabIndex = 28;
            this.guna2HtmlLabel6.Text = "Biển Số Xe:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(482, 153);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(177, 22);
            this.guna2HtmlLabel9.TabIndex = 31;
            this.guna2HtmlLabel9.Text = "Số Điện Thoại Người Lái:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(482, 115);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(104, 22);
            this.guna2HtmlLabel10.TabIndex = 32;
            this.guna2HtmlLabel10.Text = "Tên Người Lái:";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.BorderColor = System.Drawing.Color.White;
            this.txtBienSoXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBienSoXe.DefaultText = "";
            this.txtBienSoXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBienSoXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBienSoXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSoXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSoXe.ForeColor = System.Drawing.Color.Black;
            this.txtBienSoXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Location = new System.Drawing.Point(137, 201);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.PasswordChar = '\0';
            this.txtBienSoXe.PlaceholderText = "";
            this.txtBienSoXe.SelectedText = "";
            this.txtBienSoXe.Size = new System.Drawing.Size(235, 31);
            this.txtBienSoXe.TabIndex = 33;
            // 
            // txtTenNguoiLai
            // 
            this.txtTenNguoiLai.BorderColor = System.Drawing.Color.White;
            this.txtTenNguoiLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNguoiLai.DefaultText = "";
            this.txtTenNguoiLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNguoiLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNguoiLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNguoiLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNguoiLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguoiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiLai.ForeColor = System.Drawing.Color.Black;
            this.txtTenNguoiLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNguoiLai.Location = new System.Drawing.Point(709, 107);
            this.txtTenNguoiLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNguoiLai.Name = "txtTenNguoiLai";
            this.txtTenNguoiLai.PasswordChar = '\0';
            this.txtTenNguoiLai.PlaceholderText = "";
            this.txtTenNguoiLai.SelectedText = "";
            this.txtTenNguoiLai.Size = new System.Drawing.Size(245, 30);
            this.txtTenNguoiLai.TabIndex = 34;
            // 
            // txtSoDienThoaiNguoiLai
            // 
            this.txtSoDienThoaiNguoiLai.BorderColor = System.Drawing.Color.White;
            this.txtSoDienThoaiNguoiLai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDienThoaiNguoiLai.DefaultText = "";
            this.txtSoDienThoaiNguoiLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDienThoaiNguoiLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDienThoaiNguoiLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNguoiLai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDienThoaiNguoiLai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNguoiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoaiNguoiLai.ForeColor = System.Drawing.Color.Black;
            this.txtSoDienThoaiNguoiLai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDienThoaiNguoiLai.Location = new System.Drawing.Point(709, 150);
            this.txtSoDienThoaiNguoiLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoaiNguoiLai.Name = "txtSoDienThoaiNguoiLai";
            this.txtSoDienThoaiNguoiLai.PasswordChar = '\0';
            this.txtSoDienThoaiNguoiLai.PlaceholderText = "";
            this.txtSoDienThoaiNguoiLai.SelectedText = "";
            this.txtSoDienThoaiNguoiLai.Size = new System.Drawing.Size(245, 30);
            this.txtSoDienThoaiNguoiLai.TabIndex = 35;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.Icons8_Ios7_Arrows_Back_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 36;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Form_Quan_Ly_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtSoDienThoaiNguoiLai);
            this.Controls.Add(this.txtTenNguoiLai);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.comboLoaiXe);
            this.Controls.Add(this.comboSoCho);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.lsvHienThi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtThoiGianDiChuyen);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnTiemKiemXe);
            this.Controls.Add(this.btnSuaXe);
            this.Controls.Add(this.btnXoaXe);
            this.Controls.Add(this.btnThemXe);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtTenXe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Quan_Ly_Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan_Ly_Xe";
            this.Load += new System.EventHandler(this.Quan_Ly_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvHienThi;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtThoiGianDiChuyen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnTiemKiemXe;
        private Guna.UI2.WinForms.Guna2Button btnSuaXe;
        private Guna.UI2.WinForms.Guna2Button btnXoaXe;
        private Guna.UI2.WinForms.Guna2Button btnThemXe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenXe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox comboSoCho;
        private Guna.UI2.WinForms.Guna2ComboBox comboLoaiXe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txtBienSoXe;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNguoiLai;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoaiNguoiLai;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}