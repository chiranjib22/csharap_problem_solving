/*
 * Problem Link : https://codeforces.com/problemset/problem/1772/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split('+').Select(int.Parse).ToArray();

    int a = num[0];
    int b = num[1];

    Console.WriteLine(a+b);
}