/*
 * Problem Link : https://codeforces.com/problemset/problem/1927/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;

    int start = -1;
    int end = -1;
    for(int i = 0; i<n; i++)
    {
        if (start == -1)
        {
            if (s[i] == 'B')
            {
                start = i;
                end = i;
            }
        }else
        {
            if (s[i] == 'B') end = i;
        }
    }
    if(start == -1) Console.WriteLine(0);
    else Console.WriteLine(end - start + 1);
}