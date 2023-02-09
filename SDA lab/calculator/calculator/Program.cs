Console.WriteLine("This is the calculator!");
Console.WriteLine("Enter the two numbers which you want to perform arithmetic operations!");
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the operation which you want to do?");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiply");
Console.WriteLine("4.Division");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("The addition of two numbers is = " + (b + c));
        break;
        case 2:
        Console.WriteLine("The subtraction of two numbers is = " + (b - c));
        break;
    case 3:
        Console.WriteLine("The multiplication of two numbers is = " + (b * c));
        break;
    case 4:
        Console.WriteLine("The division of two numbers is = " + (b / c));
        break;
}
