/*
 * Problem Link : https://codeforces.com/problemset/problem/1426/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    if (num[0] < 3) Console.WriteLine(1);
    else
    {
        int ans = ((num[0] - 3) / num[1]) + 2;
        Console.WriteLine(ans);
    }
}