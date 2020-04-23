using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace _30Exercicios
{
    public partial class Exercicio30 : Form
    {
        int n1;
        ArrayList numeros = new ArrayList();
        ArrayList linhas_resultados = new ArrayList(); // split ('|')[0] => numero jogador
        ArrayList novos_resultados = new ArrayList();
    
        public Exercicio30()
        {
            InitializeComponent();
        }


        private void Porcentagens()
        {
            // Descobre o numero total de votos
            int total_Votos = 0;
            foreach (string indice_votos in linhas_resultados)
            {
                total_Votos += Convert.ToInt32(indice_votos.Split('|')[1].Split('%')[0]);
                //MessageBox.Show(indice_votos.Split('|')[1].Split('%')[0]);
            }

            int calculo = 0;
            foreach(string indice in linhas_resultados)
            {
                calculo = ((Convert.ToInt32(indice.Split('|')[1].Split('%')[0]) * 100)/total_Votos) ;
                novos_resultados.Add(indice + calculo.ToString());
                //MessageBox.Show(indice.Split('|')[1].Split('%')[0]);
            }        

            foreach(string indice in novos_resultados)
            {
                listResults.Items.Add(indice);
            }


        }

        private void Processamento()
        {
            listResults.Items.Clear();
            listResults.Items.Add("Foram computados " + numeros.Count + " votos");
            listResults.Items.Add("Jogador   Votos    %   ");
            int contador = 0;
            int anterior = 0;
            foreach (int indice in numeros)
            {
                if (indice == anterior)
                    continue;
                foreach(int indiceCompara in numeros)
                {
                    if(indice == indiceCompara)
                    {
                        contador++;
                    }
                }
             
                //totalVotos.Add(indice, contador); // Adiciona a chave:valor ao dicionario (jogador:votos)
                linhas_resultados.Add(String.Format("{0}        |         {1}         %         ", indice, contador));
                contador = 0; // total votos
                anterior = indice;
            }
            Porcentagens();
        }
        

        private void btComputa_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(tbNumero.Text);
                if(n1 == 0)
                {
                    // processa, mostra e limpa
                    Processamento();
                    linhas_resultados.Clear();
                    novos_resultados.Clear();
                    numeros.Clear();
                    listResults.Items.Add("Limpando registros..");

                }
                else if (n1 >= 1 && n1 <= 23)
                {
                    numeros.Add(n1);
                }
                else
                {
                    MessageBox.Show("Número de jogador inválido", "Aviso");
                    return;
                }
                

            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
                return;
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            tbNumero.Text = "";
            listResults.Items.Clear();
            
        }
    }
}
