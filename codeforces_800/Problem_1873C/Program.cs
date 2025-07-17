/*
 * Problem Link : https://codeforces.com/problemset/problem/1873/C
 */

int t = int.Parse(Console.ReadLine()!);
while(t-- > 0)
{
    // input
    string[] inputs = new string[10];
    for(int i = 0; i<10; i++)
    {
        inputs[i] = Console.ReadLine()!;
    }

    // logic
    int score = 0;
    for(int i = 0; i < 10; i++)
    {
        for(int j = 0; j < inputs[i].Length; j++)
        {
            if (inputs[i][j] == 'X')
            {
                if (i == 0 || i == 9) score += 1;
                if(i == 1 || i == 8)
                {
                    if (j == 0 || j == 9) score += 1;
                    else score += 2;
                }
                if(i == 2 || i == 7)
                {
                    if (j == 0 || j == 9) score += 1;
                    else if (j == 1 || j == 8) score += 2;
                    else score += 3;
                }
                if(i == 3 || i == 6)
                {
                    if (j == 0 || j == 9) score += 1;
                    else if (j == 1 || j == 8) score += 2;
                    else if (j == 2 || j == 7) score += 3;
                    else score += 4;
                }
                if(i == 4 || i == 5)
                {
                    if (j == 0 || j == 9) score += 1;
                    else if (j == 1 || j == 8) score += 2;
                    else if (j == 2 || j == 7) score += 3;
                    else if (j == 3 || j == 6) score += 4;
                    else score += 5;
                }
            }
        }
    }
    Console.WriteLine(score);
}

