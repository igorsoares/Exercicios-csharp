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
    public partial class Exercicio25 : Form
    {
        public Exercicio25()
        {
            InitializeComponent();
        }

        private void btInverter_Click(object sender, EventArgs e)
        {
            try{
                tbResult.Text = "";
                string msg = "";
                int n1 = Convert.ToInt32(tbDigito.Text);

                for(int i=Convert.ToInt32(n1.ToString().Length); i != 0; i--)
                {
                    msg += n1.ToString()[i-1] + " ";
                }

                tbResult.Text = msg;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
                tbDigito.Focus();
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
                return;
            }
        }
    }
}
