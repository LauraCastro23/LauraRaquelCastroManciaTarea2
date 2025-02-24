﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaestudiantes.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias Mt = new frmMaterias();
            Mt.MdiParent = this;
            Mt.Show();
        }

        private void aLUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos Student = new frmAlumnos();
            Student.MdiParent = this;
            Student.Show();
        }

        private void nOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas Note = new frmNotas();
            Note.MdiParent = this;
            Note.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
