using System;

namespace тест
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Sum(100, 99);
            Console.WriteLine(res);

            Display("Nastja", 25);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
