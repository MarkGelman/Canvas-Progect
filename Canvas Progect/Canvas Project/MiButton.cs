using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
   internal class MiButton
    {
        protected Point _topLeft;
        internal bool SetTopLeft(Point topLeft,Point bottomRight)
        {
                _topLeft = topLeft;
                return true;
        }
        internal Point GetTopLeft()
        {
            return _topLeft;
        }

        protected Point _bottomRight;
        internal bool SetBottomRight(Point bottomRight)
        {
            _bottomRight = bottomRight;
            _height = _topLeft.GetY() - _bottomRight.GetY();
            _width= _bottomRight.GetX() -  _topLeft.GetX();
            return true;
        }

        internal Point GetBottomRight()
        {
            return _bottomRight;
        }

        private int _width;
        internal int GetWidth ()
        {
            return _width;
        }
        private int _height;
        internal int GetHeight()
        {
            return _height;
        }
        
        public MiButton(Point topLeft,Point bottomRight)
        {
           if(!SetTopLeft(topLeft,bottomRight))
                Console.WriteLine("Coordinates of points are not correct!!!"); ;
           SetBottomRight(bottomRight);
        }

       /* public override string ToString()
        {
            return $"top left = {_topLeft}  bottom right {_bottomRight} height {_height} width {_width}";
        }*/
    }
}
