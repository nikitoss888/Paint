using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace OOPDrawNew
{
    public partial class Form1 : Form
    {
        protected List<Shape> Shapes = new List<Shape>();
        protected Pen Pen;
        protected Mode Mode;
        protected int MouseX, MouseY;
        protected Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            buttonColor.BackColor = Color.Black;
            graphics = pictureBox.CreateGraphics();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }

        private void buttonCircle_Click_1(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseX != e.X)
            {
                switch (Mode)
                {
                    case Mode.DrawPoint:
                        break;
                    case Mode.DrawLine:
                        Shapes.Add(new Line(MouseX, MouseY, e.X, e.Y, 
                            Pen = new Pen(buttonColor.BackColor, 2)));
                        listBoxShapes.Items.Add("Линия");
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawRectangle:
                        Shapes.Add(new ShapesLibrary.Rectangle(MouseX, MouseY, e.X, e.Y,
                            Pen = new Pen(buttonColor.BackColor, 2)));
                        listBoxShapes.Items.Add("Прямоугольник");
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawCircle:
                        Shapes.Add(new Circle(MouseX, MouseY, e.X, e.Y,
                            Pen = new Pen(buttonColor.BackColor, 2)));
                        listBoxShapes.Items.Add("Круг");
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawEllipse:
                        Shapes.Add(new Ellipse(MouseX, MouseY, e.X, e.Y,
                            Pen = new Pen(buttonColor.BackColor, 2)));
                        listBoxShapes.Items.Add("Эллипс");
                        pictureBox.Refresh();
                        break;
                }
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    Shapes.Add(new ShapesLibrary.Point(e.X, e.Y,
                            Pen = new Pen(buttonColor.BackColor, 2)));
                    listBoxShapes.Items.Add("Точка");
                    pictureBox.Refresh();
                    break;
                default:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Remove();
        }
        private void Remove()
        {
            int index;
            for(int i = 0; i < Shapes.Count; i++)
            {
                if (listBoxShapes.SelectedIndex == i)
                {
                    index = listBoxShapes.SelectedIndex;
                    listBoxShapes.Items.RemoveAt(index);
                    Shapes.RemoveAt(index);
                    pictureBox.Refresh();
                    i--;
                }
            }
            if (listBoxShapes.Items.Count > 0)
            {
                listBoxShapes.SetSelected(0, true);
            }
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw(e.Graphics);
            }
        }

    }
}
