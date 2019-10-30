using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            loadTable();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAcountProfile f = new fAcountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {

                
            Button btn = new Button();
            int i = 0;
            while (i <= 10)
                {
                    btn.Text = "bàn" + i;
                    btn.AutoSize = true;
                flowLayoutPanel1.Controls.Add(btn);
            }

                
            
        }
    }
}
