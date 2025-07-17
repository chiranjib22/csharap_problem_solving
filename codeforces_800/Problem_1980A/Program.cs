/*
 * Problem Link : https://codeforces.com/problemset/problem/1980/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    Dictionary<char, int> table = new Dictionary<char, int>()
    {
        {'A',0},
        {'B',0},
        {'C',0},
        {'D',0},
        {'E',0},
        {'F',0},
        {'G',0}
    };

    string s = Console.ReadLine()!;
    for(int i = 0; i<s.Length; i++)
    {
        table[s[i]]++;
    }
    int ans = 0;
    foreach(var ele in table)
    {
        if (ele.Value < num[1]) ans += (num[1] - ele.Value);
    }
    Console.WriteLine(ans);
}