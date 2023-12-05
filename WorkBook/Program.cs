﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WorkBook
{
    public class Program
    {
        private static String Label;
        private static String Input;
        private static Object Expect;
        private static Object Actual;

        public static void Main(string[] args)
        {
            try
            {
                Label = "Example1";
                var dataSets = new Dictionary<int, Object>()
                {
                    {1, "奇数です" },
                    {2, "偶数です" },
                    {3, "奇数です" },
                    {828, "偶数です" },
                    {2413, "奇数です" },
                    {-295636, "偶数です" }
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Example1().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question1";
                dataSets = new Dictionary<int, Object>()
                {
                    {2, "3の倍数ではありません"},
                    {3, "3の倍数です"},
                    {4, "3の倍数ではありません"},
                    {828, "3の倍数です"},
                    {2412, "3の倍数です"},
                    {-2956, "3の倍数ではありません"},
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question1().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question2";
                dataSets = new Dictionary<int, Object>()
                {
                    {6, "6の倍数です"},
                    {3, "3の倍数です"},
                    {5, ""},
                    {1590, "6の倍数です"},
                    {-8529, "3の倍数です"},
                    {2519, ""},
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question2().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question3";
                dataSets = new Dictionary<int, Object>()
                {
                    {1999, "20世紀です"},
                    {2000, "20世紀です"},
                    {2001, "21世紀です"},
                    {42807, "429世紀です"},
                    {0, "1世紀です"},
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question3().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question4";
                dataSets = new Dictionary<int, Object>()
                {
                    {1996, "うるう年です"},
                    {1900, "うるう年ではありません"},
                    {2000, "うるう年です"},
                    {1999, "うるう年ではありません"},
                    {824, "うるう年です"},
                    {700, "うるう年ではありません"},
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question4().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question5";
                dataSets = new Dictionary<int, Object>()
                {
                    {4, 0},
                    {5, 1},
                    {6, 2},
                    {7, 3},
                    {0, 0},
                    {3, 3},
                    {1276, 0},
                    {-3929, -1},
                    {38070, 2},
                    {-86575, -3},

                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question5().Answer(item.Key);
                    Assert.AreEqual(Expect, Actual);
                }

                Label = "Question6";
                dataSets = new Dictionary<int, Object>()
                {
                    {55, 55 },
                };
                foreach (var item in dataSets)
                {
                    Input = item.Key.ToString();
                    Expect = item.Value;
                    Actual = new Question6().Answer();
                    Assert.AreEqual(Expect, Actual);
                }

            }
            catch (AssertionException ex)
            {
                Console.WriteLine($"{Label}のテストに失敗しました。");
                Console.WriteLine($"入力             : {Input}");
                Console.WriteLine($"期待する実行結果 : {Expect}");
                Console.WriteLine($"実際の実行結果   : {Actual}");
                return;
            }
        }
    }
}
