/*
 * Problem Link : https://codeforces.com/problemset/problem/2014/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int n = input[0];
    int k = input[1];

    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int haveGold = 0;
    int giveGold = 0;
    for(int i = 0; i<n; i++)
    {
        if (num[i] == 0)
        {
            if (haveGold > 0)
            {
                haveGold--;
                giveGold++;
            }
        }else
        {
            if (num[i] >= k) haveGold += num[i];
        }
    }
    Console.WriteLine(giveGold);
}