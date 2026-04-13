// Добавление произвольного количества минут(uint) к объекту типа Time. 
// Результат должен быть типа Time. 
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите часы: ");
            string hoursInput = Console.ReadLine();
            Console.Write("Введите минуты (0-59): ");
            string minInput = Console.ReadLine();

            if (byte.TryParse(hoursInput, out byte hours)
                && byte.TryParse(minInput, out byte min)&& min < 60)
            {
                Time currentTime = new(hours, min);
                Console.WriteLine($"Текущее время: {currentTime}");

                Console.Write("Сколько минут добавить? ");
                if (uint.TryParse(Console.ReadLine(), out uint minToAdd))
                {
                    currentTime += minToAdd;
                    Console.WriteLine($"Результат: {currentTime}");
                }
                else
                {
                    Console.WriteLine("Ошибка: некорректное" +
                        " количество минут.");
                }
                Console.Write("Сколько минут вычесть? ");
                if (uint.TryParse(Console.ReadLine(), out uint minToSub))
                {
                    currentTime -= minToSub;
                    Console.WriteLine($"Результат: {currentTime}");
                }
                else
                {
                    Console.WriteLine("Ошибка: некорректное" +
                        " количество минут.");
                }
                Console.WriteLine($"Количество часов: " +
                    $"{(byte)currentTime.Hours}");
                if ((byte)currentTime.Hours <= 59)
                {
                    if (currentTime.Hours < currentTime.Minutes)
                    {
                        Console.WriteLine("Уменьшение количества минут " +
                            "до количества часов");
                        while (currentTime.Hours < currentTime.Minutes)
                        {
                            currentTime.Minutes--;
                        }
                        Console.WriteLine($"Результат: {currentTime}");
                    }
                    else if (currentTime.Hours > currentTime.Minutes)
                    {
                        Console.WriteLine("Увеличение количества минут " +
                            "до количества часов");
                        while (currentTime.Hours > currentTime.Minutes)
                        {
                            currentTime.Minutes++;
                        }
                        Console.WriteLine($"Результат: {currentTime}");
                    }
                    else Console.WriteLine($"Время равно: {currentTime}");
                }
                else
                {
                    Console.WriteLine("Время превышает количество возможных минут");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: некорректный формат " +
                    "времени (часы 0 - 255, минуты - 0-59).");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла непредвиденная" +
                $" ошибка: {ex.Message}");
        }

    }
}