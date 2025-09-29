namespace Student_Management
{
    partial class frmChinh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnControl = new System.Windows.Forms.Panel();
            this.clMonHocDangKy = new System.Windows.Forms.CheckedListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktSoDT = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.msktSCMND = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktMSSV = new System.Windows.Forms.MaskedTextBox();
            this.pnDanhsach = new System.Windows.Forms.Panel();
            this.dgvDanhsachsv = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsImportOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemdataTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.itemdataJson = new System.Windows.Forms.ToolStripMenuItem();
            this.itemdataXML = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.pnControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachsv)).BeginInit();
            this.cmsImportOptions.SuspendLayout();
            this.ctmsMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnControl.Controls.Add(this.clMonHocDangKy);
            this.pnControl.Controls.Add(this.btnThoat);
            this.pnControl.Controls.Add(this.btnCapNhat);
            this.pnControl.Controls.Add(this.btnThemMoi);
            this.pnControl.Controls.Add(this.btnTimKiem);
            this.pnControl.Controls.Add(this.btnReset);
            this.pnControl.Controls.Add(this.txtDiaChi);
            this.pnControl.Controls.Add(this.label5);
            this.pnControl.Controls.Add(this.msktSoDT);
            this.pnControl.Controls.Add(this.label10);
            this.pnControl.Controls.Add(this.cboLop);
            this.pnControl.Controls.Add(this.label9);
            this.pnControl.Controls.Add(this.txtTen);
            this.pnControl.Controls.Add(this.label8);
            this.pnControl.Controls.Add(this.groupBox1);
            this.pnControl.Controls.Add(this.label7);
            this.pnControl.Controls.Add(this.msktSCMND);
            this.pnControl.Controls.Add(this.label4);
            this.pnControl.Controls.Add(this.dtpNgaySinh);
            this.pnControl.Controls.Add(this.label3);
            this.pnControl.Controls.Add(this.txtHoTenLot);
            this.pnControl.Controls.Add(this.label2);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.msktMSSV);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1344, 346);
            this.pnControl.TabIndex = 0;
            // 
            // clMonHocDangKy
            // 
            this.clMonHocDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clMonHocDangKy.BackColor = System.Drawing.Color.White;
            this.clMonHocDangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clMonHocDangKy.CheckOnClick = true;
            this.clMonHocDangKy.ColumnWidth = 200;
            this.clMonHocDangKy.ContextMenuStrip = this.ctmsMonHoc;
            this.clMonHocDangKy.FormattingEnabled = true;
            this.clMonHocDangKy.Items.AddRange(new object[] {
            "Hệ điều hành",
            "Mạng máy tính",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clMonHocDangKy.Location = new System.Drawing.Point(624, 3);
            this.clMonHocDangKy.MultiColumn = true;
            this.clMonHocDangKy.Name = "clMonHocDangKy";
            this.clMonHocDangKy.Size = new System.Drawing.Size(720, 278);
            this.clMonHocDangKy.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1007, 302);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 31);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(879, 302);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 31);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(742, 302);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(109, 31);
            this.btnThemMoi.TabIndex = 22;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(607, 302);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 31);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Location = new System.Drawing.Point(452, 302);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 36);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(152, 277);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 26);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ liên lạc :";
            // 
            // msktSoDT
            // 
            this.msktSoDT.Location = new System.Drawing.Point(434, 130);
            this.msktSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktSoDT.Mask = "0000000000";
            this.msktSoDT.Name = "msktSoDT";
            this.msktSoDT.Size = new System.Drawing.Size(164, 26);
            this.msktSoDT.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số ĐT :";
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
            this.cboLop.Location = new System.Drawing.Point(434, 91);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(164, 28);
            this.cboLop.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Lớp :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(434, 42);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(164, 26);
            this.txtTen.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Location = new System.Drawing.Point(153, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(6, 21);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(67, 24);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(121, 21);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 24);
            this.rdNu.TabIndex = 0;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính :";
            // 
            // msktSCMND
            // 
            this.msktSCMND.Location = new System.Drawing.Point(153, 173);
            this.msktSCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktSCMND.Mask = "000000000";
            this.msktSCMND.Name = "msktSCMND";
            this.msktSCMND.Size = new System.Drawing.Size(196, 26);
            this.msktSCMND.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số CMND : ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(153, 124);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(195, 26);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh :";
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(153, 82);
            this.txtHoTenLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Size = new System.Drawing.Size(196, 26);
            this.txtHoTenLot.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ và tên lót :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MSSV :";
            // 
            // msktMSSV
            // 
            this.msktMSSV.Location = new System.Drawing.Point(153, 39);
            this.msktMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktMSSV.Mask = "0000000";
            this.msktMSSV.Name = "msktMSSV";
            this.msktMSSV.Size = new System.Drawing.Size(196, 26);
            this.msktMSSV.TabIndex = 2;
            // 
            // pnDanhsach
            // 
            this.pnDanhsach.Controls.Add(this.dgvDanhsachsv);
            this.pnDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhsach.Location = new System.Drawing.Point(0, 346);
            this.pnDanhsach.Name = "pnDanhsach";
            this.pnDanhsach.Size = new System.Drawing.Size(1344, 352);
            this.pnDanhsach.TabIndex = 1;
            // 
            // dgvDanhsachsv
            // 
            this.dgvDanhsachsv.AllowDrop = true;
            this.dgvDanhsachsv.AllowUserToAddRows = false;
            this.dgvDanhsachsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.MSSV,
            this.HoTenLot,
            this.Ten,
            this.NgaySinh,
            this.Lop,
            this.CMND,
            this.SoDienThoai,
            this.DiaChi,
            this.GioiTinh,
            this.MonHoc});
            this.dgvDanhsachsv.ContextMenuStrip = this.cmsImportOptions;
            this.dgvDanhsachsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsachsv.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhsachsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhsachsv.Name = "dgvDanhsachsv";
            this.dgvDanhsachsv.RowHeadersVisible = false;
            this.dgvDanhsachsv.RowHeadersWidth = 51;
            this.dgvDanhsachsv.RowTemplate.Height = 24;
            this.dgvDanhsachsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhsachsv.Size = new System.Drawing.Size(1344, 352);
            this.dgvDanhsachsv.TabIndex = 1;
            this.dgvDanhsachsv.SelectionChanged += new System.EventHandler(this.dgvDanhsachsv_SelectionChanged);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "";
            this.colCheck.MinimumWidth = 6;
            this.colCheck.Name = "colCheck";
            this.colCheck.Width = 80;
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 91;
            // 
            // HoTenLot
            // 
            this.HoTenLot.DataPropertyName = "HoTenLot";
            this.HoTenLot.HeaderText = "Họ và tên lót";
            this.HoTenLot.MinimumWidth = 6;
            this.HoTenLot.Name = "HoTenLot";
            this.HoTenLot.Width = 156;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 157;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 156;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 157;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Số CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 157;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 156;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ liên lạc";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 157;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinhText";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 90;
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "MonHocText";
            this.MonHoc.HeaderText = "Môn học đăng ký";
            this.MonHoc.MinimumWidth = 6;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Width = 200;
            // 
            // cmsImportOptions
            // 
            this.cmsImportOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsImportOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemdataTxt,
            this.itemdataJson,
            this.itemdataXML,
            this.itemDelete});
            this.cmsImportOptions.Name = "cmsImportOptions";
            this.cmsImportOptions.Size = new System.Drawing.Size(190, 132);
            // 
            // itemdataTxt
            // 
            this.itemdataTxt.Name = "itemdataTxt";
            this.itemdataTxt.Size = new System.Drawing.Size(189, 32);
            this.itemdataTxt.Text = "Tải file txt";
            this.itemdataTxt.Click += new System.EventHandler(this.itemdataTxt_Click);
            // 
            // itemdataJson
            // 
            this.itemdataJson.Name = "itemdataJson";
            this.itemdataJson.Size = new System.Drawing.Size(189, 32);
            this.itemdataJson.Text = "Tải file Json";
            this.itemdataJson.Click += new System.EventHandler(this.itemdataJson_Click);
            // 
            // itemdataXML
            // 
            this.itemdataXML.Name = "itemdataXML";
            this.itemdataXML.Size = new System.Drawing.Size(189, 32);
            this.itemdataXML.Text = "Tải file XML";
            this.itemdataXML.Click += new System.EventHandler(this.itemdataXML_Click);
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(189, 32);
            this.itemDelete.Text = "Xóa sinh viên";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // ctmsMonHoc
            // 
            this.ctmsMonHoc.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmsMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsThem,
            this.ctmsXoa});
            this.ctmsMonHoc.Name = "ctmsMonHoc";
            this.ctmsMonHoc.Size = new System.Drawing.Size(241, 101);
            // 
            // ctmsThem
            // 
            this.ctmsThem.Name = "ctmsThem";
            this.ctmsThem.Size = new System.Drawing.Size(240, 32);
            this.ctmsThem.Text = "Thêm";
            this.ctmsThem.Click += new System.EventHandler(this.ctmsThem_Click);
            // 
            // ctmsXoa
            // 
            this.ctmsXoa.Name = "ctmsXoa";
            this.ctmsXoa.Size = new System.Drawing.Size(240, 32);
            this.ctmsXoa.Text = "Xóa";
            this.ctmsXoa.Click += new System.EventHandler(this.ctmsXoa_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 698);
            this.Controls.Add(this.pnDanhsach);
            this.Controls.Add(this.pnControl);
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachsv)).EndInit();
            this.cmsImportOptions.ResumeLayout(false);
            this.ctmsMonHoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnDanhsach;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktSCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktMSSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktSoDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckedListBox clMonHocDangKy;
        private System.Windows.Forms.ContextMenuStrip cmsImportOptions;
        private System.Windows.Forms.ToolStripMenuItem itemdataTxt;
        private System.Windows.Forms.ToolStripMenuItem itemdataJson;
        private System.Windows.Forms.ToolStripMenuItem itemdataXML;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.DataGridView dgvDanhsachsv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.ContextMenuStrip ctmsMonHoc;
        private System.Windows.Forms.ToolStripMenuItem ctmsThem;
        private System.Windows.Forms.ToolStripMenuItem ctmsXoa;
    }
}

