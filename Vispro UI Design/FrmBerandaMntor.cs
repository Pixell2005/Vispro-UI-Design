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
    public partial class FrmBerandaMntor : Form
    {
        public FrmBerandaMntor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmJadwalPemeriksaan frmJadwalPemeriksaan = new FrmJadwalPemeriksaan();
            frmJadwalPemeriksaan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCekpoin frmCekpoin = new FrmCekpoin();
            frmCekpoin.Show();
            this.Hide();
        }
    }
}
