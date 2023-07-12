namespace edu.byui.cs210.dev3;
using System;
using System.Collections.Generic;


public class Scripture
{
    public string Text { get; set; }
    public Reference Reference { get; set; }

    private List<Word> Words = new List<Word>();

    private List<int> HiddenWords = new List<int>();

    private int callCount = 0;
    public Scripture(string text, Reference reference)
    {
        this.Text = text;
        this.Reference = reference;
        var array = text.Split(" ");

        foreach (string s in array)
        {
            this.Words.Add(new Word(s));
        }

    }
    public void Print()
    {
        Console.Write(this.Reference.Text);
        Console.Write(" ");
        int i = 0;
        foreach (var item in this.Words)
        {
            Console.Write(this.HiddenWords.Contains(i) ? item.HiddenText : item.Text);
            Console.Write(" ");
            i++;

        }
        this.callCount++;
        this.AddNewRandom();
    }
    private void AddNewRandom()
    {

        if (this.Words.Count == this.HiddenWords.Count)
        {
            //If all the words are hidden just return
            return;
        }
        //Generate a random number not in the list
        //add it to the list 
        Random randomGenerator = new Random();
        int number;
        do
        {
            number = randomGenerator.Next(1, this.Words.Count);
        } while (this.HiddenWords.Contains(number));

        this.HiddenWords.Add(number);
    }


}