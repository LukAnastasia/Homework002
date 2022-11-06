// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число "); 
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < 3 && (x <= 100 | x > 999); i=i+1)
//     {
//         Console.Write(i + "Число не является трехзначным, попробуйте ещё раз ");
//         x = Convert.ToInt32(Console.ReadLine());
//     }
//     x = x / 10 % 10;
//     Console.WriteLine($"Вторая цифра введённого числа {x}");

//  или 

// Console.WriteLine("Введите трехзначное число ");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = x % 100; 
// int x2 = x1 / 10;
// Console.WriteLine(x2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите любое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x / 100 > 0) Console.WriteLine ($"Третьей цифрой числа {x} является цифра {x / 100}");
// else Console.WriteLine("Нет третей цифры");
// Console.WriteLine();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите натуральное число ");
int x = Convert.ToInt32 (Console.ReadLine());
{
if(x==1) Console.WriteLine("Понедельник");
else if(x==2) Console.WriteLine("Вторник");
else if(x==3) Console.WriteLine("Среда");
else if(x==4) Console.WriteLine("Четверг");
else if(x==5) Console.WriteLine("Пятница");
else if(x==6) Console.WriteLine("Суббота");
else if(x==7) Console.WriteLine("Воскресенье");
}
if (x > 0 && x < 8)
{
    if (x == 6 || x == 7)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Рабочий");
    }
}
else
{
    Console.Write("Число не соответствует 7 дням недели");
}
return;



