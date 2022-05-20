using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass {
    public abstract class Shape {
        protected List<PointF> Vertexes = new List<PointF>();
       
        protected Pen MyPen;
        
        public abstract float Area();
        public abstract float Perimetr();

        public void Draw(PaintEventArgs e) {    

            for (int i = 0; i < Vertexes.Count; i++) {
                PointF NextPoint;
                if (i == Vertexes.Count - 1) {
                    NextPoint = Vertexes[0];
                } else {
                    NextPoint = Vertexes[i + 1];
                }
                e.Graphics.DrawLine(MyPen, Vertexes[i], NextPoint);
            }
        }
    }
}
