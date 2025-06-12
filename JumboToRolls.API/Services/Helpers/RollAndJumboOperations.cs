using JumboToRolls.API.Data;
using JumboToRolls.API.Models;

namespace JumboToRolls.API.Services.Helpers;

public static class RollAndJumboOperations
{
    private static double AreaOfJumboPaper(int jumboPaperRadius, ShellDefinition shellDiameter)
    {
        
        var shellRadius = shellDiameter.Diameter / 2;
        var jumboRadius = jumboPaperRadius + shellRadius;
        return Math.PI * (Math.Pow(jumboRadius, 2) - Math.Pow(shellRadius, 2));
    }

    private static double AreaOfRollPaper(int rollDiameter, int coreDiameter)
    {
        var coreRadius = coreDiameter / 2;
        var rollRadius =(rollDiameter / 2);
        return Math.PI * (Math.Pow(rollRadius, 2) - Math.Pow(coreRadius, 2));
    }

    public static Dictionary<double, double> NumberOfRoll(int jumboPaperRadius, int rollDiameter, int coreType)
    {
        Dictionary<double, double> rolls = new Dictionary<double, double>();
        
        var areaJumbo = AreaOfJumboPaper(jumboPaperRadius, CoreAndShellSizeRepository.GetShellSize);
        var areaRoll = AreaOfRollPaper(rollDiameter, coreType);
        var numberOfRolls = areaJumbo / areaRoll;
        var totalUsed = (int)numberOfRolls * areaRoll;
        var waste = areaJumbo - totalUsed;
        Console.WriteLine($"Number of rolls: {numberOfRolls}, roll Diameter: {rollDiameter}, core Type: {coreType}, area Jumbo {areaJumbo}, Total used {totalUsed}, waste: {waste}");

        rolls[numberOfRolls] = waste;
        return rolls;
    }
}