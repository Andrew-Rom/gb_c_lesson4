/* Задача 25
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Применять Math.Pow нельзя! */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод проверки числа B
bool IsNumValid(int bNum)
{
    if (bNum <= 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// Метод возведения в степень
double Exponentiation(double a, int b)
{
    double result = a;
    for (int i = 2; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine("Возведение A в натуральную степень B");
double a = GetNumFromUser("Введите число: ");
int b = GetNumFromUser("Введите степень: ");
bool isValid = IsNumValid(b);
if (isValid)
{
    Console.WriteLine($"Результат возведения числа {a} в степень {b}: {Exponentiation(a, b)}.");
}
else
{
    Console.WriteLine("Введено некорректное число степени (B).");
}