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
            //5.3 Tema1

            //int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            //RotateArrByAPivot(arr, 5);
            //TotalNumberBits();


            //6.3Tema 2

            //AnBisesct();
            //SumInFile();



            Console.ReadLine();
        }

        private static void TotalNumberBits()
        {
            int i;
            Console.WriteLine("Introduceti un numar:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine($"Suma bitiilor numarului {i} este:");
            Console.WriteLine(countBits(i));
        }

        static int countBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        static void RotateArrByAPivot(int[] arr, int nr)
        {
            int[] newArr = new int[arr.Length];
            int i;
            int j = 0;
            for (i = nr + 1; i < arr.Length; i++)
            {
                newArr[j] = arr[i];
                j++;
            }
            for (int k = 0; k < nr; k++)
            {
                if (k == 0)
                {
                    newArr[j] = arr[nr];
                    j++;
                }
                newArr[j] = arr[k];
                j++;
            }
            PrintArrays(newArr);
        }
        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
        }
        private static void SumInFile()
        {
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
