using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question6
    {
        public int Answer()
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
            return b;
        }
    }
}
