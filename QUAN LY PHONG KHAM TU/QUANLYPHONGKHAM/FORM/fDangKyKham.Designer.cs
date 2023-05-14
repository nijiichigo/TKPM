
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
            this.lTieuDe = new System.Windows.Forms.Label();
            this.lNgay = new System.Windows.Forms.Label();
            this.tNgay = new System.Windows.Forms.TextBox();
            this.pTieuDe = new System.Windows.Forms.Panel();
            this.pNut = new System.Windows.Forms.Panel();
            this.bDangKyKham = new System.Windows.Forms.Button();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.bDangKyBN = new System.Windows.Forms.Button();
            this.bXoaBN = new System.Windows.Forms.Button();
            this.pThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbMaBenhNhan = new System.Windows.Forms.TextBox();
            this.lMabenhnhan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lHoTen = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.lDienThoai = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lGioiTinh = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNamSinh = new System.Windows.Forms.TextBox();
            this.lNgaySinh = new System.Windows.Forms.Label();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachKham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbMaBN = new System.Windows.Forms.RadioButton();
            this.rbHoTenBN = new System.Windows.Forms.RadioButton();
            this.rbNamSinh = new System.Windows.Forms.RadioButton();
            this.rbDienThoai = new System.Windows.Forms.RadioButton();
            this.lDanhSachKham = new System.Windows.Forms.Label();
            this.bHuyKham = new System.Windows.Forms.Button();
            this.pTieuDe.SuspendLayout();
            this.pNut.SuspendLayout();
            this.pThongTinBenhNhan.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTieuDe
            // 
            this.lTieuDe.AutoSize = true;
            this.lTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lTieuDe.Location = new System.Drawing.Point(41, 7);
            this.lTieuDe.Name = "lTieuDe";
            this.lTieuDe.Size = new System.Drawing.Size(382, 33);
            this.lTieuDe.TabIndex = 0;
            this.lTieuDe.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // lNgay
            // 
            this.lNgay.AutoSize = true;
            this.lNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNgay.Location = new System.Drawing.Point(3, 5);
            this.lNgay.Name = "lNgay";
            this.lNgay.Size = new System.Drawing.Size(81, 29);
            this.lNgay.TabIndex = 1;
            this.lNgay.Text = "Ngày: ";
            // 
            // tNgay
            // 
            this.tNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNgay.Location = new System.Drawing.Point(90, 3);
            this.tNgay.Name = "tNgay";
            this.tNgay.Size = new System.Drawing.Size(212, 31);
            this.tNgay.TabIndex = 2;
            // 
            // pTieuDe
            // 
            this.pTieuDe.Controls.Add(this.lTieuDe);
            this.pTieuDe.Location = new System.Drawing.Point(109, 2);
            this.pTieuDe.Name = "pTieuDe";
            this.pTieuDe.Size = new System.Drawing.Size(443, 43);
            this.pTieuDe.TabIndex = 0;
            // 
            // pNut
            // 
            this.pNut.Controls.Add(this.rbDienThoai);
            this.pNut.Controls.Add(this.rbNamSinh);
            this.pNut.Controls.Add(this.rbHoTenBN);
            this.pNut.Controls.Add(this.rbMaBN);
            this.pNut.Controls.Add(this.bTimKiem);
            this.pNut.Controls.Add(this.bSua);
            this.pNut.Controls.Add(this.bDangKyBN);
            this.pNut.Controls.Add(this.bXoaBN);
            this.pNut.Location = new System.Drawing.Point(12, 224);
            this.pNut.Name = "pNut";
            this.pNut.Size = new System.Drawing.Size(646, 52);
            this.pNut.TabIndex = 8;
            // 
            // bDangKyKham
            // 
            this.bDangKyKham.Location = new System.Drawing.Point(361, 2);
            this.bDangKyKham.Name = "bDangKyKham";
            this.bDangKyKham.Size = new System.Drawing.Size(95, 43);
            this.bDangKyKham.TabIndex = 13;
            this.bDangKyKham.Text = "Đăng ký khám";
            this.bDangKyKham.UseVisualStyleBackColor = true;
            // 
            // bTimKiem
            // 
            this.bTimKiem.Location = new System.Drawing.Point(312, 3);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(95, 43);
            this.bTimKiem.TabIndex = 12;
            this.bTimKiem.Text = "Tìm kiếm";
            this.bTimKiem.UseVisualStyleBackColor = true;
            // 
            // bSua
            // 
            this.bSua.Location = new System.Drawing.Point(211, 3);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(95, 43);
            this.bSua.TabIndex = 11;
            this.bSua.Text = "Điều chỉnh thông tin";
            this.bSua.UseVisualStyleBackColor = true;
            // 
            // bDangKyBN
            // 
            this.bDangKyBN.Location = new System.Drawing.Point(9, 3);
            this.bDangKyBN.Name = "bDangKyBN";
            this.bDangKyBN.Size = new System.Drawing.Size(95, 43);
            this.bDangKyBN.TabIndex = 9;
            this.bDangKyBN.Text = "Đăng ký bệnh nhân mới";
            this.bDangKyBN.UseVisualStyleBackColor = true;
            this.bDangKyBN.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoaBN
            // 
            this.bXoaBN.Location = new System.Drawing.Point(110, 3);
            this.bXoaBN.Name = "bXoaBN";
            this.bXoaBN.Size = new System.Drawing.Size(95, 43);
            this.bXoaBN.TabIndex = 10;
            this.bXoaBN.Text = "Xóa bệnh nhân";
            this.bXoaBN.UseVisualStyleBackColor = true;
            // 
            // pThongTinBenhNhan
            // 
            this.pThongTinBenhNhan.Controls.Add(this.panel5);
            this.pThongTinBenhNhan.Controls.Add(this.panel7);
            this.pThongTinBenhNhan.Controls.Add(this.panel3);
            this.pThongTinBenhNhan.Controls.Add(this.panel4);
            this.pThongTinBenhNhan.Controls.Add(this.panel9);
            this.pThongTinBenhNhan.Controls.Add(this.panel6);
            this.pThongTinBenhNhan.Location = new System.Drawing.Point(21, 51);
            this.pThongTinBenhNhan.Name = "pThongTinBenhNhan";
            this.pThongTinBenhNhan.Size = new System.Drawing.Size(580, 170);
            this.pThongTinBenhNhan.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbDiaChi);
            this.panel5.Controls.Add(this.lDiaChi);
            this.panel5.Location = new System.Drawing.Point(3, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 43);
            this.panel5.TabIndex = 7;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(88, 3);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(443, 35);
            this.tbDiaChi.TabIndex = 1;
            // 
            // lDiaChi
            // 
            this.lDiaChi.AutoSize = true;
            this.lDiaChi.Location = new System.Drawing.Point(3, 6);
            this.lDiaChi.Name = "lDiaChi";
            this.lDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lDiaChi.TabIndex = 0;
            this.lDiaChi.Text = "Địa chỉ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbMaBenhNhan);
            this.panel7.Controls.Add(this.lMabenhnhan);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(547, 24);
            this.panel7.TabIndex = 2;
            // 
            // tbMaBenhNhan
            // 
            this.tbMaBenhNhan.Location = new System.Drawing.Point(88, 3);
            this.tbMaBenhNhan.Name = "tbMaBenhNhan";
            this.tbMaBenhNhan.Size = new System.Drawing.Size(443, 20);
            this.tbMaBenhNhan.TabIndex = 1;
            // 
            // lMabenhnhan
            // 
            this.lMabenhnhan.AutoSize = true;
            this.lMabenhnhan.Location = new System.Drawing.Point(3, 6);
            this.lMabenhnhan.Name = "lMabenhnhan";
            this.lMabenhnhan.Size = new System.Drawing.Size(76, 13);
            this.lMabenhnhan.TabIndex = 0;
            this.lMabenhnhan.Text = "Mã bệnh nhân";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbHoTen);
            this.panel3.Controls.Add(this.lHoTen);
            this.panel3.Location = new System.Drawing.Point(3, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 24);
            this.panel3.TabIndex = 3;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(88, 3);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(443, 20);
            this.tbHoTen.TabIndex = 1;
            // 
            // lHoTen
            // 
            this.lHoTen.AutoSize = true;
            this.lHoTen.Location = new System.Drawing.Point(3, 6);
            this.lHoTen.Name = "lHoTen";
            this.lHoTen.Size = new System.Drawing.Size(39, 13);
            this.lHoTen.TabIndex = 0;
            this.lHoTen.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbDienThoai);
            this.panel4.Controls.Add(this.lDienThoai);
            this.panel4.Location = new System.Drawing.Point(3, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 26);
            this.panel4.TabIndex = 6;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(88, 3);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(443, 20);
            this.tbDienThoai.TabIndex = 1;
            // 
            // lDienThoai
            // 
            this.lDienThoai.AutoSize = true;
            this.lDienThoai.Location = new System.Drawing.Point(3, 6);
            this.lDienThoai.Name = "lDienThoai";
            this.lDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lDienThoai.TabIndex = 0;
            this.lDienThoai.Text = "Điện thoại";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbbGioiTinh);
            this.panel9.Controls.Add(this.lGioiTinh);
            this.panel9.Location = new System.Drawing.Point(281, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 24);
            this.panel9.TabIndex = 5;
            // 
            // lGioiTinh
            // 
            this.lGioiTinh.AutoSize = true;
            this.lGioiTinh.Location = new System.Drawing.Point(3, 7);
            this.lGioiTinh.Name = "lGioiTinh";
            this.lGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lGioiTinh.TabIndex = 0;
            this.lGioiTinh.Text = "Giới tính";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNamSinh);
            this.panel6.Controls.Add(this.lNgaySinh);
            this.panel6.Location = new System.Drawing.Point(3, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 24);
            this.panel6.TabIndex = 4;
            // 
            // tbNamSinh
            // 
            this.tbNamSinh.Location = new System.Drawing.Point(88, 3);
            this.tbNamSinh.Name = "tbNamSinh";
            this.tbNamSinh.Size = new System.Drawing.Size(159, 20);
            this.tbNamSinh.TabIndex = 1;
            // 
            // lNgaySinh
            // 
            this.lNgaySinh.AutoSize = true;
            this.lNgaySinh.Location = new System.Drawing.Point(3, 6);
            this.lNgaySinh.Name = "lNgaySinh";
            this.lNgaySinh.Size = new System.Drawing.Size(51, 13);
            this.lNgaySinh.TabIndex = 0;
            this.lNgaySinh.Text = "Năm sinh";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(12, 282);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(646, 387);
            this.dgvDanhSachBenhNhan.TabIndex = 14;
            // 
            // dgvDanhSachKham
            // 
            this.dgvDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKham.Location = new System.Drawing.Point(12, 100);
            this.dgvDanhSachKham.Name = "dgvDanhSachKham";
            this.dgvDanhSachKham.Size = new System.Drawing.Size(563, 567);
            this.dgvDanhSachKham.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lDanhSachKham);
            this.panel1.Controls.Add(this.dgvDanhSachKham);
            this.panel1.Location = new System.Drawing.Point(664, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 680);
            this.panel1.TabIndex = 15;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(94, 3);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(159, 21);
            this.cbbGioiTinh.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bHuyKham);
            this.panel2.Controls.Add(this.tNgay);
            this.panel2.Controls.Add(this.bDangKyKham);
            this.panel2.Controls.Add(this.lNgay);
            this.panel2.Location = new System.Drawing.Point(15, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 48);
            this.panel2.TabIndex = 17;
            // 
            // rbMaBN
            // 
            this.rbMaBN.AutoSize = true;
            this.rbMaBN.Location = new System.Drawing.Point(414, 4);
            this.rbMaBN.Name = "rbMaBN";
            this.rbMaBN.Size = new System.Drawing.Size(94, 17);
            this.rbMaBN.TabIndex = 13;
            this.rbMaBN.TabStop = true;
            this.rbMaBN.Text = "Mã bệnh nhân";
            this.rbMaBN.UseVisualStyleBackColor = true;
            // 
            // rbHoTenBN
            // 
            this.rbHoTenBN.AutoSize = true;
            this.rbHoTenBN.Location = new System.Drawing.Point(514, 4);
            this.rbHoTenBN.Name = "rbHoTenBN";
            this.rbHoTenBN.Size = new System.Drawing.Size(111, 17);
            this.rbHoTenBN.TabIndex = 14;
            this.rbHoTenBN.TabStop = true;
            this.rbHoTenBN.Text = "Họ tên bệnh nhân";
            this.rbHoTenBN.UseVisualStyleBackColor = true;
            // 
            // rbNamSinh
            // 
            this.rbNamSinh.AutoSize = true;
            this.rbNamSinh.Location = new System.Drawing.Point(414, 27);
            this.rbNamSinh.Name = "rbNamSinh";
            this.rbNamSinh.Size = new System.Drawing.Size(69, 17);
            this.rbNamSinh.TabIndex = 15;
            this.rbNamSinh.TabStop = true;
            this.rbNamSinh.Text = "Năm sinh";
            this.rbNamSinh.UseVisualStyleBackColor = true;
            // 
            // rbDienThoai
            // 
            this.rbDienThoai.AutoSize = true;
            this.rbDienThoai.Location = new System.Drawing.Point(514, 27);
            this.rbDienThoai.Name = "rbDienThoai";
            this.rbDienThoai.Size = new System.Drawing.Size(73, 17);
            this.rbDienThoai.TabIndex = 16;
            this.rbDienThoai.TabStop = true;
            this.rbDienThoai.Text = "Điện thoại";
            this.rbDienThoai.UseVisualStyleBackColor = true;
            // 
            // lDanhSachKham
            // 
            this.lDanhSachKham.AutoSize = true;
            this.lDanhSachKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lDanhSachKham.Location = new System.Drawing.Point(98, 10);
            this.lDanhSachKham.Name = "lDanhSachKham";
            this.lDanhSachKham.Size = new System.Drawing.Size(342, 33);
            this.lDanhSachKham.TabIndex = 3;
            this.lDanhSachKham.Text = "ĐĂNG KÝ KHÁM BỆNH";
            // 
            // bHuyKham
            // 
            this.bHuyKham.Location = new System.Drawing.Point(462, 2);
            this.bHuyKham.Name = "bHuyKham";
            this.bHuyKham.Size = new System.Drawing.Size(95, 43);
            this.bHuyKham.TabIndex = 14;
            this.bHuyKham.Text = "Hủy khám";
            this.bHuyKham.UseVisualStyleBackColor = true;
            // 
            // fDangKyKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDanhSachBenhNhan);
            this.Controls.Add(this.pNut);
            this.Controls.Add(this.pThongTinBenhNhan);
            this.Controls.Add(this.pTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fDangKyKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khám bệnh";
            this.pTieuDe.ResumeLayout(false);
            this.pTieuDe.PerformLayout();
            this.pNut.ResumeLayout(false);
            this.pNut.PerformLayout();
            this.pThongTinBenhNhan.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTieuDe;
        private System.Windows.Forms.Label lNgay;
        private System.Windows.Forms.TextBox tNgay;
        private System.Windows.Forms.Panel pTieuDe;
        private System.Windows.Forms.Panel pNut;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bDangKyBN;
        private System.Windows.Forms.Button bXoaBN;
        private System.Windows.Forms.Panel pThongTinBenhNhan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbMaBenhNhan;
        private System.Windows.Forms.Label lMabenhnhan;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label lHoTen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbDienThoai;
        private System.Windows.Forms.Label lDienThoai;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lGioiTinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNamSinh;
        private System.Windows.Forms.Label lNgaySinh;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.DataGridView dgvDanhSachKham;
        private System.Windows.Forms.Button bDangKyKham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.RadioButton rbDienThoai;
        private System.Windows.Forms.RadioButton rbNamSinh;
        private System.Windows.Forms.RadioButton rbHoTenBN;
        private System.Windows.Forms.RadioButton rbMaBN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bHuyKham;
        private System.Windows.Forms.Label lDanhSachKham;
    }
}