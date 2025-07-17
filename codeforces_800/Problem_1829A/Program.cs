/*
 * Problem Link: https://codeforces.com/problemset/problem/1829/A
 */

int t = int.Parse(Console.ReadLine()!);
string str = "codeforces";
while (t-- > 0)
{
    string s = Console.ReadLine()!;

    int difference = 0;

    for (int i = 0; i < 10; i++)
    {
        if (str[i] != s[i]) difference++;
    }
    Console.WriteLine(difference);
}