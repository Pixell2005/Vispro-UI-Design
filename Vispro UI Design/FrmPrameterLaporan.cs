using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vispro_UI_Design
{
    public partial class FrmPrameterLaporan : Form
    {
        public FrmPrameterLaporan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBerandaKepas frmBerandaKepas = new FrmBerandaKepas();
            frmBerandaKepas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBerandaKepas frmBerandaKepas = new FrmBerandaKepas();
            frmBerandaKepas.Show();
            this.Hide();
        }
    }
}
