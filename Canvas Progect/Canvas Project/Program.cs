using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_Project
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[] coordinats = new int[12] {4, 770, 16, 720, 4, 560, 16, 471, 450, 18, 520, 5};
            for (int i=0; i<12;i++)
            {

               MyCanvas.CreateNewButton(coordinats[i++], coordinats[i++], coordinats[i++], coordinats[i]);
            }

            Client.CheckIfAnyButtonIsOverlapping();
            Console.ReadKey();
            Client.CreateNewButton(7, 751, 44, 701);
            Console.ReadKey();
            Client.MoveButton(4, 23, 115);
            Console.ReadKey();
            Client.ButtonСharacteristics();
            Console.ReadKey();
            Client.GetMaxNumberOfButtons();
            Console.ReadKey();
            Client.IsPointInsideAButton(499,11);
            Console.ReadKey();
            Client.DeleteLastButtons();
            Console.ReadKey();
            Client.ClearAllButtons();
            Console.ReadKey();
          
            /*for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Enter coordinats of top left by 'ENTER':");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter coordinats of buttom right by 'ENTER':");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());

                Client clnt = new Client(x1, y1, x2, y2);
            }*/
        }
    }
}
