namespace Student_Management
{
    partial class frmSearch
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
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.cbDiaChi = new System.Windows.Forms.CheckBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.cbTenTK = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.msktMSSV = new System.Windows.Forms.MaskedTextBox();
            this.cbMonHoc = new System.Windows.Forms.CheckBox();
            this.cbNamSinh = new System.Windows.Forms.CheckBox();
            this.cbLop = new System.Windows.Forms.CheckBox();
            this.cbMSSV = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(643, 109);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(196, 26);
            this.txtMonHoc.TabIndex = 9;
            // 
            // txtDc
            // 
            this.txtDc.Location = new System.Drawing.Point(163, 215);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(164, 26);
            this.txtDc.TabIndex = 4;
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.AutoSize = true;
            this.cbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiaChi.Location = new System.Drawing.Point(37, 215);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.Size = new System.Drawing.Size(90, 24);
            this.cbDiaChi.TabIndex = 0;
            this.cbDiaChi.Text = "Địa chỉ";
            this.cbDiaChi.UseVisualStyleBackColor = true;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(643, 162);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(196, 26);
            this.txtTenTK.TabIndex = 10;
            // 
            // cbTenTK
            // 
            this.cbTenTK.AutoSize = true;
            this.cbTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenTK.Location = new System.Drawing.Point(453, 162);
            this.cbTenTK.Name = "cbTenTK";
            this.cbTenTK.Size = new System.Drawing.Size(65, 24);
            this.cbTenTK.TabIndex = 7;
            this.cbTenTK.Text = "Tên";
            this.cbTenTK.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(643, 241);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(196, 42);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(643, 52);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(196, 26);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.AutoSize = true;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.Location = new System.Drawing.Point(453, 54);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(102, 24);
            this.cbGioiTinh.TabIndex = 5;
            this.cbGioiTinh.Text = "Giới tính";
            this.cbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(163, 162);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(164, 26);
            this.txtNamSinh.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK47A",
            "CTK47B",
            "CTK47C",
            "CTK46A",
            "CTK46B",
            "CTK46C",
            "CTK45A",
            "CTK45B",
            "CTK45C",
            "CTK44A",
            "CTK44B",
            "CTK44C"});
            this.cboLop.Location = new System.Drawing.Point(163, 103);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(164, 28);
            this.cboLop.TabIndex = 2;
            // 
            // msktMSSV
            // 
            this.msktMSSV.Location = new System.Drawing.Point(163, 52);
            this.msktMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktMSSV.Mask = "0000000";
            this.msktMSSV.Name = "msktMSSV";
            this.msktMSSV.Size = new System.Drawing.Size(164, 26);
            this.msktMSSV.TabIndex = 1;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.AutoSize = true;
            this.cbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonHoc.Location = new System.Drawing.Point(453, 109);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(170, 24);
            this.cbMonHoc.TabIndex = 6;
            this.cbMonHoc.Text = "Môn học đăng ký";
            this.cbMonHoc.UseVisualStyleBackColor = true;
            // 
            // cbNamSinh
            // 
            this.cbNamSinh.AutoSize = true;
            this.cbNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamSinh.Location = new System.Drawing.Point(37, 162);
            this.cbNamSinh.Name = "cbNamSinh";
            this.cbNamSinh.Size = new System.Drawing.Size(109, 24);
            this.cbNamSinh.TabIndex = 0;
            this.cbNamSinh.Text = "Năm sinh";
            this.cbNamSinh.UseVisualStyleBackColor = true;
            // 
            // cbLop
            // 
            this.cbLop.AutoSize = true;
            this.cbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.Location = new System.Drawing.Point(37, 105);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(65, 24);
            this.cbLop.TabIndex = 0;
            this.cbLop.Text = "Lớp";
            this.cbLop.UseVisualStyleBackColor = true;
            // 
            // cbMSSV
            // 
            this.cbMSSV.AutoSize = true;
            this.cbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMSSV.Location = new System.Drawing.Point(37, 52);
            this.cbMSSV.Name = "cbMSSV";
            this.cbMSSV.Size = new System.Drawing.Size(85, 24);
            this.cbMSSV.TabIndex = 0;
            this.cbMSSV.Text = "MSSV";
            this.cbMSSV.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 324);
            this.Controls.Add(this.cbDiaChi);
            this.Controls.Add(this.txtDc);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbNamSinh);
            this.Controls.Add(this.cbTenTK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.msktMSSV);
            this.Controls.Add(this.cbMSSV);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.cbGioiTinh);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbMonHoc;
        private System.Windows.Forms.CheckBox cbNamSinh;
        private System.Windows.Forms.CheckBox cbLop;
        private System.Windows.Forms.CheckBox cbMSSV;
        private System.Windows.Forms.MaskedTextBox msktMSSV;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.CheckBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox cbTenTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.CheckBox cbDiaChi;
        private System.Windows.Forms.TextBox txtMonHoc;
    }
}