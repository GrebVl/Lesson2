/* Программ выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


if (100 < num && num < 1000)
{
    Console.WriteLine(num % 10);
}
if (1000 < num && num < 10000)
{
    Console.WriteLine((num % 100 - num % 10) / 10);
}
if (10000 < num && num < 100000)
{
    Console.WriteLine((num % 1000 - num % 100) / 100);
}
else
{
    Console.WriteLine(num + " третьей цыфры не имеется");
}