/*
 * Problem Link : https://codeforces.com/problemset/problem/1866/A
 */

// input
int n = int.Parse(Console.ReadLine()!);
int[] number = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

// logic
int ans = int.MaxValue;
for(int i = 0; i<n; i++)
{
    ans = int.Min(ans, int.Abs(0 - number[i]));
}

Console.WriteLine(ans);
