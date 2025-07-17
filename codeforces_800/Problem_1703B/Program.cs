/*
 * Problem Link : https://codeforces.com/problemset/problem/1703/B
 */

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;
    Dictionary<char, int> table = new Dictionary<char, int>();
    for (char i = 'A'; i <= 'Z'; i++)
    {
        table[i] = 0;
    }

    int ans = 0;
    for (int i = 0; i < n; i++)
    {
        if (table[s[i]] == 0)
        {
            table[s[i]]++;
            ans += 2;
        }
        else ans++;
    }
    Console.WriteLine(ans);
}