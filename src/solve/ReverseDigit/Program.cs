#region Opimal Approach
// Time Complexity : O(log(number) , Space Complexity : O(1)

int number = int.Parse(Console.ReadLine()!);
int temp = number;
int reversedNumber = 0;
while(temp != 0)
{
    reversedNumber = reversedNumber * 10 + temp % 10;
    temp /= 10;
}
Console.WriteLine(reversedNumber);

#endregion