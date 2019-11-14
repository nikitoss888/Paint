using System.Drawing;
using System;

namespace ShapesLibrary
{
    public abstract class Shape
    {
        protected int X1, Y1;
        protected Random coord = new Random();
        protected Pen Pen;
        abstract public void Draw(Graphics draw);
        abstract public void CoordsChange(int dX, int dY);
    }
}
