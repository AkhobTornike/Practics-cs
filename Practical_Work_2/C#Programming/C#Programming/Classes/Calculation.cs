using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programming.Classes
{
    internal static class Calculation
    {
        public static int sum(int number1, int number2) => number1 + number2;
        public static int sum(int number1, int number2, ref string msg)
        {
            int total = number1 + number2;
            msg = $"{number1} + {number2} = {total}";
            return total;
        }

        public static int sum(int number1, int number2, int number3) => number1 + number2 + number3;

        public static int sum(int number1, int number2, int number3, out string msg)
        {
            int total = number1 + number2 + number3;
            msg = $"{number1} + {number2} + {number3} = {total}";
            return total;
        }

        public static int sum(params int[] args)
        {
            int sum = 0;
            foreach (int i in args) { sum += i; }
            return sum;
        }
    }
}
