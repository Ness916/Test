using System;

namespace Task3
{//Реализовать функции изменения значимых и ссылочных типов данных.
    internal class Program
    {
        static void Value(int a)
        {
          a = 5;
        }

        static void Ref (int[]arrey)
        {
            arrey[0] = 5;
        }
        static void Main(string[] args)
        {
            int a = 1;

            Value(a);
            Console.WriteLine($"Velue type: {a}");//value type

            int[] b = new int[1];

            Ref(b);

            Console.WriteLine($"Reference type: {b[0]}");//ref type


        }
    }
}
