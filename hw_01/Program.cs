/* Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

Console.WriteLine("Введите первое число: ");
int firstnum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnum = int.Parse(Console.ReadLine());

if ( firstnum > secondnum )
{
    Console.WriteLine("Максимальное число равно: " + firstnum );
}
else if ( secondnum > firstnum )
{
    Console.WriteLine("Максимальное число равно: " + secondnum );
}
else if ( firstnum == secondnum )
{
    Console.WriteLine("Числа равны!");
}
