дз семинар 3.1
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

if(a > b)
{
    Console.WriteLine($"max = {a}\nmin = {b}");
}

else
{
    Console.WriteLine($"max = {b}\nmin = {a}");
} 

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!); 
Console.Write("Введите число: ");
int c = int.Parse(Console.ReadLine()!);
//если a больше b, то открываем if(a > c), если нет то переходим в else if(b > c)
if(a > b)
{
//если а больше c, то макс = а
if(a > c)
    Console.Write($"max = {a} ");
//если нет, то макс = с
else
   Console.Write($"max = {c} ");
}
//проверяем b
else if (b > c)
{
    Console.Write($"max = {b} ");
}
else {
    Console.Write($"max = {c} ");
} 

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет  */

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int b = a % 2;
if(b == 0)
{
    Console.Write("да ");
}
else 
{
    Console.Write("нет ");
}

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= n; i++)
{
    if((i % 2) == 0)
    Console.Write($"{i} ");
}