decimal number = decimal.Parse(Console.ReadLine()!);

if(number % 1 == 0)
{
    Console.WriteLine($"int {(int)number}");
}
else
{
    Console.WriteLine($"float {(int)number} {number - (int)number}");
}