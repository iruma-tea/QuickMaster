namespace QuickMaster.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public int Price { get; set; }
    public string Publisher { get; set; } = String.Empty;
    public bool Sample { get; set; }
}