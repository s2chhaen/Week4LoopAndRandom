Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

bool loopactive = true;
int nmb_tries = 0;
int userGuess=0;

while (loopactive)
{
    nmb_tries++;
    Console.WriteLine($"{nmb_tries}. try to guess the cpu number:");
    userGuess=Convert.ToInt32(Console.ReadLine());
 
    if (userGuess == cpuRandom)
    {
        Console.WriteLine($"You won! The cpu number was {cpuRandom}.");
        loopactive = false;
    }
    else if (nmb_tries == 3)
    {
        Console.WriteLine("You loose!");
        loopactive = false;
    }
}
Console.WriteLine($"Number of tries: {nmb_tries}");
Console.WriteLine("Have a nice day!");
