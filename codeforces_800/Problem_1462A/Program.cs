/*
 * Problem Link : https://codeforces.com/problemset/problem/1462/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int[] ans = new int[n];
    int i = 0;
    int j = num.Length - 1;
    int k = 0;
    while(i <= j)
    {
        ans[k++] = num[i++];
        if(k<n) ans[k++] = num[j--];
    }
    Console.Write(ans[0]);
    for(int l = 1; l<n; l++) Console.Write(" " + ans[l]);
    Console.WriteLine();
}