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

        int Bulls = 0;
        int Cows = 0;
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
            mtbInputOtgadka.Mask = "0000";
        }

        private void buttonLevelMiddle_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            Level = 6;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 20;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
            mtbInputOtgadka.Mask = "000000";
        }

        private void buttonLevelHard_Click(object sender, EventArgs e)
        {
            panelLevelSelect.Visible = false;
            Level = 8;
            StartNumber = new int[Level];
            Otgadka = new int[Level];
            Score = 40;
            labelLevel.Text = Level + " ";
            labelScorePoint.Text = Score + " ";
            mtbInputOtgadka.Mask = "00000000";
        }

        private void buttonPopytka_Click(object sender, EventArgs e) //кнопка Угадать
        {
            Bulls = 0;
            Cows = 0;
            
            Score -= 1;
            labelScorePoint.Text = Score + " ";
            Console.WriteLine(mtbInputOtgadka.Text);
            string InputOtgadka = mtbInputOtgadka.Text;
            for (int it = 0; it < Level; it++)
            {
                char c = InputOtgadka[it]; 
                if (char.IsDigit(c))
                    Otgadka[it] = Convert.ToInt32(c - 48);
            }

            //int nAnswers = 1;
            //while (nAnswers <= Score)
            //{
                //for (int und = 0; und < Level; und++)
                //{
                //if (Otgadka[und])  // ответ
                if (NumberCompare(StartNumber, Otgadka))
                {
                    rtbChat.AppendText("Вы угадали число " + InputOtgadka + " c " + Counter + " попытки!");
                //Console.WriteLine("Вы угадали число c {0} попытки!", nAnswers);
                buttonStart.Visible = true;
                buttonPopytka.Visible = false;
                
                return;
                }


                int[,] Analyze = new int[4, 2];
                // угаданная цифра Analyze[i,1], бык(Analyze[i,0]=2) корова(Analyze[i,0]=1)
                // АНАЛИЗ. CountAnswer - число угаданных цифр
                int CountAnswer = BullsAndСows(StartNumber, Otgadka, Analyze);
                for (int i = 0; i < CountAnswer; i++)
                {
                    Console.WriteLine(Analyze[i, 0] + " , " + Analyze[i, 1]);
                    if (Analyze[i, 0] == 1)
                    {
                        //Cows += 1;
                        Console.WriteLine("КОРОВА ({0})", Analyze[i, 1]);
                    }
                    else
                    {
                        //Bulls += 1;
                        Console.WriteLine("БЫК ({0})", Analyze[i, 1]);
                    }
                }


            if (CountAnswer == 0)
            {
                rtbChat.AppendText("Ход " + Counter + ". В Вашем числе " + InputOtgadka + " нет загаданных цифр..." + "\r\n");
                Counter += 1;
                rtbChat.ScrollToCaret();
                //Console.WriteLine("Ход " + Counter + ". В Вашем числе " + InputOtgadka + " нет загаданных цифр...");
            }
            //nAnswers++;
            else
            {
                rtbChat.AppendText("Ход " + Counter + ". Число " + InputOtgadka + ". Быки = " + Bulls + ", Коровы = " + Cows + "\r\n");
                Counter += 1;
                rtbChat.ScrollToCaret();
            }
            //}

            //rtbChat.AppendText("Ход " + Counter + ". Число " + InputOtgadka + ". Быки = " + Bulls + ", Коровы = " + Cows + "\r\n");
            //Counter += 1;
            //rtbChat.ScrollToCaret();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
            mtbInputOtgadka.Text = "";
            GenSetN(Level, 10, StartNumber);

            //rtbChat.AppendText("Ход " + Counter + ": Быки = " + Bulls + ", Коровы = " + Cows + "\r\n");
            buttonStart.Visible = false;
            buttonPopytka.Visible = true;
            //Counter += 1;
            label1.Text = StartNumber[0] + " " + StartNumber[1] + " " + StartNumber[2] + " " + StartNumber[3];
            //rtbChat.ScrollToCaret();
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
        private int BullsAndСows(int[] a, int[] b, int[,] d)
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
