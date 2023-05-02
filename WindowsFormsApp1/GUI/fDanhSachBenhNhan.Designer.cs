
namespace WindowsFormsApp1.GUI
{
    partial class fDanhSachBenhNhan
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
            this.dtgvDSBN = new System.Windows.Forms.DataGridView();
            this.bDangKy = new System.Windows.Forms.Button();
            this.bCapNhat = new System.Windows.Forms.Button();
            this.bLichSu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lHoTenTimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTieuDe
            // 
            this.lTieuDe.AutoSize = true;
            this.lTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieuDe.Location = new System.Drawing.Point(364, 9);
            this.lTieuDe.Name = "lTieuDe";
            this.lTieuDe.Size = new System.Drawing.Size(451, 39);
            this.lTieuDe.TabIndex = 0;
            this.lTieuDe.Text = "DANH SÁCH BỆNH NHÂN";
            this.lTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvDSBN
            // 
            this.dtgvDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBN.Location = new System.Drawing.Point(12, 147);
            this.dtgvDSBN.Name = "dtgvDSBN";
            this.dtgvDSBN.RowHeadersWidth = 51;
            this.dtgvDSBN.RowTemplate.Height = 24;
            this.dtgvDSBN.Size = new System.Drawing.Size(1238, 514);
            this.dtgvDSBN.TabIndex = 1;
            // 
            // bDangKy
            // 
            this.bDangKy.Location = new System.Drawing.Point(3, 3);
            this.bDangKy.Name = "bDangKy";
            this.bDangKy.Size = new System.Drawing.Size(115, 34);
            this.bDangKy.TabIndex = 2;
            this.bDangKy.Text = "Đăng ký";
            this.bDangKy.UseVisualStyleBackColor = true;
            // 
            // bCapNhat
            // 
            this.bCapNhat.Location = new System.Drawing.Point(124, 3);
            this.bCapNhat.Name = "bCapNhat";
            this.bCapNhat.Size = new System.Drawing.Size(115, 34);
            this.bCapNhat.TabIndex = 3;
            this.bCapNhat.Text = "Cập nhật";
            this.bCapNhat.UseVisualStyleBackColor = true;
            // 
            // bLichSu
            // 
            this.bLichSu.Location = new System.Drawing.Point(245, 3);
            this.bLichSu.Name = "bLichSu";
            this.bLichSu.Size = new System.Drawing.Size(115, 34);
            this.bLichSu.TabIndex = 4;
            this.bLichSu.Text = "Lịch sử";
            this.bLichSu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bDangKy);
            this.panel1.Controls.Add(this.bLichSu);
            this.panel1.Controls.Add(this.bCapNhat);
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 42);
            this.panel1.TabIndex = 5;
            // 
            // bTimKiem
            // 
            this.bTimKiem.Location = new System.Drawing.Point(507, 4);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(115, 34);
            this.bTimKiem.TabIndex = 5;
            this.bTimKiem.Text = "Tìm kiếm";
            this.bTimKiem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lHoTenTimKiem);
            this.panel2.Controls.Add(this.txbHoTen);
            this.panel2.Controls.Add(this.bTimKiem);
            this.panel2.Location = new System.Drawing.Point(13, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 41);
            this.panel2.TabIndex = 6;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(133, 10);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(357, 22);
            this.txbHoTen.TabIndex = 6;
            // 
            // lHoTenTimKiem
            // 
            this.lHoTenTimKiem.AutoSize = true;
            this.lHoTenTimKiem.Location = new System.Drawing.Point(3, 13);
            this.lHoTenTimKiem.Name = "lHoTenTimKiem";
            this.lHoTenTimKiem.Size = new System.Drawing.Size(122, 17);
            this.lHoTenTimKiem.TabIndex = 7;
            this.lHoTenTimKiem.Text = "Họ tên bệnh nhân";
            // 
            // fDanhSachBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDSBN);
            this.Controls.Add(this.lTieuDe);
            this.Name = "fDanhSachBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDanhSachBenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieuDe;
        private System.Windows.Forms.DataGridView dtgvDSBN;
        private System.Windows.Forms.Button bDangKy;
        private System.Windows.Forms.Button bCapNhat;
        private System.Windows.Forms.Button bLichSu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lHoTenTimKiem;
        private System.Windows.Forms.TextBox txbHoTen;
    }
}