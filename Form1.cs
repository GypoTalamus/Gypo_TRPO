using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        //int StartNumber = 1;
        //int Otgadka = 0;

        int[] StartNumber = new int[4];  // загадываемое число
        int[] Otgadka = new int[4];  // Ваш ответ
        int Counter = 1;

        int Byki = 0;
        int Korovy = 0;
        int val, val1, val2, val3;

        public Form1()
        {
            InitializeComponent();
            //int StartNumber = 0;
        }

        private void button2_Click(object sender, EventArgs e) //кнопка Угадать
        {
           //StartNumber = val * 1000 + val1 * 100 + val2 * 10 + val3;

            //button2.Text = (val + " " + val1 + " " + val2 + " " + val3);

            //Otgadka = Int32.Parse(textBox1.Text);

            //button2.Text = " " + Otgadka + " ";

            //richTextBox1.Text = "Ход " + StartNumber + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n";
            richTextBox1.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            Counter += 1;
            richTextBox1.ScrollToCaret();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание объекта для генерации чисел
            //Random rnd = new Random();

            GenSetN(4, 10, StartNumber);

            //val = rnd.Next(0, 10);  //Получить очередное случайное число
            //val1 = rnd.Next(0, 10); //Получить очередное случайное число
            //if (val1 == val) val1 = rnd.Next(0, 10);
            //val2 = rnd.Next(0, 10); //Получить очередное случайное число
            //if ((val2 == val) || (val2 == val1)) val2 = rnd.Next(0, 10);
            //val3 = rnd.Next(0, 10); //Получить очередное случайное число
            //if ((val3 == val) || (val3 == val1) || (val3 == val2)) val3 = rnd.Next(0, 10);

            richTextBox1.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            //StartNumber = StartNumber + 1;
            //label8.Text = val + " " + val1 + " " + val2 + " " + val3;
            //button1.Visible = false;
            //button2.Visible = true;
            Counter += 1;
            label8.Text = StartNumber[0] + " " + StartNumber[1] + " " + StartNumber[2] + " " + StartNumber[3];
            richTextBox1.ScrollToCaret();

        }

        // Генератор множества Nq не повторяющихся 
        // целых чисел в диапазоне от 0 до Nm-1 (RVA)
        static void GenSetN(int Nq, int Nm, int[] qN)
        {
            Random r = new Random();
            int p, k = 0;
            while (k < Nq)
            {
                p = r.Next(Nm);
                bool b = true;
                for (int i = 0; i < k; i++)
                    if (p == qN[i])
                    {
                        b = false;
                        break;
                    }
                if (b)
                {
                    qN[k] = p;
                    k++;
                }
            }
        }


    }
}
