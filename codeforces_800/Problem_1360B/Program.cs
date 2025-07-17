/*
 * Problem Link : https://codeforces.com/problemset/problem/1360/B
 */

using System.Collections.Immutable;

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Array.Sort(num);
    int ans = int.MaxValue;
    for (int i = 1; i < n; i++)
    {
        if (num[i] - num[i - 1] < ans) ans = num[i] - num[i - 1];
    }
    Console.WriteLine(ans);
}