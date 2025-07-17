/*
 * Problem Link : https://codeforces.com/problemset/problem/1873/B
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int[] num = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int a = num.Min();
    int product = 1;

    bool increment = true;
    foreach(var ele in num)
    {
        if (increment && a == ele)
        {
            product *= (ele + 1);
            increment = false;
        }
        else product *= ele;
    }
    Console.WriteLine(product);
}