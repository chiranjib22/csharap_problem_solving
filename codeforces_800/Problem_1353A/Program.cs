/*
 * Problem Link : https://codeforces.com/problemset/problem/1353/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine(int.Min(2, num[0] - 1) * num[1]);
}