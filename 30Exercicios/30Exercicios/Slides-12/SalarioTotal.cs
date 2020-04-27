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
    public partial class SalarioTotal : Form
    {
        IObjectContainer banco2;
        public SalarioTotal(object banco)
        {
            InitializeComponent();
            banco2 = (IObjectContainer)banco;
        }

        private void SalarioTotal_Load(object sender, EventArgs e)
        {
            Clientes tmp;
            IObjectSet retorno = banco2.QueryByExample(new Clientes());
            double salario = 0;
            while (retorno.HasNext())
            {
                tmp = (Clientes)retorno.Next();
                lbResultado.Items.Add(tmp.nome + "|" + tmp.salario.ToString());
                salario += tmp.salario;
                
            }
            labelSal.Text = salario.ToString();
        }
    }
}
