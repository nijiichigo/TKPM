using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYPHONGKHAM.SERVICE;
using QUANLYPHONGKHAM.DAL;

namespace QUANLYPHONGKHAM.FORM
{
    public partial class fDanhMucThuoc : Form
    {
        private IXuLyNhomThuoc _xuLyNhomThuoc = new XuLyNhomThuoc();
        private IXuLyThuoc _xuLyThuoc = new XuLyThuoc();
        private IXuLyChung _xuLyChung = new XuLyChung();
        private string manhom { get { return tbMaNhomThuoc.Text.ToString(); } }
        private string tennhom { get { return tbTenNhomThuoc.Text.ToString(); } }
        private string tukhoanhom { get { return tbTuKhoaNhomThuoc.Text.ToString(); } }
        private string loainhom { get { return cbLoaiTimKiemNhomThuoc.Text.ToString(); } }
        private string mathuoc { get { return tbMaThuoc.Text.ToString(); } }
        private string tenthuoc { get { return tbTenThuoc.Text.ToString(); } }
        private string tennhomthuoc { get { return tbNhomThuoc.Text.ToString(); } }
        private string donvi { get { return cbDonVi.Text.ToString(); } }
        private string dongia { get { return tbDonGia.Text.ToString(); } }
        private string tukhoathuoc { get { return tbTuKhoaThuoc.Text.ToString(); } }
        private string loaithuoc { get { return cbLoaiTimKiemThuoc.Text.ToString(); } }
        private string thongbao = string.Empty;

        public fDanhMucThuoc()
        {
            InitializeComponent();
            TaiDanhSachNhomThuoc();
            TaiDanhSachThuoc();
            HeaderDanhSachNhomThuoc();
            HeaderDanhSachThuoc();
            LietKeNhomThuoc();
            LietKeDonVi();
        }

        private void XoaInput()
        {
            tbMaNhomThuoc.Clear();
            tbTenNhomThuoc.Clear();
            tbTuKhoaNhomThuoc.Clear();
            cbLoaiTimKiemNhomThuoc.SelectedIndex = -1;
            tbMaThuoc.Clear();
            tbTenThuoc.Clear();
            cbDonVi.SelectedIndex = -1;
            tbNhomThuoc.Clear();
            tbDonGia.Clear();
            tbTuKhoaThuoc.Clear();
            cbLoaiTimKiemThuoc.SelectedIndex = -1;
        }

        //--------------NHÓM THUỐC---------------
        private void HeaderDanhSachNhomThuoc()
        {
            dgvNhomThuoc.Columns[0].HeaderText = "Mã nhóm";
            dgvNhomThuoc.Columns[1].HeaderText = "Tên nhóm";
        }

        private void dgvNhomThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhomThuoc.CurrentRow.Index;
            tbMaNhomThuoc.Text = dgvNhomThuoc.Rows[i].Cells[0].Value.ToString();
            tbTenNhomThuoc.Text = dgvNhomThuoc.Rows[i].Cells[1].Value.ToString();
        }

        private void TaiDanhSachNhomThuoc()
        {
            dgvNhomThuoc.DataSource = _xuLyNhomThuoc.TaiDanhSachNhomThuoc();
        }

        private void bThemNhomThuoc_Click(object sender, EventArgs e)
        {
            bool themnhomthuoc = _xuLyNhomThuoc.ThemNhomThuoc(tennhom, ref thongbao);

            if (themnhomthuoc)
            {
                MessageBox.Show(thongbao);
                dgvNhomThuoc.DataSource = _xuLyNhomThuoc.TaiDanhSachNhomThuoc();
                XoaInput();
                LietKeNhomThuoc();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bXoaNhomThuoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa phân loại nhóm thuốc {tennhom} - mã phân loại: {manhom}?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool xoanhomthuoc = _xuLyNhomThuoc.XoaNhomThuoc(manhom, ref thongbao);
                if (xoanhomthuoc)
                {
                    MessageBox.Show(thongbao);
                    dgvNhomThuoc.DataSource = _xuLyNhomThuoc.TaiDanhSachNhomThuoc();
                    XoaInput();
                    LietKeNhomThuoc();
                }
                else
                {
                    MessageBox.Show(thongbao);
                }
            }
        }

