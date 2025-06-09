using JumboToRolls.API.Models;
namespace JumboToRolls.API.DTOs;

public class RollCalculationResult
{
    public List<RollResult> ValidRolls { get; set; } = new();
}