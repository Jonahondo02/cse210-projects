using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world that he gave his one and only Son";
        Scripture scripture = new Scripture(verseText, reference);

        Console.WriteLine("Original Verse:");
        Console.WriteLine(scripture.Display());

        scripture.HideRandomWords(3);
        Console.WriteLine("\nVerse with Hidden Words:");
        Console.WriteLine(scripture.Display());

        Console.WriteLine("\nReference:");
        Console.WriteLine(scripture.GetReference());
    }
}