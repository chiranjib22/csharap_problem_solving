/*
 * Problem Link : https://codeforces.com/problemset/problem/702/A
 */

int n = int.Parse(Console.ReadLine()!);
int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int ans = 1;
int count = 1;

for(int i = 1; i<n; i++)
{
    if (num[i - 1] < num[i]) count++;
    else
    {
        ans = int.Max(ans, count);
        count = 1;
    }
}
ans = int.Max(ans, count);
Console.WriteLine(ans);