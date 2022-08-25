Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int max = number1;

Console.Write("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2>max)max=number2;

Console.Write("Введите 3 число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if(number3>max)max=number3;

Console.Write("max = ");
Console.WriteLine(max);