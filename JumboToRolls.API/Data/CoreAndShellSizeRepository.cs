using JumboToRolls.API.Models;

namespace JumboToRolls.API.Data;

public static class CoreAndShellSizeRepository
{
    public static List<CoreDefinition> GetCoreSize()
    {
        return new List<CoreDefinition>
        {
            new CoreDefinition { SizeId = "CA40", Diameter = 100 }
        };
    }


    public static ShellDefinition GetShellSize = new ShellDefinition{Diameter = 1000};
}