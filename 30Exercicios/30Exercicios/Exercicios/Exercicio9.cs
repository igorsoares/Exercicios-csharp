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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            string texto = tbDigito.Text;

            switch (texto.ToUpper())
            {
                case "M":
                    tbDigitado.Text = "M-Masculino";
                    break;
                case "F":
                    tbDigitado.Text = "F-Feminino";
                    break;
                default:
                    tbDigitado.Text = "Sexo invalido";
                    break;
            }

        }
    }
}
