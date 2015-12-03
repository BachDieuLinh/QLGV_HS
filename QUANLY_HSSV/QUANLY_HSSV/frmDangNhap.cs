using System;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        DangNhap dn = new DangNhap();

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (dn.Login(txtName.Text, txtPass.Text) == true)
            {
                MessageBox.Show("Đăng nhập thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main frm = new Main();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Đăng nhập thất bại, sai mật khẩu hoặc sai tên người dùng !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
