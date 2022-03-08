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
        int Score; //Количество очков сложности
        int Level; //Сложность игры
        int ScorePoint;//Счётчик очков

        int Bulls = 0;
        int Cows = 0;

        public Form1()
        {
            InitializeComponent();
            panelLevelSelect.Visible = true;
            panel1.Location = new Point(400, 20);
            panelLevelSelect.Location = new Point(15,60);
        }

        private void buttonLevelEasy_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(0, 20);
            Level = 4;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 10;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
            mtbInputOtgadka.Mask = "0000";
            Counter = 1;
        }

        private void buttonLevelMiddle_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(0, 20);
            Level = 6;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 20;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
            mtbInputOtgadka.Mask = "000000";
            Counter = 1;
        }

        private void buttonLevelHard_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            panel1.Visible = true;
            panel1.Location = new Point(0, 20);
            Level = 8;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 40;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
            mtbInputOtgadka.Mask = "00000000";
            Counter = 1;
        }

        private void buttonPopytka_Click(object sender, EventArgs e) //кнопка Угадать
        {
            Bulls = 0;
            Cows = 0;

            if (ScorePoint > 1)
            {
                ScorePoint -= 1;
                labelScorePoint.Text = ScorePoint + " ";
                Console.WriteLine(mtbInputOtgadka.Text);
                string InputOtgadka = mtbInputOtgadka.Text;
                for (int it = 0; it < Level; it++)
                {
                    char c = InputOtgadka[it];
                    if (char.IsDigit(c))
                        Otgadka[it] = Convert.ToInt32(c - 48);
                }

                if (NumberCompare(StartNumber, Otgadka))
                {
                    rtbChat.AppendText("Вы угадали число " + InputOtgadka + " c " + Counter + " попытки!");
                    buttonStart.Visible = true;
                    buttonPopytka.Visible = false;
                    return;
                }

                int[,] Analyze = new int[Level, 2];
                // угаданная цифра Analyze[i,1], бык(Analyze[i,0]=2) корова(Analyze[i,0]=1)
                // АНАЛИЗ. CountAnswer - число угаданных цифр
                int CountAnswer = BullsAndСows(StartNumber, Otgadka, Analyze);


                if (CountAnswer == 0)
                {
                    rtbChat.AppendText("Ход " + Counter + ". В Вашем числе " + InputOtgadka + " нет загаданных цифр..." + "\r\n");
                    Counter++;
                    rtbChat.ScrollToCaret();
                }
                else
                {
                    rtbChat.AppendText("Ход " + Counter + ". Число " + InputOtgadka + ". Быки = " + Bulls + ", Коровы = " + Cows + "\r\n");
                    Counter++;
                    rtbChat.ScrollToCaret();
                }
            }
            else
            {
                rtbChat.AppendText("Вы не угадали загаданное компьютером число  даже за " + Score + " предоставленных попыток..." + "\r\n");
                buttonStart.Visible = true;
                buttonPopytka.Visible = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
            mtbInputOtgadka.Text = "";
            GenSetN(Level, 10, StartNumber);
            ScorePoint = Score;
            buttonStart.Visible = false;
            buttonPopytka.Visible = true;
            labelInputOtgadka.Visible = true;
            mtbInputOtgadka.Visible = true;
            Counter = 1;
        }

        // Генератор множества Nq не повторяющихся целых чисел в диапазоне от 0 до Nm-1 (RVA)
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
        private int BullsAndСows(int[] a, int[] b, int[,] d)
        {
            int k = 0;
            for (int i = 0; i < Level; i++)
            {
                for (int j = 0; j < Level; j++)
                {
                    if (a[i] == b[j])
                    {
                        d[k, 1] = a[i];
                        if (i == j)
                        {
                            d[k, 0] = 2;
                            Bulls += 1;
                        }
                        else
                        { 
                            d[k, 0] = 1;
                            Cows += 1;
                        }
                        k++;
                    }
                }
            }
            return k;
        }

        // Сравнение на чистое совпадение
        private bool NumberCompare(int[] a, int[] b)
        {
            bool d = true;
            for (int i = 0; i < Level; i++)
            {
                if (a[i] != b[i])
                {
                    d = false;
                    break;
                }
            }
            return d;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
