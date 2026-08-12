double number = double.Parse(Console.ReadLine()!);

if(number >= 0 && number<= 25)
{
    Console.WriteLine("Interval [0,25]");
}
else if (number > 25 && number <= 50)
{
    Console.WriteLine("Interval (25,50]");
}
else if (number > 50 && number <= 75)
{
    Console.WriteLine("Interval (50,75]");
}
else if (number > 75 && number <= 100)
{
    Console.WriteLine("Interval (75,100]");
}
else
{
    Console.WriteLine("Out of Intervals");
}
