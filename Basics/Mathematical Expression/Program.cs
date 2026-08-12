string[] symbole = Console.ReadLine()!.Split(" ").ToArray();

int A = Convert.ToInt32(symbole[0]);
int B = Convert.ToInt32(symbole[2]);

char symbol = Convert.ToChar(symbole[1]);

int C = Convert.ToInt32(symbole[4]);

switch (symbol)
{
    case '+':
        if (A + B == C)
            Console.WriteLine("Yes");
        else
            Console.WriteLine(A + B);
        break;
    case '-':
        if (A - B == C)
            Console.WriteLine("Yes");
        else
            Console.WriteLine(A - B);
        break;
    case '*':
        if (A * B == C)
            Console.WriteLine("Yes");
        else
            Console.WriteLine(A * B);
        break;

}
