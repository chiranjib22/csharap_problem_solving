/*
 * Problem Link : https://codeforces.com/problemset/problem/1097/A
 */

string cardT = Console.ReadLine()!;

string[] cardH = Console.ReadLine()!.Split(' ');

bool play = false;
for(int i = 0; i<5; i++)
{
    if (cardT[0] == cardH[i][0] || cardT[1] == cardH[i][1])
    {
        play = true;
        break;
    } 
}
if(play) Console.WriteLine("YES");
else Console.WriteLine("NO");