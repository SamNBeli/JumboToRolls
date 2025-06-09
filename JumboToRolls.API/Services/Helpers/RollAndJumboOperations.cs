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

    public static int NumberOfRoll(int jumboPaperRadius, int rollDiameter, int coreType)
    {
        return (int)(AreaOfJumboPaper(jumboPaperRadius, CoreAndShellSizeRepository.GetShellSize ) - AreaOfRollPaper(rollDiameter, coreType));
    }
}