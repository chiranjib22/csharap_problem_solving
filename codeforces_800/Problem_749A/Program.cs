/*
 * Problem Link: https://codeforces.com/problemset/problem/749/A
 */

int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
{
    int k = n / 2;
    Console.WriteLine(k);
    Console.Write("2");
    for (int i = 0; i < k-1; i++)
    {
        Console.Write(" 2");
    }
    Console.WriteLine();
}
else
{
    if (n == 3)
    {
        Console.WriteLine(1);
        Console.WriteLine("3");
    }
    else
    {
        int k = (n - 1) / 2;
        Console.WriteLine(k);
        Console.Write("2");
        for (int i = 0; i < k - 2; i++)
        {
            Console.Write(" 2");
        }
        Console.WriteLine(" 3");
    }
}
