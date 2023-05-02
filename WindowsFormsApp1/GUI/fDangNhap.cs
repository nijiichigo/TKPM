using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();

            //LoadAccountList();
        }
        private void bDangNhap_Click(object sender, EventArgs e)
        {
            GUI.fQuanLy f = new GUI.fQuanLy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'database1DataSet1.TaiKhoan' table. You can move, or remove it, as needed.
        //    this.taiKhoanTableAdapter.Fill(this.database1DataSet1.TaiKhoan);
        //    // TODO: This line of code loads data into the 'database1DataSet.BenhNhan' table. You can move, or remove it, as needed.
        //    this.benhNhanTableAdapter.Fill(this.database1DataSet.BenhNhan);

        //}

        //void LoadAccountList()
        //{
        //    string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionStr);

        //    string query = "SELECT Username,Admin FROM dbo.TaiKhoan";

        //    connection.Open();

        //    SqlCommand cmd = new SqlCommand(query, connection);

        //    DataTable data = new DataTable();

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //    adapter.Fill(data);

        //    connection.Close();

        //dtgvAccount.DataSource = data;
        //}

        //private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
