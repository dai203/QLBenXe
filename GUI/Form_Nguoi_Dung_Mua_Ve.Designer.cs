namespace GUI
{
    partial class Form_Nguoi_Dung_Mua_Ve
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMuaVe = new Guna.UI2.WinForms.Guna2Button();
            this.txtTroLai = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.lsvHienThi.Location = new System.Drawing.Point(1, 127);
            this.lsvHienThi.Name = "lsvHienThi";
            this.lsvHienThi.Size = new System.Drawing.Size(1065, 426);
            this.lsvHienThi.TabIndex = 37;
            this.lsvHienThi.UseCompatibleStateImageBehavior = false;
            this.lsvHienThi.View = System.Windows.Forms.View.Details;
            this.lsvHienThi.SelectedIndexChanged += new System.EventHandler(this.lsvHienThi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Vé";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Vé";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại Vé";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Giá Vé";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 300;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã Xe";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 0;
            // 
            // txtMuaVe
            // 
            this.txtMuaVe.BorderRadius = 10;
            this.txtMuaVe.BorderThickness = 2;
            this.txtMuaVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMuaVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMuaVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtMuaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtMuaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtMuaVe.FillColor = System.Drawing.Color.White;
            this.txtMuaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtMuaVe.ForeColor = System.Drawing.Color.Black;
            this.txtMuaVe.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtMuaVe.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.txtMuaVe.HoverState.ForeColor = System.Drawing.Color.White;
            this.txtMuaVe.Location = new System.Drawing.Point(1, 68);
            this.txtMuaVe.Name = "txtMuaVe";
            this.txtMuaVe.PressedColor = System.Drawing.Color.Transparent;
            this.txtMuaVe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMuaVe.Size = new System.Drawing.Size(1065, 53);
            this.txtMuaVe.TabIndex = 38;
            this.txtMuaVe.Text = "Mua Vé";
            this.txtMuaVe.Click += new System.EventHandler(this.txtMuaVe_Click);
            // 
            // txtTroLai
            // 
            this.txtTroLai.BorderRadius = 10;
            this.txtTroLai.BorderThickness = 2;
            this.txtTroLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTroLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTroLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtTroLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtTroLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtTroLai.FillColor = System.Drawing.Color.White;
            this.txtTroLai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtTroLai.ForeColor = System.Drawing.Color.Black;
            this.txtTroLai.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtTroLai.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.txtTroLai.HoverState.ForeColor = System.Drawing.Color.White;
            this.txtTroLai.Location = new System.Drawing.Point(1, 12);
            this.txtTroLai.Name = "txtTroLai";
            this.txtTroLai.PressedColor = System.Drawing.Color.Transparent;
            this.txtTroLai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTroLai.Size = new System.Drawing.Size(1065, 50);
            this.txtTroLai.TabIndex = 39;
            this.txtTroLai.Text = "Trở Lại";
            this.txtTroLai.Click += new System.EventHandler(this.txtTroLai_Click);
            // 
            // Form_Nguoi_Dung_Mua_Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTroLai);
            this.Controls.Add(this.txtMuaVe);
            this.Controls.Add(this.lsvHienThi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Nguoi_Dung_Mua_Ve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Nguoi_Dung_Mua_Ve";
            this.Load += new System.EventHandler(this.Form_Nguoi_Dung_Mua_Ve_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvHienThi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private Guna.UI2.WinForms.Guna2Button txtMuaVe;
        private Guna.UI2.WinForms.Guna2Button txtTroLai;
    }
}