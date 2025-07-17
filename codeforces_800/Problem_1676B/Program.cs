/*
 * Problem Link: https://codeforces.com/problemset/problem/1676/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int min = num.Min();
    int ans = 0;
    foreach(var ele in num)
    {
        ans += (ele - min);
    }
    Console.WriteLine(ans);
}