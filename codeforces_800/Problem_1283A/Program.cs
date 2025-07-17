/*
 * Problem Link : https://codeforces.com/problemset/problem/1283/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine((23 - num[0]) * 60 + (60 - num[1]));
}