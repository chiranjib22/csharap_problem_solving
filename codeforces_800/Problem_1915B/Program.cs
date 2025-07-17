/*
 * Problem Link : https://codeforces.com/problemset/problem/1915/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string f = Console.ReadLine()!;
    string s = Console.ReadLine()!;
    string h = Console.ReadLine()!;

    char ans = default;
    Dictionary<char, int> table = new Dictionary<char, int>()
    {
        {'A',0},
        {'B',0 },
        {'C',0 }
    };
    for(int i = 0; i<3; i++)
    {
        if (f[i] != '?') table[f[i]]++;
    }
    for (int i = 0; i < 3; i++)
    {
        if (s[i] != '?') table[s[i]]++;
    }
    for (int i = 0; i < 3; i++)
    {
        if (h[i] != '?') table[h[i]]++;
    }

    foreach(var ele in table)
    {
        if (ele.Value == 2) ans = ele.Key;
    }
    Console.WriteLine(ans);
}