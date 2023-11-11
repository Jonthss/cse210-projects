public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Clear existing entries before loading from file

        try
        {
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];

                    _entries.Add(new Entry { _date = date, _promptText = prompt, _entryText = entryText });
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}