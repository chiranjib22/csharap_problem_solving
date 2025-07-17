/*
 * Problem Link : https://codeforces.com/problemset/problem/703/A
 */

int t = int.Parse(Console.ReadLine()!);
int m = 0;
int c = 0;

while(t-- > 0)
{
    int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    if (input[0] > input[1]) m++;
    else if (input[0] < input[1]) c++;
}

if(m == c) Console.WriteLine("Friendship is magic!^^");
else if(m > c) Console.WriteLine("Mishka");
else Console.WriteLine("Chris");