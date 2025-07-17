/*
 * Problem Link : https://codeforces.com/problemset/problem/1551/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);

    int c1 = n / 3;
    int c2 = n / 3;

    if (n % 3 == 1) c1++;
    if (n % 3 == 2) c2++;

    Console.WriteLine($"{c1} {c2}");
}