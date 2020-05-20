using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Exercicios.Exercicios
{
    public partial class Exercicio8 : Form
    {
        // tinta é vendida em latas de 18litros=R$80
        // Ou em galões de 3.6 Litros = R$25

        // 1Litro - 6metros

        public Exercicio8()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbMetros.Text))
                {
                    MessageBox.Show("Metros é obrigatório","Erro");
                    return;
                }
                double metros_q = Convert.ToDouble(tbMetros.Text);

                // regra de 3
                // 1 - 6
                // x - metros_q

                double x = (1*metros_q)/6;

                double latas_redondo = Math.Round(x / 18);
                double preco_lata = latas_redondo * 80; // R$80 cada
                tbQuantLata.Text = latas_redondo.ToString();


                double galao_redondo = Math.Round(x / 3.6);
                double preco_galao = galao_redondo * 25; // R$25 cada
                tbQuantGalao.Text = galao_redondo.ToString();

                tb18L.Text = preco_lata.ToString();
                tb3L.Text = preco_galao.ToString();

            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Erro");
                tbMetros.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro");
                return;
            }
        }
    }
}
