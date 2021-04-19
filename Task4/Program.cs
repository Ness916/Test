using System;

namespace Task4
{
    // Реализовать функции изменения значимых и ссылочных типов данных для составных типов.
    internal class Program
    {
        private static void Main(string[] args)
        {
            Value value1 = new Value(); // Структура Value
            Value value2 = new Value();
            value2.x = 7;
            value2.y = 10;
            value1 = value2;
            value2.x = 5; // value1.x=1 по-прежнему
            Console.WriteLine ($"Value type: {value1.x}"); 
            Console.WriteLine($"Value type: { value2.x}");

            Reference reference1 = new Reference(); // Класс Reference
            Reference reference2 = new Reference();
            reference2.x = 5;
            reference2.y = 10;
            reference1 = reference2;
            reference2.x = 8; // теперь и reference1.x = 8, так как обе ссылки и reference1 и reference2 
                              // указывают на один объект в хипе
            Console.WriteLine ($"Reference type: { reference1.x}"); // 8
            Console.WriteLine($"Reference type: {reference2.x}"); // 8

            Console.Read();
        }
    }
    struct Value
    {
        public int x;
        public int y;
        public Reference reference;
    }
    class Reference
    {
        public int x;
        public int y;
    }
}
