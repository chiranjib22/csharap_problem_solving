/*
 * Problem Link : https://codeforces.com/problemset/problem/1542/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int even = 0;
    int odd = 0;

    for(int i = 0; i<2*n; i++)
    {
        if (num[i] % 2 == 1) odd++;
        else even++;
    }

    if(even == odd) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}