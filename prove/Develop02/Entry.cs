using System.Diagnostics.Contracts;
using System.Drawing;
using Microsoft.VisualBasic;

public class Entry
{
    //Create empty variables
    public string _journalEntry;
    public string _prompt;
    public string _promptType;

    //Generate the date and store it as a string
    static DateTime dateNow = DateTime.Now;
    public string _date = dateNow.ToShortDateString();

    //Invoke constructor method
    public Entry()
    {
    }

    //Create function to format entry
    public string FormatEntry()
    {
        return $"Date: {_date} - Prompt[{_promptType}]: {_prompt} \n{_journalEntry}";
    }
}