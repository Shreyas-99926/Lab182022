Console.WriteLine("Enter the value of a");
int a =  int.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b");
start: int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the operation you need to perform");
Char operand = Convert.ToChar(Console.ReadLine());  

switch(operand)
{
    case '+':
        Console.WriteLine(addition(a, b));
        break;
    case '-':
        Console.WriteLine(subtraction(a, b));
        break;
    case '*':
        Console.WriteLine(multiplication(a, b));
        break;
    case '/':
        if (b == 0)
        {
            Console.WriteLine("division not possible");
            goto start;
        }
        else
        {
            Console.WriteLine(division(a, b));
        }
        break;
    default:
        Console.WriteLine("Invalid");
        break;

}
static int addition(int a, int b)
{
    return a + b;
}
static int subtraction(int a, int b)
{
    return a - b;
}
static int multiplication(int a, int b)
{
    return a * b;
}
static double division(double a, double b)
{
    return (a / b);
}