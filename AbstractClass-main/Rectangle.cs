using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractClass
{
    public class Rectangle : Shape
    {

        float SideA, SideB;

        public override float Area()
        {

            return SideA * SideB;
        
        }
        public override float Perimetr()
        {
            return (SideA + SideB) * 2;
        }

        public Rectangle(Pen pen, float x1, float y1, float x2, float y2)
        {

            MyPen = pen;
            Vertexes.Add(new PointF(x1, y1));
            Vertexes.Add(new PointF(x2, y1));
            Vertexes.Add(new PointF(x2, y2));
            Vertexes.Add(new PointF(x1, y2));
            SideA = x2 - x1;
            if (SideA < 0)
            {
                SideA = -SideA;
            }
            SideB = y2 - y1;
            if (SideB < 0)
            {
                SideB = -SideB;
            }
        
        }

    }

}