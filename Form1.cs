using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_home
{
    public partial class Form1 : Form
    {
        public int[] MassX = new int[100];
        public int[] MassY = new int[100];

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);

            Pen common = new Pen(Color.Black);  //Забор и здание
            Pen window = new Pen(Color.Yellow);  //Окна
            Pen room = new Pen(Color.Blue);  //Комната

            //graph.DrawLine(common, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value));  //Рисуем забор

            int stepX = Convert.ToInt32(Math.Abs(numericUpDown3.Value - numericUpDown1.Value)/100);
            int stepY = Convert.ToInt32(Math.Abs(numericUpDown4.Value - numericUpDown2.Value)/ 100);
            int x = 0;
            int y = 0;
            //int[] MassX = new int[100];
            //int[] MassY = new int[100];


            for (int i = 0; i<100; i++)
            {
                MassX[i] = Convert.ToInt32(numericUpDown1.Value) + x;
                x += stepX;
            }

            for(int i = 0; i<100; i++)
            {
                MassY[i] = Convert.ToInt32(numericUpDown2.Value) + y;
                y += stepY;
            }

            for(int i = 1; i<100; i++)
            {
                graph.DrawLine(common, MassX[i-1], MassY[i-1], MassX[i], MassY[i]);
            }

            graph.DrawLine(common, Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown6.Value), Convert.ToInt32(numericUpDown7.Value), Convert.ToInt32(numericUpDown8.Value));  //Рисуем здание
            graph.DrawLine(common, Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown6.Value), Convert.ToInt32(numericUpDown9.Value), Convert.ToInt32(numericUpDown10.Value));
            graph.DrawLine(common, Convert.ToInt32(numericUpDown9.Value), Convert.ToInt32(numericUpDown10.Value), Convert.ToInt32(numericUpDown11.Value), Convert.ToInt32(numericUpDown12.Value));
            graph.DrawLine(common, Convert.ToInt32(numericUpDown11.Value), Convert.ToInt32(numericUpDown12.Value), Convert.ToInt32(numericUpDown7.Value), Convert.ToInt32(numericUpDown8.Value));

            graph.DrawLine(window, Convert.ToInt32(numericUpDown13.Value), Convert.ToInt32(numericUpDown14.Value), Convert.ToInt32(numericUpDown15.Value), Convert.ToInt32(numericUpDown16.Value));  //Рисуем окна
            graph.DrawLine(window, Convert.ToInt32(numericUpDown25.Value), Convert.ToInt32(numericUpDown26.Value), Convert.ToInt32(numericUpDown27.Value), Convert.ToInt32(numericUpDown28.Value));

            graph.DrawLine(room, Convert.ToInt32(numericUpDown17.Value), Convert.ToInt32(numericUpDown18.Value), Convert.ToInt32(numericUpDown19.Value), Convert.ToInt32(numericUpDown20.Value));  //Рисуем комнату
            graph.DrawLine(room, Convert.ToInt32(numericUpDown19.Value), Convert.ToInt32(numericUpDown20.Value), Convert.ToInt32(numericUpDown23.Value), Convert.ToInt32(numericUpDown24.Value));
            graph.DrawLine(room, Convert.ToInt32(numericUpDown21.Value), Convert.ToInt32(numericUpDown22.Value), Convert.ToInt32(numericUpDown23.Value), Convert.ToInt32(numericUpDown24.Value));
            graph.DrawLine(room, Convert.ToInt32(numericUpDown17.Value), Convert.ToInt32(numericUpDown18.Value), Convert.ToInt32(numericUpDown21.Value), Convert.ToInt32(numericUpDown22.Value));

            //Левое окно
            if (numericUpDown13.Value < numericUpDown15.Value)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown15.Value - numericUpDown13.Value) / 2) + numericUpDown13.Value));
            }
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown15.Value - numericUpDown13.Value) / 2) + numericUpDown15.Value));
            }

            if (numericUpDown14.Value < numericUpDown16.Value)
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown16.Value - numericUpDown14.Value) / 2) + numericUpDown14.Value));
            }
            else
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown16.Value - numericUpDown14.Value) / 2) + numericUpDown16.Value));
            }

            //Правое окно
            if (numericUpDown25.Value < numericUpDown27.Value)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown27.Value - numericUpDown25.Value) / 2) + numericUpDown25.Value));
            }
            else
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown27.Value - numericUpDown25.Value) / 2) + numericUpDown27.Value));
            }

            if (numericUpDown26.Value < numericUpDown28.Value)
            {
                textBox5.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown28.Value - numericUpDown26.Value) / 2) + numericUpDown26.Value));
            }
            else
            {
                textBox5.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown28.Value - numericUpDown26.Value) / 2) + numericUpDown28.Value));
            }

            //Комната
            if (numericUpDown17.Value < numericUpDown19.Value)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown19.Value - numericUpDown17.Value) / 2) + numericUpDown17.Value));
            }
            else
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown19.Value - numericUpDown17.Value) / 2) + numericUpDown19.Value));
            }

            if (numericUpDown22.Value < numericUpDown18.Value)
            {
                textBox6.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown18.Value - numericUpDown22.Value) / 2) + numericUpDown22.Value));
            }
            else
            {
                textBox6.Text = Convert.ToString(Convert.ToInt32((Math.Abs(numericUpDown18.Value - numericUpDown22.Value) / 2) + numericUpDown18.Value));
            }

            ///////РАСЧЕТ ВЕРОЯТНОСТЕЙ///////
            double leftK = 2;
            double rightK = 0.5;

            double minL = 100;
            double maxL = 0;

            double minR = 100;
            double maxR = 0;

            int LminX = 0;
            int LminY = 0;
            int LmaxX = 0;
            int LmaxY = 0;

            int RminX = 0;
            int RminY = 0;
            int RmaxX = 0;
            int RmaxY = 0;

            ////ЧЕРЕЗ ЛЕВОЕ ОКНО
            double[] leftP = new double[100];

            for (int i = 0; i < 100; i++)
            {
                double left1 = Math.Sqrt(Math.Pow(MassY[i] - Convert.ToInt32(textBox4.Text), 2) + Math.Pow(MassX[i] - Convert.ToInt32(textBox1.Text), 2));
                double left2 = Math.Sqrt(Math.Pow(Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox6.Text), 2) + Math.Pow(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text), 2));

                leftP[i] = Math.Round(((leftK * rightK * Convert.ToInt32(numericUpDown30.Value)) / (left1 * left2)), 4);
            }

            for (int i = 0; i < 100; i++)
            {
                if (leftP[i] > maxL)
                {
                    maxL = leftP[i];

                    LmaxX = MassX[i];
                    LmaxY = MassY[i];
                }

                if (leftP[i] < minL)
                {
                    minL = leftP[i];

                    LminX = MassX[i];
                    LminY = MassY[i];
                }
            }

            ////ЧЕРЕЗ ПРАВОЕ ОКНО
            double[] rightP = new double[100];

            for (int i = 0; i < 100; i++)
            {
                double left1 = Math.Sqrt(Math.Pow(MassY[i] - Convert.ToInt32(textBox5.Text), 2) + Math.Pow(MassX[i] - Convert.ToInt32(textBox2.Text), 2));
                double left2 = Math.Sqrt(Math.Pow(Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox6.Text), 2) + Math.Pow(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text), 2));

                rightP[i] = Math.Round(((leftK * rightK * Convert.ToInt32(numericUpDown29.Value)) / (left1 * left2)), 4);
            }

            for (int i = 0; i < 100; i++)
            {
                if (rightP[i] > maxR)
                {
                    maxR = rightP[i];

                    RmaxX = MassX[i];
                    RmaxY = MassY[i];
                }

                if (rightP[i] < minR)
                {
                    minR = rightP[i];

                    RminX = MassX[i];
                    RminY = MassY[i];
                }
            }

            ///////СРАВНЕНИЕ ВЕРОЯТНОСТЕЙ///////
            Pen probMin = new Pen(Color.Aqua);
            Pen probMax = new Pen(Color.Purple);

            if (minL <= minR)
            {
                textBox10.Text = Convert.ToString(minL);
                graph.DrawLine(probMin, LminX, LminY, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text));
                graph.DrawLine(probMin, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text));
            }
            else
            {
                textBox10.Text = Convert.ToString(minR);
                graph.DrawLine(probMin, RminX, RminY, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text));
                graph.DrawLine(probMin, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text));
            }

            if (maxL >= maxR)
            {
                textBox9.Text = Convert.ToString(maxL);
                graph.DrawLine(probMax, LmaxX, LmaxY, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text));
                graph.DrawLine(probMax, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text));
            }
            else
            {
                textBox9.Text = Convert.ToString(maxR);
                graph.DrawLine(probMax, RmaxX, RmaxY, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text));
                graph.DrawLine(probMax, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text));
            }

            pictureBox1.Image = bmp;
        }

        

        private void button1_Click(object sender, EventArgs e)  //РАССЧИТАТЬ ВЕРОЯТНОСТЬ
        {
            Draw();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

       
    }
}
