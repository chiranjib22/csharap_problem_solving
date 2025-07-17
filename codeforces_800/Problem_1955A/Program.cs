/*
 * Problem Link : https://codeforces.com/problemset/problem/1955/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    int n = num[0];
    int a = num[1];
    int b = num[2];

    int oneBurle = n * a;
    int twoBurle = (n / 2) * b + (n % 2) * a;

    if(oneBurle < twoBurle) Console.WriteLine(oneBurle);
    else Console.WriteLine(twoBurle);
}