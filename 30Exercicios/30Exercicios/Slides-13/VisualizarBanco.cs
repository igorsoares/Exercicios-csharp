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
        public VisualizarBanco(IObjectContainer banco)
        {
            InitializeComponent();
            this.banco = banco;
            IObjectSet retorno = banco.QueryByExample(new Conta());
            while (retorno.HasNext())
            {
                Conta tmp;
                tmp = (Conta)retorno.Next();
                listBox.Items.Add(tmp.titular + "-" + tmp.numero);
            }
        }
    }
}
