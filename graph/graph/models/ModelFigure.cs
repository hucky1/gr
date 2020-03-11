
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace graph.models
{
    public abstract class ModelFigure
    {
        public List<PointF> Points { get; private set; }

        public EnumDirection Direction { get; set; }

        protected List<PointF> RotatePoints(List<PointF> points, float angle)
        {
            var cosAngle = (float)Math.Cos(GetAngleRadian(angle));
            var sinAngle = (float)Math.Sin(GetAngleRadian(angle));
            Points = points.Select(point => RotatePoint(point, cosAngle, sinAngle)).ToList();
            return Points;
        }

        public void RotateFigure(float angle)
        {
            RotatePoints(Points, angle);
        }

      
        private static PointF RotatePoint(PointF p, float cos, float sin)
        {
            var x = p.X * cos - p.Y * sin;
            var y = p.Y * cos + p.X * sin;
            return new PointF(x, y);
        }

        private static float GetAngleRadian(float angle)
            => (float)(angle * Math.PI / 180f);

        protected abstract List<PointF> GetPoints();

        public PointF[] RenderPoints()
        {
            RotateFigure(AngleRotate);
            var newPosition = Points.Select(f => SumPoints(f, CenterPoint));
            return newPosition.ToArray();
        }

        protected static PointF SumPoints(PointF a, PointF b)
            => new PointF(a.X + b.X, a.Y + b.Y);


       public PointF CenterPoint { get; set; }
        public float AngleRotate { get; set; }

        /// <summary>
        /// Для получения базовых координат фигуры
        /// </summary>
        protected void ReRerenderFigure()
        {
            Points = GetPoints();
        }
        protected abstract PointF CenterFigure { get; }
        
       
    }
}
