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
    public partial class Exercicio20 : Form
    {
        public Exercicio20()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            int i = 0, y = 1;
            int resultado = 0;
            for (int x = 1; x < 1000; x++)
            {
                resultado = i + y;
                //MessageBox.Show("I: " + i.ToString() + " Y: " + y.ToString());
                if (resultado >= 500)
                {
                    break;
                }
                lbFibo.Items.Add(resultado.ToString());
                
                i = y;
                y = resultado;

            }
        }

        private void Exercicio20_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbFibo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
