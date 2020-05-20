using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace _30Exercicios.Slides_13
{
    public partial class VisualizarBanco : Form
    {
        IObjectContainer banco;

        private bool BuscaBanco(string nome, string numero)
        {
            Conta pesquisa = new Conta();
            pesquisa.titular = nome;
            pesquisa.numero = Convert.ToInt32(numero);
            IObjectSet retorno = banco.QueryByExample(pesquisa);
            if (!retorno.HasNext())
            {
                MessageBox.Show("Conta não encontrada !","Erro");
                tbNome.Focus();
                return false;
            }
            while (retorno.HasNext())
            {
                Conta tmp;
                tmp = (Conta)retorno.Next();
                listBox.Items.Add(tmp.titular + "-" + tmp.numero + "-"+tmp.metodo+"-"+"R$"+tmp.digitado);
            }
            return true;
        }
        public VisualizarBanco(IObjectContainer banco,string nome, string numero)
        {
            InitializeComponent();
            this.banco = banco;
            if(nome.Length>0 && numero.Length > 0)
            {
                if (!BuscaBanco(nome,numero))
                    return;
                else
                {
                    tbNome.Text = nome;
                    tbNumero.Text = numero;
                }
                
            }
            // se nao não faça nada (BUTTON)
        }

        private void VisualizarBanco_Load(object sender, EventArgs e)
        {

        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string numero = tbNumero.Text;
            BuscaBanco(nome,numero);
        }
    }
}
