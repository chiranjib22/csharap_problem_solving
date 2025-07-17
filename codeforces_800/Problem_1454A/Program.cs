/*
 * Problem Link : https://codeforces.com/problemset/problem/1454/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] ans = new int[n];

    for(int i = 0; i<n; i++)
    {
        ans[i] = n - i;
    }

    if(n % 2 != 0)
    {
        int temp = ans[n / 2];
        ans[n / 2] = ans[0];
        ans[0] = temp;
    }

    Console.Write(ans[0]);
    for(int i = 1; i<n; i++)
    {
        Console.Write(" " + ans[i]);
    }
    Console.WriteLine();
}