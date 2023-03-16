using System;


namespace P151_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력해주세요");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number > 50)
            {
                Console.WriteLine($"입력하신 정수 {number}는 50이상입니다. ");
            }
            else if (number < 50)
            {
                Console.WriteLine($"입력하신 정수 {number}는 50미만입니다. ");
            }


        }
    }
}
