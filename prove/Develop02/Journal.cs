using System;
using System.Security.AccessControl;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public  Journal()
    {
    }

    public void AddEntry()
    {   
        Entry newEntry = new Entry();
    
        newEntry._date = DateTime.Now;

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.GetRandomPrompt();
        newEntry._promptText = promptGenerator._prompt;

        DateTime startTime = DateTime.Now;

        newEntry._entryText = Console.ReadLine();

        DateTime endTime = DateTime.Now;

        newEntry._duration = endTime - startTime;

        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date:yyyy-MM-dd HH:mm:ss}|{entry._promptText}|{entry._entryText}|{entry._duration.TotalSeconds}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        try
        {
            if (File.Exists(filename))
            {
                _entries.Clear();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4) 
                        {
                            DateTime entryDate = DateTime.ParseExact(parts[0], "yyyy-MM-dd HH:mm:ss", null);
                            double durationInSeconds = double.Parse(parts[3]);

                            Entry entry = new Entry
                            {
                                _date = entryDate,
                                _promptText = parts[1],
                                _entryText = parts[2],
                                _duration = TimeSpan.FromSeconds(durationInSeconds)
                            };
                            _entries.Add(entry);
                        }
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }


}