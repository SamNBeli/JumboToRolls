namespace JumboToRolls.API.Models;

public class RollDefinition
{
    public string SizeId { get; set; } = string.Empty;
    public int MinDiameter { get; set; }
    public int MaxDiameter { get; set; }
}