/*
 * Problem Link : https://codeforces.com/problemset/problem/1368/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int count = 0;
    while (num[0] <= num[2] && num[1] <= num[2])
    {
        count++;
        if (num[0] > num[1]) num[1] += num[0];
        else num[0] += num[1];
    }
    Console.WriteLine(count);
}