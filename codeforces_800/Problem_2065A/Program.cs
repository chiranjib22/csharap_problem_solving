/*
 * Problem Link : https://codeforces.com/problemset/problem/2065/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string s = Console.ReadLine()!;

    s = s.Remove(s.Length - 2);
    s += 'i';
    Console.WriteLine(s);
}