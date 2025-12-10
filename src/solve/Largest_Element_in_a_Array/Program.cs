string input = Console.ReadLine() ?? "";
int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

int max = int.MinValue;
foreach(int number in numbers)
{
    if(number > max) max = number;
}
Console.WriteLine(max);

