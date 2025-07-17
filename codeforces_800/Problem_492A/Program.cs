/*
 * Problem Link: https://codeforces.com/problemset/problem/492/A
 */

int n = int.Parse(Console.ReadLine()!);

int level = 1;
int cubes = 1;

while(cubes <= n)
{
    level++;
    cubes += (level * (level + 1)/2);

}
Console.WriteLine(level-1);
