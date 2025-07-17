/*
 * Problem Link : https://codeforces.com/problemset/problem/1360/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int a = num[0];
    int b = num[1];
    int ans = 0;
    if(a < b)
    {
        if (2 * a >= b) ans = 2 * a * 2 * a;
        else ans = b * b;
    }else
    {
        if (2 * b >= a) ans = 2 * b * 2 * b;
        else ans = a * a;
    }
    Console.WriteLine(ans);
}