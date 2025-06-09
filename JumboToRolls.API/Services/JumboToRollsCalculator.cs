using JumboToRolls.API.DTOs;

namespace JumboToRolls.API.Services;

public class JumboToRollsCalculator : IJumboToRollsCalculator
{
    
    
    public RollCalculationResult CalculateFromJumbo(int jumboPaperRadius, string coreType )
    {
        // logic here
        return new RollCalculationResult();
    }

    public RollCalculationResult CalculateFromSnapoff(int snapoffRadius, string coreType, List<string>? availableOrders)
    {
        // logic here
        return new RollCalculationResult();
    }
    
}