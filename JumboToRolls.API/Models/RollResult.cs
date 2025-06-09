namespace JumboToRolls.API.Models;

public class RollResult
{
    public string SizeId { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double UsedArea { get; set; }
    public double TotalAvailableArea { get; set; }
    public double Efficiency => UsedArea / TotalAvailableArea;
}