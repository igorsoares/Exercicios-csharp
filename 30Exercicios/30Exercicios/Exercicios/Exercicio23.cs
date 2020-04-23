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
using System.Collections;

namespace _30Exercicios
{
    public partial class Exercicio23 : Form
    {

        ArrayList numeros = new ArrayList();

        public Exercicio23()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(tbNumero.Text);
                if (numero < 0)
                    this.Close();
                numeros.Add(numero);


            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
                tbNumero.Focus();
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumero.Focus();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio23_Results form23 = new Exercicio23_Results(numeros);
            form23.Show();

        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
