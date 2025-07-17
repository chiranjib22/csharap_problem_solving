/*
 * Problem Link : https://codeforces.com/problemset/problem/1899/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    //input
    int n = int.Parse(Console.ReadLine()!);

    if(n%3 == 0)
        Console.WriteLine("Second");
    else
        Console.WriteLine("First");
}