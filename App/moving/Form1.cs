﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moving
{
    public partial class Form1 : Form
    {
        public List<PointF> square = new List<PointF>();
        public List<PointF> rhombus = new List<PointF>();
        const int default_a = 120;
        int dir = 1; //направление движения по молчанию вперед
        double dx = 0.1; //приращение по х при движении
        double xc, yc; //координаты центра
        int a; //размер фигуры и координаты центра
        int v = 1; //скорость движения
        PointF[] p1 = new PointF[4]; //массив точек для ромба
        PointF[] p2 = new PointF[4]; //массив точек для квадрата
 
        double fi; // угол, на который фигура поворачивается при обновлении таймера
        double c_fi = 0; // угол, на который фигура повернулась
        int rotation_rate = 1; // скорость вращения
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            a = default_a; // задаем размер фигуры
                           // Вычисляем координаты центра, чтобы фигура находилась в левом нижнем углу
                           // pictureBox1.W6idth и pictureBox1.Height - ширина и высота pictureBox
            xc = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 6));
            yc = Convert.ToInt32(pictureBox1.Height - a / 2.0);
            fi = 3 * dir * Math.PI / 180;
            // начальное положение ползунков
            trbFigRotRate.Value = rotation_rate;
            trbFigSize.Value = a;
            trbFigSpeed.Value = v;
        }
        static private PointF RotatePoint(PointF p, float angle)
        {
            var c = (float)Math.Cos((double)angle);
            var s = (float)Math.Sin((double)angle);
            var x = p.X;
            var y = p.Y;

            return new PointF(
                x * c - y * s,
                x * s + y * c
            );
        }

        public void RotateRom(float angle)
        { 
            rhombus = new List<PointF>(rhombus.Select(p => RotatePoint(p, angle)));
        }
        public void Rotate(float angle)
        {
           square = new List<PointF>(square.Select(p => RotatePoint(p, angle))); 
        }

        public void RotateRom(float angle, PointF pivot)
        {          
            rhombus = new List<PointF>(rhombus.Select(p => new PointF(p.X - pivot.X, p.Y - pivot.Y)));
            Rotate(angle);
            rhombus = new List<PointF>(rhombus.Select(p => new PointF(p.X + pivot.X, p.Y + pivot.Y)));
        }

        public void Rotate(float angle, PointF pivot)
        {
           square = new List<PointF>(square.Select(p => new PointF(p.X - pivot.X, p.Y - pivot.Y)));
            Rotate(angle);
          square = new List<PointF>(square.Select(p => new PointF(p.X + pivot.X, p.Y + pivot.Y)));
          
        }

        private byte colorInc()
        {
            try
            {
                double col = 255 * (xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                    (pictureBox1.Width - a * Math.Cos(Math.PI / 6));
                return Convert.ToByte(col);
            }
            catch { return 0; }
        }

        // Расчет убывающих цветовых координат
        private byte colorDec()
        {
            try
            {
                double col = -255 * ((xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                                  (pictureBox1.Width - a * Math.Cos(Math.PI / 6))) + 255;
                return Convert.ToByte(col);
            }
            catch { return 0; }
        }
        private void btnDraw_Click(object sender, EventArgs e) => Draw();

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xc+a > pictureBox1.Width)       
                dir = -1;//меняем направление 
            if (xc < 0)
                dir = 1;

            c_fi += fi * rotation_rate;

            Draw(); //перерисовываем фигуру   

            dx = v * dir; //приращение координаты зависит от направления и скорости       
            fi = 1 * dir * Math.PI / (180); //угол меняет направление         
            xc = xc + dx;
            yc = pictureBox1.Height  + ((pictureBox1.Height - 4 * a)) * Math.Sin(0.04 * (xc - a / 2));

        }

        private void btnStart_Click(object sender, EventArgs e) => timer1.Start();
      

        private void trbFigRotRate_Scroll(object sender, EventArgs e)
        {
            rotation_rate = trbFigRotRate.Value;
        }

        private void trbFigSpeed_Scroll(object sender, EventArgs e)
        {
            v = trbFigSpeed.Value;
        }

        private void btnDefaultA_Click(object sender, EventArgs e)
        {
            a = default_a;
            if (!timer1.Enabled) //проверка включенности таймера(true-таймер выключен)
            {
                xc = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 6));
                yc = Convert.ToInt32(pictureBox1.Height - a / 2.0);
                Draw();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            xc = Convert.ToInt32((a / 2.0) * Math.Cos(Math.PI / 6));
            yc = Convert.ToInt32(pictureBox1.Height - a / 2.0);
            c_fi = 0;
            Draw();
        }

        private void trbFigSize_Scroll(object sender, EventArgs e)
        {
            a = trbFigSize.Value;
        }

        private void Draw()
        {
            Graphics g = pictureBox1.CreateGraphics(); // Создание графического объекта
            Brush br1 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc())); // кисть ромба
            Brush br2 = new SolidBrush(Color.FromArgb(colorInc(), colorDec(), colorInc())); //кисть квадрата
            g.Clear(SystemColors.Control); // стирание

            square.Add(new PointF((float)(xc + a / 4), (float)(yc + pictureBox1.Height - ((a / 2) + (a / 4)) - 500)));
            square.Add(new PointF((float)((xc + a / 2) + (a / 4)), (float)(yc + pictureBox1.Height - ((a / 2) + (a / 4)) - 500)));
            square.Add(new PointF((float)((xc + a / 2) + (a / 4)), (float)(yc + pictureBox1.Height - (a / 4) - 500)));
            square.Add(new PointF((float)(xc + a / 4), (float)(yc + pictureBox1.Height - (a / 4) - 500)));

           rhombus.Add(new PointF((float)(xc + a / 2), (float)(yc + pictureBox1.Height - a - 500)));
           rhombus.Add(new PointF((float)(xc + a), (float)yc + pictureBox1.Height - (a / 2) - 500));
           rhombus.Add(new PointF((float)(xc + a / 2), (float)(yc + pictureBox1.Height - 500)));
           rhombus.Add(new PointF((float)(xc), (float)(yc + pictureBox1.Height - (a / 2) - 500)));

          //  Rotate((float)trbFigRotRate.Value, new PointF((float)(xc), (float)(yc)));
           // RotateRom((float)trbFigRotRate.Value, new PointF((float)(xc), (float)(yc)));

            PointF[] sqArr = square.ToArray();
            PointF[] romArr = rhombus.ToArray();


          
            g.FillPolygon(br2, romArr);
            g.FillPolygon(br1, sqArr);

            lblXcYc.Text = String.Format("X: {0:0.00}, Y: {1:0.00}", xc, yc); // вывод координат центра тяжести точки
        }
    }
}