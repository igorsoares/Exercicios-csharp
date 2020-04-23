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
    public partial class Exercicio24 : Form
    {

        string nome;
        decimal salto1, salto2, salto3, salto4, salto5, media=0;



        public Exercicio24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal ComparaMenor()
        {
            decimal menor=0;

            if (salto1 < salto2 && salto1 < salto3 && salto1 < salto4 && salto1 < salto5)
                menor = salto1;
            else if (salto2 < salto1 && salto2 < salto3 && salto2 < salto4 && salto2 < salto5)
                menor = salto2;
            else if (salto3 < salto1 && salto3 < salto2 && salto3 < salto4 && salto3 < salto5)
                menor = salto3;
            else if (salto4 < salto1 && salto4 < salto2 && salto4 < salto3 && salto4 < salto5)
                menor = salto4;
            else if (salto5 < salto1 && salto5 < salto2 && salto5 < salto3 && salto5 < salto4)
                menor = salto5;

            return menor;
        }

        private string Compara()
        {
            decimal maior=0, menor=0;
            if (salto1 > salto2 && salto1 > salto3 && salto1 > salto4 && salto1 > salto5)
                maior = salto1;
            else if (salto2 > salto1 && salto2 > salto3 && salto2 > salto4 && salto2 > salto5)
                maior = salto2;
            else if (salto3 > salto1 && salto3 > salto2 && salto3 > salto4 && salto3 > salto5)
                maior = salto3;
            else if (salto4 > salto1 && salto4 > salto2 && salto4 > salto3 && salto4 > salto5)
                maior = salto4;
            else if (salto5 > salto1 && salto5 > salto2 && salto5 > salto3 && salto5 > salto4)
                maior = salto5;
            menor = ComparaMenor();
            return maior+"|"+menor;
            

            
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(tbNome.Text))
                {
                    this.Close();
                }
                else
                {
                    listResults.Items.Clear();
                    nome = tbNome.Text;
                    salto1 = Convert.ToDecimal(tbSalto1.Text);
                    salto2 = Convert.ToDecimal(tbSalto2.Text);
                    salto3 = Convert.ToDecimal(tbSalto3.Text);
                    salto4 = Convert.ToDecimal(tbSalto4.Text);
                    salto5 = Convert.ToDecimal(tbSalto5.Text);

                    string recebe = Compara();
                    media = (salto1 + salto2 + salto3 + salto4 + salto5) - (Convert.ToDecimal(recebe.Split('|')[0]) - Convert.ToDecimal(recebe.Split('|')[1]));
                    listResults.Items.Add("==========================================");
                    listResults.Items.Add("    " + nome);
                    listResults.Items.Add("Maior salto:" + recebe.Split('|')[0]);
                    listResults.Items.Add("Menor salto: "+recebe.Split('|')[1]);
                    listResults.Items.Add("Media dos demais: " + media.ToString());
                    listResults.Items.Add("Resultado final : " + media.ToString());
                    listResults.Items.Add("==========================================");


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
    }
}
