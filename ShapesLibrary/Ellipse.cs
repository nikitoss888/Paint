using System;
using System.Drawing;

namespace ShapesLibrary
{
    public class Ellipse : Circle
    {
        protected int Radius2;
        public Ellipse(Pen pen) : base(pen)
        {
            Radius = Math.Abs(X2 - X1) * 2;
            Radius2 = Math.Abs(Y2 - Y1) * 2;
        }
        public Ellipse(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, x2, y2, pen)
        {
            Radius = Math.Abs(X2 - X1) * 2;
            Radius2 = Math.Abs(Y2 - Y1) * 2;
        }
        public Ellipse(Ellipse obj, Pen pen) : base(obj, pen)
        {
            Radius = Math.Abs(X2 - X1) * 2;
            Radius2 = Math.Abs(Y2 - Y1) * 2;
        }
        public override void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Radius = Math.Abs(X2 - X1) * 2;
            Radius2 = Math.Abs(Y2 - Y1) * 2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1 - Radius / 2, Y1 - Radius2 / 2, Radius, Radius2);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
}
