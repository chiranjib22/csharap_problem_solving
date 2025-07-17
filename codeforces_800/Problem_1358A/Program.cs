/*
 * Problem Link: https://codeforces.com/problemset/problem/1358/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine(((num[0] * num[1]) + 1)/2);
}