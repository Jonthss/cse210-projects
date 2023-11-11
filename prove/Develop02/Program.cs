using System;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

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
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your entry: ");
        string entryText = Console.ReadLine();

        journal.AddEntry(new Entry { _date = DateTime.Now.ToString(), _promptText = prompt, _entryText = entryText });
        Console.WriteLine("Entry added successfully.");
    }

    static void DisplayJournal(Journal journal)
    {
        journal.DisplayAll();
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}