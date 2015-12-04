using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUANLY_HSSV
{
    public partial class Thongtingiangday : Form
    {
        public Thongtingiangday()
        {
            InitializeComponent();
        }
        ttgiangday TTGD=new ttgiangday();
        int chon=0;


        void KhoaDieuKhien()
        {
            txtMalop.Enabled = txtTenlop.Enabled = txtMaHS.Enabled = txtTenHS.Enabled = dtp_NS.Enabled = cb_GT.Enabled = txtDiaChi.Enabled = txtMaGV.Enabled = txtTenGV.Enabled = false;
            btnThem.Enabled =  btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtMalop.Enabled = txtTenlop.Enabled = txtMaHS.Enabled = txtTenHS.Enabled = dtp_NS.Enabled = cb_GT.Enabled = txtDiaChi.Enabled = txtMaGV.Enabled = txtTenGV.Enabled = true;
            btnThem.Enabled =  btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtMaHS.Text = txtTenHS.Text = txtDiaChi.Text = txtMaGV.Text = txtTenGV.Text = "";
            cb_GT.Text = "";
            dtp_NS.Text = "";
        }
        private void Thongtingiangday_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = TTGD.HienThiGiaoVien();
            dgvGV.DataSource = dt1;
            dt2 = TTGD.HienThiLop();
            dgvLOP.DataSource = dt2;
            KhoaDieuKhien();
        }

        private void dgvTTGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnXoa.Enabled = true;
            try
            {
                txtMalop.Text = dgvTTGD.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenlop.Text = dgvTTGD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaGV.Text = dgvTTGD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenGV.Text = dgvTTGD.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            btnXoa.Enabled = true;
            try
            {
                txtMaHS.Text = dgvHS.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenHS.Text = dgvHS.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_NS.Value = DateTime.Parse(dgvHS.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch
            {
                return;
            }
        }

        private void dgvLOP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            btnXoa.Enabled = true;
            try
            {
                txtMalop.Text = dgvLOP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenlop.Text = dgvLOP.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            btnXoa.Enabled = true;
            try
            {
                txtMaGV.Text = dgvGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenGV.Text = dgvGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaHS.Enabled = false;
            txtMalop.Enabled = false;
            txtTenlop.Enabled = false;
            txtTenHS.Enabled = false;
            dtp_NS.Enabled = false;
            cb_GT.Enabled = false;
            txtDiaChi.Enabled = false;
            SetNull();
            
            chon = 1;
        }
        private void btnThemHS_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMalop.Enabled = false;
            txtTenlop.Enabled = false;
            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            txtMaHS.Enabled = false;
            SetNull();
            chon = 2;
        }
         

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMalop.Text=="" || txtMaGV.Text == "")
                MessageBox.Show("Chọn giáo viên theo lớp!");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa giáo viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    TTGD.XoaGV(txtMalop.Text, txtMaGV.Text);
                    MessageBox.Show("Xóa thành công!");
                    DataTable dt = new DataTable();
                    dt = TTGD.HienThiTTGD(txtMalop.Text);
                    dgvTTGD.DataSource = dt;
                    SetNull();
                }
            if (txtMalop.Text == "" || txtMaHS.Text == "")
                MessageBox.Show("Chọn học sinh theo lớp!");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    TTGD.XoaHS(txtMalop.Text, txtMaHS.Text);
                    MessageBox.Show("Xóa thành công!");
                    DataTable dt = new DataTable();
                    dt = TTGD.HienThiHocSinh(txtMalop.Text);
                    dgvHS.DataSource = dt;
                    SetNull();
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtMalop.Text == "" ||  txtMaGV.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm giáo viên viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        TTGD.ThemGV(txtMalop.Text, txtMaGV.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        DataTable dt = new DataTable();
                        dt = TTGD.HienThiTTGD(txtMalop.Text);
                        dgvTTGD.DataSource = dt;
                    }
                
            }
            else if (chon == 2)
            {
                if (txtTenHS.Text == "" || dtp_NS.Text == "" || cb_GT.Text == "" || txtDiaChi.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        TTGD.ThemHS(txtTenHS.Text, DateTime.Parse(dtp_NS.Text), cb_GT.Text, txtDiaChi.Text, txtMalop.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        DataTable dt = new DataTable();
                        dt = TTGD.HienThiHocSinh(txtMalop.Text);
                        dgvHS.DataSource = dt;
                    }
            }
             
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Thongtingiangday_Load(sender, e);
            SetNull();
            chon = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ứng dụng này??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TTGD.HienThiTTGD(txtMalop.Text);
            dgvTTGD.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 = TTGD.HienThiHocSinh(txtMalop.Text);
            dgvHS.DataSource = dt1;
        }

        

    }
}
