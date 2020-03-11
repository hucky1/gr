using System.Collections.Generic;
using System.Drawing;

namespace graph.models
{
    public class ModelSquare: ModelFigure
    {
        //
        // Oy
        // |
        // |  0,0    side,0
        // |
        // |
        // |
        // |
        // |  0,side  side,side
        // _______________→ Ox

        /// <summary>
        /// Длинна стороны
        /// </summary>
        private float _side;

        public double Side => _side;

        public ModelSquare(float side)
        {
            _side = side;
            ReRerenderFigure();
        }

        protected override List<PointF> GetPoints()
        {
            var square = new List<PointF>();

          
            var halfSize = _side / 2.0f;
            square.Add(new PointF(-halfSize, -halfSize));
            square.Add(new PointF(halfSize, -halfSize));
            square.Add(new PointF(halfSize, halfSize));
            square.Add(new PointF(-halfSize, halfSize));

            return square;
        }

        protected override PointF CenterFigure => new PointF(120 / 2f, 120 / 2f);
    }
}
