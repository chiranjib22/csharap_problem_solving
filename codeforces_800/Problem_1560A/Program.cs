/*
 * Problem Link : https://codeforces.com/problemset/problem/1560/A
 */

int[] memory = new int[1001];
int j = 0;
for(int i = 1; i<=1666; i++)
{
    if (i % 3 != 0 && i % 10 != 3) memory[j++] = i;
}
int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int k = int.Parse(Console.ReadLine()!);
    Console.WriteLine(memory[k-1]);
}