using System;

namespace pop2020
{
    class Program
    {
        static void Homework1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hippolyte Guesdon " );
            Console.WriteLine("  ");

            Console.WriteLine("Give me 2 numbers ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("The sum is equal to " + sum);

            Console.WriteLine("  ");

            double c = 4 + 4 * 6;
            double d = (35 + 5) % 7;
            double e = 14 + -4 * 6 / 11;
            double f = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("The result of the first operation is " + c);
            Console.WriteLine("The result of the second operation is " + d);
            Console.WriteLine("The result of the third operation is " + e);
            Console.WriteLine("The result of the forth operation is " + f);

        }

        static void Homework2()
        {
            Console.WriteLine("Give me 3 numbers ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a * b * c;
            Console.WriteLine("The multiplication is equal to " + d);
            Console.WriteLine("  ");

            Console.WriteLine("Give me 1 number ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(e + " * " + i + " = " + e*i);
            }

            Console.WriteLine("  ");

            Console.WriteLine("Give me 4 numbers ");
            double f = Convert.ToInt32(Console.ReadLine());

            double g = Convert.ToInt32(Console.ReadLine());
            double h = Convert.ToInt32(Console.ReadLine());
            double k = Convert.ToInt32(Console.ReadLine());
            double average = (f + g + h + k) / 4;
            Console.WriteLine("The average of these for numbers is " + average);

            Console.WriteLine("  ");

            Console.WriteLine("Give me 1 numbers ");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l<=200 && l>= 100)
            {
                Console.WriteLine("Your number is within range between 100 and 200 ");
            }
            else
            {
                Console.WriteLine("Your number is not within range between 100 and 200 ");
            }

            

            Console.WriteLine("  ");

            Console.WriteLine("How old will you be at the end of 2020? ");
            int m = Convert.ToInt32(Console.ReadLine());
            int yearofbirth = 2020 - m;
            Console.WriteLine("you were birth in " + yearofbirth);

            Console.WriteLine("  ");

            Console.WriteLine("Give me 3 numbers ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x+y)*z + "\n" + (x * y + y * z));

        }
        static void Main(string[] args)
        {
            Homework2();
        }
    }
}
