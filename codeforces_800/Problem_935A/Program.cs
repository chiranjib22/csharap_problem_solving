/*
 * Problem Link : https://codeforces.com/problemset/problem/935/A
 */

int n = int.Parse(Console.ReadLine()!);

int ans = 0;
for(int i = 1; i<=n/2; i++)
{
    if (n % i == 0) ans++;
}
Console.WriteLine(ans);