using Microsoft.SqlServer.Server;
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

namespace _30Exercicios
{
    public partial class Exercicio26 : Form
    {
        public Exercicio26()
        {
            InitializeComponent();
        }

        private void btTermos_Click(object sender, EventArgs e)
        {
            try
            {
                tbResult.Text = "";
                ArrayList teste = new ArrayList();
                int Ntermo = Convert.ToInt32(tbDigito.Text);
                float Mtermo = 1;
                float soma=0;
                string msg = "";
                for(int i=1; i <=Ntermo; i++)
                {
                    soma += i / Mtermo;
                    msg += i + "/" + Mtermo + " ";
                    teste.Add(msg);
                    Mtermo += 2;
                }

                tbResult.Text = msg;
                tbSoma.Text = soma.ToString("N2");


            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
                tbDigito.Focus();
                return;
            }
        }
    }
}
