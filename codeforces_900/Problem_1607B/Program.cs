/*
 * Problem Link : https://codeforces.com/problemset/problem/1607/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    long[] num = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
    long ans = num[0];
    long rem = num[1] % 4;


    if(rem == 1)
    {
        if (ans % 2 == 0) ans -= num[1];
        else ans += num[1];
    }
    else if(rem == 2)
    {
        if (ans % 2 == 0) ans -= ((num[1] - 1) - (num[1]));
        else ans += ((num[1] - 1) - (num[1]));
    }else if(rem == 3)
    {
        if (ans % 2 == 0) ans -= ((num[1] - 2) - (num[1] - 1) - num[1]);
        else ans += ((num[1] - 2) - (num[1] - 1) - num[1]);
    }
    Console.WriteLine(ans);
}