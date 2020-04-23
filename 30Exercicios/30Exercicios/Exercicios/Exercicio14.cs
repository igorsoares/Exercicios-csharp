using Microsoft.SqlServer.Server;
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
    public partial class Exercicio14 : Form
    {
        public Exercicio14()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(tbNumero.Text);
                string msg;
                if(numero <0 && numero >= 1000)
                {
                    MessageBox.Show("Digite número menor que 1000 e maior que 0","Erro");
                    return;
                }
                if (numero.ToString().Length == 1)
                    msg = numero + " unidades";
                else if (numero.ToString().Length == 2)
                    msg = numero.ToString()[0] + " dezena " + numero.ToString()[1] + " unidades";
                else
                    msg = numero.ToString()[0] + " centena " + numero.ToString()[1] + " dezenas " + numero.ToString()[2] + " unidades";

                tbResposta.Text = msg;

            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números! ","Erro");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro");
                return;
            }
            
        }
    }
}
