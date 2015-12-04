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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void giảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtingiangday TTGD = new Thongtingiangday();
            TTGD.Show();
        }

<<<<<<< HEAD
        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
=======
        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGIAOVIEN GV = new frmGIAOVIEN();
            GV.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHOCSINH HS = new frmHOCSINH();
            HS.Show();
>>>>>>> 770dd0398960888b024e1e1043f419eea81c97d7
        }
    }
}
