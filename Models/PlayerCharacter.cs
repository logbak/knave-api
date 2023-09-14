using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Knave_API.Models;
using Knave_API.Models.Enums;

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
    [JsonIgnore]
    public int AlignmentValue { get; set; }
    public string Alignment => AlignmentValue.AlignmentToString();
    [JsonIgnore]
    public int ArmorValue { get; set; }
    public string Armor => ArmorValue.ArmorToString();
    [JsonIgnore]
    public int HelmetAndShieldValue { get; set; }
    public string HelmetAndShield => HelmetAndShieldValue.HelmetAndShieldToString();
    public List<Item> Inventory { get; set; }

}
