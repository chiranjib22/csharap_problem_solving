/*
 * Problem Link : https://codeforces.com/problemset/problem/1900/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    //input
    int n = int.Parse(Console.ReadLine()!);
    string s = Console.ReadLine()!;

    int isContinuousThree = 0;
    int countDot = 0;
    int continuousDot = 0;
    for(int i = 0; i<n; i++)
    {
        if (s[i] == '.')
        {
            countDot++;
            continuousDot++;
        }else
        {
            continuousDot = 0;
        }
        if(continuousDot == 3)
        {
            isContinuousThree = 1;
        }
    }
    if(isContinuousThree == 1)
    {
        Console.WriteLine(2);
    }else
    {
        Console.WriteLine(countDot);
    }
}