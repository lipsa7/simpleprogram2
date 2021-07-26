using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please input a 4 digit number");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqroot = Math.Sqrt(num);
            double cubroot = MathF.Cbrt(num);
                //Math.Ceiling(Math.Pow(num, (double)1 / 3));
            Console.WriteLine(sqroot);
            Console.WriteLine(cubroot);
            int reverse = 0;
            int rem;
            while(num!=0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed number is " + reverse);
        }
    }
}
