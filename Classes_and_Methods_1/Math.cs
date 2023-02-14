using System;

namespace Classes_and_Methods_1
{
    public class Math
    {
        public static int MyDivInt(int a, int b)
        {
            return a % b;
        }
        public static decimal MyDivDec(decimal a, decimal b)
        {
            return Convert.ToInt32(a / b);
        }
        public static int MyDivString(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }



    }
}