/*
 * Problem Link : https://codeforces.com/problemset/problem/1722/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    string firstLine = Console.ReadLine()!;
    string secondLine = Console.ReadLine()!;

    bool ok = true;
    for(int i = 0; i<n; i++)
    {
        if (firstLine[i] == 'R' && secondLine[i] != 'R' || firstLine[i] != 'R' && secondLine[i] == 'R')
        {
            ok = false;
            break;
        }
    }
    if(ok) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}