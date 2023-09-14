using System.ComponentModel.DataAnnotations;
using Knave_API.Models;

namespace Models;

public class PlayerCharacter
{
    [Range(1, 20)]
    public int Strength { get; set; }
    [Range(1, 20)]
    public int Dexterity { get; set; }
    [Range(1, 20)]
    public int Constitution { get; set; }
    [Range(1, 20)]
    public int Intelligence { get; set; }
    [Range(1, 20)]
    public int Wisdom { get; set; }
    [Range(1, 20)]
    public int Charisma { get; set; }
    public Traits Traits { get; set; }
    [Range(1, 20)]
    public int Alignment { get; set; }
    public int Armor { get; set; }
    public int HelmetAndShield { get; set; }
    public List<string> Inventory { get; set; }

}
