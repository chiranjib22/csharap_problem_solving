/*
 * Problem Link : https://codeforces.com/problemset/problem/1807/A
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

    if(a + b == c) Console.WriteLine("+");
    else if(a - b == c) Console.WriteLine("-");
}
