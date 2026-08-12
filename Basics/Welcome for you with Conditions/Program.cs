int[] number = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

if (number[0] >= number[1])
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");