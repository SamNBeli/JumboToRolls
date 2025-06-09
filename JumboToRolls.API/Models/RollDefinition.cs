namespace JumboToRolls.API.Models;

public class RollDefinition
{
    public string SizeId { get; set; } = string.Empty;
    public double MinDiameter { get; set; }
    public double MaxDiameter { get; set; }
}