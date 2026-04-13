// Разработать словарь, который сокращает строку до первого и последнего символа.
// Также разработать продвинутую версию словаря, который будет находить насколько сократилась строка, а также разворачивать новое слово.
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary dictionary1 = new Dictionary();
        Console.WriteLine("Введите новое слово, которое нужно сократить: ");
        string word = Console.ReadLine();
        Dictionary dictionary2 = new Dictionary(word);
        Dictionary dictionary3 = new Dictionary(dictionary2);
        Console.WriteLine($"Слово 1, по умолчанию {dictionary1}, " +
            $"его сокращение - {dictionary1.makeShort()}");
        Console.WriteLine($"Слово 2, ввод пользователя " +
            $"{dictionary2}, его сокращение - " +
            $"{dictionary2.makeShort()}");
        Console.WriteLine($"Слово 3, копирование второго слова " +
            $"{dictionary3}, его сокращение - " +
            $"{dictionary3.makeShort()}");

        AdvancedDictionary aDictionary1 = new AdvancedDictionary();
        Console.WriteLine("Введите другое новое слово, которое нужно сократить: ");
        word = Console.ReadLine();
        AdvancedDictionary aDictionary2 = new AdvancedDictionary(word);
        AdvancedDictionary aDictionary3 = new AdvancedDictionary(aDictionary2);

        Console.WriteLine($"Слово 1, по умолчанию {aDictionary1}, " +
            $"его сокращение - {aDictionary1.makeShort()}");
        Console.WriteLine($"Слово 2, ввод пользователя " +
            $"{aDictionary2}, его сокращение - " +
            $"{aDictionary2.makeShort()}");
        Console.WriteLine($"Слово 3, копирование второго слова " +
            $"{aDictionary3}, его сокращение - " +
            $"{aDictionary3.makeShort()}");

        aDictionary2.howMuchShort();
        aDictionary2.reversWord();


    }
}