char letter = char.Parse(Console.ReadLine()!);

if(char.IsUpper(letter))
{
    Console.WriteLine(char.ToLower(letter));
}
else 
{
    Console.WriteLine(char.ToUpper(letter));
}
