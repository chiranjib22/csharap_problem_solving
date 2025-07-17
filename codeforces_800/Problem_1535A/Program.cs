/*
 * Problem Link: https://codeforces.com/problemset/problem/1535/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int first = num[0];
    int second = num[1];
    int third = num[2];
    int fourth = num[3];

    if(first > second)
    {
        if(third > fourth)
        {
            if(first > fourth &&  third > second) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }else
        {
            if(first > third && fourth > second) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
    else
    {
        if(third > fourth)
        {
            if(second > fourth && third > first) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }else
        {
            if(second > third && fourth > first) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}