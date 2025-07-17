/*
 * Problem Link : https://codeforces.com/problemset/problem/1858/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input

    string[] input = Console.ReadLine()!.Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    // logic

    a += (c / 2);
    b += (c / 2);
    c = c % 2;


    // output

    if(a == b)
    {
        if(c == 0) Console.WriteLine("Second");
        else Console.WriteLine("First");
    }
    else
    {
        if(a > b) Console.WriteLine("First");
        else Console.WriteLine("Second");
    }
}