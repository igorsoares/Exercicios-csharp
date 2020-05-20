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
    public partial class Exercicio5 : Form
    {

        private double formula;
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                formula = (72.7 * Convert.ToDouble(tbAltura.Text)) - 58;
                tbPeso.Text = Math.Round(formula, 2).ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }
            
        }
    }
}
