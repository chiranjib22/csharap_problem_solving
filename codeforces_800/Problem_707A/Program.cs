/*
 * Problem Link : https://codeforces.com/problemset/problem/707/A
 */

int[] dimension = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

bool colored = false;
for (int i = 0; i < dimension[0]; i++)
{
    string input = Console.ReadLine()!;
    if (input.IndexOfAny(['C', 'Y', 'M']) >= 0)
    {
        colored = true;
    }
}
if(colored) Console.WriteLine("#Color");
else Console.WriteLine("#Black&White");