using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    internal class Point
    {
        int _x, _y;
        internal int GetX()
        {
            return _x;
        }

        internal void SetX (int x)
        {
            if (x < 0 && x > MyCanvas.MAX_WIDTH)
                Console.WriteLine( $"Entered data is not correct:{x}");
            else
                _x = x;
        }

        internal int GetY ()
        {
            return _y;
        }

        internal void SetY (int y)
        {
            if (y < 0 && y > MyCanvas.MAX_HEIGHT)
                Console.WriteLine($"Entered data is not correct:{y}");
            else
                _y = y;
        }
        internal Point (int x, int y)
        {
           SetX(x);
           SetY(y);
        }

        /*public override string ToString ()
        {
            return "Entered data is not correct:";
        }*/

    }
}

