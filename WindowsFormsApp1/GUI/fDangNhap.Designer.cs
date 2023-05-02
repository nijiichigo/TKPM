
namespace WindowsFormsApp1
{
    partial class fDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.lTenDangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lMatKhau = new System.Windows.Forms.Label();
            this.bDangNhap = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTaiKhoan);
            this.panel1.Controls.Add(this.lTenDangNhap);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 44);
            this.panel1.TabIndex = 0;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(147, 10);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(319, 22);
            this.txbTaiKhoan.TabIndex = 1;
            // 
            // lTenDangNhap
            // 
            this.lTenDangNhap.AutoSize = true;
            this.lTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenDangNhap.Location = new System.Drawing.Point(3, 10);
            this.lTenDangNhap.Name = "lTenDangNhap";
            this.lTenDangNhap.Size = new System.Drawing.Size(123, 18);
            this.lTenDangNhap.TabIndex = 1;
            this.lTenDangNhap.Text = "Tên đăng nhập:";
            this.lTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMatKhau);
            this.panel2.Controls.Add(this.lMatKhau);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 44);
            this.panel2.TabIndex = 2;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(147, 10);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(319, 22);
            this.txbMatKhau.TabIndex = 1;
            // 
            // lMatKhau
            // 
            this.lMatKhau.AutoSize = true;
            this.lMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatKhau.Location = new System.Drawing.Point(3, 10);
            this.lMatKhau.Name = "lMatKhau";
            this.lMatKhau.Size = new System.Drawing.Size(82, 18);
            this.lMatKhau.TabIndex = 1;
            this.lMatKhau.Text = "Mật khẩu:";
            this.lMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bDangNhap
            // 
            this.bDangNhap.Location = new System.Drawing.Point(213, 123);
            this.bDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDangNhap.Name = "bDangNhap";
            this.bDangNhap.Size = new System.Drawing.Size(115, 34);
            this.bDangNhap.TabIndex = 3;
            this.bDangNhap.Text = "Đăng nhập";
            this.bDangNhap.UseVisualStyleBackColor = true;
            this.bDangNhap.Click += new System.EventHandler(this.bDangNhap_Click);
            // 
            // bThoat
            // 
            this.bThoat.Location = new System.Drawing.Point(333, 123);
            this.bThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(115, 34);
            this.bThoat.TabIndex = 4;
            this.bThoat.Text = "Thoát";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 161);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.bDangNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label lTenDangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lMatKhau;
        private System.Windows.Forms.Button bDangNhap;
        private System.Windows.Forms.Button bThoat;
    }
}

