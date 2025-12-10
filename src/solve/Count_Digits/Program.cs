
#region BRUTEFORCE
//int number = Convert.ToInt32(Console.ReadLine());
//int temp = number;
//int count = 0;
//while(temp!=0)
//{
//    count++;
//    temp /= 10;
//}
//Console.WriteLine(count);
#endregion

#region OPTIMAL
int number = Convert.ToInt32(Console.ReadLine());
int count = (number > 0) ? (int)Math.Log10(number) + 1 : 1;
Console.WriteLine(count);
#endregion


