﻿using System;

namespace Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum;
            int oddSum;

            string currentNum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                evenSum = 0;
                oddSum = 0;
                currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        oddSum += currentNum[j];
                    }
                    else
                    {
                        evenSum += currentNum[j];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
