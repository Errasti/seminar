/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int firstnum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdnum = int.Parse(Console.ReadLine());
int max = firstnum;

if ( max < secondnum )
{
    max = secondnum;
}
else if ( max < thirdnum )
{
    max = thirdnum;
}

Console.WriteLine("Максимальное число равно: " + max);

