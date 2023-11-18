using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question1
    {
        public String Answer(int number)
        {
            var a = number % 3;
            if (a == 0)
            {
                return "3の倍数です";
            }
            else
            {
                return "3の倍数ではありません";
            }
        }
    }
}