        private void bSuaNhomThuoc_Click(object sender, EventArgs e)
        {
            bool dieuchinhnhomthuoc = _xuLyNhomThuoc.DieuChinhNhomThuoc(manhom, tennhom, ref thongbao);

            if (dieuchinhnhomthuoc)
            {
                MessageBox.Show(thongbao);
                dgvNhomThuoc.DataSource = _xuLyNhomThuoc.TaiDanhSachNhomThuoc();
                XoaInput();
                LietKeNhomThuoc();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bTimKiemNhomThuoc_Click(object sender, EventArgs e)
        {
            if ((tukhoanhom == "") || (loainhom == ""))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và loại tra cứu!");
            }
            else
            {
                DataTable timkiem = _xuLyNhomThuoc.TimKiemNhomThuoc(tukhoanhom, loainhom);
                dgvNhomThuoc.DataSource = timkiem;
            }
        }

        private void bReloadNhomThuoc_Click(object sender, EventArgs e)
        {
            TaiDanhSachNhomThuoc();
        }

        private void bXoaFormNhomThuoc_Click(object sender, EventArgs e)
        {
            XoaInput();
        }

        //----------------THUỐC------------------------------
        private void HeaderDanhSachThuoc()
        {
            dgvThuoc.Columns[0].HeaderText = "Mã thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên thuốc";
            dgvThuoc.Columns[2].HeaderText = "Phân loại";
            dgvThuoc.Columns[3].HeaderText = "Đơn vị";
            dgvThuoc.Columns[4].HeaderText = "Đơn giá";
        }

        private void LietKeNhomThuoc()
        {
            DataTable result = _xuLyThuoc.LietKeNhomThuoc();
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            foreach (DataRow row in result.Rows)
            {
                string columnAValue = row["TenNhom"].ToString();
                autoCompleteCollection.Add(columnAValue);
            }
            tbNhomThuoc.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void LietKeDonVi()
        {
            DataTable result = _xuLyThuoc.LietKeDonVi();
            cbDonVi.DisplayMember = "TenDonVi";
            cbDonVi.DataSource = result;
            cbDonVi.SelectedIndex = -1;
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThuoc.CurrentRow.Index;
            tbMaThuoc.Text = dgvThuoc.Rows[i].Cells[0].Value.ToString();
            tbTenThuoc.Text = dgvThuoc.Rows[i].Cells[1].Value.ToString();
            tbNhomThuoc.Text = dgvThuoc.Rows[i].Cells[2].Value.ToString();
            cbDonVi.Text = dgvThuoc.Rows[i].Cells[3].Value.ToString();
            tbDonGia.Text = dgvThuoc.Rows[i].Cells[4].Value.ToString();
        }

        private void TaiDanhSachThuoc()
        {
            dgvThuoc.DataSource = _xuLyThuoc.TaiDanhSachThuoc();
        }

        private void bThemThuoc_Click(object sender, EventArgs e)
        {
            bool themthuoc = _xuLyThuoc.ThemThuoc(tenthuoc, tennhomthuoc, donvi, dongia , ref thongbao);

            if (themthuoc)
            {
                MessageBox.Show(thongbao);
                dgvThuoc.DataSource = _xuLyThuoc.TaiDanhSachThuoc();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bXoaThuoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa thuốc {tenthuoc} - mã: {mathuoc}?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool xoathuoc = _xuLyThuoc.XoaThuoc(mathuoc, ref thongbao);
                if (xoathuoc)
                {
                    MessageBox.Show(thongbao);
                    dgvThuoc.DataSource = _xuLyThuoc.TaiDanhSachThuoc();
                    XoaInput();
                }
                else
                {
                    MessageBox.Show(thongbao);
                }
            }
        }

        private void bSuaThuoc_Click(object sender, EventArgs e)
        {
            bool dieuchinhthuoc = _xuLyThuoc.DieuChinhThuoc(mathuoc, tenthuoc, tennhomthuoc, donvi, dongia, ref thongbao);

            if (dieuchinhthuoc)
            {
                MessageBox.Show(thongbao);
                dgvThuoc.DataSource = _xuLyThuoc.TaiDanhSachThuoc();
                XoaInput();
            }
            else
            {
                MessageBox.Show(thongbao);
            }
        }

        private void bTimKiemThuoc_Click(object sender, EventArgs e)
        {
            if ((tukhoathuoc == "") || (loaithuoc == ""))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và loại tra cứu!");
            }
            else
            {
                DataTable timkiem = _xuLyThuoc.TimKiemThuoc(tukhoathuoc, loaithuoc);
                dgvNhomThuoc.DataSource = timkiem;
            }
        }
    }
}
