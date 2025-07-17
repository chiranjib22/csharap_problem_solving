/*
 * Problem Link: https://codeforces.com/problemset/problem/1791/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;

    int x = 0;
    int y = 0;
    bool pass = false;
    for(int i = 0; i<n; i++)
    {
        if (s[i] == 'L') x--;
        else if (s[i] == 'R') x++;
        else if (s[i] == 'U') y++;
        else y--;

        if (x == 1 && y == 1) pass = true;
    }

    if(pass) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}