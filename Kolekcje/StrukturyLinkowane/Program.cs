using System;

namespace StrukturyLinkowane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var head = new Node<string>("aaa", null);
            Console.WriteLine( head );
            var p1 = new Node<string>("bbb", null);
            head.next = p1;
            Console.WriteLine(head);
        }
    }

    class Node<T>
    {
        public T value;
        public Node<T> next;

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public override string ToString()
        {
            if( next == null)
                return $"{value} -> NULL";
            else
                return $"{value} -> {next}";
        }
    }
}
