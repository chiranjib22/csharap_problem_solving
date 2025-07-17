/*
 * Problem Link : https://codeforces.com/problemset/problem/432/A
 */

int[] inital = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int[] exp = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int count = 0;

for(int i = 0; i < inital[0]; i++)
{
    if (exp[i] + inital[1] <= 5) count++;
}

Console.WriteLine(count/3);