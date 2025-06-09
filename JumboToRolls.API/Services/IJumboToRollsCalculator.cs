using JumboToRolls.API.DTOs;

namespace JumboToRolls.API.Services;

public interface IJumboToRollsCalculator
{
    RollCalculationResult CalculateFromJumbo(int jumboPaperRadius, string coreType);
    RollCalculationResult CalculateFromSnapoff(int snapoffRadius, string coreType, List<string>? availableOrders);
}