/*
 * Problem Link : https://codeforces.com/problemset/problem/1433/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int d = int.Parse(Console.ReadLine()!);

    int digit = d % 10;
    int count = 0;
    int temp = d;

    while(temp != 0)
    {
        count++;
        temp /= 10;
    }
    int ans = 10 * (digit - 1) + ((count * (count + 1)) / 2);
    Console.WriteLine(ans);
}