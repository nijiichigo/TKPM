
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
            this.dgvDanhSachKham = new System.Windows.Forms.DataGridView();
            this.bHuyKham = new System.Windows.Forms.Button();
            this.bReloadDanhSach = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.bDangKyKham = new System.Windows.Forms.Button();
            this.bXoaForm = new System.Windows.Forms.Button();
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
            this.tbNgay = new System.Windows.Forms.TextBox();
            this.lNgay = new System.Windows.Forms.Label();
            this.lMaBNKham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcDanhSachBN = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.tcDangKyKham = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pNut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).BeginInit();
            this.panel5.SuspendLayout();
            this.pThongTinBenhNhan.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcDanhSachBN.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.tcDangKyKham.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNut
            // 
            this.pNut.Controls.Add(this.tbTuKhoa);
            this.pNut.Controls.Add(this.lTuKhoa);
            this.pNut.Controls.Add(this.cbLoai);
            this.pNut.Controls.Add(this.lLoaiTraCuu);
            this.pNut.Location = new System.Drawing.Point(7, 90);
            this.pNut.Name = "pNut";
            this.pNut.Size = new System.Drawing.Size(657, 31);
            this.pNut.TabIndex = 7;
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.tbTuKhoa.Location = new System.Drawing.Point(270, 3);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(370, 20);
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
            // dgvDanhSachKham
            // 
            this.dgvDanhSachKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachKham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKham.Location = new System.Drawing.Point(6, 50);
            this.dgvDanhSachKham.Name = "dgvDanhSachKham";
            this.dgvDanhSachKham.Size = new System.Drawing.Size(544, 587);
            this.dgvDanhSachKham.TabIndex = 20;
            this.dgvDanhSachKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKham_CellClick);
            // 
            // bHuyKham
            // 
            this.bHuyKham.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bHuyKham.Location = new System.Drawing.Point(428, 5);
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
            this.bReloadDanhSach.Location = new System.Drawing.Point(332, 127);
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
            this.panel5.Location = new System.Drawing.Point(7, 61);
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
            this.bDangKyKham.Location = new System.Drawing.Point(322, 4);
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
            this.bXoaForm.Location = new System.Drawing.Point(547, 127);
            this.bXoaForm.Name = "bXoaForm";
            this.bXoaForm.Size = new System.Drawing.Size(100, 25);
            this.bXoaForm.TabIndex = 14;
            this.bXoaForm.Text = "Clear";
            this.bXoaForm.UseVisualStyleBackColor = true;
            this.bXoaForm.Click += new System.EventHandler(this.bXoaForm_Click);
            // 
            // bDangKyBN
            // 
            this.bDangKyBN.AutoSize = true;
            this.bDangKyBN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDangKyBN.Location = new System.Drawing.Point(7, 127);
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
            this.bXoaBN.Location = new System.Drawing.Point(120, 127);
            this.bXoaBN.Name = "bXoaBN";
            this.bXoaBN.Size = new System.Drawing.Size(100, 25);
            this.bXoaBN.TabIndex = 10;
            this.bXoaBN.Text = "Delete";
            this.bXoaBN.UseVisualStyleBackColor = true;
            this.bXoaBN.Click += new System.EventHandler(this.bXoaBN_Click);
            // 
            // pThongTinBenhNhan
            // 
            this.pThongTinBenhNhan.BackColor = System.Drawing.SystemColors.Control;
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
            this.pThongTinBenhNhan.Location = new System.Drawing.Point(5, 3);
            this.pThongTinBenhNhan.Name = "pThongTinBenhNhan";
            this.pThongTinBenhNhan.Size = new System.Drawing.Size(671, 160);
            this.pThongTinBenhNhan.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbMaBenhNhan);
            this.panel7.Controls.Add(this.lMabenhnhan);
            this.panel7.Location = new System.Drawing.Point(7, 3);
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
            this.bDieuChinh.Location = new System.Drawing.Point(226, 127);
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
            this.bTimKiem.Location = new System.Drawing.Point(438, 127);
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
            this.panel3.Location = new System.Drawing.Point(220, 3);
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
            this.panel4.Location = new System.Drawing.Point(381, 32);
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
            this.panel9.Location = new System.Drawing.Point(220, 32);
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
            this.panel6.Location = new System.Drawing.Point(7, 32);
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
            // tbNgay
            // 
            this.tbNgay.Enabled = false;
            this.tbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgay.Location = new System.Drawing.Point(110, 8);
            this.tbNgay.Name = "tbNgay";
            this.tbNgay.ReadOnly = true;
            this.tbNgay.Size = new System.Drawing.Size(180, 20);
            this.tbNgay.TabIndex = 17;
            // 
            // lNgay
            // 
            this.lNgay.AutoSize = true;
            this.lNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNgay.Location = new System.Drawing.Point(66, 9);
            this.lNgay.Name = "lNgay";
            this.lNgay.Size = new System.Drawing.Size(44, 13);
            this.lNgay.TabIndex = 17;
            this.lNgay.Text = "Ngày: ";
            // 
            // lMaBNKham
            // 
            this.lMaBNKham.AutoSize = true;
            this.lMaBNKham.BackColor = System.Drawing.SystemColors.Control;
            this.lMaBNKham.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lMaBNKham.Location = new System.Drawing.Point(3, 24);
            this.lMaBNKham.Name = "lMaBNKham";
            this.lMaBNKham.Size = new System.Drawing.Size(35, 13);
            this.lMaBNKham.TabIndex = 21;
            this.lMaBNKham.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lMaBNKham);
            this.panel2.Controls.Add(this.bHuyKham);
            this.panel2.Controls.Add(this.tbNgay);
            this.panel2.Controls.Add(this.bDangKyKham);
            this.panel2.Controls.Add(this.lNgay);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 41);
            this.panel2.TabIndex = 17;
            // 
            // tcDanhSachBN
            // 
            this.tcDanhSachBN.Controls.Add(this.tabPage1);
            this.tcDanhSachBN.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcDanhSachBN.Location = new System.Drawing.Point(1, 2);
            this.tcDanhSachBN.Name = "tcDanhSachBN";
            this.tcDanhSachBN.SelectedIndex = 0;
            this.tcDanhSachBN.Size = new System.Drawing.Size(694, 673);
            this.tcDanhSachBN.TabIndex = 0;
            this.tcDanhSachBN.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDanhSachBN_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.dgvDanhSachBenhNhan);
            this.tabPage1.Controls.Add(this.pThongTinBenhNhan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(5, 169);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(671, 468);
            this.dgvDanhSachBenhNhan.TabIndex = 15;
            this.dgvDanhSachBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBenhNhan_CellClick);
            // 
            // tcDangKyKham
            // 
            this.tcDangKyKham.Controls.Add(this.tabPage2);
            this.tcDangKyKham.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcDangKyKham.Location = new System.Drawing.Point(694, 2);
            this.tcDangKyKham.Name = "tcDangKyKham";
            this.tcDangKyKham.SelectedIndex = 0;
            this.tcDangKyKham.Size = new System.Drawing.Size(568, 673);
            this.tcDangKyKham.TabIndex = 16;
            this.tcDangKyKham.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDangKyKham_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.dgvDanhSachKham);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 647);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // fDangKyKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tcDangKyKham);
            this.Controls.Add(this.tcDanhSachBN);
            this.Name = "fDangKyKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khám";
            this.pNut.ResumeLayout(false);
            this.pNut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcDanhSachBN.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.tcDangKyKham.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNut;
        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.Label lTuKhoa;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lLoaiTraCuu;
        private System.Windows.Forms.DataGridView dgvDanhSachKham;
        private System.Windows.Forms.Button bHuyKham;
        private System.Windows.Forms.Button bReloadDanhSach;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Button bDangKyKham;
        private System.Windows.Forms.Button bXoaForm;
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
        private System.Windows.Forms.TextBox tbNgay;
        private System.Windows.Forms.Label lNgay;
        private System.Windows.Forms.Label lMaBNKham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcDanhSachBN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.TabControl tcDangKyKham;
        private System.Windows.Forms.TabPage tabPage2;
    }
}