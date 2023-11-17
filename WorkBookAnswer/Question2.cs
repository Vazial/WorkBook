using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question2
    {
        public String Answer(int number)
        {
            var a = number % 6;
            if (a == 0)
            {
                return "6の倍数です";
            }
            else
            {
                a = number % 3;
                if (a == 0)
                {
                    return "3の倍数です";
                }
            }
            return "";
        }

        public String Answer2(int number)
        {
            var a = number % 6;
            if (a == 0)
            {
                return "6の倍数です";
            }
            else
            {
                if (a == 3)
                {
                    return "3の倍数です";
                }
            }
            return "";
        }
    }
}
