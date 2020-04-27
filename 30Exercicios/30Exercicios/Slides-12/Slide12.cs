using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _30Exercicios.Slides_12;
using Db4objects.Db4o;
// O requisito "Mostrar quantidade de pessoas cadastradas está junto com Listar pessoas cadastradas"

namespace _30Exercicios.Slides
{
    public partial class Slide12 : Form
    {
        IObjectContainer banco;
        public const string banco_path = @"c:\temp\cadastros.db";
        public Slide12()
        {
            InitializeComponent();
        }

        private string VerificaCampos()
        {
            if (String.IsNullOrEmpty(tbNome.Text))
                return "Nome é obrigatório!"; // erro
            if(tbTelefone.Text.Length != 15)
                return "Preencha o número corretamente!"; // erro
            if(String.IsNullOrEmpty(tbSalario.Text))
                return "Salário é obrigatório!"; // erro
            return "";
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string retorno = VerificaCampos();
                if (retorno.Length > 0)
                {
                    MessageBox.Show(retorno, "Aviso");
                    tbNome.Focus();
                    return;
                }
                Clientes obj = new Clientes();

                obj.nome = tbNome.Text;
                obj.salario = Convert.ToDouble(tbSalario.Text);
                obj.mes = cbMes.SelectedItem.ToString();
                obj.telefone = tbTelefone.Text;
                if (rbHomem.Checked)
                    obj.sexo = 'M';
                else
                    obj.sexo = 'F';
                banco.Store(obj);
                MessageBox.Show("Usuario cadastrado!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Slide12_Load(object sender, EventArgs e)
        {
            try
            {
                rbHomem.Checked = true;
                cbMes.SelectedIndex = 0;
                banco = Db4oFactory.OpenFile(banco_path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListaUsuarios obj = new ListaUsuarios(banco);
            obj.ShowDialog();

        }

        private void retornoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisaMes obj = new PesquisaMes(banco);
            obj.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banco.Close();
            this.Close();
        }

        private void comumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalarioTotal obj = new SalarioTotal(banco);
            obj.ShowDialog();
        }

        private void homemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalarioSexo obj = new SalarioSexo(banco,'M');
            obj.ShowDialog();
        }

        private void mulherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalarioSexo obj = new SalarioSexo(banco, 'F');
            obj.ShowDialog();
        }
    }
}
