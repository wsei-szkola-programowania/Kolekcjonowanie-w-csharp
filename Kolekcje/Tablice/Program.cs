using System;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] tab;
            tab = new int[10];
            Random los = new Random();
            for (var i = 0; i < tab.Length; i++)
            {
                tab[i] = los.Next(-10, 11); // od -10 do 10
            }

            tab[0] = tab[2] = tab[4] = -1;
            foreach(var x in tab)
            {
                Console.WriteLine(x);
            }

            var napis = string.Join(' ', tab);
            Console.WriteLine(napis);

            Array.Reverse(tab);
            Console.WriteLine(string.Join(' ', tab));
            Array.Sort(tab);
            Console.WriteLine(string.Join(' ', tab));
        }
    }
}
