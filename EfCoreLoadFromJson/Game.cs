namespace EfCoreLoadFromJson;
public class Game
{
    public int GameId { get; set; }
    public string Title { get; set; }
    public string Developer { get; set; }
    public virtual List<Dlc> Dlcs { get; set; } = null!;

    public Game(string title, string developer)
    {
        Title = title;
        Developer = developer;
    }
}
