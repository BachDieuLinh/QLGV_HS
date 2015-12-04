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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtingiangday TTGD = new Thongtingiangday();
            TTGD.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
