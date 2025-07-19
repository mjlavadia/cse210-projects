using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Mosiah", 2, 17), 
                "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), 
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
        };

        Random rand = new Random(); //For extra credit, I included a part of the program where it will randomly selects one of the verses in the list above
        int index = rand.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords(2);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }

        Console.WriteLine("\nProgram ended. Thank you!");
    }
}