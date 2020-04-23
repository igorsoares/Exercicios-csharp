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
    public partial class Exercicio2 : Form
    {
        public double area;
        public const double pi = 3.14f;
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            tbArea.Text = "";
            area = pi * Math.Pow(Convert.ToDouble(tbRaio.Text),2);
            tbArea.Text = area.ToString("N2");
        }
    }
}
