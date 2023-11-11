class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator(new System.Collections.Generic.List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        });

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    LoadJournal(journal);
                    break;
                case "4":
                    SaveJournal(journal);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    Console.ResetColor(); 
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.ForegroundColor = ConsoleColor.Cyan; 
        Console.WriteLine($"Prompt: {prompt}");
        Console.ResetColor(); 

        Console.Write("Your entry: ");
        string entryText = Console.ReadLine();

        journal.AddEntry(new Entry { _date = DateTime.Now.ToString(), _promptText = prompt, _entryText = entryText });

        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("Entry added successfully.");
        Console.ResetColor(); 
    }

    static void DisplayJournal(Journal journal)
    {
        Console.ForegroundColor = ConsoleColor.Yellow; 
        journal.DisplayAll();
        Console.ResetColor(); 
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);

        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("Journal saved successfully.");
        Console.ResetColor(); 
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}