// Вариант: 2 — Палиндром
// Номер в журнале: 20 (20 % 3 = 2)

namespace Final;

class Program
{
    static void Main()
    {
        // 1. Запрос массива у пользователя
        Console.Write("Введите массив (числа через пробел): ");
        string input = Console.ReadLine();

        // Разбиваем строку по пробелам, убирая пустые фрагменты
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Преобразуем строки в числа
        int[] arr = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            arr[i] = int.Parse(parts[i]);
        }

        // 2. Проверка на палиндром
        // Сравниваем элементы симметрично: arr[0] с arr[n-1], arr[1] с arr[n-2] и т.д.
        bool isPalindrome = true;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        // 3. Вывод результата
        if (isPalindrome)
            Console.WriteLine("Массив — палиндром");
        else
            Console.WriteLine("Массив — не палиндром");
    }
}
