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
    public partial class Exercicio4 : Form
    {
        int metros;


        public Exercicio4()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                metros = Convert.ToInt32(tbMetros.Text);
                tbCm.Text = (metros * 100).ToString();
            }catch(FormatException ex)
            {
                MessageBox.Show("Erro na conversão, digite apenas números", "" +
                    "Erro");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
