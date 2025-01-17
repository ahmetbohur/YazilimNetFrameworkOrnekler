﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimNetFrameworkOrnekler.ProjectEuler
{
    internal class ProjectEuler
    {
        internal void Problem1()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        internal void Problem2()
        {
            int sum = 0;
            int a = 1;
            int b = 2;
            while (b < 4000000)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine(sum);
        }

        internal void Problem3()
        {
            long number = 600851475143;
            long i = 2;
            while (i * i < number)
            {
                while (number % i == 0)
                {
                    number = number / i;
                }
                i++;
            }
            Console.WriteLine(number);
        }

        internal void Problem4()
        {
            int max = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    string productString = product.ToString();
                    char[] productArray = productString.ToCharArray();
                    Array.Reverse(productArray);
                    string reversedProductString = new string(productArray);
                    if (productString == reversedProductString && product > max)
                    {
                        max = product;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
