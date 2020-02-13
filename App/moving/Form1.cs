using System;
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
        const int default_a = 120;
        double i =1;
        int dir = 1; //направление движения по молчанию вперед
        double dx = 0.1; //приращение по х при движении
        double xc, yc; //координаты центра
        int a; //размер фигуры и координаты центра
        int v = 1; //скорость движения
        Point[] p1 = new Point[4]; //массив точек для ромба
        Point[] p2 = new Point[4]; //массив точек для квадрата
        double[] x = new double[8];
        double[] y = new double[8];
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
        private double[] x_rot(double[] x0, double[] y0)
        {
            double[] x1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x1[i] = (x0[i]) * Math.Cos(c_fi) - (y0[i]) * Math.Sin(c_fi);
            }
            return x1;
        }

        // Расчет координат y точек при вращении
        private double[] y_rot(double[] x0, double[] y0)
        {
            double[] y1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y1[i] = (x0[i]) * Math.Sin(c_fi) + (y0[i]) * Math.Cos(c_fi);
            }
            return y1;
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
            // yc = ((pictureBox1.Height -2*a)/2* Math.Sin(i)-200); //движение по синусоиде   
            yc = pictureBox1.Height  + ((pictureBox1.Height - 4 * a)) * Math.Sin(0.04 * (xc - a / 2));
            i +=0.05;

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

            //рассчет координат точек фигуры относительно центра
            //квадрат
            x[0] = Convert.ToInt32((xc+a / 4));
            y[0] = Convert.ToInt32(yc+pictureBox1.Height - ((a / 2) + (a / 4)))-500;
            x[1] = Convert.ToInt32((xc+a / 2) + (a / 4));
            y[1] = Convert.ToInt32(yc+pictureBox1.Height - ((a / 2) + (a / 4)))-500;
            x[2] = Convert.ToInt32((xc+a / 2) + (a / 4));
            y[2] = Convert.ToInt32(yc+pictureBox1.Height - (a / 4))-500;
            x[3] = Convert.ToInt32(xc+a / 4);
            y[3] = Convert.ToInt32(yc+pictureBox1.Height - (a / 4))-500;
            //ромб
            x[4] = Convert.ToInt32(xc+a / 2);
            y[4] = Convert.ToInt32(yc+pictureBox1.Height - a)-500;
            x[5] = Convert.ToInt32(xc+a);
            y[5] = Convert.ToInt32(yc+pictureBox1.Height - (a / 2))-500;
            x[6] = Convert.ToInt32(xc+a / 2);
            y[6] = Convert.ToInt32(yc+pictureBox1.Height)-500;
            x[7] = Convert.ToInt32(xc+0);
            y[7] = Convert.ToInt32(yc+pictureBox1.Height - (a / 2))-500;

            
            double[] temp = new double[8];
            temp = x; //копируем массив x во временную переменную         
           x = x_rot(temp, y);
            y = y_rot(temp, y);

            //заполняем массив точек квадрата
            p1[0] = new Point((int)(x[0]), (int)(y[0]));
            p1[1] = new Point((int)(x[1]), (int)(y[1]));
            p1[2] = new Point((int)(x[2]), (int)(y[2]));
            p1[3] = new Point((int)(x[3]), (int)(y[3]));

            //заполняем массив точек ромба
            p2[0] = new Point((int)(x[4]), (int)(y[4]));
            p2[1] = new Point((int)(x[5]), (int)(y[5]));
            p2[2] = new Point((int)(x[6]), (int)(y[6]));
            p2[3] = new Point((int)(x[7]), (int)(y[7]));


            g.FillPolygon(br2, p2);
            g.FillPolygon(br1, p1);
            lblXcYc.Text = String.Format("X: {0:0.00}, Y: {1:0.00}", xc, yc); // вывод координат центра тяжести точки
        }
    }
}
