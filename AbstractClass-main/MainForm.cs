using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass {
    public partial class MainForm : Form {
        List <Shape> shapes = new List<Shape>();
        public MainForm() {
            Text = Application.ProductName;
            InitializeComponent();
            shapes.Add(new Rectangle(Pens.Red, 20f, 20f, 60f, 40f));
            shapes.Add(new Rectangle(Pens.Green, 70f, 20f, 120f, 40f));
            shapes.Add(new Rectangle(Pens.Blue, 130f, 20f, 170f, 40f));
            PointF VertexA = new PointF(180f, 20f);
            PointF VertexB = new PointF(120f, 40f);
            PointF VertexC = new PointF(240f, 40f);
            shapes.Add(new Triangel(Pens.Blue, VertexA, VertexB, VertexC));
        } 
        private void MainForm_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < shapes.Count; i++) {
                shapes[i].Draw(e);
            }
        }
    }
}
