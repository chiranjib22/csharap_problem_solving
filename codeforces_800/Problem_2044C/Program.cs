/*
 * Problem Link : https://codeforces.com/problemset/problem/2044/C
 */

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int seat = 2 * num[0];
    int seated = 0;

    if (num[0] > num[1])
    {
        seat -= num[1];
        seated += num[1];
    }
    else
    {
        seat -= num[0];
        seated += num[0];
    }

    if (num[0] > num[2])
    {
        seat -= num[2];
        seated += num[2];
    }else
    {
        seat -= num[0];
        seated += num[0];
    }

    if(seat >= num[3]) Console.WriteLine(seated + num[3]);
    else Console.WriteLine(seated + seat);
}