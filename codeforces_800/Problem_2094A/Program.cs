/*
 * Problem Link : https://codeforces.com/problemset/problem/2094/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] input = Console.ReadLine()!.Split(' ');
    string ans = "";
    ans += input[0][0];
    ans += input[1][0];
    ans += input[2][0];
    Console.WriteLine(ans);
}