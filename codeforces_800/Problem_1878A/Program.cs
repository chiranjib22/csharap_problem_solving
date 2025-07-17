/*
 * Problem Link : https://codeforces.com/problemset/problem/1878/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split(' ');
    int n = int.Parse(inputs[0]);
    int m = int.Parse(inputs[1]);

    int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    bool isFound = false;
    for(int i = 0; i<n; i++)
    {
        if (numbers[i] == m)
        {
            isFound = true;
            break;
        }
    }
    if(isFound) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}