/* Программ выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (100 > num && num > -99)
{
    Console.WriteLine(num + " третьей цыфры не имеется");
}
if (99 < num && num < 1000)
{
    Console.WriteLine(num % 10);
}
if (-1000 < num && num < -99)
{
    Console.WriteLine(num % 10);
}
if (999 < num && num < 10000)
{
    Console.WriteLine((num % 100 - num % 10) / 10);
}
if (-1000 < num && num < -999)
{
    Console.WriteLine((num % 100 - num % 10) / 10);
}
if (9999 < num && num < 100000)
{
    Console.WriteLine((num % 1000 - num % 100) / 100);
}
if (-100000 < num && num < -9999)
{
    Console.WriteLine((num % 1000 - num % 100) / 100);
}
if (99999 < num && num < 1000000)
{
    Console.WriteLine((num % 10000 - num % 1000) / 1000);
}
if (-10000000 < num && num < -99999)
{
    Console.WriteLine((num % 100000 - num % 10000) / 10000);
}
