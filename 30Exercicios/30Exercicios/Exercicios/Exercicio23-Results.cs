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
    public partial class Exercicio23_Results : Form
    {
        ArrayList numeros;
        ArrayList intervalo025 = new ArrayList();
        ArrayList intervalo2650 = new ArrayList();
        ArrayList intervalo5175 = new ArrayList();
        ArrayList intervalo76100 = new ArrayList();
        ArrayList intervaloNOT = new ArrayList();

        public void NumerosAnsw(string msg, ArrayList tratamento)
        {
            if(tratamento.Count > 0)
            {
                string numbers = "";
                bool repeated = false;
                int quant = 0;
                foreach(int indice in tratamento)
                {
                    // verifica se ja foi digitado
                    repeated = false;
                    
                    foreach(string split in numbers.Split(' '))
                    {
                        if (indice.ToString().Equals(split))
                        {
                            repeated = true;
                            quant++;
                        }
                    }
                    if (repeated == false)
                    {
                        numbers += indice + " ";
                    }
                    
                }
                listResults.Items.Add("Quantidade :" + (tratamento.Count - quant) + " " + msg + " " +numbers);
            }

        }

        public Exercicio23_Results(ArrayList tmp)
        {
            InitializeComponent();
            numeros = tmp;

            foreach(int indice in numeros)
            {
                if (indice >= 0 && indice <= 25)
                    intervalo025.Add(indice);
                else if (indice >= 26 && indice <= 50)
                    intervalo2650.Add(indice);
                else if (indice >= 51 && indice <= 75)
                    intervalo5175.Add(indice);
                else if (indice >= 76 && indice <= 100)
                    intervalo76100.Add(indice);
                else
                    intervaloNOT.Add(indice);
            }
            listResults.Items.Add("====================================================");
            NumerosAnsw("= Intervalo entre 0 e 25 :", intervalo025);
            NumerosAnsw("= Intervalo entre 26 e 50 :", intervalo2650);
            NumerosAnsw("= Intervalo entre 51 e 75 :", intervalo5175);
            NumerosAnsw("= Intervalo entre 76 e 100 :", intervalo76100);
            NumerosAnsw("= Números foras do contexto : ", intervaloNOT);

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Deseja realmente sair ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re.Equals(DialogResult.Yes))
                this.Close();

        }
    }
}
