
#region BRUTE FORCE APPROACH
int[] numbers = Array.ConvertAll((Console.ReadLine()!.Split(',')), int.Parse);
Array.Sort(numbers);
Console.WriteLine(numbers[^1]);
#endregion

#region OPTIMAL APPROACH

//string input = Console.ReadLine() ?? "";
//int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

//int max = int.MinValue;
//foreach(int number in numbers)
//{
//    if(number > max) max = number;
//}
//Console.WriteLine(max);

#endregion
