/*
 * Problem Link : https://codeforces.com/problemset/problem/1921/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int minX = int.MaxValue;
    int maxX = int.MinValue;

    foreach(var i in Enumerable.Range(1,4))
    {
        int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        if (num[0] < minX) minX = num[0];
        if (num[0] > maxX) maxX = num[0];
    }

    int length = Math.Abs(maxX - minX);
    Console.WriteLine(length * length);
}