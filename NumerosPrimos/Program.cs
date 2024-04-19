int num = 0, count = 0;

do
{
    Console.WriteLine("Escreva um numero:");
    num = int.Parse(Console.ReadLine());
} while (num < 0);

if (num == 0 || num ==1)
{
    Console.WriteLine($"{num} não é um numero primo");
}
else
{
    for (int i = num ; i > 0; i--)
    {
        if( num % i == 0)
        {
            count++;
        }
    }

    if (count == 2)
    {
        Console.WriteLine($"{num} é um numero primo pois tem somente {count} divisores.");

    } else
    {
        Console.WriteLine(num + "não é um numero primo, pois tem " + count + " divisores");
    }
}
