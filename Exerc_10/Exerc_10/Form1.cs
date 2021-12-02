﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo s;
            s = new Calculo();
            s.setNum1(int.Parse(txtBase.Text));
            s.setNum2(int.Parse(txtAltura.Text));
            s.calcular();
            radGrande.Checked = s.getGrande();
            radPequeno.Checked = !s.getGrande();
            lblResultado.Text = s.getResultado().ToString();
        }
    }
}
