﻿using System;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력해주세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number % 3 == 0)
            {
                Console.WriteLine($"입력하신 정수{number}는(은) 3의 배수입니다.");
            }
            else
                Console.WriteLine($"입력하신 정수{number}는(은) 3의 배수가 아닙니다.");







        }
    }
}
