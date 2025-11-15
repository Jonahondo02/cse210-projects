using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public string VerseText { get; private set; }
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string verseText, Reference reference)
    {
        VerseText = verseText;
        Reference = reference;
        Words = verseText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var wordsToHide = Words.OrderBy(x => random.Next()).Take(count).ToList();
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string Display()
    {
        return string.Join(" ", Words.Select(word => word.Visible ? word.Text : "_____"));
    }

    public string GetReference()
    {
        return Reference.GetDisplayText();
    }
}