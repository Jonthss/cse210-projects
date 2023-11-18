using System;
using System.Collections.Generic;

namespace DailyScripture
{
    class Program
    {
        static void Main()
        {
            Scripture scripture = new Scripture("3 Nephi", 5, 13, "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.");
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue, type 'back' to undo, or 'exit' to quit.");

            Stack<List<Word>> previousStates = new Stack<List<Word>>();

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                    break;

                if (input == "back")
                {
                    if (previousStates.Count > 0)
                    {
                        List<Word> previousWords = previousStates.Pop();
                        scripture.RestoreWords(previousWords);
                        Console.Clear();
                        scripture.Display();
                        Console.WriteLine("\nPress Enter to continue, type 'back' to undo, or 'exit' to quit.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No more previous states to restore.");
                        continue;
                    }
                }

                // Save the current state before hiding words
                previousStates.Push(new List<Word>(scripture.GetWords()));

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou got this, you memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue, type 'back' to undo, or 'exit' to quit.");
            }
        }
    }
}