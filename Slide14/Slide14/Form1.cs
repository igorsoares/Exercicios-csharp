using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
namespace Slide14
{
    public partial class Form1 : Form
    {
        DataTable table;
        IObjectContainer banco;
        string caminhoDB = @"c:\temp\banco-sl14.db";
        int linhaSelecionada = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void VerificaDiretorio()
        {

            try
            {
                if (!Directory.Exists(@"c:\temp\"))
                    Directory.CreateDirectory(@"c:\temp\");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }

            

        }
        private void VerificaArquivo()
        {
            try
            {
                if (!File.Exists(caminhoDB))
                    File.Open(caminhoDB, FileMode.Create);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }
            
        }
        private void atualizaBanco()
        {
            IObjectSet resultados = banco.QueryByExample(new Usuarios());
            while (resultados.HasNext())
            {
                Usuarios tmp = (Usuarios)resultados.Next();
                table.Rows.Add(tmp.id, tmp.nome, tmp.profissao);
            }
            dataGridView.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            // COLUNAS

            table.Columns.Add("Código",typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Profissao", typeof(string));

            VerificaDiretorio();
            VerificaArquivo();

            banco = Db4oFactory.OpenFile(caminhoDB);

            atualizaBanco();



        }
        private bool VerificaID(int id)
        {
            Usuarios tmp = new Usuarios();
            tmp.id = id;
            IObjectSet resultado = banco.QueryByExample(tmp);
            if (resultado.HasNext())
            {
                return true; // existe
            }
            else
            {
                return false;// nao existe 
            }
        }
        private int ajustaID(Usuarios user)
        {
            IObjectSet resultados = banco.QueryByExample(new Usuarios());
            int lastID = 0;
            while (resultados.HasNext())
            {
                Usuarios tmp = (Usuarios)resultados.Next();
                lastID = tmp.id;
            }
            return lastID + 1;
        }
        private void btInserir_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(tbCodigo.Text) || String.IsNullOrEmpty(tbNome.Text) ||
                String.IsNullOrEmpty(tbProfissao.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                    return;
                }
                Usuarios user = new Usuarios();

                int id = Convert.ToInt32(tbCodigo.Text);
                string nome = tbNome.Text;
                string profissao = tbProfissao.Text;
                user.id = id;


                user.nome = nome;
                user.profissao = profissao;


                if (VerificaID(user.id))
                {
                    MessageBox.Show("Conta com ID ja existe..","Erro");
                    return;
                }

                int id_ajustado = ajustaID(user);
                user.id = id_ajustado;
                tbCodigo.Text = id_ajustado.ToString();

                // SE ESTIVER TUDO TRANQUILO...
                banco.Store(user);
                

                table.Rows.Add(id_ajustado, nome, profissao);
                dataGridView.DataSource = table;
                //banco.Close();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números..","Erro");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
                return;
            }
            

        }
        private bool excluirConta(Usuarios excluir)
        {
            try
            {
                IObjectSet resultado = banco.QueryByExample(excluir);
                if (resultado.HasNext())
                {
                    Usuarios tmp = (Usuarios)resultado.Next();
                    banco.Delete(tmp);
                }
                return true;
            }catch(Exception ex)
            {
                throw;
            }
            
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dataG = dataGridView.Rows[linhaSelecionada];
                
                Usuarios excluir = new Usuarios();
                excluir.id = Convert.ToInt32(dataGridView.Rows[linhaSelecionada].Cells[0].Value.ToString());
                excluir.nome = dataGridView.Rows[linhaSelecionada].Cells[1].Value.ToString();
                excluir.profissao = dataGridView.Rows[linhaSelecionada].Cells[2].Value.ToString();
                if (excluirConta(excluir))
                {
                    MessageBox.Show("Conta deletada com sucesso.", "Aviso");
                }

                // nao precisa do senao , pois caso de erro, o throw joga 
                // nesse try

                dataGridView.Rows.Remove(dataG);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo hitT = dataGridView.HitTest(e.X, e.Y);
                linhaSelecionada = hitT.RowIndex;
            }
        }
    }
}
