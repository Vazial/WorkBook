using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question4
    {
        public String Answer(int year)
        {
            var a = year % 400;
            if (a == 0)
            {
                return "うるう年です";
            }
            else
            {
                if ((a % 100) == 0)
                {
                    return "うるう年ではありません";
                }
                else
                {
                    if ((a % 4) == 0)
                    {
                        return "うるう年です";
                    }
                    else
                    {
                        return "うるう年ではありません";
                    }
                }
            }
        }
    }
}
