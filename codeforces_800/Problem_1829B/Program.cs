/*
 * Problem Link: https://codeforces.com/problemset/problem/1829/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int ans = 0;
    int zero = 0;
    for(int i = 0; i<n; i++)
    {
        if (a[i] == 0) zero++;
        else
        {
            ans = Math.Max(ans, zero);
            zero = 0;
        }
    }
    ans = Math.Max(ans, zero);
    Console.WriteLine(ans);
}