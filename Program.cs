using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djeljenje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neki broj ");
            int x =Convert.ToInt32( Console.ReadLine());
            if(x % 4 == 0) 
            {
                Console.WriteLine("Broj je djeljiv sa 4 ");
            }
            if (x % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6 ");
            }
            if (x % 4 == 0 && x % 6 == 0 )
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6 ");
            }
            if (x % 4 != 0 && x % 6 != 0 )
            {
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6 ");
            }
            Console.ReadKey();
        }
    }
}
