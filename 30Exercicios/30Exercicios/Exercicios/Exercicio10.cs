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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            // Matutino Vespertino ou Noturno
            string digito = tbDigito.Text;
            switch (digito.ToUpper())
            {
                case "M":
                    tbDigitado.Text = "Bom dia!";
                    break;
                case "V":
                    tbDigitado.Text = "Boa tarde!";
                    break;
                case "N":
                    tbDigitado.Text = "Boa noite!";
                    break;
                default:
                    tbDigitado.Text = "Valor invalido";
                    break;
            }
        }
    }
}
