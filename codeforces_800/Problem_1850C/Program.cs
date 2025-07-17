/*
 * Problem Link : https://codeforces.com/problemset/problem/1850/C
 */
int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{

    int n = 8;

    string ans = "";
    for(int i = 0; i<n; i++)
    {
        string s = Console.ReadLine()!;
        for(int j = 0; j<n; j++)
        {
            if (s[j] != '.')
            {
                ans += s[j];
                break;
            } 
        }
    }
    Console.WriteLine(ans);
}