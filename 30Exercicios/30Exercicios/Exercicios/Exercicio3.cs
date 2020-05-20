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
    public partial class Exercicio3 : Form
    {
        private double area;

        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbLado.Text))
                {
                    MessageBox.Show("Campo de lado é obrigatório");
                    return;
                } 
                area = Math.Pow(Convert.ToDouble(tbLado.Text), 2);
                tbArea.Text = area.ToString();
                tbAreaD.Text = (Convert.ToDouble(tbArea.Text) * 2).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro");
                return;
            }
            
        }
    }
}
