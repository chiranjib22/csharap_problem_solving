/*
 * Problem Link : https://codeforces.com/problemset/problem/1385/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Array.Sort(num);

    if(num[1] != num[2]) Console.WriteLine("NO");
    else
    {
        Console.WriteLine("YES");
        Console.WriteLine($"{num[0]} {num[0]} {num[2]}");
    }
}