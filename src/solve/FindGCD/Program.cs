int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);


#region Brute Force Approach
// Time Complexity : O(min(number1,number2)) , Space Complexity : O(1)

//int gcd = 1;

//for (int i = 1;  i < Math.Min(number1,number2);  i++)
//{
//    if (number1 % i == 0 && number2 % i == 0) gcd = i;
//}

//Console.WriteLine(gcd);
#endregion

#region Better Approach

//// Time Complexity : O(min(number1,number2)) , Space Complexity : O(1)
//int gcd = 1;

//for (int i = Math.Min(number1, number2); i >= 1; i--)
//{
//    if (number1 % i == 0 && number2 % i == 0)
//    {
//        gcd = i;
//        break;
//    }
//}

//Console.WriteLine(gcd);

#endregion

#region Better Approach - Euclidean Algorithm

int a, b;
if (number1 > number2)
{
    a = number1;
    b = number2;
}
else
{
    a = number2;
    b = number1;
}

int r = 0;
while (a % b != 0)
{
    r = a % b;
    a = b;
    b = r;
}
Console.WriteLine(b);

#endregion

