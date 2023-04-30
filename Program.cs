Random truth = new Random();
//int numberUser = 0;
int guesses = 0;
int numberComp = 0;

Console.WriteLine("Choose a range to guess from");
string range = Console.ReadLine();
int trueRange = 0;
while(int.TryParse(range, out trueRange) == false)
{
    if (int.TryParse(range, out trueRange) == false)
    {
        Console.WriteLine("invalid input!");
        range = Console.ReadLine();
    }
    else
    {
        numberComp = truth.Next(1, trueRange + 1);
    }
}


while (true)
{

    Console.Write($"Guess a number from 1 to {trueRange}:");

    //numberUser = int.Parse(Console.ReadLine());
    string userGuess = Console.ReadLine();
    if(int.TryParse(userGuess, out int numberUser) == false)
    {
        Console.WriteLine("invalid input!");
    }
    else 
    {
        if (numberUser < numberComp)
        {
            Console.WriteLine("Too low! Guess again");
            guesses++;
        }
        else if (numberUser > numberComp)
        {
            Console.WriteLine("Too high! Guess again");
            guesses++;
        }
        else { 
            Console.WriteLine("You guessed it!");
            guesses++;
            Console.WriteLine($"Number of guesses: {guesses}");
            Console.WriteLine("Choose a range to guess from");
            range = Console.ReadLine();
            while (int.TryParse(range, out trueRange) == false)
            {
                if (int.TryParse(range, out trueRange) == false)
                {
                    Console.WriteLine("invalid input!");
                }
                else
                {
                    numberComp = truth.Next(1, trueRange + 1);
                }
            }

        }
    }
    



}