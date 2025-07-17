/*
 * Problem Link : https://codeforces.com/problemset/problem/1722/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;
    if(n != 5) Console.WriteLine("NO");
    else
    {
        if(s.Contains('T') && s.Contains('i') && s.Contains('m') && s.Contains('u') && s.Contains('r'))
            Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}