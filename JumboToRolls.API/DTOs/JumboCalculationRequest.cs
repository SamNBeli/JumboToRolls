namespace JumboToRolls.API.DTOs;

public class JumboCalculationRequest
{
    public int JumboPaperRadius { get; set; }
    public string CoreType { get; set; } = string.Empty;
}