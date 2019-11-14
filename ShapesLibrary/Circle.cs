using System;
using System.Drawing;
namespace ShapesLibrary
{
    public class Circle : Point
    {
        protected int X2, Y2;
        protected int Radius;
        public Circle(Pen pen) : base(pen)
        {
            X2 = coord.Next(401);
            Y2 = coord.Next(401);
            Radius = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)) * 2;
        }
        public Circle(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {
            X2 = x2;
            Y2 = y2;
            Radius = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)) * 2;
        }
        public Circle(Circle obj, Pen pen) : base(obj, pen)
        {
            X2 = obj.X2;
            Y2 = obj.Y2;
            Radius = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)) * 2;
        }
        public virtual void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Radius = (int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)) * 2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1 - Radius / 2, Y1 - Radius / 2, Radius, Radius);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
}
