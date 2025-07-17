/*
 * Problem Link : https://codeforces.com/problemset/problem/1896/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    //input
    int n = int.Parse(Console.ReadLine()!);
    int[] a = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

    // logic
    int minValue = a.Min();

    if (a[0] != minValue)
        Console.WriteLine("NO");
    else
    {
        Console.WriteLine("YES");
    }
}