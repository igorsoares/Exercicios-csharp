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
    public partial class Exercicio7 : Form
    {
        int valorH, horasM;
        public Exercicio7()
        {
            InitializeComponent();
        }
        private double Porcents(double bruto, int porcentagem)
        {
            return (bruto * porcentagem)/100;

        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                valorH = Convert.ToInt32(tbGanhoH.Text);
                horasM = Convert.ToInt32(tbNumHora.Text);
                double bruto = (valorH * horasM);
                double liquido, inss, ir, sindicato;

                tbSalarioBruto.Text = bruto.ToString();

                //Quanto pagou ao INSS
                inss = Porcents(bruto, 8); // 8%
                tbINSS.Text = (inss.ToString());

                ir = Porcents(bruto, 11); // 11% -> IR
                tbIR.Text = ir.ToString();

                sindicato = Porcents(bruto, 5); // 5% -> Sindicato
                tbSindicato.Text = sindicato.ToString();

                liquido = (bruto - (inss + ir + sindicato));
                tbSalarioL.Text = liquido.ToString();

            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }
            
            

        }
    }
}
