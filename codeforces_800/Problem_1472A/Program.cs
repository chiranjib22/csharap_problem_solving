/*
 * Problem Link : https://codeforces.com/problemset/problem/1472/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int ans = 0;
    if (num[0] % 2 != 0 && num[1] % 2 != 0) ans = 1;
    //else if (num[0] % 2 == 0 && num[1] % 2 == 0)
    else
    {
        int mul = 1;
        while (num[0] % 2 == 0)
        {
            mul *= 2;
            num[0] /= 2;
        }
        while (num[1] % 2 == 0)
        {
            mul *= 2;
            num[1] /= 2;
        }
        ans = mul;
    }
    if(ans >= num[2]) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}