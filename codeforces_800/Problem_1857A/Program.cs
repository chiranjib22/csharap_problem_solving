/*
 * Problem Link : https://codeforces.com/problemset/problem/1857/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input

    int n = int.Parse(Console.ReadLine()!);
    int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    // logic

    int sum = 0;
    foreach (var ele in numbers) sum += ele;

    // output
    if(sum % 2 == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}