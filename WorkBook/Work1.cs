using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Work1
    {
        public void Answer1(int number)
        {
            var a = number % 3;
            if (a == 0)
            {
                Console.WriteLine("3の倍数です");
            }
            else
            {
                Console.WriteLine("3の倍数ではありません");
            }
        }

        public void Answer2(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("3の倍数です");
            }
            else
            {
                Console.WriteLine("3の倍数ではありません");
            }
        }

        public void Answer3(int number)
        {
            var Message = (number % 3 == 0)? "3の倍数です": "3の倍数ではありません";
            Console.WriteLine(Message);
        }
    }
}
