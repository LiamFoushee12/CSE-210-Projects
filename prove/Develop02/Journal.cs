using System;
using System.Collections.Generic;
using System.IO;


class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(':');
                if (data.Length == 3)
                {
                    string prompt = data[1].Trim();
                    string response = data[2].Trim();
                    Entry entry = new Entry(prompt, response);
                    entries.Add(entry);
                }
            }
        }
    }
}