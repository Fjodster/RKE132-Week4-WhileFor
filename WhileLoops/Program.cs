
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - t/f

while (loopActive)
{
    cpuRandom = rnd.Next(1,4);
    Console.WriteLine($"Make a guess. Enter a number 1-3 (CPU has generated {cpuRandom})");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
            {
        Console.WriteLine("Congratulations you won !");
        loopActive = false;
    }
    else
        Console.WriteLine("oops.Try again");
}
Console.WriteLine("Have a nice day !");