using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using moving.Models;

namespace moving
{
    public partial class Form1 : Form
    {
        private readonly ModelSquare _square;
        private readonly ModelRhombus _rhombus;

        private double freq = 0.04;

        /// <summary>
        /// Длинна сторон фигур
        /// </summary>
        const int SizeSide = 120;

        double dx = 0.1; //приращение по х при движении

        private float SpeedFigure => trbFigSpeed.Value;

        double fi; // угол, на который фигура поворачивается при обновлении таймера
        double c_fi = 0; // угол, на который фигура повернулась

        /// <summary>
        /// Скорость вращения
        /// </summary>
        private float RotationRate => trbFigRotRate.Value / 10f;

        StreamWriter file;
        private Graphics _graphic;

        public Form1()
        {
            _square = new ModelSquare(SizeSide);
            _rhombus = new ModelRhombus(SizeSide);

            InitializeComponent();
            _graphic = pictureBox1.CreateGraphics(); // Создание графического объекта
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trbFigRotRate.Value = 10;
            trbFigSize.Value = SizeSide;
            trbFigSpeed.Value = 1;

            file = new StreamWriter("D:\\TestFile.txt");
        }

        private byte colorInc()
        {
            try
            {
                double col = 255 * (_rhombus.CenterPoint.X - (SizeSide / 2) * Math.Cos(Math.PI / 6)) /
                             (pictureBox1.Width - SizeSide * Math.Cos(Math.PI / 6));
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        // Расчет убывающих цветовых координат
        private byte colorDec()
        {
            try
            {
                double col = -255 * ((_rhombus.CenterPoint.X - (SizeSide / 2) * Math.Cos(Math.PI / 6)) /
                                     (pictureBox1.Width - SizeSide * Math.Cos(Math.PI / 6))) + 255;
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e) => Draw();


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_rhombus.CenterPoint.X + _rhombus.Side > pictureBox1.Width)
                _rhombus.Direction = EnumDirection.Left; //меняем направление 
            if (_rhombus.CenterPoint.X < 0)
                _rhombus.Direction = EnumDirection.Right;

            _rhombus.AngleRotate = _rhombus.AngleRotate + RotationRate;
            _square.AngleRotate = _square.AngleRotate + RotationRate;


            Draw(); //перерисовываем фигуру   

            freq += 0.01;
        }

        private void btnStart_Click(object sender, EventArgs e) => timer1.Start();

        private void btnDefaultA_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) //проверка включенности таймера(true-таймер выключен)
            {
                Draw();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            c_fi = 0;
            Draw();
            file.Close();
        }

        private void Draw()
        {
            Brush br1 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc())); // кисть ромба
            Brush br2 = new SolidBrush(Color.FromArgb(colorInc(), colorDec(), colorInc())); //кисть квадрата

            _rhombus.CenterPoint = new PointF((float)
                (_rhombus.CenterPoint.X + SpeedFigure),
                (float) ((pictureBox1.Height / 4.0f) * Math.Cos(_rhombus.CenterPoint.X * Math.PI / 180) +
                         (pictureBox1.Height / 2.0f)));


            _graphic.Clear(SystemColors.Control); // стирание
            _graphic.FillPolygon(br2, _rhombus.RenderPoints());
            _graphic.FillPolygon(br1, _square.RenderPoints());


            //file.WriteLine(String.Format("xc = {0}; xy = {1};  00 = {2}; 01 = {3}; 10 = {4}; 11 = {5}", xc,yc  ,square[0], square[1], square[2], square[3]));

            lblXcYc.Text =
                String.Format("X: {0:0.00}, Y: {1:0.00}",
                    _rhombus.CenterPoint.X,
                    _rhombus.CenterPoint.Y); // вывод координат центра тяжести точки
        }
    }
}