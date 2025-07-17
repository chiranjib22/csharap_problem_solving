/*
 * Problem Link : https://codeforces.com/problemset/problem/1624/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine(num.Max() - num.Min());
}