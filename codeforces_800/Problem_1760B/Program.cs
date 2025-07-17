/*
 * Problem Link : https://codeforces.com/problemset/problem/1760/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;

    int ans = 0;
    for(int i = 0; i<n; i++)
    {
        if (s[i] - 'a' > ans) ans = s[i] - 'a';
    }
    Console.WriteLine(ans + 1);
}