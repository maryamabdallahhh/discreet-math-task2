// See https://aka.ms/new-console-template for more information
using System.Security;

Console.Write("Enter the  first number to  : ");
int num1 =int.Parse(Console.ReadLine());
Console.Write("Enter the the second number : ");
int num2 =int.Parse(Console.ReadLine());
Console.Write("the perfect numbers betwen " + num1 + " and " + num2 + " is : ");
 for(int i = num1; i < num2; i++)
{
    int n = i, sum = 0, factor = 1;
    while (factor < n)
    {
        if (n % factor == 0)
            sum = sum + factor;
        factor++;
    }
    if (sum == i) Console.WriteLine(i + "");
}
