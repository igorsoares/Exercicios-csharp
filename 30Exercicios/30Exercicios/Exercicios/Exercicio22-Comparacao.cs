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
    public partial class Exercicio22_Comparacao : Form
    {
        ArrayList pessoas_tmp = new ArrayList();

        public Exercicio22_Comparacao(ArrayList pessoas)
        {
            InitializeComponent();
            pessoas_tmp = pessoas;
            lblCadastro.Text=pessoas_tmp.Count.ToString();

        }

        public void InsertValues(int codigo_alturaMaior, int codigo_alturaMenor, int codigo_PesoMenor, int codigo_Pesomaior, decimal pesoMenor, decimal pesoMaior,
            decimal alturaMenor, decimal alturaMaior)
        {
            decimal media_alturas = 0, media_pesos = 0;
            foreach(Exercicio22_class indice in pessoas_tmp)
            {
                media_alturas += Convert.ToDecimal(indice.altura);
                media_pesos += Convert.ToDecimal(indice.peso);
            }
            listResults.Items.Add("================================================");
            listResults.Items.Add(" Código Altura maior : " + codigo_alturaMaior);
            listResults.Items.Add(" Código Altura menor : " + codigo_alturaMenor);
            listResults.Items.Add(" Código Peso menor   : " + codigo_PesoMenor);
            listResults.Items.Add(" Código peso maior   : " + codigo_Pesomaior);
            listResults.Items.Add("    Menor peso       : " + pesoMenor);
            listResults.Items.Add("    Maior peso       : " + pesoMaior);
            listResults.Items.Add("    Menor altura     : " + alturaMenor);
            listResults.Items.Add("    Maior altura     : " + alturaMaior);
            listResults.Items.Add(" Média alturas       : " + (media_alturas / Convert.ToDecimal(pessoas_tmp.Count)).ToString("N1"));
            listResults.Items.Add(" Média pesos         : " + (media_pesos / Convert.ToDecimal(pessoas_tmp.Count)).ToString("N1"));
            listResults.Items.Add("================================================");
        }

        private void listResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
