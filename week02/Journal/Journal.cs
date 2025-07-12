using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();

    public void WriteEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Time = DateTime.Now.ToString("hh:mm tt"),
            Prompt = prompt,
            Response = response
        };

        entries.Add(entry);
        Console.WriteLine("Entry saved.\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save to (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Time}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                entries.Add(new Entry
                {
                    Date = parts[0],
                    Time = parts[1],
                    Prompt = parts[2],
                    Response = parts[3]
                });
            }
        }

        Console.WriteLine("Journal loaded successfully.\n");
    }
}