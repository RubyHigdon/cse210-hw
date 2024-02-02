using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Welcome the user
        Console.WriteLine("Welcome to the Journal Program!");

        //Create new instance of the Journal class
        Journal journal = new Journal();

        //Display a looping menu for the user
        int menu;
        do
        {
            Console.WriteLine("\nPlease select one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                //Create a new instance of the entry class
                Entry entry = new Entry();
                Prompt prompt = new Prompt();

                //Allow user to select a type of prompt
                Console.WriteLine("\nPrompt types: ");
                Console.WriteLine("1. Quick response \n2. Reflective \n3. Creative");
                Console.Write("What type of prompt would you like to answer? ");
                int selection = int.Parse(Console.ReadLine());

                //Generate and display appropriate prompt type
                if (selection == 1)
                {
                    //Save the prompt and type to the entry case
                    entry._promptType = "Quick Response";
                    entry._prompt = prompt.GenerateQuickPrompt();

                    //Display the prompt
                    Console.WriteLine(entry._prompt);
                }
                else if (selection == 2)
                {
                    //Save the prompt and type to the entry case
                    entry._promptType = "Reflective";
                    entry._prompt = prompt.GenerateReflectivePrompt();

                    //Display the prompt
                    Console.WriteLine(entry._prompt);
                }
                else if (selection == 3)
                {
                    //Save the prompt and type to the entry case
                    entry._promptType = "Creative";
                    entry._prompt = prompt.GenerateCreativePrompt();

                    //Display the prompt
                    Console.WriteLine(entry._prompt);
                }

                //Allow user to write
                Console.Write("> ");
                entry._journalEntry = Console.ReadLine();

                //Format entry and add to the journal
                string formattedEntry = entry.FormatEntry();
                journal._entries.Add(formattedEntry);
            }

            else if (menu == 2)
            {
                //Call the Display function from the journal class
                journal.DisplayJournal();
            }

            else if (menu == 3)
            {
                //Clear the current journal to replace with loaded file
                journal._entries.Clear();
                
                //Store file name to journal instance
                Console.Write("What is the file name? ");
                journal._fileName = Console.ReadLine();

                //Call the Load function from the journal class
                journal.LoadFile();
            }

            else if (menu == 4)
            {
                //Store file name to journal instance
                Console.Write("What is the file name? ");
                journal._fileName = Console.ReadLine();

                //Call the Save function from the journal class
                journal.SaveFile();
            }

            else if (menu == 5)
            {
                //Say goodbye if user quits
                Console.WriteLine("Goodbye!");
            }

            else
            {
                //Display error message for invalid entry
                Console.WriteLine("Invalid entry. Please enter a number 1-5");
            }

        //Quit the loop if user enters 5
        } while(menu != 5);
    }
}