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
    public partial class Exercicio28 : Form
    {
        int[] vetorA = new int[10];
        int contador = 1, indiceAtual = 0;
        public Exercicio28()
        {
            InitializeComponent();
        }

        private void btProcessa_Click(object sender, EventArgs e)
        {
            double soma = 0;
            foreach(int indice in vetorA)
            {
                soma += Math.Pow(indice, 2);
            }
            tbResult.Text = "A soma de todos os quadrados é " + soma;
        }

        private void btAddNum_Click(object sender, EventArgs e)
        {
            try
            {
                contador++;
                int n1 = Convert.ToInt32(tbDigito.Text);
                vetorA[indiceAtual] = n1;
                labelVetor.Text = (contador).ToString() + " número: ";
                indiceAtual++;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Você ja digitou 10 valores.", "Aviso");
                tbDigito.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }
    }
}
