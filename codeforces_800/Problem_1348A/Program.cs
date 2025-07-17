/*
 * Problem Link : https://codeforces.com/problemset/problem/1348/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    long pileA = 1 << n;
    long pileB = 0;

    for (int i = 1; i < n / 2; i++) pileA += (1 << i);
    for (int i = n / 2; i < n; i++) pileB += (1 << i);

    Console.WriteLine(pileA - pileB);
}