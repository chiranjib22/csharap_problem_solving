/*
 * Problem Link : https://codeforces.com/problemset/problem/1853/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    // input
    int n = int.Parse(Console.ReadLine()!);
    int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();


    // logic
    long operation = long.MaxValue;

    for(int i = 0; i < n - 1; i++)
    {
        if (numbers[i] <= numbers[i + 1])
        {
            long requiredOperation = (numbers[i + 1] - numbers[i]) / 2 + 1;
            operation = long.Min(requiredOperation, operation);
        }
        else operation = 0;
    }
    Console.WriteLine(operation);
}