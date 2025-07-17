/*
 * Problem Link : https://codeforces.com/problemset/problem/1619/A
 */

int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string s = Console.ReadLine()!;
    bool ok = true;
    if (s.Length % 2 == 0)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[i + s.Length / 2])
            {
                ok = false;
                break;
            }
        }
    }
    else ok = false;

    if (ok) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}