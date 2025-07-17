/*
 * Problem Link : https://codeforces.com/problemset/problem/2044/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string s = Console.ReadLine()!;

    string ans = "";

    for(int i = s.Length-1; i>=0; i--)
    {
        if (s[i] == 'p') ans += 'q';
        else if (s[i] == 'q') ans += 'p';
        else ans += s[i];
    }
    Console.WriteLine(ans);
}