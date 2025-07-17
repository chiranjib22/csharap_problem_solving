/*
 * Problem Link: https://codeforces.com/problemset/problem/1371/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    if(n % 2 == 0) Console.WriteLine(n/2);
    else Console.WriteLine((n/2) + 1);
}