/*
 * Problem Link : https://codeforces.com/problemset/problem/1729/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int d1 = (num[0] - 1);
    int d2 = Math.Abs(num[1] - num[2]) + Math.Abs(num[2] - 1);

    if(d1 < d2) Console.WriteLine(1);
    else if(d1 > d2) Console.WriteLine(2);
    else Console.WriteLine(3);
}