﻿using System;

namespace nothesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dize1 = new int[10];
            for (int i = 0; i < dize1.Length; i++)
            {
                Console.WriteLine(i + ". Değer Girinşz: ");
                dize1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int c = 0; c < dize1.Length; c++)
            {
                if (dize1[c] % 2 == 0)
                {
                    Console.WriteLine(dize1[c]);
                }
            }
        }
    }
}
