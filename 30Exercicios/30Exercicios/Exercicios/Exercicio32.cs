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


    

    public partial class Exercicio32 : Form
    {
        ArrayList resultados = new ArrayList();
        ArrayList splitResults = new ArrayList();
        public Exercicio32()
        {
            InitializeComponent();
        }
        private int CalculaQuant(int numero)
        {
            int calculo = 0;
            foreach(int x1 in resultados)
            {
                if (numero == x1)
                    calculo++;
            }
            return calculo;
        }
        private void btJoga_Click(object sender, EventArgs e)
        {
            listDados.Items.Clear();
            resultados.Clear();
            Random rnd = new Random();
            int numero = 0;
            for (int i=1; i<=100; i++)
            {
                numero = rnd.Next(1,7);
                resultados.Add(numero);
            }

            try
            {
                listDados.Items.Clear();
                int temp;
                for (int conta1 = 1; conta1 <= 6; conta1++)
                {
                    temp = CalculaQuant(conta1);
                    listDados.Items.Add("Número " + conta1 + " repetiu "+temp+" vezes");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
