﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void frm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exibirFrm1_Click(object sender, EventArgs e)
        {
            Frm1 frm = new Frm1(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog(); 
        }

        private void exibirFrm2_Click(object sender, EventArgs e)
        {
            Frm2 frm = new Frm2(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog();
        }

        private void exibirFrm3_Click(object sender, EventArgs e)
        {
            Frm3 frm = new Frm3(); //indico qual form vai ser aberto
            this.Hide(); //fechar o atual
            frm.ShowDialog();
        }
    }
}
