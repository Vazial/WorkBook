using System;

namespace WorkBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Work1().Answer1(100);
            new Work2().Answer1(100);
            new Work3().Answer1(1900);
            new Work4().Answer1(1900);
            new Work5().Answer1(100);
            new Work6().Answer1();

            Console.WriteLine();

            new Work1().Answer1(99);
            new Work2().Answer1(100);
            new Work3().Answer1(1901);
            new Work4().Answer1(2000);
            new Work5().Answer1(103);
            new Work6().Answer1();
        }
    }
}
