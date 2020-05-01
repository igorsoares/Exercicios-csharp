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
    public partial class Slide13 : Form
    {
        IObjectContainer banco;
        public Slide13()
        {
            InitializeComponent();
        }

        private void VerificaCampos()
        {
            if (String.IsNullOrEmpty(tbTitular.Text))
            {
                MessageBox.Show("Nome é obrigatório !", "Erro");
                tbTitular.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tbNumero.Text))
            {
                MessageBox.Show("Número é obrigatório !", "Erro");
                tbNumero.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tbValor.Text))
            {
                MessageBox.Show("Valor é obrigatório !", "Erro");
                tbNumero.Focus();
                return;
            }
        }


        private bool ContaExiste(Conta obj)
        {
            IObjectSet retorno = banco.QueryByExample(obj);
            if (retorno.HasNext())
            {
                return false; // conta existe
            }
            else
            {
                return true; // conta nao existe
            }
        }








        private void Slide13_Load(object sender, EventArgs e)
        {
            banco = Db4oFactory.OpenFile(@"c:\temp\slide13.db");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificaCampos();
            Conta obj = new Conta();
            obj.titular = tbTitular.Text;
            obj.numero = Convert.ToInt32(tbNumero.Text);
            decimal valorDigitado = Convert.ToDecimal(tbValor.Text);
            if (ContaExiste(obj))
            {
                obj.valor = valorDigitado;
                banco.Store(obj);
                MessageBox.Show("Conta criada com sucesso !","Aviso");
            }
            else
            {
                decimal valor_conta; // valor r$ atual do usuario
                IObjectSet retorno = banco.QueryByExample(obj);
                Conta tmp = new Conta();
                while (retorno.HasNext())
                {
                    obj = (Conta)retorno.Next();
                    obj.valor += valorDigitado;
                    tbSaldo.Text = obj.valor.ToString();
                    tmp.titular = obj.titular;
                    tmp.numero = obj.numero;
                    tmp.valor = obj.valor;
                    
                }
                banco.Store(tmp);

            }


        }

        private void visualizarBancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarBanco obj = new VisualizarBanco(banco);
            obj.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            banco.Close();
            this.Close();
        }

        private void btSaca_Click(object sender, EventArgs e)
        {
            VerificaCampos();

            Conta obj = new Conta();
            obj.titular = tbTitular.Text;
            obj.numero = Convert.ToInt32(tbNumero.Text);
            decimal valorDigitado = Convert.ToDecimal(tbValor.Text);
            if (ContaExiste(obj))
            {
                obj.valor = valorDigitado;
                banco.Store(obj);
                MessageBox.Show("Conta criada com sucesso !", "Aviso");
            }
            else
            {
                decimal valor_conta=0;
                IObjectSet retorno = banco.QueryByExample(obj);
                Conta tmp = new Conta();
                while (retorno.HasNext())
                {
                    obj = (Conta)retorno.Next();
                    valor_conta += obj.valor;   
                }
                valor_conta -= valorDigitado;
                obj.valor = valor_conta;
                tbSaldo.Text = valor_conta.ToString();
                tmp.titular = obj.titular;
                tmp.numero = obj.numero;
                tmp.valor = obj.valor;
                banco.Store(tmp);

            }




        }
    }
}
