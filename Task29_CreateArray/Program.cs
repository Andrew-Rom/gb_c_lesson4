/* Задача 29
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
(на входе N- длина массива, 
min и max- ограничения для значений элементов массива, которые лежат в [min, max]) */

// Метод считывания
int GetNumFromUser(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

// Метод формирования массива
int[] CreateRandomArray(int quantity, int minValue, int maxValue)
{
    int[] array = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

// Метод вывода массива
string PrintArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i].ToString() + ", ";
    }
    result = result.Remove(result.Length - 2) + "]";
    return result;
}

Console.WriteLine("Генерация массива случайных чисел в промежутке между MIN и MAX включительно, длиной N.");
int n = GetNumFromUser("Введите длину массива (N): ");
int minNum = GetNumFromUser("Введите минимальное значение (MIN): ");
int maxNum = GetNumFromUser("Введите максимальное значение (MAX): ");
Console.WriteLine($"Результат: {PrintArray(CreateRandomArray(n, minNum, maxNum))}.");
