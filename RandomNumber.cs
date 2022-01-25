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
                GuessNumber();
                PlayAgain();
            } else
            {
                PlayAgain();

               
            }
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
