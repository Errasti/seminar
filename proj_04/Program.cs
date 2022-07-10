Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

/*
int i = -num;
while (i <= num)
{
    Console.Write(i + " ");
    i = i + 1;
}
*/

for (int i = -num; i <= num; i++)
{
    Console.Write(i + " ");
}