﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsbd_lab_3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
           DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,БИС,Муртазин Ринат Ришатович,740-1,2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBooks.fw.ShowForm();
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReaders.fw.ShowForm();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormWorkers.fw.ShowForm();
        }

        private void читательскийБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReadersCard.fw.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fw.ShowForm();
        }

        private void картотекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCard.fw.ShowForm();
        }
    }
    
}
