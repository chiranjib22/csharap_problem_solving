/*
 * Problem Link : https://codeforces.com/problemset/problem/1992/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Array.Sort(num);
    for (int i = 1; i<=5; i++)
    {
        num[0]++;
        Array.Sort(num);
    }
    Console.WriteLine(num[0] * num[1] * num[2]);
}