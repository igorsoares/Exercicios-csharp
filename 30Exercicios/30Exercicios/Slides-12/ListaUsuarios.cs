using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _30Exercicios.Slides;
using Db4objects.Db4o;
namespace _30Exercicios.Slides_12
{
    public partial class ListaUsuarios : Form
    {
        IObjectContainer banco;
        public ListaUsuarios(object banco)
        {
            InitializeComponent();
            Clientes tmp;
            this.banco = (IObjectContainer)banco;
            IObjectSet resultado = this.banco.QueryByExample(new Clientes());
            int cont = 0;
            string msg = "";
            while (resultado.HasNext())
            {
                tmp = (Clientes)resultado.Next();
                msg = tmp.nome + "|" + tmp.telefone + "|" + tmp.sexo;
                lbTodos.Items.Add(msg);
                cont++;
            }
            lbQuantidade.Text = cont.ToString();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
