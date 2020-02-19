using System.Collections.Generic;
using System.Drawing;

namespace moving.Models
{
    public class ModelRhombus : ModelSquare
    {
        public ModelRhombus(float side) : base(side)
        {
            ReRerenderFigure();
        }


        protected override List<PointF> GetPoints()
        {
            var squarePoints = base.GetPoints();
            var rhombus = RotatePoints(squarePoints, 45);
            return rhombus;
        }
    }
}