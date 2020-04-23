using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio18 : Form
    {
        public Exercicio18()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            try
            {
                int calculo = 0;
                int basee = Convert.ToInt32(tbBase.Text);
                int expoente = Convert.ToInt32(tbExpoente.Text);
                calculo = basee;
                for(int cont=1; cont < expoente; cont++)
                {
                    calculo *= basee;
                }
                tbResult.Text = calculo.ToString();



            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
            }
        }
    }
}
