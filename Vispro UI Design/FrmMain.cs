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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Kepala Asrama" && txtPass.Text == "Kepala Asrama")
            {
                FrmBerandaKepas frmBerandaKepas = new FrmBerandaKepas();
                frmBerandaKepas.Show();
                this.Hide();
            }
            else if (txtEmail.Text == "Monitor" && txtPass.Text == "Monitor")
            {
                FrmBerandaMntor frmBerandaMntor = new FrmBerandaMntor();
                frmBerandaMntor.Show();
                this.Hide();
            }
            else if (txtEmail.Text == "Student" && txtPass.Text == "Student")
            {
                FrmBerandaStudent frmBerandaStudent = new FrmBerandaStudent();
                frmBerandaStudent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda salah menginput Username atau Password");
            }
        }
    }
}
