/*
 * Problem Link : https://codeforces.com/problemset/problem/1472/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int count1 = 0;
    int count2 = 0;
    for(int i = 0; i<n; i++)
    {
        if (num[i] == 1)
            count1++;
        else
            count2++;
    }

    int sum = (count1 + 2 * count2);
    if(sum % 2 != 0) Console.WriteLine("NO");
    else
    {
        sum /= 2;
        if(sum % 2 == 0 || (sum % 2 == 1 && count1 != 0)) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}