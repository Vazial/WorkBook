﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBook
{
    public class Example1
    {
        /// <summary>
        /// 例題①
        /// </summary>
        /// <param name="number">数値</param>
        public String Answer(int number)
        {
            var isOdd = number % 2;
            if (isOdd == 0)
            {
                return "偶数です";
            }
            else
            {
                return "奇数です";
            }
        }
    }
}
