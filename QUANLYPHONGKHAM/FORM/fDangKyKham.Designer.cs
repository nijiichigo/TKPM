
namespace QUANLYPHONGKHAM.FORM
{
    partial class fDangKyKham
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
            this.pNut = new System.Windows.Forms.Panel();
            this.tbTuKhoa = new System.Windows.Forms.TextBox();
            this.lTuKhoa = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.lLoaiTraCuu = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgvDanhSachKham = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lDanhSachKham = new System.Windows.Forms.Label();
            this.bHuyKham = new System.Windows.Forms.Button();
            this.bReloadDanhSach = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.bDangKyKham = new System.Windows.Forms.Button();
            this.bXoaForm = new System.Windows.Forms.Button();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.lTieuDe = new System.Windows.Forms.Label();
            this.bDangKyBN = new System.Windows.Forms.Button();
            this.bXoaBN = new System.Windows.Forms.Button();
            this.pThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lMabenhnhan = new System.Windows.Forms.Label();
            this.bDieuChinh = new System.Windows.Forms.Button();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lHoTen = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.lDienThoai = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lGioiTinh = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNamSinh = new System.Windows.Forms.TextBox();
            this.lNgaySinh = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pTieuDe = new System.Windows.Forms.Panel();
            this.tbNgay = new System.Windows.Forms.TextBox();
            this.lNgay = new System.Windows.Forms.Label();
            this.lMaBNKham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pNut.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.pThongTinBenhNhan.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pTieuDe.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNut
            // 
            this.pNut.Controls.Add(this.tbTuKhoa);
            this.pNut.Controls.Add(this.lTuKhoa);
            this.pNut.Controls.Add(this.cbLoai);
            this.pNut.Controls.Add(this.lLoaiTraCuu);
            this.pNut.Location = new System.Drawing.Point(20, 92);
            this.pNut.Name = "pNut";
            this.pNut.Size = new System.Drawing.Size(511, 31);
            this.pNut.TabIndex = 7;
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.Location = new System.Drawing.Point(270, 3);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(235, 20);
            this.tbTuKhoa.TabIndex = 8;
            // 
            // lTuKhoa
            // 
            this.lTuKhoa.AutoSize = true;
            this.lTuKhoa.Location = new System.Drawing.Point(216, 7);
            this.lTuKhoa.Name = "lTuKhoa";
            this.lTuKhoa.Size = new System.Drawing.Size(47, 13);
            this.lTuKhoa.TabIndex = 8;
            this.lTuKhoa.Text = "Từ khóa";
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Mã bệnh nhân",
            "Họ tên",
            "Năm sinh",
            "Điện thoại"});
            this.cbLoai.Location = new System.Drawing.Point(88, 4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(111, 21);
            this.cbLoai.TabIndex = 7;
            // 
            // lLoaiTraCuu
            // 
            this.lLoaiTraCuu.AutoSize = true;
            this.lLoaiTraCuu.Location = new System.Drawing.Point(4, 9);
            this.lLoaiTraCuu.Name = "lLoaiTraCuu";
            this.lLoaiTraCuu.Size = new System.Drawing.Size(68, 13);
            this.lLoaiTraCuu.TabIndex = 7;
            this.lLoaiTraCuu.Text = "Tra cứu theo";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.dgvDanhSachKham);
            this.panel12.Location = new System.Drawing.Point(-2, 97);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(550, 578);
            this.panel12.TabIndex = 21;
            // 
            // dgvDanhSachKham
            // 
            this.dgvDanhSachKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachKham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKham.Location = new System.Drawing.Point(5, 3);
            this.dgvDanhSachKham.Name = "dgvDanhSachKham";
            this.dgvDanhSachKham.Size = new System.Drawing.Size(538, 564);
            this.dgvDanhSachKham.TabIndex = 20;
            this.dgvDanhSachKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKham_CellClick);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.lDanhSachKham);
            this.panel11.Location = new System.Drawing.Point(-2, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(552, 41);
            this.panel11.TabIndex = 16;
            // 
            // lDanhSachKham
            // 
            this.lDanhSachKham.AutoSize = true;
            this.lDanhSachKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDanhSachKham.Location = new System.Drawing.Point(142, 5);
            this.lDanhSachKham.Name = "lDanhSachKham";
            this.lDanhSachKham.Size = new System.Drawing.Size(283, 29);
            this.lDanhSachKham.TabIndex = 16;
            this.lDanhSachKham.Text = "ĐĂNG KÝ KHÁM BỆNH";
            this.lDanhSachKham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bHuyKham
            // 
            this.bHuyKham.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bHuyKham.Location = new System.Drawing.Point(440, 7);
            this.bHuyKham.Name = "bHuyKham";
            this.bHuyKham.Size = new System.Drawing.Size(100, 25);
            this.bHuyKham.TabIndex = 19;
            this.bHuyKham.Text = "Remove";
            this.bHuyKham.UseVisualStyleBackColor = true;
            this.bHuyKham.Click += new System.EventHandler(this.bHuyKham_Click);
            // 
            // bReloadDanhSach
            // 
            this.bReloadDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bReloadDanhSach.Location = new System.Drawing.Point(345, 129);
            this.bReloadDanhSach.Name = "bReloadDanhSach";
            this.bReloadDanhSach.Size = new System.Drawing.Size(100, 25);
            this.bReloadDanhSach.TabIndex = 12;
            this.bReloadDanhSach.Text = "Reload";
            this.bReloadDanhSach.UseVisualStyleBackColor = true;
            this.bReloadDanhSach.Click += new System.EventHandler(this.bReloadDanhSach_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbDiaChi);
            this.panel5.Controls.Add(this.lDiaChi);
            this.panel5.Location = new System.Drawing.Point(20, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(661, 28);
            this.panel5.TabIndex = 6;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(88, 3);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(552, 20);
            this.tbDiaChi.TabIndex = 6;
            // 
            // lDiaChi
            // 
            this.lDiaChi.AutoSize = true;
            this.lDiaChi.Location = new System.Drawing.Point(4, 6);
            this.lDiaChi.Name = "lDiaChi";
            this.lDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lDiaChi.TabIndex = 6;
            this.lDiaChi.Text = "Địa chỉ";
            // 
            // bDangKyKham
            // 
            this.bDangKyKham.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDangKyKham.Location = new System.Drawing.Point(334, 6);
            this.bDangKyKham.Name = "bDangKyKham";
            this.bDangKyKham.Size = new System.Drawing.Size(100, 25);
            this.bDangKyKham.TabIndex = 18;
            this.bDangKyKham.Text = "Add";
            this.bDangKyKham.UseVisualStyleBackColor = true;
            this.bDangKyKham.Click += new System.EventHandler(this.bDangKyKham_Click);
            // 
            // bXoaForm
            // 
            this.bXoaForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bXoaForm.Location = new System.Drawing.Point(560, 129);
            this.bXoaForm.Name = "bXoaForm";
            this.bXoaForm.Size = new System.Drawing.Size(100, 25);
            this.bXoaForm.TabIndex = 14;
            this.bXoaForm.Text = "Clear";
            this.bXoaForm.UseVisualStyleBackColor = true;
            this.bXoaForm.Click += new System.EventHandler(this.bXoaForm_Click);
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(683, 446);
            this.dgvDanhSachBenhNhan.TabIndex = 15;
            this.dgvDanhSachBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBenhNhan_CellClick);
            // 
            // lTieuDe
            // 
            this.lTieuDe.AutoSize = true;
            this.lTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieuDe.Location = new System.Drawing.Point(170, 5);
            this.lTieuDe.Name = "lTieuDe";
            this.lTieuDe.Size = new System.Drawing.Size(317, 29);
            this.lTieuDe.TabIndex = 0;
            this.lTieuDe.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // bDangKyBN
            // 
            this.bDangKyBN.AutoSize = true;
            this.bDangKyBN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDangKyBN.Location = new System.Drawing.Point(20, 129);
            this.bDangKyBN.Name = "bDangKyBN";
            this.bDangKyBN.Size = new System.Drawing.Size(100, 25);
            this.bDangKyBN.TabIndex = 9;
            this.bDangKyBN.Text = "Register";
            this.bDangKyBN.UseVisualStyleBackColor = true;
            this.bDangKyBN.Click += new System.EventHandler(this.bDangKyBN_Click);
            // 
            // bXoaBN
            // 
            this.bXoaBN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bXoaBN.Location = new System.Drawing.Point(133, 129);
            this.bXoaBN.Name = "bXoaBN";
            this.bXoaBN.Size = new System.Drawing.Size(100, 25);
            this.bXoaBN.TabIndex = 10;
            this.bXoaBN.Text = "Delete";
            this.bXoaBN.UseVisualStyleBackColor = true;
            this.bXoaBN.Click += new System.EventHandler(this.bXoaBN_Click);
            // 
            // pThongTinBenhNhan
            // 
            this.pThongTinBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pThongTinBenhNhan.Controls.Add(this.bXoaForm);
            this.pThongTinBenhNhan.Controls.Add(this.panel5);
            this.pThongTinBenhNhan.Controls.Add(this.bReloadDanhSach);
            this.pThongTinBenhNhan.Controls.Add(this.pNut);
            this.pThongTinBenhNhan.Controls.Add(this.bDangKyBN);
            this.pThongTinBenhNhan.Controls.Add(this.panel7);
            this.pThongTinBenhNhan.Controls.Add(this.bDieuChinh);
            this.pThongTinBenhNhan.Controls.Add(this.bTimKiem);
            this.pThongTinBenhNhan.Controls.Add(this.bXoaBN);
            this.pThongTinBenhNhan.Controls.Add(this.panel3);
            this.pThongTinBenhNhan.Controls.Add(this.panel4);
            this.pThongTinBenhNhan.Controls.Add(this.panel9);
            this.pThongTinBenhNhan.Controls.Add(this.panel6);
            this.pThongTinBenhNhan.Location = new System.Drawing.Point(-2, 49);
            this.pThongTinBenhNhan.Name = "pThongTinBenhNhan";
            this.pThongTinBenhNhan.Size = new System.Drawing.Size(691, 160);
            this.pThongTinBenhNhan.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbMaBenhNhan);
            this.panel7.Controls.Add(this.lMabenhnhan);
            this.panel7.Location = new System.Drawing.Point(20, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 24);
            this.panel7.TabIndex = 1;
            // 
            // tbMaBenhNhan
            // 
            this.tbMaBenhNhan.Location = new System.Drawing.Point(88, 3);
            this.tbMaBenhNhan.Name = "tbMaBenhNhan";
            this.tbMaBenhNhan.Size = new System.Drawing.Size(110, 20);
            this.tbMaBenhNhan.TabIndex = 1;
            // 
            // lMabenhnhan
            // 
            this.lMabenhnhan.AutoSize = true;
            this.lMabenhnhan.Location = new System.Drawing.Point(3, 6);
            this.lMabenhnhan.Name = "lMabenhnhan";
            this.lMabenhnhan.Size = new System.Drawing.Size(76, 13);
            this.lMabenhnhan.TabIndex = 1;
            this.lMabenhnhan.Text = "Mã bệnh nhân";
            // 
            // bDieuChinh
            // 
            this.bDieuChinh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDieuChinh.Location = new System.Drawing.Point(239, 129);
            this.bDieuChinh.Name = "bDieuChinh";
            this.bDieuChinh.Size = new System.Drawing.Size(100, 25);
            this.bDieuChinh.TabIndex = 11;
            this.bDieuChinh.Text = "Edit";
            this.bDieuChinh.UseVisualStyleBackColor = true;
            this.bDieuChinh.Click += new System.EventHandler(this.bDieuChinh_Click);
            // 
            // bTimKiem
            // 
            this.bTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bTimKiem.Location = new System.Drawing.Point(451, 129);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(100, 25);
            this.bTimKiem.TabIndex = 13;
            this.bTimKiem.Text = "Search";
            this.bTimKiem.UseVisualStyleBackColor = true;
            this.bTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbHoTen);
            this.panel3.Controls.Add(this.lHoTen);
            this.panel3.Location = new System.Drawing.Point(233, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 24);
            this.panel3.TabIndex = 2;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(56, 3);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(371, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // lHoTen
            // 
            this.lHoTen.AutoSize = true;
            this.lHoTen.Location = new System.Drawing.Point(3, 6);
            this.lHoTen.Name = "lHoTen";
            this.lHoTen.Size = new System.Drawing.Size(39, 13);
            this.lHoTen.TabIndex = 2;
            this.lHoTen.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbDienThoai);
            this.panel4.Controls.Add(this.lDienThoai);
            this.panel4.Location = new System.Drawing.Point(394, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 26);
            this.panel4.TabIndex = 5;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(64, 3);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(202, 20);
            this.tbDienThoai.TabIndex = 5;
            // 
            // lDienThoai
            // 
            this.lDienThoai.AutoSize = true;
            this.lDienThoai.Location = new System.Drawing.Point(3, 6);
            this.lDienThoai.Name = "lDienThoai";
            this.lDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lDienThoai.TabIndex = 5;
            this.lDienThoai.Text = "Điện thoại";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbbGioiTinh);
            this.panel9.Controls.Add(this.lGioiTinh);
            this.panel9.Location = new System.Drawing.Point(233, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(155, 24);
            this.panel9.TabIndex = 4;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(56, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(87, 21);
            this.cbbGioiTinh.TabIndex = 4;
            // 
            // lGioiTinh
            // 
            this.lGioiTinh.AutoSize = true;
            this.lGioiTinh.Location = new System.Drawing.Point(3, 7);
            this.lGioiTinh.Name = "lGioiTinh";
            this.lGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lGioiTinh.TabIndex = 4;
            this.lGioiTinh.Text = "Giới tính";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNamSinh);
            this.panel6.Controls.Add(this.lNgaySinh);
            this.panel6.Location = new System.Drawing.Point(20, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 24);
            this.panel6.TabIndex = 3;
            // 
            // tbNamSinh
            // 
            this.tbNamSinh.Location = new System.Drawing.Point(88, 3);
            this.tbNamSinh.Name = "tbNamSinh";
            this.tbNamSinh.Size = new System.Drawing.Size(110, 20);
            this.tbNamSinh.TabIndex = 3;
            // 
            // lNgaySinh
            // 
            this.lNgaySinh.AutoSize = true;
            this.lNgaySinh.Location = new System.Drawing.Point(3, 6);
            this.lNgaySinh.Name = "lNgaySinh";
            this.lNgaySinh.Size = new System.Drawing.Size(51, 13);
            this.lNgaySinh.TabIndex = 3;
            this.lNgaySinh.Text = "Năm sinh";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.dgvDanhSachBenhNhan);
            this.panel10.Location = new System.Drawing.Point(-2, 215);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(691, 455);
            this.panel10.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.pTieuDe);
            this.panel8.Controls.Add(this.pThongTinBenhNhan);
            this.panel8.Location = new System.Drawing.Point(12, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(691, 677);
            this.panel8.TabIndex = 18;
            // 
            // pTieuDe
            // 
            this.pTieuDe.BackColor = System.Drawing.SystemColors.Control;
            this.pTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTieuDe.Controls.Add(this.lTieuDe);
            this.pTieuDe.Location = new System.Drawing.Point(-2, 3);
            this.pTieuDe.Name = "pTieuDe";
            this.pTieuDe.Size = new System.Drawing.Size(691, 41);
            this.pTieuDe.TabIndex = 0;
            // 
            // tbNgay
            // 
            this.tbNgay.Enabled = false;
            this.tbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgay.Location = new System.Drawing.Point(117, 6);
            this.tbNgay.Name = "tbNgay";
            this.tbNgay.ReadOnly = true;
            this.tbNgay.Size = new System.Drawing.Size(164, 26);
            this.tbNgay.TabIndex = 17;
            // 
            // lNgay
            // 
            this.lNgay.AutoSize = true;
            this.lNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNgay.Location = new System.Drawing.Point(43, 8);
            this.lNgay.Name = "lNgay";
            this.lNgay.Size = new System.Drawing.Size(59, 20);
            this.lNgay.TabIndex = 17;
            this.lNgay.Text = "Ngày: ";
            // 
            // lMaBNKham
            // 
            this.lMaBNKham.AutoSize = true;
            this.lMaBNKham.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lMaBNKham.Location = new System.Drawing.Point(2, 15);
            this.lMaBNKham.Name = "lMaBNKham";
            this.lMaBNKham.Size = new System.Drawing.Size(35, 13);
            this.lMaBNKham.TabIndex = 17;
            this.lMaBNKham.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lMaBNKham);
            this.panel2.Controls.Add(this.bHuyKham);
            this.panel2.Controls.Add(this.tbNgay);
            this.panel2.Controls.Add(this.bDangKyKham);
            this.panel2.Controls.Add(this.lNgay);
            this.panel2.Location = new System.Drawing.Point(-2, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 41);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(702, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 677);
            this.panel1.TabIndex = 17;
            // 
            // fDangKyKham_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "fDangKyKham_new";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangKyKham";
            this.pNut.ResumeLayout(false);
            this.pNut.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.pThongTinBenhNhan.ResumeLayout(false);
            this.pThongTinBenhNhan.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pTieuDe.ResumeLayout(false);
            this.pTieuDe.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNut;
        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.Label lTuKhoa;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lLoaiTraCuu;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dgvDanhSachKham;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lDanhSachKham;
        private System.Windows.Forms.Button bHuyKham;
        private System.Windows.Forms.Button bReloadDanhSach;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Button bDangKyKham;
        private System.Windows.Forms.Button bXoaForm;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.Label lTieuDe;
        private System.Windows.Forms.Button bDangKyBN;
        private System.Windows.Forms.Button bXoaBN;
        private System.Windows.Forms.Panel pThongTinBenhNhan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbMaBenhNhan;
        private System.Windows.Forms.Label lMabenhnhan;
        private System.Windows.Forms.Button bDieuChinh;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label lHoTen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbDienThoai;
        private System.Windows.Forms.Label lDienThoai;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label lGioiTinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNamSinh;
        private System.Windows.Forms.Label lNgaySinh;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pTieuDe;
        private System.Windows.Forms.TextBox tbNgay;
        private System.Windows.Forms.Label lNgay;
        private System.Windows.Forms.Label lMaBNKham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}