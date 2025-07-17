/*
 * Problem Link : https://codeforces.com/problemset/problem/1520/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;
    int[] track = new int[27];

    bool suspicious = false;
    track[s[0] - 'A'] = 1;
    for(int i = 1; i<s.Length; i++)
    {
        if (s[i-1] != s[i])
        {
            if (track[s[i] - 'A'] != 0)
            {
                suspicious = true;
                break;
            }
            else
            {
                track[s[i] - 'A'] = 1;
            }
        }
    }
    if(suspicious) Console.WriteLine("NO");
    else Console.WriteLine("YES");
}