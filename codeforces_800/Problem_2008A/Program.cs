/*
 * Problem Link : https://codeforces.com/problemset/problem/2008/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    num[1] = num[1] % 2;

    if (num[1] > 0)
    {
        if (num[1] * 2 <= num[0])
        {
            num[0] -= 2;
            num[1] = 0;
        }
    }

    num[0] = num[0] % 2;

    if (num[1] == 0 && num[0] == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}