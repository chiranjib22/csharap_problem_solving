/*
 * Problem Link : https://codeforces.com/problemset/problem/1343/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    if(n % 4 == 0)
    {
        Console.WriteLine("YES");
        for(int i = 1; i<=n/2; i++)
        {
            Console.Write($"{2 * i} ");     
        }
        for(int i = 1; i<n/2; i++)
        {
            Console.Write($"{2 * i - 1} ");
        }
        Console.WriteLine(3 * (n/2) - 1);
    }else
    {
        Console.WriteLine("NO");
    }
}