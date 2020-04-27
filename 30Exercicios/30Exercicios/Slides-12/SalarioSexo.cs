using _30Exercicios.Slides;
using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Exercicios.Slides_12
{
    public partial class SalarioSexo : Form
    {
        IObjectContainer banco2;
        char sexo = 'x';
        public SalarioSexo(object banco, char sexo)
        {
            InitializeComponent();
            banco2 = (IObjectContainer)banco;
            this.sexo = sexo;
        }
        private void Salario(char sexo)
        {
            Clientes tmp = new Clientes();
            tmp.sexo = sexo;
            IObjectSet resultado = banco2.QueryByExample(tmp);
            double sal = 0;
            while (resultado.HasNext())
            {
                tmp = (Clientes)resultado.Next();
                sal += Convert.ToDouble(tmp.salario);
                lbResultado.Items.Add(tmp.nome + "|" + tmp.salario.ToString());
            }
            lblSalario.Text = sal.ToString();
        }
        private void SalarioSexo_Load(object sender, EventArgs e)
        {
            if (sexo == 'M')
            {
                Salario('M');
            }
            else
            {
                Salario('F');
            }
        }
    }
}
