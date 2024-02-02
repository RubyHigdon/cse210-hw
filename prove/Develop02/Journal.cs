public class Journal
{
    //Create an empty list to store the entries
    public List<string> _entries = new List<string>();

    //Create an empty variable to store user input of the file name
    public string _fileName;

    //Invoke constructor method
    public Journal()
    {
    }

    //Iterate through the list of entries and display each entry
    public void DisplayJournal()
    {
        foreach (string log in _entries)
        {
            Console.WriteLine($"{log}\n");
        }
    }

    public void LoadFile()
    {
        //Read user inputted file
        string fileContent = System.IO.File.ReadAllText(_fileName);

        //Split file into entries
        string[] parts = fileContent.Split("~|~");
        foreach (string part in parts)
        {
            //eliminate whitespace and add each entry to the journal
            if (!string.IsNullOrWhiteSpace(part))
            {
                _entries.Add(part.Trim());
            }
        } 
    }
    
    public void SaveFile()
    {
        //Write each entry in new file with file name inputted by user
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(string log in _entries)
            {
                outputFile.WriteLine($"{log}~|~");
            }
        }
    }
    
}