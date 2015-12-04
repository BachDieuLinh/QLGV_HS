﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_HSSV
{
    public partial class frmHOCSINH : Form
    {
        public frmHOCSINH()
        {
            InitializeComponent();
        }
        Hocsinh hs = new Hocsinh();
        int chon;
        TimKiem tk = new TimKiem();

        private void frmHOCSINH_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvHocSinh.DataSource = hs.Show_HS();

            cbLop.DataSource = hs.LayThongTinLop();
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.SelectedValue = "MALOP";
            chon = 0;
        }
       
        public void KhoiTao()
        {
            txtHoTen_HS.Enabled = cbGT_HS.Enabled = cbLop.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = false;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = true;
            btnLuu_HS.Enabled = false;
        }

        public void Mo()
        {
            txtHoTen_HS.Enabled =  cbGT_HS.Enabled = cbLop.Enabled = dtpNgaySinh_HS.Enabled = txtDiaChi.Enabled = true;
            btnThem_HS.Enabled = btnSua_HS.Enabled = btnXoa_HS.Enabled = false;
            btnLuu_HS.Enabled = true;
        }

        public void SetNull()
        {
            txtMa_HS.Text = txtHoTen_HS.Text = txtDiaChi.Text =  cbGT_HS.Text = cbLop.Text = cbTK_HS.Text = txtTK_HS.Text = "";
            dtpNgaySinh_HS.Text = DateTime.Now.ToShortDateString();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgaySinh_HS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            { }
        }

        private void btnSua_HS_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            txtMa_HS.Enabled = false;
            chon = 1;
        }

        private void btnXoa_HS_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hs.Xoa_HS(txtMa_HS.Text);
                MessageBox.Show("Xóa thành công!");
                frmHOCSINH_Load(sender, e);
                SetNull();
            }
        }

        private void btnLuu_HS_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtHoTen_HS.Text == "" || cbGT_HS.Text == "" || txtDiaChi.Text == "" ||  cbLop.Text == "" || dtpNgaySinh_HS.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hs.Sua_HS(txtMa_HS.Text, txtHoTen_HS.Text, DateTime.Parse(dtpNgaySinh_HS.Text), cbGT_HS.Text, txtDiaChi.Text, cbLop.SelectedValue.ToString());
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        frmHOCSINH_Load(sender, e);
                    }
                }
            }
            else if (chon == 2)
            {
                if (txtHoTen_HS.Text == "" || cbGT_HS.Text == "" || txtDiaChi.Text == "" ||  cbLop.Text == "" || dtpNgaySinh_HS.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm học sinh này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hs.ThemHS(txtHoTen_HS.Text, DateTime.Parse(dtpNgaySinh_HS.Text), cbGT_HS.Text, txtDiaChi.Text, cbLop.SelectedValue.ToString());
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                       frmHOCSINH_Load(sender, e);
                    }
                }
            }

        }

         

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHOCSINH_Load(sender, e);
            SetNull();
        }

        private void btnThem_HS_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 2;
        }

        private void txtTK_HS_TextChanged(object sender, EventArgs e)
        {
            if (cbTK_HS.Text == "Mã")
                dgvHocSinh.DataSource = tk.TK_Ma_HocSinh(txtTK_HS.Text);
            else
                dgvHocSinh.DataSource = tk.TKTenHocSinh(txtTK_HS.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
