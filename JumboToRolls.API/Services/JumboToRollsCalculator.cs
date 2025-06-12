using JumboToRolls.API.Data;
using JumboToRolls.API.DTOs;
using JumboToRolls.API.Models;
using JumboToRolls.API.Services.Helpers;

namespace JumboToRolls.API.Services;

public class JumboToRollsCalculator : IJumboToRollsCalculator
{
    
    
    public RollCalculationResult CalculateFromJumbo(int jumboPaperRadius, string coreType )
    {
        var rolls = RollSizeRepository.GetAll();
        var core = CoreAndShellSizeRepository.GetCoreSize(coreType);
        Dictionary<string, Dictionary<double, double>> waste = new Dictionary<string, Dictionary<double, double>>();
        foreach (var roll in rolls)
        {
            waste[roll.SizeId] = RollAndJumboOperations.NumberOfRoll(jumboPaperRadius, roll.MaxDiameter, core.Diameter);
            
        }
        
        var validRolls = waste
            .SelectMany(kv => kv.Value.Select(pair => new RollResult
            {
                SizeId = kv.Key,
                Quantity = (int)pair.Key,
                Waste = pair.Value
            }))
            .ToList();
        
        return new RollCalculationResult
        {
            ValidRolls = validRolls
        };
    }

    public RollCalculationResult CalculateFromSnapoff(int snapoffRadius, string coreType, List<string>? availableOrders)
    {
        // logic here
        return new RollCalculationResult();
    }
    
}