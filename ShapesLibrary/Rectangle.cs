using System;
using System.Drawing;

namespace ShapesLibrary
{
    public class Rectangle : Line
    {
        protected int Width, Height;
        public Rectangle(Pen pen) : base(pen)
        {
            Width = Math.Abs(X1 - X2);
            Height = Math.Abs(Y1 - Y2);
        }
        public Rectangle(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, x2, y2, pen)
        {
            Width = Math.Abs(X1 - X2);
            Height = Math.Abs(Y1 - Y2);
        }
        public Rectangle(Rectangle obj, Pen pen) : base(obj, pen)
        {
            Width = Math.Abs(X1 - obj.X2) - 1;
            Height = Math.Abs(Y1 - obj.Y2) - 1;
        }
        public override void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y2 = y2;
            X2 = x2;
            Y2 = y2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawRectangle(Pen, X1, Y1, Width, Height);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
}
