public class Word
{
    public string Text { get; private set; }
    public bool Visible { get; private set; }

    public Word(string text)
    {
        Text = text;
        Visible = true;
    }

    public void Hide()
    {
        Visible = false;
    }

    public void Show()
    {
        Visible = true;
    }
}