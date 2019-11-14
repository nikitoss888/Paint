using System.Drawing;

namespace ShapesLibrary
{
    public class Point : Shape
    {
        public Point(Pen pen)
        {
            X1 = coord.Next(301);
            Y1 = coord.Next(301);
            Pen = pen;
        }
        public Point(int x1, int y1, Pen pen)
        {
            X1 = x1;
            Y1 = y1;
            Pen = pen;
        }
        public Point(Point obj, Pen pen)
        {
            X1 = obj.X1;
            Y1 = obj.Y1;
            Pen = pen;
        }
        public virtual void Set(int x1, int y1)
        {
            X1 = x1;
            Y1 = y1;
        }
        public override void Draw(Graphics draw)
        {
            draw.DrawEllipse(Pen, X1, Y1, 1, 1);
        }
        public override void CoordsChange(int dX, int dY)
        {
            X1 -= dX;
            Y1 -= dY;
        }
    }
}
