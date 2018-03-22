using System;

namespace number_guess
{
  class Program
  {
    static void Main(string[] args)
    {

      int max;
      Random rnd = new Random();
      int secretNumber;
      int guesses = 1;
      bool winner = false;

      Console.Clear();
      Console.WriteLine("Provide an upper threshold");
      string maxNum = Console.ReadLine();
      bool valid = Int32.TryParse(maxNum, out max);


      if (!valid)
      {
        Console.WriteLine("Invalid Number");
      }
      else
      {
        secretNumber = rnd.Next(max + 1);
        Console.WriteLine("I have my number take a guess: ");
        while (guesses < 6 && !winner)
        {
          guesses++;
          string guess = Console.ReadLine();
          int numGuessed;
          bool validNum = Int32.TryParse(guess, out numGuessed);
          if (!validNum)
          {
            Console.WriteLine("Way to waste that Guess");
          }
          else
          {
            if (numGuessed == secretNumber)
            {
              System.Console.WriteLine("WINNER !!!! It took you " + guesses + " Guesses");
              winner = true;
            }
            else if (numGuessed > secretNumber)
            {
              System.Console.WriteLine("Wrong, guess lower next time");
            }
            else
            {
              System.Console.WriteLine("Wrong, guess higher next time");
            }
          }
        }
        if(!winner)
        {
            System.Console.WriteLine("Bummer dude it was "+ secretNumber);
        }
      }
    }
  }
}
