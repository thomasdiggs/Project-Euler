﻿namespace ProjectEuler
{
    internal class Program
    {
        public static void Problem1()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Problem 1: " + sum);
        }
        public static void Problem2()
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
            Console.WriteLine("Problem 2: " + sum);
        }
        public static void Problem3()
        {
            long n = 600851475143;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    n /= i;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Problem 3: " + n);
        }
        public static void Problem4()
        {
            int largestPalindrome = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 90; j--)
                {
                    int product = i * j;
                    string productString = product.ToString();
                    char[] productArray = productString.ToCharArray();
                    Array.Reverse(productArray);
                    string reverseProductString = new string(productArray);
                    if (productString == reverseProductString)
                    {
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            Console.WriteLine("Problem 4: " + largestPalindrome);
        }
        public static void Problem5()
        {
            bool found = false;
            int i = 1;
            while (!found)
            {
                bool divisible = true;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0 && divisible)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible)
                {
                    found = true;
                } else
                {
                    i++;
                }
            }
            Console.WriteLine("Problem 5: " + i);
        }
        public static void Problem6()
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
            }
            int squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
            int difference = squareOfSum - sumOfSquares;
            Console.WriteLine("Problem 6: " + difference);
        }
        public static void Problem7()
        {
            ICollection<int> primes = new List<int>();
            int i = 2;
            while (primes.Count < 10_001)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        break;
                    }
                    else if (i == j)
                    {
                        primes.Add(i);
                    }
                }
               i++;
            }
            Console.WriteLine("Problem 7: " + primes.Last());
        }

        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
        }
    }
}