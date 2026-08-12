int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int[] sortedNumbers = numbers.OrderBy(n => n).ToArray();

foreach (int number in sortedNumbers)
    Console.WriteLine(number);

Console.WriteLine();

foreach(int number in numbers)
{
    Console.WriteLine(number);
}