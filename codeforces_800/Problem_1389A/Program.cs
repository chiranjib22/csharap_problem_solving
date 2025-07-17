/*
 * Problem Link: https://codeforces.com/problemset/problem/1389/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    if (2 * num[0] > num[1]) Console.WriteLine("-1 -1");
    else Console.WriteLine($"{num[0]} {2 * num[0]}");
}