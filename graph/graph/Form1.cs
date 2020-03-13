using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using graph.models;


namespace graph
{
    public partial class Form1 : Form
    {
        private  ModelSquare _square;
        private  ModelRhombus _rhombus;
        bool start;
        //  private readonly ModelFigure [] figures;
        /// <summary>
        /// Длинна сторон фигур
        /// </summary>
        private int SizeSide = 120;

 
        private float SpeedFigure => trbFigSpeed.Value;


       
        private Graphics _graphic;

        public Form1()
        {
             
            InitializeComponent();
            start = false;
            _graphic = pictureBox1.CreateGraphics(); // Создание графического объекта
          //  figures = new ModelFigure[] { _square, _rhombus };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _square = new ModelSquare(SizeSide * 0.7f);
            _rhombus = new ModelRhombus(SizeSide);
            _rhombus.Direction = EnumDirection.Right;
            _square.Direction = EnumDirection.Right;

        }

        private byte colorInc(ModelFigure _figure)
        {
            try
            {
                double col = 255 * (_figure.CenterPoint.X - (SizeSide / 2) * Math.Cos(Math.PI / 6)) /
                             (pictureBox1.Width - SizeSide * Math.Cos(Math.PI / 6));
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        // Расчет убывающих цветовых координат
        private byte colorDec(ModelFigure _figure)
        {
            try
            {
                double col = -255 * ((_figure.CenterPoint.X - (SizeSide / 2) * Math.Cos(Math.PI / 6)) /
                                     (pictureBox1.Width - SizeSide * Math.Cos(Math.PI / 6))) + 255;
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e) =>Draw();
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Draw();
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
            Draw();
        }


        private void Moving(short vector, short offset, ModelFigure _figure)
        { 
            _figure.CenterPoint = new PointF((float)
                (_figure.CenterPoint.X+((offset)*85)+ (SpeedFigure * (vector))),
                (float)((pictureBox1.Height / 4.0f) * Math.Cos(_figure.CenterPoint.X * Math.PI / 180) +
                         (pictureBox1.Height / 2.0f)));
        }
        private void MoveAll(short vector, short offset)
        {
            Moving(vector, offset, _rhombus);
            Moving(vector, offset, _square);
        }
        private void Draw()
        {
            Brush br1 = new SolidBrush(Color.FromArgb(colorDec(_rhombus), colorDec(_rhombus), colorInc(_rhombus))); // кисть ромба
            Brush br2 = new SolidBrush(Color.FromArgb(colorInc(_square), colorDec(_square), colorInc(_square))); //кисть квадрата
            if (!start)
            {
                MoveAll(1, 1);
                start = true;
            }

            var offset = SizeSide * _rhombus.CoeffSize;
            if (_rhombus.CenterPoint.X + offset> pictureBox1.Width)
                _rhombus.Direction = EnumDirection.Left;
            if (_rhombus.CenterPoint.X -offset < 0)
                _rhombus.Direction = EnumDirection.Right;
            if (_rhombus.Direction == EnumDirection.Right)
                MoveAll(1, 0);
            else
                MoveAll(-1, 0);

            _graphic.Clear(SystemColors.Control); // стирание
            _graphic.FillPolygon(br1, _rhombus.RenderPoints());
            _graphic.FillPolygon(br2, _square.RenderPoints());
            lblXcYc.Text =
                String.Format("X: {0:0.00}, Y: {1:0.00}",
                    _rhombus.CenterPoint.X,
                    _rhombus.CenterPoint.Y); // вывод координат центра тяжести точки
        }

        private void trbFigSize_Scroll(object sender, EventArgs e)
        {
            _rhombus.CoeffSize = trbFigSize.Value/10f;
            _square.CoeffSize = trbFigSize.Value/10f;
        }

        private void trbFigRotRate_Scroll(object sender, EventArgs e)
        {
            _rhombus.AngleRotate = trbFigRotRate.Value;
            _square.AngleRotate = trbFigRotRate.Value;
        }
    }
}
