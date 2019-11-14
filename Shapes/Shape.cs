using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shapes
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
