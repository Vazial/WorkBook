using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Work2
    {
        public void Answer1(int number)
        {
            var a = number % 6;
            if (a == 0)
            {
                Console.WriteLine("6の倍数です");
            }
            else
            {
                a = number % 3;
                if (a == 0)
                {
                    Console.WriteLine("3の倍数です");
                }
            }
        }

        public void Answer2(int number)
        {
            var a = number % 6;
            if (a == 0)
            {
                Console.WriteLine("6の倍数です");
            }
            else
            {
                if (a == 3)
                {
                    Console.WriteLine("3の倍数です");
                }
            }
        }
    }
}
