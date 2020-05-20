using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exercicios
{
    public partial class Exercicio16 : Form
    {
        ArrayList numeros = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Exercicio16()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Aviso");
                tbUsuario.Focus();
                return;
            }

            if (numeros.Contains(tbUsuario.Text.Substring(0,1)))
            {
                MessageBox.Show("Primeiro digito de usuário deve ser caractere", "Aviso");
                tbUsuario.Focus();
                return;
            }

            if(tbUsuario.Text == tbPassword.Text)
            {
                MessageBox.Show("Usuario e senha são iguais..", "Aviso");
                tbUsuario.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Bem vindo, " + tbUsuario.Text, "Aviso");
                return;
            }


            
            
        }
    }
}
