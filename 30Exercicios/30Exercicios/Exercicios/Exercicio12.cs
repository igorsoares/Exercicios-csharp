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
    public partial class Exercicio12 : Form
    {
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            try
            {
                // a -> b 
                double val1 = Convert.ToDouble(tbLado1.Text);
                double val2 = Convert.ToDouble(tbLado2.Text);
                double val3 = Convert.ToDouble(tbLado3.Text);
                // é triangulo?
                if ( (val1 + val2)  > val3)
                {
                    if ((val1 == val2) && (val2 == val3))
                        tbResultado.Text = "Triângulo equilátero";
                    else if ((val1 == val2) || (val2 == val3))
                        tbResultado.Text = "Triângulo Isósceles";
                    else
                        tbResultado.Text = "Triângulo escaleno";

                }
                else
                {
                    tbResultado.Text = "Não é um triângulo";
                }
                



            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite somente números", "Aviso");
            }
        }
    }
}
