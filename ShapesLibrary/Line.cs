using System.Drawing;

namespace ShapesLibrary
{
    public class Line : Point
    {
        protected int X2, Y2;
        public Line(Pen pen) : base(pen)
        {
            X2 = coord.Next(301);
            Y2 = coord.Next(301);
        }
        public Line(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {
            X2 = x2;
            Y2 = y2;
        }
        public Line(Line obj, Pen pen) : base(obj, pen)
        {
            X2 = obj.X2;
            Y2 = obj.Y2;
        }
        public virtual void Set(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y2 = y2;
            X2 = x2;
            Y2 = y2;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawLine(Pen, X1, Y1, X2, Y2);
        }
        public override void CoordsChange(int dX, int dY)
        {
            base.CoordsChange(dX, dY);
            X2 -= dX;
            Y2 -= dY;
        }
    }
}
