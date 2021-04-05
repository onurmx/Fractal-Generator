using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalGenerator
{
    public class FractalClass
    {
        public static List<PointF[]> ListOfTriangles = new List<PointF[]>();

        public static void CalculateTriangle(int Step, PointF TopPoint, PointF LeftPoint, PointF RightPoint)
        {
            if (Step == 0)
            {
                PointF[] points = { TopPoint, RightPoint, LeftPoint };
                ListOfTriangles.Add(points);
            }
            else
            {
                PointF LeftMidPoint = new PointF((TopPoint.X + LeftPoint.X) / 2f, (TopPoint.Y + LeftPoint.Y) / 2f);
                PointF RightMidPoint = new PointF((TopPoint.X + RightPoint.X) / 2f, (TopPoint.Y + RightPoint.Y) / 2f);
                PointF BottomMidPoint = new PointF((LeftPoint.X + RightPoint.X) / 2f, (LeftPoint.Y + RightPoint.Y) / 2f);

                CalculateTriangle(Step - 1, TopPoint, LeftMidPoint, RightMidPoint);
                CalculateTriangle(Step - 1, LeftMidPoint, LeftPoint, BottomMidPoint);
                CalculateTriangle(Step - 1, RightMidPoint, BottomMidPoint, RightPoint);
            }
        }
    }
}
