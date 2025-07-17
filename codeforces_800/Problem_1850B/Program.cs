/*
 * Problem Link : https://codeforces.com/problemset/problem/1850/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    var pairs = new List<(int, int)>();
    for(int i = 0; i<n; i++)
    {
        int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        pairs.Add((num[0], num[1]));
    }

    
    int res = 0;
    int quality = int.MinValue;
    for(int i = 0; i<n; i++)
    {
        if (pairs[i].Item1 <= 10)
        {
            if (pairs[i].Item2 > quality)
            {
                res = i;
                quality = pairs[i].Item2;
            }
        }
    }
    Console.WriteLine(res+1);
}