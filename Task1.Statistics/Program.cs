namespace Task1;

class Program
{
  static void Main()
  {
    Random rnd = new Random();
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
      arr[i] = rnd.Next(1, 101);

    Console.WriteLine("Массив: " + string.Join(", ", arr));

    int sum = 0;
    long product = 1;
    int evenCount = 0;
    foreach (int x in arr)
    {
      sum += x;
      product *= x;
      if (x % 2 == 0) evenCount++;
    }

    double avg = (double)sum / arr.Length;
    int aboveAvg = 0;
    foreach (int x in arr)
      if (x > avg) aboveAvg++;

    Console.WriteLine($"Сумма: {sum}");
    Console.WriteLine($"Произведение: {product}");
    Console.WriteLine($"Чётных чисел: {evenCount}");
    Console.WriteLine($"Больше среднего ({avg:F1}): {aboveAvg}");
  }
}
