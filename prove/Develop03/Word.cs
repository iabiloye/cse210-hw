class Word
{
    private string value;
    private bool isHidden;

    public Word(string value)
    {
        this.value = value;
        this.isHidden = false;
    }

    public bool IsHidden => isHidden;

    public void Hide()
    {
        isHidden = true;
    }

    public override string ToString()
    {
        return isHidden ? "_____" : value;
    }
}
