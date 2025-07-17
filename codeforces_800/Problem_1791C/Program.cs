/*
 * Problem Link : https://codeforces.com/problemset/problem/1791/C
 */

using System.Text;

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    StringBuilder s = new StringBuilder(Console.ReadLine()!);

    while (s.Length > 0 && s[0] != s[s.Length-1])
    {
        s.Remove(0, 1);
        s.Remove(s.Length - 1, 1);
    }
    Console.WriteLine(s.Length);
}