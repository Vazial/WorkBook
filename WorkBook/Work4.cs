using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Work4
    {
        public void Answer1(int year)
        {
            var a = year % 400;
            if (a == 0)
            {
                Console.WriteLine("うるう年です");
            }
            else
            {
                if ((a % 100) == 0)
                {
                    Console.WriteLine("うるう年ではありません");
                }
                else
                {
                    if ((a % 4) == 0)
                    {
                        Console.WriteLine("うるう年です");
                    }
                    else
                    {
                        Console.WriteLine("うるう年ではありません");
                    }
                }
            }
        }
    }
}
