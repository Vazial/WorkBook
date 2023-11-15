using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Work6
    {
        public void Answer1()
        {
            var a = 1;
            var b = a;
            while (true)
            {
                a = a + 1;
                if (a == 11)
                {
                    break;
                }
                else
                {
                    b = b + a;
                }
            }
            Console.WriteLine(b);
        }
    }
}
