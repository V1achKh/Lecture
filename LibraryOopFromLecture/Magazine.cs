namespace Library;

class Magazine: LibraryItem
{
    public int IssueNumber { get ; set ; }
    public string Publisher { get; set; }

    public override string GetCardInfo()
    {
        return $"{Title} - {Publisher}";
    }

    public Magazine(string title, int year, int issueNumber, string publisher) : 
        base(title, year)
    {
        this.IssueNumber = issueNumber;
        this.Publisher = publisher;
    }

    public override string GetInfo()
    {
        return $"{Title} - {Year} - {IssueNumber} - {Publisher}";
    }
}