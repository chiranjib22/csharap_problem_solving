/*
 * Problem Link : https://codeforces.com/problemset/problem/1926/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string s = Console.ReadLine()!;

    int countA = 0;
    int countB = 0;

    foreach(char c in s)
    {
        if (c == 'A') countA++;
        else countB++;
    }

    if(countA > countB) Console.WriteLine('A');
    else Console.WriteLine('B');
}