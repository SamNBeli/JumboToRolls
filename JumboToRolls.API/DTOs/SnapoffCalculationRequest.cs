namespace JumboToRolls.API.DTOs;

public class SnapoffCalculationRequest
{
    public int SnapoffRadius { get; set; }
    public string CoreType { get; set; } = string.Empty;
    public List<string>? AvailableOrders { get; set; }
}