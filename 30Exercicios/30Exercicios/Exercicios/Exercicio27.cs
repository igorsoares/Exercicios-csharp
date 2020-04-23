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
    public partial class Exercicio27 : Form
    {
        int[] vetor = new int[9];
        int indiceAtual = 0;
        int contador = 1;
        public Exercicio27()
        {
            InitializeComponent();
        }

        private void btAddNum_Click(object sender, EventArgs e)
        {
            try
            {
                contador++;
                int n1 = Convert.ToInt32(tbDigito.Text);
                vetor[indiceAtual] = n1;
                labelVetor.Text = (contador).ToString()+" número: ";
                indiceAtual++;
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números","Aviso");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Você ja digitou 10 valores.", "Aviso");
                tbDigito.Focus();
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

        private void btProcessa_Click(object sender, EventArgs e)
        {

            if (indiceAtual != vetor.Length)
            {
                MessageBox.Show("Preencha os 10 valores primeiro.", "Aviso");
            }
            else
            {
                for(int i=vetor.Length; i!=0; i--)
                {
                    tbResult.Text += vetor[i-1] + " ";
                }
            }
        }

    }
}
