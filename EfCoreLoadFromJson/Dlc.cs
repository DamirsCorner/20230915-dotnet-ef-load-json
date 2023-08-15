namespace EfCoreLoadFromJson;
public class Dlc
{
    public int DlcId { get; set; }
    public int GameId { get; set; }
    public virtual Game Game { get; set; } = null!;
    public string Title { get; set; }
    public virtual List<Achievement> Achievements { get; set; } = null!;

    public Dlc(string title)
    {
        Title = title;
    }
}
