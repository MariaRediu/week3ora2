using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapt3tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnBisesct();

            string text1 = System.IO.File.ReadAllText(@"C:\Users\Maria\source\repos\week3ora22\File1.txt");
            
            string[] linii = System.IO.File.ReadAllLines(@"C:\Users\Maria\source\repos\week3ora22\File1.txt");

            int valoare1 = int.Parse(linii[0]);
            int valoare2 = int.Parse(linii[1]);
            int suma = valoare1 + valoare2;
         

            Console.WriteLine("Continutul fiserului text este :");
            
            foreach (string line in linii)
            {
                
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine(suma + " este suma numerelor");

            using (System.IO.StreamWriter writer = new StreamWriter(@"C:\Users\Maria\source\repos\week3ora22\File1.txt", true))
            {
                writer.WriteLine($"numarul {valoare1} adunat cu numarul {valoare2} are suma {suma}");
            }
            Console.ReadLine();
        }

        private static void AnBisesct()
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
            else if ((an % 4) == 0)
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
