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
        //int val, val1, val2, val3;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLevelEasy_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            Level = 4;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 10;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
        }

        private void buttonPopytka_Click(object sender, EventArgs e) //кнопка Угадать
        {
            rtbChat.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            Counter += 1;
            rtbChat.ScrollToCaret();
            Score -= 1;
            labelScorePoint.Text = Score + " ";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
         
            GenSetN(Level, 10, StartNumber);

            rtbChat.AppendText("Ход " + Counter + ": Быки = " + Byki + ", Коровы = " + Korovy + "\r\n");
            //button1.Visible = false;
            //button2.Visible = true;
            Counter += 1;
            label1.Text = StartNumber[0] + " " + StartNumber[1] + " " + StartNumber[2] + " " + StartNumber[3];
            rtbChat.ScrollToCaret();
            labelInputOtgadka.Visible = true;
            mtbInputOtgadka.Visible = true;
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

        // Сравнение заданного и введенного чисел 
        static int BullsAndСows(int[] a, int[] b, int[,] d)
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i] == b[j])
                    {
                        d[k, 1] = a[i];
                        if (i == j)
                            d[k, 0] = 2;
                        else
                            d[k, 0] = 1;
                        k++;
                    }
                }
            }
            return k;
        }

        // Сравнение на чистое совпадение
        static bool NumberCompare(int[] a, int[] b)
        {
            bool d = true;
            for (int i = 0; i < 4; i++)
            {
                if (a[i] != b[i])
                {
                    d = false;
                    break;
                }
            }
            return d;
        }


    }
}
