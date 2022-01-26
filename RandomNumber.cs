using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberMalmoUni
{
    class RandomNumber
    {
        private Random random = new Random();
        bool done = true;


        public void Start()
        {

           

            if(done)
            {
                WelcomeText();
                GuessNumber();
                PlayAgain();
            } else
            {
                PlayAgain();

               
            }
        }

        private void WelcomeText()
        {
            
          string textI = "---------------- Guess the NUmber --------\n";
            textI    += "The computer selects a random value between 0 and 99\n ";
            textI += "You have to guess the numer. The game will help you\n";
            textI += "by letting you know if the guess number is to high\n";
            textI += " or  to low! It also displays the number of attepts\n.";
            textI += "the game stops and you replay.\n";
            textI += "---------------- Guess the NUmber --------\n";

            Console.WriteLine(textI);

                
        }      
       


        private bool PlayAgain()
        {
            Console.WriteLine("Play again (y/n)?");
            string input = Console.ReadLine();
            bool again = false;
            if (input.Contains("y"))
            {
                GuessNumber();
                PlayAgain();
                again = true; 
            } else
            {
                Console.WriteLine("no thank you! Enter to exit!!" );
                Console.ReadKey();
                again = false;
            }

            return again;
        }

        private void GuessNumber()
        {
            int answer = random.Next(0, 100);
            int guess = -1;
            int count = 1;

            while (guess != answer)
            {
                Console.WriteLine("Guess the right number?");
                string line = Console.ReadLine();
                guess = int.Parse(line);

                if (guess > answer)
                {
                    Console.WriteLine($"Attemp no. {count}, Your Guess (0 - 99): {guess}");
                    Console.WriteLine("Too high!");
                    count++;
                }
                else if (guess < answer)
                {
                    Console.WriteLine($"Attemp no. {count}, Your Guess (0 - 99): {guess}");
                    Console.WriteLine("Too low!");
                    count++;
                }

               
            }
            Console.WriteLine($"Attemp no. {count}, Your Guess (0 - 99): {answer} was the right one!!");
            Console.WriteLine("******************** Congratulations ************");
        }
        

    }
}
