/*
 * Problem Link: https://codeforces.com/problemset/problem/1807/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int mihai = 0;
    int binaca = 0;
    for(int i = 0; i<n; i++)
    {
        if (num[i] % 2 == 0) mihai += num[i];
        else binaca += num[i];
    }

    if(mihai > binaca) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}