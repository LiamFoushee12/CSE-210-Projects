namespace edu.byui.cs210.dev3;
using System.Text.RegularExpressions;
public class Word
{

    public string Text { get; set; }
    public string HiddenText { get; set; }


    public Word(string text)
    {
        this.Text = text;
        this.HiddenText = Regex.Replace(text, "[a-zA-Z0-9]", "_");
    }
}