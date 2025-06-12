using JumboToRolls.API.Models;

namespace JumboToRolls.API.Data;

public static class CoreAndShellSizeRepository
{
    public static CoreDefinition? GetCoreSize(string sizeId)
    {
        var allSizes = new List<CoreDefinition>
        {
            new CoreDefinition { SizeId = "CA40", Diameter = 100 }
        };

        return allSizes.FirstOrDefault(c => c.SizeId == sizeId);
    }


    public static ShellDefinition GetShellSize = new ShellDefinition{Diameter = 1000};
}