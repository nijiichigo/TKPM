using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGKHAM.FORM
{
    public partial class fManHinhChinh : Form
    {
        public fManHinhChinh()
        {
            InitializeComponent();
        }

        private void đăngKýKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangKyKham f = new fDangKyKham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
