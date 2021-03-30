using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 20);
            int guessLeft = 3;
            Console.WriteLine("Try guess number 1-20, you hae 3 attempt");
            while (guessLeft > 0 ){
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == randomNumber){
                    Console.WriteLine("Correct");
                    break;
                }
                guessLeft -= 1;
                if(input > randomNumber){
                    Console.WriteLine($"Number is lower, you have {guessLeft} guess left");
                }else{
                    Console.WriteLine($"Number is higher, you have {guessLeft} guess left");
                }
            }
            if(guessLeft == 0){
                Console.WriteLine($"you lose, correct number is {randomNumber}");

            }
        }
    }
}
