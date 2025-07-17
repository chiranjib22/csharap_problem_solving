/*
 * Problem Link : https://codeforces.com/problemset/problem/1862/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input

    int n = int.Parse(Console.ReadLine()!);
    int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    // logic

    List<int> list = new List<int>();
    list.Add(numbers[0]);
    for(int i = 1; i<n; i++)
    {
        if (numbers[i] < numbers[i - 1])
        {
            list.Add(numbers[i]);
        }
        list.Add(numbers[i]);
    }

    // output

    Console.WriteLine(list.Count);
    Console.Write(list[0]);

    for(int i = 1; i<list.Count; i++)
    {
        Console.Write(" " + list[i]);
    }
    Console.WriteLine();
}