internal class AdvancedDictionary:Dictionary
{
    public AdvancedDictionary()
        : base()
    { }
    public AdvancedDictionary(string originalWord)
        : base(originalWord)
    { }
    public AdvancedDictionary(AdvancedDictionary advancedDictionary)
        : base(advancedDictionary)
    { }

    public void howMuchShort()
    {
        string shortWord = makeShort();
        double efficiency = (shortWord.Length)*100.0/
            this.OriginalWord.Length;
        Console.WriteLine($"Слово сократилось с эффективностью:" +
            $" {100-efficiency}%");
    }

    public void reversWord()
    {
        string shortWord = makeShort();
        shortWord = shortWord[1]+""+shortWord[0];
        Console.WriteLine($"развернутая строка: {shortWord}");
    }
    public override string ToString()
    {
        return $"Исходное слово: {OriginalWord}";
    }
}