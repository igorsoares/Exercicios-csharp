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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        public double CalculoPorcentagem(double bruto, int porcentagem)
        {
            return (bruto * porcentagem)/100;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string porHora = tbGanhoH.Text;
                string horaMes = tbNumHora.Text;
                double salarioBruto = Convert.ToDouble(porHora) * Convert.ToDouble(horaMes);
                double impostoRenda, descontos;
                // Descondo do Imposto de renda
                if (salarioBruto > 0 && salarioBruto <= 900)
                    impostoRenda = 0;
                else if (salarioBruto > 900 && salarioBruto <= 1500)
                    impostoRenda = 5; // 5%
                else if (salarioBruto > 1500 && salarioBruto <= 2500)
                    impostoRenda = 10; // 10%
                else
                    impostoRenda = 20; // 20%

                // Coloca no text
                tbSalarioBruto.Text = salarioBruto.ToString();
                tbIR.Text = ( impostoRenda == 0 ? "0":CalculoPorcentagem(salarioBruto,5).ToString() );
                tbINSS.Text = CalculoPorcentagem(salarioBruto,10).ToString();
                tbFGTS.Text = CalculoPorcentagem(salarioBruto, 11).ToString();

                descontos = Convert.ToDouble(tbIR.Text) + Convert.ToDouble(tbINSS.Text);
                tbTotalD.Text = descontos.ToString();

                tbSalarioL.Text = (salarioBruto - descontos).ToString();





            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
