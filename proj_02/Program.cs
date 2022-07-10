Console.WriteLine("Это программа проверяет является ли первое число, квадратом второго");
Console.WriteLine("Введите первое число: ");
int firstnum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secnum = int.Parse(Console.ReadLine());

if (firstnum / secnum == secnum )
{
    Console.WriteLine("Это квадрат второго числа!");
}
else
{
    Console.WriteLine("Это не квадрат второго числа!");
}
