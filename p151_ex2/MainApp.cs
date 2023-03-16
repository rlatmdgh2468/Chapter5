using System;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number >= 90)
            {
                Console.WriteLine($"입력하신 점수 {number}는 A 학점 입니다.");
            }
            else if (number >= 80) 
            {
                Console.WriteLine($"입력하신 점수 {number}는 B 학점 입니다.");
            }
            else if (number >= 70)
            {
                Console.WriteLine($"입력하신 점수 {number}는 C 학점 입니다.");
            }
            else if (number <= 69)
            {
                Console.WriteLine($"입력하신 점수 {number}는 D 학점 입니다.");
            }
          

            

            

                        
                }
            }
        }
    

