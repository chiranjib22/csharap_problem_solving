/*
 * Problem Link: https://codeforces.com/problemset/problem/1850/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    if (input[0] + input[1] >= 10 || input[1] + input[2] >= 10 || input[2] + input[0] >= 10)
        Console.WriteLine("YES");
    else Console.WriteLine("NO");
}