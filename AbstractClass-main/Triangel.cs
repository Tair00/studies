using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractClass {
    public class Triangel : Shape {
        float a, b, c;
   
        public override float Area()
        {
            float p = Perimetr() / 2;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        public override float Perimetr() { 
            return a + b + c;
        }
        public Triangel(Pen pen, PointF VertexA, PointF VertexB, PointF VertexC) {
            MyPen = pen;
            Vertexes.Add(VertexA);
            Vertexes.Add(VertexB);
            Vertexes.Add(VertexC);
            float a = (float)Math.Sqrt((2 * (VertexA.X - VertexB.X)) + (2 * (VertexA.Y - VertexB.Y)));
            float b = (float)Math.Sqrt((2 * (VertexB.X - VertexC.X)) + (2 * (VertexB.Y - VertexC.Y)));
            float c = (float)Math.Sqrt((2 * (VertexC.X - VertexA.X)) + (2 * (VertexC.Y - VertexA.Y)));
        }
    }
}










