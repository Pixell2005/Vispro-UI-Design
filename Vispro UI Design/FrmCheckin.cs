﻿using System;
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
    public partial class FrmCheckin : Form
    {
        public FrmCheckin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBerandaStudent frmBerandaStudent = new FrmBerandaStudent();
            frmBerandaStudent.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmBerandaStudent frmBerandaStudent = new FrmBerandaStudent();
            frmBerandaStudent.Show();
            this.Hide();
        }
    }
}
