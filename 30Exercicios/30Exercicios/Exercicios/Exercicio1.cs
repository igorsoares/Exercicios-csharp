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
    public partial class Exercicio1 : Form
    {
        decimal salario;
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tbSalarioT.Text = "";
                salario = Convert.ToDecimal(tbGanhoH.Text) * Convert.ToDecimal(tbNumHora.Text);
                tbSalarioT.Text = salario.ToString();

            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números");
                return;
            }
            
        }
    }
}
