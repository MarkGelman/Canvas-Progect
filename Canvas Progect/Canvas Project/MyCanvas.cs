using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    public class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;
        private static int _buttonIndex = 0;
        private static int MaxButtons = 3;
        private static MiButton[] buttons = new MiButton[MaxButtons];

        
        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (_buttonIndex != MaxButtons)
            {
               
                Point topLeft = new Point(x1, y1);
                Point buttonTopRight = new Point(x2, y2);
                MiButton button = new MiButton(topLeft, buttonTopRight);
                buttons[_buttonIndex] = button;
                _buttonIndex++;
                return true;
            }
            return false;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            if (buttonNumber < 3 && buttonNumber >= 0 && buttons[buttonNumber] != null)
            {
                int x1 = buttons[buttonNumber].GetTopLeft().GetX() + x;
                int y1 = buttons[buttonNumber].GetTopLeft().GetX() + y;
                int x2 = buttons[buttonNumber].GetBottomRight().GetX() + x;
                int y2 = buttons[buttonNumber].GetBottomRight().GetX() + y;
                                                
                buttons[buttonNumber].GetTopLeft().SetX(x1);
                buttons[buttonNumber].GetTopLeft().SetY(y1);
                buttons[buttonNumber].GetBottomRight().SetX(x2);
                buttons[buttonNumber].GetBottomRight().SetY(y2);
                return true;
            }
            return false;  
        }

        public static bool DeleteLastButtons()
        {
            _buttonIndex = _buttonIndex == MaxButtons ? _buttonIndex = MaxButtons -1 : _buttonIndex;
            if (buttons.Length != 0)
            {
                buttons[_buttonIndex] = null;
                _buttonIndex--;
                return true;
            }
            return false;
        }

        public static bool ClearAllButtons()
        {
            if (_buttonIndex != 0)
            {
                for (int i = 0; i < MaxButtons;i++)
                    buttons[i] = null;
                _buttonIndex = 0;
                return true;
            }
            return false;
        }

        public static int GetCurrentNumberOfButtons()
        {
            return _buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOFAButton()
        {
            int maxWidth = 0;
            for (int i = 0; i < MaxButtons; i++)
            {
                if (buttons[i] != null)
                    maxWidth = buttons[i].GetWidth() > maxWidth ? maxWidth = buttons[i].GetWidth() : maxWidth;
            }
            return maxWidth;
        }

        public static int GetTheMaxHeightOFAButton()
        {
            int maxHeight = 0;
            for (int i = 0; i < MaxButtons; i++)
            {
                if (buttons[i] != null)
                    maxHeight = buttons[i].GetHeight() > maxHeight ? maxHeight = buttons[i].GetWidth() : maxHeight;
            }
            return maxHeight;
        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            for (int i =0 ; i < MaxButtons;i++)
            {
                if (buttons[i] != null)
                { 
                    if (buttons[i].GetTopLeft().GetX() < x && x < buttons[i].GetBottomRight().GetX()
                           && buttons[i].GetTopLeft().GetY() > y && y > buttons[i].GetBottomRight().GetY())
                        return true;
                       
                }
            }
            return false;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
     
            for (int i = 0; i< MaxButtons; i++)
            {
                if (buttons[i] != null)
                {
                   if (IsPointInsideAButton(buttons[i].GetBottomRight().GetX(), buttons[i].GetBottomRight().GetY()))
                        return true;
                   if (IsPointInsideAButton(buttons[i].GetTopLeft().GetX(), buttons[i].GetTopLeft().GetY()))
                        return true;
                   if (IsPointInsideAButton(buttons[i].GetTopLeft().GetX(), buttons[i].GetBottomRight().GetY()))
                        return true;
                   if (IsPointInsideAButton(buttons[i].GetBottomRight().GetX(), buttons[i].GetTopLeft().GetY()))
                        return true;
                }
            }
            return false;
        }

        public static void Print ()
        {
            for (int i = 0; i<MaxButtons;i++)
            {
                if (buttons[i] != null)
                    Console.WriteLine($"Button_{i}:\n   Height{i} = {buttons[i].GetHeight()}\n  Width{i} = {buttons[i].GetWidth()}");
                Console.WriteLine("");
            }
            
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
