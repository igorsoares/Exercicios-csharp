using System;
using System.Collections;
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
    public partial class Exercicio29 : Form
    {
        int nota;
        ArrayList notas = new ArrayList();
        public Exercicio29()
        {
            InitializeComponent();
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            if (tbNota.Text == "-1")
            {
                this.Close();
            }
            else
            {

                try
                {
                    nota = Convert.ToInt32(tbNota.Text);
                    notas.Add(nota);

                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Digite apenas números", "Aviso");
                    return;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso");
                    return;
                }
                
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            notas.Clear();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            string msg = "";
            int soma = 0,media=0, abaixoSete=0;
            if(notas.Count > 0)
            {
                listResult.Items.Add("=======================================");
                listResult.Items.Add("Itens lidos : " + notas.Count);
                foreach(int i in notas)
                {
                    msg += i + " ";
                    soma += i;
                }
                listResult.Items.Add(msg);
                // Ordem inversa
                for(int inversa=notas.Count; inversa != 0; inversa--)
                {
                    listResult.Items.Add(notas[inversa-1]);
                }
                // Soma dos valores
                listResult.Items.Add("Soma : " + soma);
                // Média
                media = (soma / notas.Count);
                listResult.Items.Add("Média: " + media);
                // Valores acima da media
                msg = "";
                foreach (int i in notas)
                {
                    if (i > media)
                        msg += i + " ";
                }
                listResult.Items.Add("Acima da média : " + msg);
                // Abaixo de 7
                msg = "";
                foreach (int i in notas)
                {
                    if (i < 7)
                        msg += i + " ";
                }
                listResult.Items.Add(" Abaixo de 7 : " + msg);
                listResult.Items.Add("=======================================");
                listResult.Items.Add("Obrigado por usar o programa !");

            }
            else
            {
                listResult.Items.Add("Sem valores ainda...");
            }
        }
    }
}
