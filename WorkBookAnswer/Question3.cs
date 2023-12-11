using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question3
    {
        public String Answer(int year)
        {
            var a = year - 1;
            var b = a / 100;
            var c = b + 1;
            return $"{c}世紀です";
        }

        public String Answer2(int year)
        {
            ;
            var century = ((year - 1) / 100) + 1;
            return $"{century}世紀です";
        }
    }
}
