namespace Task4;

class Program
{
  static void Main()
  {
    int[] arr = new int[5];

    // 1. Заполнение с обработкой исключений
    for (int i = 0; i < arr.Length; i++)
    {
      while (true)
      {
        Console.Write($"Введите элемент [{i}]: ");
        try
        {
          arr[i] = int.Parse(Console.ReadLine());
          break;
        }
        catch (FormatException)
        {
          Console.WriteLine("Ошибка: Введите целое число!");
        }
        catch (OverflowException)
        {
          Console.WriteLine("Ошибка: Число слишком большое!");
        }
      }
    }

    // 2. Запрос индекса с обработкой IndexOutOfRangeException
    while (true)
    {
      Console.Write("Введите индекс для вывода (0-4): ");
      try
      {
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Элемент [{index}] = {arr[index]}");
        break;
      }
      catch (FormatException)
      {
        Console.WriteLine("Ошибка: введите целое число!");
      }
      catch (OverflowException)
      {
        Console.WriteLine("Ошибка: число слишком большое!");
      }
      catch (IndexOutOfRangeException)
      {
        Console.WriteLine("Ошибка: Индекс вне границ массива.");
      }
    }
  }
}