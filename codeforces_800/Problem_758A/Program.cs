/*
 * Problem Link: https://codeforces.com/problemset/problem/758/A
 */

int n = int.Parse(Console.ReadLine()!);
int[] number = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int max = number.Max();
int ans = 0;

for(int i = 0; i<n; i++)
{
    ans += Math.Abs(number[i] - max);
}

Console.WriteLine(ans);