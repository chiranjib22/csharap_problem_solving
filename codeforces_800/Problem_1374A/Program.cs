/*
 * Problem Link : https://codeforces.com/problemset/problem/1374/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] input = Console.ReadLine()!.Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    int n = int.Parse(input[2]);

    int p = (n - y) / x;
    Console.WriteLine((x*p) + y);
}