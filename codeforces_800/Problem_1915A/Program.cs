
/*
 * Problem Link : https://codeforces.com/problemset/problem/1915/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] input = Console.ReadLine()!.Split(' ');
    int a = int.Parse(input[0]) ^ int.Parse(input[1]) ^ int.Parse(input[2]);
    Console.WriteLine(a);
}