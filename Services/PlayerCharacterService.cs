using Dice;
using Knave_API.Models;
using Knave_API.Models.Enums;
using Models;

public class playerCharacterService : IPlayerCharacterService
{
    public PlayerCharacter Random()
    {
        return new PlayerCharacter()
        {
            Strength = RollForAttribute(),
            Dexterity = RollForAttribute(),
            Constitution = RollForAttribute(),
            Intelligence = RollForAttribute(),
            Wisdom = RollForAttribute(),
            Charisma = RollForAttribute(),
            Traits = new Traits()
            {
                Background = (Background) RollD20(),
                Clothing = (Clothing) RollD20(),
                Face = (Face) RollD20(),
                Hair = (Hair) RollD20(),
                Misfortune = (Misfortune) RollD20(),
                Physique = (Physique) RollD20(),
                Skin = (Skin) RollD20(),
                Speech = (Speech) RollD20(),
                Vice = (Vice) RollD20(),
                Virtue = (Virtue) RollD20(),

            },
            Inventory = new List<Item>()
            {
                StartingConstants.StartingDungeneeringGear[RollD20()],
                StartingConstants.StartingDungeneeringGear[RollD20()],
                StartingConstants.StartingGearOne[RollD20()],
                StartingConstants.StartingGearTwo[RollD20()]
            }
        };
    }

    private int RollD20() => (int) Roller.Roll("1d20").Value;

    private int RollForAttribute()
    {
        return new List<int>
        {
            (int) Roller.Roll("1d6").Value,
            (int) Roller.Roll("1d6").Value,
            (int) Roller.Roll("1d6").Value,
        }.Min();
    }
}