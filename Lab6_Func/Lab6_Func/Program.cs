
//Базовый уровень. 18 вариант.
using System.ComponentModel;
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр a + b = {Func(a)+Func(b)}");
int Func(int i)
{
    if (i >= 10 && i <= 99)
    {
        int des = i / 10;

        int ed = i % 10;
        int sum = des+ed;
        return sum;
    }
    else
    {
        return 0;
    }
}


