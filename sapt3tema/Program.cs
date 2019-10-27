using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapt3tema
{
    class Program
    {
        static void Main(string[] args)
        {
            int an;
            Console.WriteLine("Introduceti un an:");
            an = int.Parse(Console.ReadLine());
            if ((an % 400) == 0)
            {
                Console.WriteLine("Anul {0} este an bisect", an);
                Console.ReadLine();
            }
            else if ((an % 100) == 0)
            {
                Console.WriteLine("Anul {0}  nu este an bisect", an);
                Console.ReadLine();
            }
            else if((an% 4) == 0)
            {
                Console.WriteLine("Anul {0} este an bisect", an);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Anul {0} nu este an bisect", an);
                Console.ReadLine();
            }
        }
  
    }
   
}
