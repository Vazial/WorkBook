using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBookAnswer
{
    public class Question5
    {
        public int Answer(int number)
        {
            var div = number / 4;
            return (number - (div * 4));
        }
    }
}
