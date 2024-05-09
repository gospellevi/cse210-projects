using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string promptText, string entryText)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _entries.Add(new Entry(date, promptText, entryText));
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in your journal yet.");
        }
        else
        {
            foreach (Entry entry in _entries)
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
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.GetDate());
                    writer.WriteLine(entry.GetPromptText());
                    writer.WriteLine(entry.GetEntryText());
                    writer.WriteLine("----");
                }
            }
            Console.WriteLine("Journal saved successfully to {0}.", file);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving journal: {0}", ex.Message);
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Clear existing entries before loading

        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File not found: {0}", file);
                return;
            }

            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                string date = null;
                string promptText = null;
                string entryText = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (date == null)
                    {
                        date = line;
                    }
                    else if (promptText == null)
                    {
                        promptText = line;
                    }
                    else if (entryText == null)
                    {
                        entryText = line;
                    }
                    else if (line == "----")
                    {
                        if (date != null && promptText != null && entryText != null)
                        {
                            _entries.Add(new Entry(date, promptText, entryText));
                        }

                        date = null;
                        promptText = null;
                        entryText = null;
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully from {0}.", file);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal: {0}", ex.Message);
        }
    }
}