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
    public partial class Exercicio6 : Form
    {
        private double altura;
        private char sexo;
        private double formulaM;
        private double formulaH;
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            altura = Convert.ToDouble(tbAltura.Text);
            if (!rbMan.Checked)
            {
                //Mulher
                formulaM = (62.1 * altura) - 44.7;
                tbPeso.Text = formulaM.ToString("N");
            }
            else
            {
                formulaH = (72.7 * altura) - 58;
                tbPeso.Text = formulaH.ToString("N");
            }



        }
    }
}
