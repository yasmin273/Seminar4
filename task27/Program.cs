// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;
int res = 0;
for (sum = 0; number > 0; sum++)
{
    number = number % 10;
    //res = sum + number;
    Console.WriteLine(number);

}

Console.WriteLine(res);