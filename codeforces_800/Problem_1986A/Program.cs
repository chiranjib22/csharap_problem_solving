/*
 * Problem Link : https://codeforces.com/problemset/problem/1986/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int ans = int.MaxValue;
    for(int i = 0; i<3; i++)
    {
        int dis = 0;
        for(int j = 0; j<3; j++)
        {
            dis += Math.Abs(num[i] - num[j]);
        }
        ans = int.Min(ans, dis);
    }
    Console.WriteLine(ans);
}