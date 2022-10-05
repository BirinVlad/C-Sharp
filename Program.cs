using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //x - значення Х
            //y - значення У
            int x, y;
            
            Console.WriteLine("Введiть значення X : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть значення Y : ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0) {
                Console.WriteLine("Належить першому квадранту.");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Належить третьому квадранту.");
            }
            if((x < 0 && y >0)||(x > 0 && y < 0))
            {
                Console.WriteLine("Неправельно !!!");
            }
            Console.ReadLine();
        }
    }
}
