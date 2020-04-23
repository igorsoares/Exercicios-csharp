using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Exercicios
{
    public partial class Exercicio15 : Form
    {
        public Exercicio15()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbLitros.Text))
                {
                    MessageBox.Show("Digite a quantidade de litros", "Aviso");
                    tbLitros.Focus();
                    return;
                }
                else
                {

                    // litro gasolina : 2,50   litro alcool : 1,90
                    double litros = Convert.ToDouble(tbLitros.Text);
                    double desconto = 0;
                    if (rbGasolina.Checked)
                    {
                        if (litros > 0 && litros < 20)
                        {
                            desconto = ((litros * 4) / 100);
                            tbDesconto.Text = desconto.ToString();
                            desconto = (2.50 * litros) + desconto;
                        }
                        else
                        {
                            desconto = (litros * 6) / 100;
                            tbDesconto.Text = desconto.ToString();
                            desconto = (2.50 * litros) + desconto;
                        }
                    }
                    else
                    {
                        if (litros > 0 && litros < 20)
                        {
                            desconto = ((litros * 3) / 100);
                            tbDesconto.Text = desconto.ToString();
                            desconto = (1.90 * litros) + desconto;
                        }
                        else
                        {
                            desconto = (litros * 5) / 100;
                            tbDesconto.Text = desconto.ToString();
                            desconto = (1.90 * litros) + desconto;
                        }
                    }

                    tbPagar.Text = "R$" + desconto.ToString();
                }



            }catch (FormatException ex)
            {
                MessageBox.Show("Digite apenas números","Aviso");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
                return;
            }
        }
    }
}
