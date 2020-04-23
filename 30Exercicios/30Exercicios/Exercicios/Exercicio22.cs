using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Exercicios
{
    public partial class Exercicio22 : Form
    {

        ArrayList pessoas = new ArrayList();

        public Exercicio22()
        {
            InitializeComponent();
        }

        private bool VerificaComp(string cont_componente, string nome_comp)
        {
            if (!String.IsNullOrEmpty(cont_componente))
                return true;
            else
            {
                MessageBox.Show(nome_comp + " é obrigatório", "Aviso");
                return false;
            }
  
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if ((!VerificaComp(tbCodigo.Text, "Codigo"))) { return; };
                if (!VerificaComp(tbAltura.Text, "Altura")) { return; } ;
                if (!VerificaComp(tbPeso.Text, "Peso")) { return; } ;

                int codigo = Convert.ToInt32(tbCodigo.Text);
                decimal altura = Convert.ToDecimal(tbAltura.Text);
                decimal peso = Convert.ToDecimal(tbPeso.Text);

                Exercicio22_class clientes = new Exercicio22_class();
                clientes.codigo = codigo;
                clientes.altura = altura;
                clientes.peso = peso;

                pessoas.Add(clientes);
                MessageBox.Show("Cliente cadastrado.", "Aviso");



            }catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
            }
        }

        private void btCompara_Click(object sender, EventArgs e)
        {
            int codigo_Pesomaior = 0, codigo_PesoMenor=0, codigo_alturaMaior=0, codigo_alturaMenor=0;
            decimal pesoMaior = 0, pesoMenor = 1000;
            decimal alturaMenor = 1000M, alturaMaior = 0;
            decimal mediaAltura, mediaPeso;

            if(pessoas.Count == 0)
            {
                MessageBox.Show("Sem registro de clientes.", "Aviso");
                return;
            }
            else
            {
                int cont = 1;
                foreach (Exercicio22_class indice in pessoas)
                {
                    if(cont == 1)
                    {
                        codigo_alturaMaior = indice.codigo;
                        codigo_alturaMenor = indice.codigo;
                        codigo_Pesomaior = indice.codigo;
                        codigo_PesoMenor = indice.codigo;
                        alturaMaior = indice.altura;
                        alturaMenor = indice.altura;
                        pesoMenor = indice.peso;
                        pesoMaior = indice.peso;
                        cont++;
                        continue;
                    }
                    else
                    {
                        if (indice.altura > alturaMaior)
                        {
                            codigo_alturaMaior = indice.codigo;
                            alturaMaior = indice.altura;
                        }

                        if (indice.altura < alturaMenor)
                        {
                            codigo_alturaMenor = indice.codigo;
                            alturaMenor = indice.altura;
                        }

                        if (indice.peso < pesoMenor)
                        {
                            codigo_PesoMenor = indice.codigo;
                            pesoMenor = indice.peso;
                        }

                        if (indice.peso > pesoMenor)
                        {
                            codigo_Pesomaior = indice.codigo;
                            pesoMaior = indice.peso;
                        }
                    cont++;
                    }
                    
                }
                Exercicio22_Comparacao formComp = new Exercicio22_Comparacao(pessoas);
                formComp.InsertValues(codigo_alturaMaior, codigo_alturaMenor, codigo_PesoMenor, codigo_Pesomaior, pesoMenor, pesoMaior, alturaMenor, alturaMaior);
                formComp.Show();

            }

            

        }
    }
}
