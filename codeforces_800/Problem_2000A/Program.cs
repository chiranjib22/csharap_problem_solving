/*
 * Problem Link : https://codeforces.com/problemset/problem/2000/A
 */

int t = int.Parse(Console.ReadLine()!);

while(t-- > 0)
{
    string num = Console.ReadLine()!;

    if(num.Length > 2)
    {
        if (num[0] == '1' && num[1] == '0')
        {
            string expo = "";
            for (int i = 2; i < num.Length; i++) expo += num[i];

            int expoNum = 0;
            if (expo[0] != '0') expoNum = int.Parse(expo); 

            if(expoNum >= 2) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        else Console.WriteLine("NO");
    } else Console.WriteLine("NO");
}