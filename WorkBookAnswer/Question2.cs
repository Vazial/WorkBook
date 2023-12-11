using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question2
    {
        public String Answer(int number)
        {
            var rem = number % 6;
            if (rem == 0)
            {
                return "6の倍数です";
            }
            else
            {
                rem = number % 3;
                if (rem == 0)
                {
                    return "3の倍数です";
                }
            }
            return "";
        }

        public String Answer2(int number)
        {
            var rem = number % 6;
            if (rem == 0)
            {
                return "6の倍数です";
            }
            else
            {
                if (rem == 3)
                {
                    return "3の倍数です";
                }
            }
            return "";
        }
    }
}
