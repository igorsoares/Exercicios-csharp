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
    public partial class Exercicio17 : Form
    {
        public Exercicio17()
        {
            InitializeComponent();
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lbResults.Items.Clear();
                int numero = Convert.ToInt32(tbNumero.Text);

                for(int i=1; i<=10; i++)
                {
                    lbResults.Items.Add(numero + " x " + i + " = " + (numero*i));
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumero.Focus();
                return;

            }
        }
    }
}
