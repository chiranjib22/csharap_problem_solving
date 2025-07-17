/*
 * Problem Link : https://codeforces.com/problemset/problem/1859/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input

    int n = int.Parse(Console.ReadLine()!);
    int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    // logic
    int max = numbers.Max();
    List<int> b = new List<int>();
    List<int> c = new List<int>();

    for(int i = 0; i<n; i++)
    {
        if (numbers[i] != max)
        {
            b.Add(numbers[i]);
        } else
        {
            c.Add(numbers[i]);
        }
    }

    // output

    if(b.Count == 0) Console.WriteLine(-1);
    else
    {
        Console.WriteLine(b.Count + " " + c.Count);

        Console.Write(b[0]);
        for(int i = 1; i<b.Count; i++)
        {
            Console.Write(" " + b[i]);
        }
        Console.WriteLine();

        Console.Write(c[0]);
        for(int i = 1; i<c.Count; i++)
        {
            Console.Write(" " + c[i]);
        }
        Console.WriteLine();
    }
}