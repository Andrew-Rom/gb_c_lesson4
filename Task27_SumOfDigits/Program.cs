/* Задача 27
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

Console.WriteLine("Опеределение суммы цифр в числе.");
int number = GetNumFromUser("Введите число: ");
int tempNumber = Math.Abs(number);
int result = 0;
while (tempNumber > 0)
{
    result = result + tempNumber % 10;
    tempNumber /= 10;
}
Console.WriteLine($"Сумма цифр {number} равна: {result}.");