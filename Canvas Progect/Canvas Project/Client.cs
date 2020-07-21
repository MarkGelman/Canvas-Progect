using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    internal class Client
    {
        static bool _flag = false;

        internal static void CheckIfAnyButtonIsOverlapping()
        {
            _flag = MyCanvas.CheckIfAnyButtonIsOverlapping();
            if (_flag)
            {
                Console.WriteLine("Button is over lapping!!!");
            }
            else
                Console.WriteLine("Button isn`t over lapping!!!");

        }

        public static void CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (MyCanvas.CreateNewButton(x1, y1, x2, y2))
            {
                Console.WriteLine("Button is create successfully!!!");
            }
            else
                Console.WriteLine("Error!!! There is no free space !!!");
        }

        public static void MoveButton(int buttonNumber, int x, int y)
        {
            if (MyCanvas.MoveButton(buttonNumber, x, y))
            {
                Console.WriteLine("Button is moved  successfully!!!");
            }
            else
                Console.WriteLine("Error!!!Button isn`t moved!!!");
        }

        public static void DeleteLastButtons()
        {
            if (MyCanvas.DeleteLastButtons())
            {
                Console.WriteLine("Button is deleted!!!");
            }
            else
                Console.WriteLine("Deletion was not done ,because no buttons have been created!!!");
        }

        public static void ClearAllButtons()
        {
            if (MyCanvas.ClearAllButtons())
            {
                Console.WriteLine("All buttons is deleted!!!");
            }
            else
                Console.WriteLine("Deletion was not done because No buttons have been created!!!");
        }

        public static void ButtonСharacteristics()
           
        {
                 MyCanvas.Print();
        }

        public static void GetMaxNumberOfButtons()
        {
            Console.WriteLine($"Number of buttons is {MyCanvas.GetMaxNumberOfButtons()}");
        }

      
        public static void IsPointInsideAButton(int x, int y)
        {
            _flag = MyCanvas.IsPointInsideAButton(x,y);
            if (_flag)
            {
                Console.WriteLine("The point is inside a button!!!");
            }
            else
                Console.WriteLine("The point isn`t inside a button!!!");
        }

       
      



    }
}