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

namespace _30Exercicios.Exercicios
{
    public partial class Exercicio31 : Form
    {

        string carro1="", carro2="", carro3 = "", carro4 = "", carro5 = "", carro_menor="";
        double carro1k = 0, carro2k = 0, carro3k = 0, carro4k = 0, carro5k = 0;
        ArrayList carros = new ArrayList();

        public const double gasolina = 2.25d;

        public Exercicio31()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool AvisoRetorna()
        {
            MessageBox.Show("Preencha todos os campos corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

        private void AdicionaListBox(string message)
        {
            listResults.Items.Add(message);
        }

        private void AdicionaCarrosArray(string nome_carro, double kmLitro, int contador)
        {
            string msg = contador+" - " + nome_carro + " - " + kmLitro.ToString("N2") + " - " + (1000 / kmLitro).ToString("N2") + " Litros - " + "R$" + ((1000 / kmLitro) * gasolina).ToString("N2");
            carros.Add(msg);
            AdicionaListBox(msg);
        }

        private void Verificar()
        {
            carros.Clear();
            listResults.Items.Clear();

            if (String.IsNullOrEmpty(tbCarro1N.Text) || String.IsNullOrEmpty(tbCarro1k.Text))
                if (AvisoRetorna()) { return;  }
            if (String.IsNullOrEmpty(tbCarro2N.Text) || String.IsNullOrEmpty(tbCarro2k.Text))
                if (AvisoRetorna()) { return; }
            if (String.IsNullOrEmpty(tbCarro3N.Text) || String.IsNullOrEmpty(tbCarro3k.Text))
                if (AvisoRetorna()) { return; }
            if (String.IsNullOrEmpty(tbCarro4N.Text) || String.IsNullOrEmpty(tbCarro4k.Text))
                if (AvisoRetorna()) { return; }
            if (String.IsNullOrEmpty(tbCarro5N.Text) || String.IsNullOrEmpty(tbCarro5k.Text))
                if (AvisoRetorna()) { return; }

            try
            {
                carro1 = tbCarro1N.Text;
                carro2 = tbCarro2N.Text;
                carro3 = tbCarro3N.Text;
                carro4 = tbCarro4N.Text;
                carro5 = tbCarro5N.Text;

                carro1k = Convert.ToDouble(tbCarro1k.Text);
                carro2k = Convert.ToDouble(tbCarro2k.Text);
                carro3k = Convert.ToDouble(tbCarro3k.Text);
                carro4k = Convert.ToDouble(tbCarro4k.Text);
                carro5k = Convert.ToDouble(tbCarro5k.Text);

                AdicionaListBox("Relatório final");
                AdicionaCarrosArray(carro1, carro1k,1);
                AdicionaCarrosArray(carro2, carro2k,2);
                AdicionaCarrosArray(carro3, carro3k,3);
                AdicionaCarrosArray(carro4, carro4k,4);
                AdicionaCarrosArray(carro5, carro5k,5);

                carro_menor = "";
                double menor = 1000;
                int contador = 1;
                double valortmp = 0;
                foreach(string indice in carros)
                {
                    valortmp = Convert.ToDouble(indice.Split('$')[1]);
                    if (contador == 1)
                    {
                        menor = valortmp;
                        carro_menor = indice.Split('-')[1];
                        contador++;
                        continue;
                    }
                        
                    if(valortmp < menor)
                    {
                        menor = valortmp;
                        carro_menor = indice.Split('-')[1];
                    }
                    
                }
 

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void btCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                Verificar();
                AdicionaListBox("O carro que menos consome é: " + carro_menor);


            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números !", "Erro");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }
            
        }
    }
}
