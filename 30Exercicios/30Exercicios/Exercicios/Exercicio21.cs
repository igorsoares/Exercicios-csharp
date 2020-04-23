using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Exercicios
{
    public partial class Exercicio21 : Form
    {
        public Exercicio21()
        {
            InitializeComponent();
        }

        private void btPrecos_Click(object sender, EventArgs e)
        {
            lbShopp.Items.Clear();
            double padrao = 1.99;
            for(int i=1; i<=50; i++)
            {
                lbShopp.Items.Add(i + " produto(s) : R$" + (padrao*i));
            }
        }
    }
}
