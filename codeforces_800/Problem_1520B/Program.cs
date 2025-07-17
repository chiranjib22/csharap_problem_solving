/*
 * Problem Link : https://codeforces.com/problemset/problem/1520/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    long n = long.Parse(Console.ReadLine()!);

    int res = 0;
    for(long p = 1; p<=n; p = p * 10 + 1)
    {
        for(long d = 1; d<=9; d++)
        {
            if (p * d <= n) res++;
        }
    }
    Console.WriteLine(res);
}