using System;

namespace Tyd2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
        }
       public static void Task1()
        {
            int counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if ((i == 2 || i == 3 || i == 5 || i == 7) || (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0))
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} prime numbers between  0 and 100");
            Console.ReadKey();
        }
        public static void Task2()
        {
            int i = 0;
            do
            {
                Console.Write("{0}, ", i);
                i += 2;
            }
            while (i <= 1000);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        public static void Task3()
        {
            double f = 0;
            double f1 = 1;
            double temp = 0;
            Console.WriteLine($"F0 = {f}");
            Console.WriteLine($"F1 = {f1}");
            for (int i = 2; i <= 100; i++)
            { 
                temp = f;
                f = temp + f1;
                f1 = f;
                Console.WriteLine($"F{i} = {f1}");
            }
            Console.ReadKey();
        }
        public static void Task4()
        {
            Console.WriteLine("Please eneter number of rows");
            int n = Int32.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                        a++;
                        Console.Write($"{a} ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        public static void Task5()
        {
            for(int i = 0; i <= 20; i++)
            {
                int j = i * i * i;
                Console.WriteLine($"{i} to third power is {j}");
                j = 0;
            }
            Console.ReadKey();
        }
        public static void Task6()
        {
            double j = 0;
            for (int i = 1; i <= 20; i++)
            {
               j += ( 1 / (double) i) ; 
                if( i == 20)
                    Console.WriteLine($"summary equals {j}");

            }
            Console.ReadKey();
        }
        public static void Task7()
        {
            int NumOfStars;
            Console.WriteLine("Please eneter number of rows:");
            NumOfStars = int.Parse(Console.ReadLine());

            if (NumOfStars % 2 == 0)
            {
                NumOfStars -= 1;
            }

            for (int i = 1; i <= NumOfStars; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= ((NumOfStars - i) / 2); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int s = 1; s <= i; s++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\r\n");
                }
            }

            for (int i = NumOfStars - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= ((NumOfStars - i) / 2); j++)
                    {
                        Console.Write(" ");
                    }

                    for (int s = 1; s <= i; s++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\r\n");
                }
            }
            Console.ReadKey();
        }
        public static void Task8()
        {
            Console.WriteLine("Please, enter string of characters");
            String text = Console.ReadLine();
            for(int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.ReadKey();

        }
        public static void Task9()
        {
            string reversebinar ="";
            
            Console.WriteLine("Please, enter positve number ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The binar code for {num} is:");
            if (num > 0)
            {
                for (int i = num; i > 0; i /= 2)
                {
                    if (i % 2 == 1 && i > 1)
                    {
                        reversebinar += "1";
                    }
                    else if (i % 2 == 0 && i > 1)
                    {
                        reversebinar += "0";
                    }
                    else if (i == 1)
                    {
                        reversebinar += "1";
                        for (int j = reversebinar.Length - 1; j >= 0; j--)
                        {
                            Console.Write(reversebinar[j]);
                        }
                    }
                }
            }
            else if (num == 0)
            {     
                Console.WriteLine("Your binar code is ");
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("it is not positve number");
            }
            Console.ReadKey();
        }
        public static void Task10()
        {
            Console.WriteLine("Please, enter first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second number");
            int b = Int32.Parse(Console.ReadLine());
            int i = 0;
            if (a > 0 && b > 0)
            {
                do
                {
                    i++;
                    if (i % a == 0 && i % b == 0)
                    {
                        Console.WriteLine($"The least common multiply is {i}");
                        break;
                    }
                } while (i >= 0);
            }
            else
            {
                Console.WriteLine("Please enter positve number bigger than 0");
            }
            Console.ReadKey();
        }

    }

}
