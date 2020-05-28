using System;
using System.Collections.Generic;
//using System.Linq;

namespace Lista
{
    class Program
    {
        static int[] dane = { 4, 3, 6, 1, 2, 7, 8, 9, 4, 2, 2 };
        static void Main()
        {
            //Lista();
            Zbior();
        }

        static void Zbior()
        {
            int[] dane = { 4, 3, 6, 1, 2, 7, 8, 9, 4, 2, 2 };
            HashSet<int> zbiorA = new HashSet<int>(dane);
            zbiorA.Add(-1);
            foreach (var x in zbiorA)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine( string.Join(' ', zbiorA) );

            // -------------
            var zbiorB = new SortedSet<int>(dane);
            Console.WriteLine(string.Join(' ', zbiorB));
            zbiorB.Add(5);
            Console.WriteLine(string.Join(' ', zbiorB));

            //zbiorB.IntersectWith(zbiorA);
            zbiorB.ExceptWith(zbiorA);
            Console.WriteLine(string.Join(' ', zbiorB));
        }

        static void Lista()
        {
            string[] zw = {"mucha", "krowaaa", "zebra" };
            List<string> zwierzaki = new List<string>(zw);
            zwierzaki.Add("kot");
            zwierzaki.Add("pies");
            Console.WriteLine(zwierzaki);
            for (int i = 0; i < zwierzaki.Count; i++)
            {
                Console.WriteLine(zwierzaki[i]);
            }

            foreach (var z in zwierzaki)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine( string.Join(';', zwierzaki) );

            zwierzaki.Sort();
            Console.WriteLine(string.Join(';', zwierzaki));

            zwierzaki.Sort((s1, s2) => s1.Length - s2.Length);
            Console.WriteLine(string.Join(';', zwierzaki));
        }
    
        static void Kolejka()
        {
            Queue<int> kolejka = new Queue<int>(dane);
        }
    
    }
}
