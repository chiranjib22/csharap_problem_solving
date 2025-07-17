/*
 * Problem Link : https://codeforces.com/problemset/problem/1999/C
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int interval = int.MinValue;
    int lastFree = 0;

    for(int i = 0; i < input[0]; i++)
    {
        int[] busy = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        interval = int.Max(busy[0] - lastFree, interval);
        lastFree = busy[1];
    }
    interval = int.Max(input[2] - lastFree, interval);
    if(input[1] <= input[2] && input[1] <= interval) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}