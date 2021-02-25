using System;

namespace HW20._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            string Agency;

            Console.Write("Input your password : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input your password : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Input your password : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Input your password : ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Input your password : ");
            e = int.Parse(Console.ReadLine());
            Console.Write("Input your password : ");
            f = int.Parse(Console.ReadLine());

            Console.Write("Input your agency : ");
            Agency = (Console.ReadLine());


            if (Agency == "CIA")
            {
                if (f % 3 == 0)
                {
                    if (e != 1 && e != 3 && e != 5)
                    {
                        if (c >= 6 && c != 8)
                        {
                            Console.WriteLine("true");
                        }
                        else
                            Console.WriteLine("flase");
                    }
                    else
                        Console.WriteLine("flase");
                }
                else
                    Console.WriteLine("flase");
            }


            else if (Agency == "FBI")
            {
                if (d % 2 == 0 && d != 6)
                {
                    if (b % 3 == 0)
                    {
                        if (a <= 7 && a >= 4)
                        {
                            Console.WriteLine("true");
                        }
                        else
                            Console.WriteLine("flase");
                    }
                    else
                        Console.WriteLine("flase");
                }
                else
                    Console.WriteLine("flase");
            }


            else if (Agency == "NSA")
            {
                if (f == 1 || f == 2 || f == 3 || f == 5 || f == 6)
                {
                    if (d % 3 == 0 && d % 2 != 0)
                    {
                        if (a == 7 || b == 7 || c == 7 || d == 7 || e == 7 || f == 7)
                        {
                            Console.WriteLine("true");
                        }
                        else
                            Console.WriteLine("flase");
                    }
                    else
                        Console.WriteLine("flase");
                }
                else
                    Console.WriteLine("flase");
            }


            else
            {
                Console.WriteLine("Password is incorrect.");
            }
            Console.ReadLine();
        }
    }
}
