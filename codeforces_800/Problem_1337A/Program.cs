/*
 * Problem Link : https://codeforces.com/problemset/problem/1337/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine($"{num[1]} {num[2]} {num[2]}");
}