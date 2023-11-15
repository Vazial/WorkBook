using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Work3
    {
        public void Answer1(int year)
        {
            var a = year - 1;
            var b = a / 100;
            var c = b + 1;
            Console.WriteLine($"{c}世紀です");
        }
    }
}
