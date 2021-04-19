using System;

namespace Task5
{
    //5. Реализовать функции изменения для ссылочных типов внутри значимых типов.
    class Program
    {
        private static void Main(string[] args)
        {
            Value value1 = new Value();
            Value value2 = new Value();

            value2.reference = new Reference();
            value2.reference.x = 50;
            value1 = value2;
            value2.reference.x = 10; 
            Console.WriteLine(value1.reference.x); // передаются по ссылке, указывают на одно место в хипе
            Console.WriteLine(value2.reference.x); 

            Console.Read();
        }
    }
    struct Value
    {
        public int x;
        public int y;
        public int z;
        public Reference reference;
    }
    class Reference
    {
        public int x;
        public int y;
        public int z;
    }
}