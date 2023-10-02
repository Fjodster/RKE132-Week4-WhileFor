using System.Runtime.ConstrainedExecution;

int sum = 0;

for(int i = 00; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Surrent Total: {sum}");
    sum = sum + i;
}
//Console.WriteLine($"Final total:{sum}" );