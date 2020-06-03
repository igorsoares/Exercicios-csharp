using System;
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
    public partial class Exercicio13 : Form
    {
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void Exercicio13_Load(object sender, EventArgs e)
        {

        }

        private void btSegundograu_Click(object sender, EventArgs e)
        {
            //tbX1.Text = "";
            //tbX2.Text = "";
            //tbVala.Text = "";
            //tbValb.Text = "";
            //tbValc.Text = "";
            double a, b, c;
            
            try
            {
                a = Convert.ToDouble(tbVala.Text);
                b = Convert.ToDouble(tbValb.Text);
                c = Convert.ToDouble(tbValc.Text);

                if (a == 0)
                {
                    MessageBox.Show("Não é de segundo grau","Aviso");
                    return;
                }

                double delta = (Math.Pow(b,2) - 4*a*c);
                
                if(delta < 0)
                {
                    MessageBox.Show("Equação não possui raízes, saindo..", "Aviso");
                    return;
                }else if (delta == 0)
                {
                    MessageBox.Show("Equação possui apenas uma raíz real", "Aviso");
                    
                }
                else
                {
                    MessageBox.Show("Equação possui raíz", "Aviso");

                }
                tbDelta.Text = delta.ToString();
                double x;
                x = ( (-b) + Math.Sqrt(delta)) / 2 * a;
                tbX1.Text = x.ToString("F2");

                x = ((-b) - Math.Sqrt(delta)) / 2 * a;
                tbX2.Text = x.ToString("F2");

                double xV = (-b / 2 * a);
                double yV = (-delta) / ( 4 * a);
                tbxV.Text = xV.ToString("F2");
                tbyV.Text = yV.ToString("F2");


                

            }
            catch(FormatException ex)
            {
                MessageBox.Show("Digite apenas números", "Aviso");
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
