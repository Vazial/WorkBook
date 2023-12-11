using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question4
    {
        public String Answer(int year)
        {
            var leapYear = year % 400;
            if (leapYear == 0)
            {
                return "うるう年です";
            }
            else
            {
                if ((leapYear % 100) == 0)
                {
                    return "うるう年ではありません";
                }
                else
                {
                    if ((leapYear % 4) == 0)
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
