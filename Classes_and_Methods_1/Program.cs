using System;


namespace ClassesAndMethodsAssignment1
{
    class Program
    {
        public static void Main()
        {
            int z = Math.MyDivInt(1, 8);
            Console.WriteLine("1 8  remainder is : " + z);

            decimal c = Math.MyDivDec(70, 3);
            Console.WriteLine("70/3 dec  division is result is : " + c);


            string x = Math.MyDivString("1234", "555");
            Console.WriteLine("1234 + 555 string is result is : " + Convert.ToInt32(x));
            Console.Read();
        }
    }
}