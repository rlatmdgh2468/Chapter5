using System;

namespace px161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 두개와 연산기호를 입력해주세요!");
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            string input1 = Console.ReadLine();
            Console.Write("두 번째 정수를 입력해주세요. : ");
            string input2 = Console.ReadLine();
            
            int number = Int32.Parse(input1);

            if (number % 3 == 0)
            {
                Console.WriteLine($"연산기호를 입력해주세요. ex)+,-,*,/,% 입니다");

            }
        }
    }
}
