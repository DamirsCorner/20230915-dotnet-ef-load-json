namespace EfCoreLoadFromJson;
public class Achievement
{
    public int AchievementId { get; set; }
    public int DlcId { get; set; }
    public virtual Dlc Dlc { get; set; } = null!;
    public string Name { get; set; }
    public string Description { get; set; }
    public int Gamerscore { get; set; }

    public Achievement(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
