internal class Dictionary
{
    private string originalWord;

    public Dictionary()
    {
        originalWord = "Standard text!";
    }

    public Dictionary(string originalWord)
    {
            this.OriginalWord = originalWord;
    }

    public Dictionary(Dictionary dictionary)
    {
        originalWord = dictionary.originalWord;
    }

    public string OriginalWord
    {
        get
        {
            return originalWord;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                originalWord = "Empty";
            else
                originalWord = value;
        }
    }

    public string makeShort()
    {
       
        return originalWord[0] + "" + originalWord[^1];
    }

    public override string ToString()
    {
        return $"Исходное слово: {originalWord}";
    }
}