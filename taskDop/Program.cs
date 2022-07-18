/*
программ принимает на вход число N и выводит 
все простые числа в промежутке 
от 0 до N (включительно).

*/



Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int index = 0;

while (index <= num)
{
    if (index % 2 > 0 && index > 1)
    {
        Console.Write(index+" ");
    }
    if (index == 2)
    {
        Console.Write(index+" ");
    }
    index++;
}
Console.WriteLine(" ");


