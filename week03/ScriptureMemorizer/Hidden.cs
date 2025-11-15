public class Hider
{
    private Scripture scripture;

    public Hider(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void HideWords(int count)
    {
        scripture.HideRandomWords(count);
    }
}