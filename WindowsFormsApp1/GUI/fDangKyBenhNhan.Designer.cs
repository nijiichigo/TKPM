
namespace WindowsFormsApp1.GUI
{
    partial class fDangKyBenhNhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lHoTen = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbNamSinh = new System.Windows.Forms.TextBox();
            this.lNamSinh = new System.Windows.Forms.Label();
            this.chbGioiTinh = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.bDangKy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTieuDe
            // 
            this.lTieuDe.AutoSize = true;
            this.lTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lTieuDe.Location = new System.Drawing.Point(111, 9);
            this.lTieuDe.Name = "lTieuDe";
            this.lTieuDe.Size = new System.Drawing.Size(399, 39);
            this.lTieuDe.TabIndex = 0;
            this.lTieuDe.Text = "ĐĂNG KÝ BỆNH NHÂN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbHoTen);
            this.panel1.Controls.Add(this.lHoTen);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 28);
            this.panel1.TabIndex = 1;
            // 
            // lHoTen
            // 
            this.lHoTen.AutoSize = true;
            this.lHoTen.Location = new System.Drawing.Point(3, 3);
            this.lHoTen.Name = "lHoTen";
            this.lHoTen.Size = new System.Drawing.Size(50, 17);
            this.lHoTen.TabIndex = 0;
            this.lHoTen.Text = "Họ tên";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(76, 0);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(473, 22);
            this.txbHoTen.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbNamSinh);
            this.panel2.Controls.Add(this.lNamSinh);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 28);
            this.panel2.TabIndex = 2;
            // 
            // txbNamSinh
            // 
            this.txbNamSinh.Location = new System.Drawing.Point(76, 0);
            this.txbNamSinh.Name = "txbNamSinh";
            this.txbNamSinh.Size = new System.Drawing.Size(137, 22);
            this.txbNamSinh.TabIndex = 2;
            // 
            // lNamSinh
            // 
            this.lNamSinh.AutoSize = true;
            this.lNamSinh.Location = new System.Drawing.Point(3, 3);
            this.lNamSinh.Name = "lNamSinh";
            this.lNamSinh.Size = new System.Drawing.Size(67, 17);
            this.lNamSinh.TabIndex = 0;
            this.lNamSinh.Text = "Năm sinh";
            // 
            // chbGioiTinh
            // 
            this.chbGioiTinh.AutoSize = true;
            this.chbGioiTinh.Location = new System.Drawing.Point(250, 91);
            this.chbGioiTinh.Name = "chbGioiTinh";
            this.chbGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.chbGioiTinh.TabIndex = 3;
            this.chbGioiTinh.Text = "Nam";
            this.chbGioiTinh.UseVisualStyleBackColor = true;
            this.chbGioiTinh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbDiaChi);
            this.panel3.Controls.Add(this.lDiaChi);
            this.panel3.Location = new System.Drawing.Point(12, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 28);
            this.panel3.TabIndex = 3;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(76, 0);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(473, 22);
            this.txbDiaChi.TabIndex = 4;
            // 
            // lDiaChi
            // 
            this.lDiaChi.AutoSize = true;
            this.lDiaChi.Location = new System.Drawing.Point(3, 3);
            this.lDiaChi.Name = "lDiaChi";
            this.lDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lDiaChi.TabIndex = 0;
            this.lDiaChi.Text = "Địa chỉ";
            // 
            // bDangKy
            // 
            this.bDangKy.Location = new System.Drawing.Point(233, 150);
            this.bDangKy.Name = "bDangKy";
            this.bDangKy.Size = new System.Drawing.Size(115, 34);
            this.bDangKy.TabIndex = 5;
            this.bDangKy.Text = "Đăng ký";
            this.bDangKy.UseVisualStyleBackColor = true;
            // 
            // fDangKyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 195);
            this.Controls.Add(this.bDangKy);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chbGioiTinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTieuDe);
            this.Name = "fDangKyBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký bệnh nhân";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lHoTen;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbNamSinh;
        private System.Windows.Forms.Label lNamSinh;
        private System.Windows.Forms.CheckBox chbGioiTinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Button bDangKy;
    }
}