char letter = char.Parse(Console.ReadLine()!);

if (letter >= '0' && letter <= '9')
    Console.WriteLine("IS DIGIT");
else if (letter >= 'A' && letter <= 'Z')
{
    Console.WriteLine("ALPHA");
    Console.WriteLine("IS CAPITAL");
}
else if (letter >= 'a' && letter <= 'z')
{
    Console.WriteLine("ALPHA");
    Console.WriteLine("IS SMALL");
}