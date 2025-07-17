/*
 * Problem Link : https://codeforces.com/problemset/problem/1367/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string b = Console.ReadLine()!;
    string a = "" + b[0] + b[1];

    int i = 3;
    while(i < b.Length)
    {
        a += b[i];
        i += 2;
    }
    Console.WriteLine(a);
}