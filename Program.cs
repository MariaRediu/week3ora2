using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ora2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "ab";
            s += "c";
            s += "d";


            StringBuilder sb = new StringBuilder();
            sb.Append("ab");
            sb.Append("c");
            sb.Append("d");

            string s2 = sb.ToString();
   

            // FindThElementFromEnd();
           // DictionaryExemple();

        }

        private static void DictionaryExemple()
        {
            string s = "Ana are mere mere.Ana are pere";
            //string cuvant= s.Substring(0, 3); //are
            char[] separatori = new[] { ' ', '.', ',' };
            string[] cuvinte = s.Split(separatori, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var cuvant in cuvinte)

            {
                if (dict.ContainsKey(cuvant))
                {
                    dict[cuvant]++;
                }
                else
                {
                    dict.Add(cuvant, 1);
                }

            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} apare de {pair.Value}");
                //Console.WriteLine(pair.Key + "apare de "+pair.Value);
                //Console.WriteLine("{0} apare de {1}", pair.Key, pair.Value);
            }
        }



        // find the 3rd element from the end, in a singly linked, in a single pass 
        private static void FindThElementFromEnd()
        {
            LinkedList<int> list = new LinkedList<int>();
            var node = list.AddLast(value: 10);
            list.AddLast(value: 20);
            list.AddLast(value: 30);
            list.AddLast(value: 40);
            list.AddLast(value: 50);


            // var lastNode = list.AddLast(value: 50); ;
            // Console.WriteLine(lastNode.Previous.Previous);
            while (node != null)
            {
                node = node.Next;
            }

            Console.ReadLine();
        }
    
}
