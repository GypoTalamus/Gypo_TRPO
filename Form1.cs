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
        int[] StartNumber;  // загадываемое число
        int[] Otgadka;  // Ваш ответ
        int Counter = 1; //Счётчик ответов
        int Score; //Счётчик очков
        int Level; //Сложность игры

        int Byki = 0;
        int Korovy = 0;
        int val, val1, val2, val3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            StartNumber = new int[4];
            Otgadka = new int[4];
            Score = 10;
        }

        private void button2_Click(object sender, EventArgs e) //кнопка Угадать
        {
            richTextBox1.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            Counter += 1;
            richTextBox1.ScrollToCaret();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            GenSetN(4, 10, StartNumber);

            richTextBox1.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            //button1.Visible = false;
            //button2.Visible = true;
            Counter += 1;
            //label8.Text = StartNumber[0] + " " + StartNumber[1] + " " + StartNumber[2] + " " + StartNumber[3];
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
