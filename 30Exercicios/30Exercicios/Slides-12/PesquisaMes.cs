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
    public partial class PesquisaMes : Form
    {
        IObjectContainer banco2; 
        public PesquisaMes(object banco)
        {
            InitializeComponent();
            banco2 = (IObjectContainer)banco;
        }

        private void btVerifica_Click(object sender, EventArgs e)
        {
            Clientes tmp = new Clientes();
            tmp.mes = cbMes.SelectedItem.ToString();
            IObjectSet resultado = banco2.QueryByExample(tmp);
            if (resultado.Count > 0)
                MessageBox.Show("Foram encontrados " + resultado.Count.ToString() + " cadastros nesse mês", "Aviso");
            else
                MessageBox.Show("Não foram encontrados nenhum cadastro nesse mês.", "Aviso");
            while (resultado.HasNext())
            {
                tmp = (Clientes)resultado.Next();
                lbResultados.Items.Add(tmp.nome+" | "+tmp.telefone);
            }
        }

        private void PesquisaMes_Load(object sender, EventArgs e)
        {
            cbMes.SelectedIndex = 0;
        }
    }
}
