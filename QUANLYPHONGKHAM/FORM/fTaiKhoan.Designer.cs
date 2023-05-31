
namespace QUANLYPHONGKHAM.FORM
{
    partial class fTaiKhoan
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tpThongTinTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lXacNhanMatKhau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.lMatKhau = new System.Windows.Forms.Label();
            this.bXoaForm = new System.Windows.Forms.Button();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.bReload = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.bDangKy = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lLoaiTimKiem = new System.Windows.Forms.Label();
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.pNut = new System.Windows.Forms.Panel();
            this.tbTuKhoa = new System.Windows.Forms.TextBox();
            this.lTuKhoa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenHienThi = new System.Windows.Forms.TextBox();
            this.lTenHienThi = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lTenTaiKhoan = new System.Windows.Forms.Label();
            this.tcTaiKhoan = new System.Windows.Forms.TabControl();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tpThongTinTaiKhoan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pNut.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tcTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.dgvTaiKhoan);
            this.panel6.Location = new System.Drawing.Point(3, 190);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 486);
            this.panel6.TabIndex = 13;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(654, 474);
            this.dgvTaiKhoan.TabIndex = 13;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // tpThongTinTaiKhoan
            // 
            this.tpThongTinTaiKhoan.Controls.Add(this.panel2);
            this.tpThongTinTaiKhoan.Controls.Add(this.panel3);
            this.tpThongTinTaiKhoan.Controls.Add(this.bXoaForm);
            this.tpThongTinTaiKhoan.Controls.Add(this.bTimKiem);
            this.tpThongTinTaiKhoan.Controls.Add(this.bReload);
            this.tpThongTinTaiKhoan.Controls.Add(this.bSua);
            this.tpThongTinTaiKhoan.Controls.Add(this.bDangKy);
            this.tpThongTinTaiKhoan.Controls.Add(this.bXoa);
            this.tpThongTinTaiKhoan.Controls.Add(this.panel5);
            this.tpThongTinTaiKhoan.Controls.Add(this.pNut);
            this.tpThongTinTaiKhoan.Controls.Add(this.panel4);
            this.tpThongTinTaiKhoan.Controls.Add(this.panel1);
            this.tpThongTinTaiKhoan.Controls.Add(this.panel7);
            this.tpThongTinTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinTaiKhoan.Name = "tpThongTinTaiKhoan";
            this.tpThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinTaiKhoan.Size = new System.Drawing.Size(661, 159);
            this.tpThongTinTaiKhoan.TabIndex = 0;
            this.tpThongTinTaiKhoan.Text = "THÔNG TIN TÀI KHOẢN";
            this.tpThongTinTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbXacNhanMatKhau);
            this.panel2.Controls.Add(this.lXacNhanMatKhau);
            this.panel2.Location = new System.Drawing.Point(331, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 24);
            this.panel2.TabIndex = 4;
            // 
            // tbXacNhanMatKhau
            // 
            this.tbXacNhanMatKhau.Location = new System.Drawing.Point(106, 3);
            this.tbXacNhanMatKhau.Name = "tbXacNhanMatKhau";
            this.tbXacNhanMatKhau.Size = new System.Drawing.Size(209, 20);
            this.tbXacNhanMatKhau.TabIndex = 4;
            // 
            // lXacNhanMatKhau
            // 
            this.lXacNhanMatKhau.AutoSize = true;
            this.lXacNhanMatKhau.Location = new System.Drawing.Point(3, 6);
            this.lXacNhanMatKhau.Name = "lXacNhanMatKhau";
            this.lXacNhanMatKhau.Size = new System.Drawing.Size(100, 13);
            this.lXacNhanMatKhau.TabIndex = 4;
            this.lXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbMatKhau);
            this.panel3.Controls.Add(this.lMatKhau);
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 24);
            this.panel3.TabIndex = 3;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(106, 3);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(209, 20);
            this.tbMatKhau.TabIndex = 3;
            // 
            // lMatKhau
            // 
            this.lMatKhau.AutoSize = true;
            this.lMatKhau.Location = new System.Drawing.Point(3, 6);
            this.lMatKhau.Name = "lMatKhau";
            this.lMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lMatKhau.TabIndex = 3;
            this.lMatKhau.Text = "Mật khẩu";
            // 
            // bXoaForm
            // 
            this.bXoaForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bXoaForm.Location = new System.Drawing.Point(546, 127);
            this.bXoaForm.Name = "bXoaForm";
            this.bXoaForm.Size = new System.Drawing.Size(100, 25);
            this.bXoaForm.TabIndex = 12;
            this.bXoaForm.Text = "Clear";
            this.bXoaForm.UseVisualStyleBackColor = true;
            this.bXoaForm.Click += new System.EventHandler(this.bXoaForm_Click);
            // 
            // bTimKiem
            // 
            this.bTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bTimKiem.Location = new System.Drawing.Point(440, 127);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(100, 25);
            this.bTimKiem.TabIndex = 11;
            this.bTimKiem.Text = "Search";
            this.bTimKiem.UseVisualStyleBackColor = true;
            this.bTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // bReload
            // 
            this.bReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bReload.Location = new System.Drawing.Point(334, 127);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(100, 25);
            this.bReload.TabIndex = 10;
            this.bReload.Text = "Reload";
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // bSua
            // 
            this.bSua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSua.Location = new System.Drawing.Point(228, 127);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(100, 25);
            this.bSua.TabIndex = 9;
            this.bSua.Text = "Edit";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // bDangKy
            // 
            this.bDangKy.AutoSize = true;
            this.bDangKy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDangKy.Location = new System.Drawing.Point(15, 127);
            this.bDangKy.Name = "bDangKy";
            this.bDangKy.Size = new System.Drawing.Size(100, 25);
            this.bDangKy.TabIndex = 7;
            this.bDangKy.Text = "Register";
            this.bDangKy.UseVisualStyleBackColor = true;
            this.bDangKy.Click += new System.EventHandler(this.bDangKy_Click);
            // 
            // bXoa
            // 
            this.bXoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bXoa.Location = new System.Drawing.Point(121, 127);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(100, 25);
            this.bXoa.TabIndex = 8;
            this.bXoa.Text = "Delete";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lLoaiTimKiem);
            this.panel5.Controls.Add(this.cbLoaiTimKiem);
            this.panel5.Location = new System.Drawing.Point(3, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 27);
            this.panel5.TabIndex = 6;
            // 
            // lLoaiTimKiem
            // 
            this.lLoaiTimKiem.AutoSize = true;
            this.lLoaiTimKiem.Location = new System.Drawing.Point(2, 6);
            this.lLoaiTimKiem.Name = "lLoaiTimKiem";
            this.lLoaiTimKiem.Size = new System.Drawing.Size(68, 13);
            this.lLoaiTimKiem.TabIndex = 6;
            this.lLoaiTimKiem.Text = "Tra cứu theo";
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Items.AddRange(new object[] {
            "Tên tài khoản",
            "Tên hiển thị",
            "Loại tài khoản"});
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(106, 3);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(209, 21);
            this.cbLoaiTimKiem.TabIndex = 6;
            // 
            // pNut
            // 
            this.pNut.Controls.Add(this.tbTuKhoa);
            this.pNut.Controls.Add(this.lTuKhoa);
            this.pNut.Location = new System.Drawing.Point(331, 94);
            this.pNut.Name = "pNut";
            this.pNut.Size = new System.Drawing.Size(327, 27);
            this.pNut.TabIndex = 7;
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.Location = new System.Drawing.Point(106, 3);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(209, 20);
            this.tbTuKhoa.TabIndex = 7;
            // 
            // lTuKhoa
            // 
            this.lTuKhoa.AutoSize = true;
            this.lTuKhoa.Location = new System.Drawing.Point(3, 6);
            this.lTuKhoa.Name = "lTuKhoa";
            this.lTuKhoa.Size = new System.Drawing.Size(47, 13);
            this.lTuKhoa.TabIndex = 7;
            this.lTuKhoa.Text = "Từ khóa";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbLoaiTaiKhoan);
            this.panel4.Controls.Add(this.lLoaiTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(3, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 24);
            this.panel4.TabIndex = 5;
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "Quản lý",
            "Bác sĩ",
            "Nhân viên",
            "Thu ngân"});
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(106, 0);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(209, 21);
            this.cbLoaiTaiKhoan.TabIndex = 5;
            // 
            // lLoaiTaiKhoan
            // 
            this.lLoaiTaiKhoan.AutoSize = true;
            this.lLoaiTaiKhoan.Location = new System.Drawing.Point(3, 6);
            this.lLoaiTaiKhoan.Name = "lLoaiTaiKhoan";
            this.lLoaiTaiKhoan.Size = new System.Drawing.Size(74, 13);
            this.lLoaiTaiKhoan.TabIndex = 5;
            this.lLoaiTaiKhoan.Text = "Loại tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTenHienThi);
            this.panel1.Controls.Add(this.lTenHienThi);
            this.panel1.Location = new System.Drawing.Point(331, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 24);
            this.panel1.TabIndex = 2;
            // 
            // tbTenHienThi
            // 
            this.tbTenHienThi.Location = new System.Drawing.Point(106, 3);
            this.tbTenHienThi.Name = "tbTenHienThi";
            this.tbTenHienThi.Size = new System.Drawing.Size(209, 20);
            this.tbTenHienThi.TabIndex = 2;
            // 
            // lTenHienThi
            // 
            this.lTenHienThi.AutoSize = true;
            this.lTenHienThi.Location = new System.Drawing.Point(3, 6);
            this.lTenHienThi.Name = "lTenHienThi";
            this.lTenHienThi.Size = new System.Drawing.Size(63, 13);
            this.lTenHienThi.TabIndex = 2;
            this.lTenHienThi.Text = "Tên hiển thị";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbTenTaiKhoan);
            this.panel7.Controls.Add(this.lTenTaiKhoan);
            this.panel7.Location = new System.Drawing.Point(3, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 24);
            this.panel7.TabIndex = 1;
            // 
            // tbTenTaiKhoan
            // 
            this.tbTenTaiKhoan.Location = new System.Drawing.Point(106, 3);
            this.tbTenTaiKhoan.Name = "tbTenTaiKhoan";
            this.tbTenTaiKhoan.Size = new System.Drawing.Size(209, 20);
            this.tbTenTaiKhoan.TabIndex = 1;
            // 
            // lTenTaiKhoan
            // 
            this.lTenTaiKhoan.AutoSize = true;
            this.lTenTaiKhoan.Location = new System.Drawing.Point(3, 6);
            this.lTenTaiKhoan.Name = "lTenTaiKhoan";
            this.lTenTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lTenTaiKhoan.TabIndex = 1;
            this.lTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // tcTaiKhoan
            // 
            this.tcTaiKhoan.Controls.Add(this.tpThongTinTaiKhoan);
            this.tcTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.tcTaiKhoan.Name = "tcTaiKhoan";
            this.tcTaiKhoan.SelectedIndex = 0;
            this.tcTaiKhoan.Size = new System.Drawing.Size(669, 185);
            this.tcTaiKhoan.TabIndex = 0;
            // 
            // fTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 681);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tcTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tpThongTinTaiKhoan.ResumeLayout(false);
            this.tpThongTinTaiKhoan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pNut.ResumeLayout(false);
            this.pNut.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tcTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TabPage tpThongTinTaiKhoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lLoaiTimKiem;
        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.Panel pNut;
        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.Label lTuKhoa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.Label lLoaiTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTenHienThi;
        private System.Windows.Forms.Label lTenHienThi;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbTenTaiKhoan;
        private System.Windows.Forms.Label lTenTaiKhoan;
        private System.Windows.Forms.TabControl tcTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbXacNhanMatKhau;
        private System.Windows.Forms.Label lXacNhanMatKhau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label lMatKhau;
        private System.Windows.Forms.Button bXoaForm;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.Button bReload;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bDangKy;
        private System.Windows.Forms.Button bXoa;
    }
}