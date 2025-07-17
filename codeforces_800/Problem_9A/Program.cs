/*
 * Problem Link: https://codeforces.com/problemset/problem/9/A
 */

int gcd(int a, int b)
{
    while(b!=0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

int[] points = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int max = Math.Max(points[0], points[1]);
int numerator = 6 - max + 1;
int denominator = 6;
int g = gcd(numerator, denominator);
if( g > 1)
{
    numerator /= g;
    denominator /= g;
}
Console.WriteLine($"{numerator}/{denominator}");