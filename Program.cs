﻿using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number - ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter a number - ");
            int b = Convert.ToInt32(Console.ReadLine());
        

            if (a == 30 || b == 30 || (a + b) == 30)
            {
                Console.WriteLine("true");
            }else{
                Console.WriteLine("false");
            }



            //    Console.WriteLine("Hello World!");

            //        Console.WriteLine(SumTriple(2, 2));
            //        Console.WriteLine(SumTriple(12, 20));
            //        Console.WriteLine(SumTriple(-5, 2));
            //}
            //    public static int SumTriple(int a, int b)
            //    {
            //        return a == b ? (a + b) * 3 : a + b;
            //    }

            return ;
        }

    }

}

