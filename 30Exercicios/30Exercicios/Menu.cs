using Exercicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using _30Exercicios.Exercicios;
using _30Exercicios.Slides;
using _30Exercicios.Slides_13;

namespace _30Exercicios
{
    public partial class Menu : Form
    {
        private decimal num_exercicio;
        private int num_int;

        public Menu()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            num_exercicio = numericExercicio.Value;

            switch (num_exercicio.ToString())
            {

                case "1":
                    Exercicio1 ex1 = new Exercicio1();
                    ex1.ShowDialog();
                    break;
                case "2":
                    Exercicio2 ex2 = new Exercicio2();
                    ex2.ShowDialog();
                    break;
                case "3":
                    Exercicio3 ex3 = new Exercicio3();
                    ex3.ShowDialog();
                    break;
                case "4":
                    Exercicio4 ex4 = new Exercicio4();
                    ex4.ShowDialog();
                    break;
                case "5":
                    Exercicio5 ex5 = new Exercicio5();
                    ex5.ShowDialog();
                    break;
                case "6":
                    Exercicio6 ex6 = new Exercicio6();
                    ex6.ShowDialog();
                    break;
                case "7":
                    Exercicio7 ex7 = new Exercicio7();
                    ex7.ShowDialog();
                    break;
                case "8":
                    Exercicio8 ex8 = new Exercicio8();
                    ex8.ShowDialog();
                    break;
                case "9":
                    Exercicio9 ex9 = new Exercicio9();
                    ex9.ShowDialog();
                    break;
                case "10":
                    Exercicio10 ex10 = new Exercicio10();
                    ex10.ShowDialog();
                    break;
                case "11":
                    Exercicio11 ex11 = new Exercicio11();
                    ex11.ShowDialog();
                    break;
                case "12":
                    Exercicio12 ex12 = new Exercicio12();
                    ex12.ShowDialog();
                    break;
                case "13":
                    Exercicio13 ex13 = new Exercicio13();
                    ex13.ShowDialog();
                    break;
                case "14":
                    Exercicio14 ex14 = new Exercicio14();
                    ex14.ShowDialog();
                    break;
                case "15":
                    Exercicio15 ex15 = new Exercicio15();
                    ex15.ShowDialog();
                    break;
                case "16":
                    Exercicio16 ex16 = new Exercicio16();
                    ex16.ShowDialog();
                    break;
                case "17":
                    Exercicio17 ex17 = new Exercicio17();
                    ex17.ShowDialog();
                    break;
                case "18":
                    Exercicio18 ex18 = new Exercicio18();
                    ex18.ShowDialog();
                    break;
                case "19":
                    Exercicio19 ex19 = new Exercicio19();
                    ex19.ShowDialog();
                    break;
                case "20":
                    Exercicio20 ex20 = new Exercicio20();
                    ex20.ShowDialog();
                    break;
                case "21":
                    Exercicio21 ex21 = new Exercicio21();
                    ex21.ShowDialog();
                    break;
                case "22":
                    Exercicio22 ex22 = new Exercicio22();
                    ex22.ShowDialog();
                    break;
                case "23":
                    Exercicio23 ex23 = new Exercicio23();
                    ex23.ShowDialog();
                    break;
                case "24":
                    Exercicio24 ex24 = new Exercicio24();
                    ex24.ShowDialog();
                    break;
                case "25":
                    Exercicio25 ex25 = new Exercicio25();
                    ex25.ShowDialog();
                    break;
                case "26":
                    Exercicio26 ex26 = new Exercicio26();
                    ex26.ShowDialog();
                    break;
                case "27":
                    Exercicio27 ex27 = new Exercicio27();
                    ex27.ShowDialog();
                    break;
                case "28":
                    Exercicio28 ex28 = new Exercicio28();
                    ex28.ShowDialog();
                    break;
                case "29":
                    Exercicio29 ex29 = new Exercicio29();
                    ex29.ShowDialog();
                    break;
                case "30":
                    Exercicio30 ex30 = new Exercicio30();
                    ex30.ShowDialog();
                    break;
                case "31":
                    Exercicio31 ex31 = new Exercicio31();
                    ex31.ShowDialog();
                    break;
                case "32":
                    Exercicio32 ex32 = new Exercicio32();
                    ex32.ShowDialog();
                    break;
                default:
                    break;
            }
            
        }

        private void btVersao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V1.0","Versão",MessageBoxButtons.OK);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSlide12_Click(object sender, EventArgs e)
        {
            Slide12 slide = new Slide12();
            slide.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slide13 obj = new Slide13();
            obj.ShowDialog();

        }
    }
}
