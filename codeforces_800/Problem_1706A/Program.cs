/*
 * Problem Link : https://codeforces.com/problemset/problem/1760/A
 */

int findMedian(int a, int b, int c)
{
    if (a > b)
    {
        if (b > c) return b;
        else // b < c
        {
            if (c > a) return a;
            else return c;
        }
    }else // a < b
    {
        if (a > c) return a;
        else // a < c
        {
            if (c > b) return b;
            else return c;
        }
    }
}

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] input = Console.ReadLine()!.Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    Console.WriteLine(findMedian(a,b,c));
}