using JumboToRolls.API.Models;

namespace JumboToRolls.API.Data;

public static class RollSizeRepository
{
    public static List<RollDefinition> GetAll()
    {
        return new List<RollDefinition>
        {
            new RollDefinition { SizeId = "S-40", MinDiameter = 966, MaxDiameter = 1016 },
            new RollDefinition { SizeId = "S-42", MinDiameter = 1017, MaxDiameter = 1067 },
            new RollDefinition { SizeId = "S-45", MinDiameter = 1093, MaxDiameter = 1143 },
            new RollDefinition { SizeId = "S-50-1", MinDiameter = 1200, MaxDiameter = 1250 },
            new RollDefinition { SizeId = "S-50-2", MinDiameter = 1220, MaxDiameter = 1270 }
        };
    }
}