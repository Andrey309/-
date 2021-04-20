using System;
using System.Windows.Forms;

namespace индивидуалка
{
    public partial class Form1 : Form
    {

        string t = "";
        Random rnd = new Random(); // Отвечает за рандомный порядок первого хода
        int[] array = new int[9];
        Button[] btn = new Button[9];
        bool tie = true;


        public Form1()
        {
            InitializeComponent();

            if (rnd.Next(1, 10) <= 5)
            {
                t = "Крестики";
                label1.Text = "Ходят рестики";
            }

            else
            {
                t = "Ходят нолики";
                label1.Text = "Ходят нолики";
            }
            // присвоение кнопок
            btn[0] = button1;

            btn[1] = button2;

            btn[2] = button3;

            btn[3] = button4;

            btn[4] = button5;

            btn[5] = button6;

            btn[6] = button7;

            btn[7] = button8;

            btn[8] = button9;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (t == "Крестики")
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        label1.Text = "Ходят Нолики";
                        t = "1";  // Можно указать любое значение . НУжно для того , что бы постоянно не попадать в Крестики
                        btn[i].Enabled = false; // делаем использованную кнопку неактивной
                        array[i] = 1;
                        break; // делаем оптимизацию)
                    }
                }
            } 
            else  //Нолики
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        if (sender == btn[i])
                        {
                            btn[i].Text = "0";
                            label1.Text = "Ходят Крестики";
                            t = "Крестики";  //  Указываем именно Крестики , что бы он его не проскачил
                            btn[i].Enabled = false; // делаем использованную кнопку неактивной
                            array[i] = 2;
                            break; // делаем оптимизацию)


                        }
                    }
                }                
            }

            // логика игры 

            tie = true;
            for (int i = 0; i < btn.Length; i++)
            {
                if (btn[i].Text == "")
                {
                    tie = false;
                }
            }

            if (tie == true)
            {
                label1.Text = "Ничья , попробуйте снова";
            }

            if (array[0] == 1 && array[1] == 1 && array[2] == 1) // верхняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[1].BackColor = System.Drawing.Color.Red;

                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }



            else if (array[3] == 1 && array[4] == 1 && array[5] == 1) // средняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[3].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[6] == 1 && array[7] == 1 && array[8] == 1) // нижняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[6].BackColor = System.Drawing.Color.Red;

                btn[7].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[0] == 1 && array[4] == 1 && array[8] == 1) // левая диагональ
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[2] == 1 && array[4] == 1 && array[6] == 1) // правая диагональ
            {
                // изменение цвета используемой кнопки
                btn[2].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[1] == 1 && array[4] == 1 && array[7] == 1) // центральная вертикаль
            {
                // изменение цвета используемой кнопки
                btn[1].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[0] == 1 && array[3] == 1 && array[6] == 1) // левая вертикаль
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[3].BackColor = System.Drawing.Color.Red;

                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";


            }
            else if (array[2] == 1 && array[5] == 1 && array[8] == 1) // правая вертикаль
            {
                // изменение цвета используемой кнопки
                btn[2].BackColor = System.Drawing.Color.Red;

                btn[5].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли крестики";

            }


            // обработка ноликов 
            else if (array[0] == 2 && array[1] == 2 && array[2] == 2) // верхняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[1].BackColor = System.Drawing.Color.Red;

                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }



            else if (array[3] == 2 && array[4] == 2 && array[5] == 2) // средняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[3].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }
            else if (array[6] == 2 && array[7] == 2 && array[8] == 2) // нижняя горизонталь
            {
                // изменение цвета используемой кнопки
                btn[6].BackColor = System.Drawing.Color.Red;

                btn[7].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }
            else if (array[0] == 2 && array[4] == 2 && array[8] == 2) // левая диагональ
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }
            else if (array[2] == 2 && array[4] == 2 && array[6] == 2) // правая диагональ
            {
                // изменение цвета используемой кнопки
                btn[2].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }
            else if (array[1] == 2 && array[4] == 2 && array[7] == 2) // центральная вертикаль
            {
                // изменение цвета используемой кнопки
                btn[1].BackColor = System.Drawing.Color.Red;

                btn[4].BackColor = System.Drawing.Color.Red;

                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }
            else if (array[0] == 2 && array[3] == 2 && array[6] == 2) // левая вертикаль
            {
                // изменение цвета используемой кнопки
                btn[0].BackColor = System.Drawing.Color.Red;

                btn[3].BackColor = System.Drawing.Color.Red;

                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли Нолики";


            }
            else if (array[2] == 2 && array[5] == 2 && array[8] == 2) // правая вертикаль
            {
                // изменение цвета используемой кнопки
                btn[2].BackColor = System.Drawing.Color.Red;

                btn[5].BackColor = System.Drawing.Color.Red;

                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false; // вывели кнопки в неактивное состояние 
                }
                button10.Enabled = true; // вернули активное состояние
                label1.Text = "Выиграли нолики";


            }

            
                

        }
        // обработка кнопки Restart
        private void button10_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Text = "";

                if(rnd.Next(1, 10) <= 5)
                {
                    t = "Крестики";
                    label1.Text = "Ходят Крестики";
                }
                else
                {
                    t = "Ходят нолики";
                    label1.Text = "Ходят нолики";
                }

                btn[i].Enabled = true;// активирует кнопки после игры 
                btn[i].BackColor = System.Drawing.Color.White; // возвращает окрашенным полям былой цвет 
            }
        }
    }

    }

