/*
 * Problem Link: https://codeforces.com/problemset/problem/1311/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int ans = 0;
    int diff = num[0] - num[1];
    if (diff < 0)
    {
        diff = Math.Abs(diff);
        if (diff % 2 == 0)
            ans = 2;
        else
            ans = 1;
    }
    else if (diff > 0)
    {
        if (diff % 2 == 0) ans = 1;
        else ans = 2;
    }
    else ans = 0;

    Console.WriteLine(ans);
}