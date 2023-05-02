
namespace WindowsFormsApp1.GUI
{
    partial class fDanhSachKham
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
            this.SuspendLayout();
            // 
            // lTieuDe
            // 
            this.lTieuDe.AutoSize = true;
            this.lTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTieuDe.Location = new System.Drawing.Point(416, 9);
            this.lTieuDe.Name = "lTieuDe";
            this.lTieuDe.Size = new System.Drawing.Size(342, 39);
            this.lTieuDe.TabIndex = 1;
            this.lTieuDe.Text = "DANH SÁCH KHÁM";
            this.lTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTieuDe.Click += new System.EventHandler(this.lTieuDe_Click);
            // 
            // fDanhSachKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lTieuDe);
            this.Name = "fDanhSachKham";
            this.Text = "fDanhSachKham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTieuDe;
    }
}