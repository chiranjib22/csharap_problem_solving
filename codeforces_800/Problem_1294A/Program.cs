/*
 * Problem Link : https://codeforces.com/problemset/problem/1294/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int ans = num.Sum();

    if(ans % 3 == 0)
    {
        int x = ans / 3;
        if(x - num[0] >= 0 && x - num[1] >= 0 && x - num[2] >= 0) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    else Console.WriteLine("NO");
}    