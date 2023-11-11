public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {DateTime.Parse(_date).ToString("dd/MM/yyyy")} - Prompt: {_promptText}");
        Console.WriteLine($"Speak: {_entryText}\n");
    }
}