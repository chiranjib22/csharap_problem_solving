/*
 * Problem Link : https://codeforces.com/problemset/problem/1399/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    int[] a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int[] b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    long ans = 0;
    int minA = a.Min();
    int minB = b.Min();
    for(int i = 0; i<n; i++)
    {
        int diffA = a[i] - minA;
        int diffB = b[i] - minB;
        ans += int.Max(diffA, diffB);
    }

    Console.WriteLine(ans);
}