Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);

    Console.WriteLine("Make a guess. Enter a number from 1 to 3");
    
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("You won!");
        break;
    } else
    {
        Console.WriteLine("You lost, try again");
    }
}