using System.Collections.Immutable;
using Knave_API.Models.Enums;

namespace Knave_API.Models;

public static class StartingConstants
{

    public static ImmutableDictionary<int, Item> StartingDungeneeringGear => new Dictionary<int, Item>()
    {
        { 1, Item.Rope },
        { 2, Item.Pulleys },
        { 3, Item.Candle },
        { 4, Item.Chain },
        { 5, Item.Chalk },
        { 6, Item.Crowbar },
        { 7, Item.Tinderbox },
        { 8, Item.GrapplingHook },
        { 9, Item.Hammer },
        { 10, Item.Waterskin },
        { 11, Item.Lantern },
        { 12, Item.LampOil },
        { 13, Item.PadlockAndKey },
        { 14, Item.Manacles },
        { 15, Item.Mirror },
        { 16, Item.Pole },
        { 17, Item.Sack },
        { 18, Item.TentPersonal },
        { 19, Item.SpikeWood },
        { 20, Item.Torch },
    }.ToImmutableDictionary();

    public static ImmutableDictionary<int, Item> StartingGearOne => new Dictionary<int, Item>()
    {
        { 1, Item.AirBladder },
        { 2, Item.BearTrap },
        { 3, Item.Shovel },
        { 4, Item.Bellows },
        { 5, Item.BlackGrease },
        { 6, Item.Saw },
        { 7, Item.Bucket },
        { 8, Item.CaltropsBag },
        { 9, Item.Chisel },
        { 10, Item.Drill },
        { 11, Item.FishingRodOrTackle },
        { 12, Item.GlassMarbles },
        { 13, Item.Glue },
        { 14, Item.Pick },
        { 15, Item.Hourglass },
        { 16, Item.Net },
        { 17, Item.IronTongs },
        { 18, Item.Lockpicks },
        { 19, Item.MetalFile },
        { 20, Item.Nails }
    }.ToImmutableDictionary();

    public static ImmutableDictionary<int, Item> StartingGearTwo => new Dictionary<int, Item>()
    {
        { 1, Item.Incense },
        { 2, Item.LargeSponge },
        { 3, Item.Lens },
        { 4, Item.Perfume },
        { 5, Item.Horn },
        { 6, Item.BottleOrVial },
        { 7, Item.Soap },
        { 8, Item.Spyglass },
        { 9, Item.Tar },
        { 10, Item.Twine },
        { 11, Item.FakeJewels },
        { 12, Item.BookBlank },
        { 13, Item.CardDeck },
        { 14, Item.SetOfDice },
        { 15, Item.Cookpots },
        { 16, Item.FacePaintOrMakeup },
        { 17, Item.Whistle },
        { 18, Item.MusicalInstrument },
        { 19, Item.QuillAndInk },
        { 20, Item.SmallBell },
    }.ToImmutableDictionary();

    public static ImmutableDictionary<Item, int> ItemCosts => new Dictionary<Item, int>()
    {
        { Item.AirBladder, 5 },
        { Item.BearTrap, 20 },
        { Item.Bedroll, 10 },
        { Item.Bellows, 10 },
        { Item.BlackGrease, 1 },
        { Item.BlockAndTackle, 30 },
        { Item.BookBlank, 300 },
        { Item.BookReading, 600 },
        { Item.BottleOrVial, 1 },
        { Item.Bucket, 5 },
        { Item.CaltropsBag, 10 },
        { Item.CardsWithAnExtraAce, 5 },
        { Item.Chain, 10 },
        { Item.Chalk, 1 },
        { Item.Chisel, 5 },
        { Item.Cookpots, 10 },
        { Item.Crowbar, 10 },
        { Item.Drill, 10 },
        { Item.FacePaintOrMakeup, 10 },
        { Item.FakeJewels, 50 },
        { Item.FishingRodOrTackle, 10 },
        { Item.GlassMarbles, 5 },
        { Item.Glue, 1 },
        { Item.GrapplingHook, 10 },
        { Item.Hammer, 10 },
        { Item.HolyWater, 25 },
        { Item.Horn, 10 },
        { Item.Hourglass, 300 },
        { Item.Incense, 10 },
        { Item.IronTongs, 10 },
        { Item.Ladder, 10 },
        { Item.LargeSponge, 5 },
        { Item.Lens, 100 },
        { Item.Lockpicks, 100 },
        { Item.Manacles, 10 },
        { Item.MetalFile, 5 },
        { Item.Mirror, 200 },
        { Item.MusicalInstrument, 200 },
        { Item.Nails, 5 },
        { Item.Net, 10 },
        { Item.OilskinBag, 5 },
        { Item.OilskinTrousers, 10 },
        { Item.PadlockAndKey, 20 },
        { Item.Perfume, 50 },
        { Item.Pick, 10 },
        { Item.Pole, 5 },
        { Item.QuillAndInk, 1 },
        { Item.Rope, 10 },
        { Item.Sack, 1 },
        { Item.Saw, 10 },
        { Item.SetOfLoadedDice, 5 },
        { Item.Shovel, 10 },
        { Item.SmallBell, 20 },
        { Item.Soap, 1 },
        { Item.SpikeIron, 5 },
        { Item.SpikeWood, 1 },
        { Item.SpikedBoots, 5 },
        { Item.Spyglass, 1000 },
        { Item.Tar, 10 },
        { Item.TentThreePerson, 100 },
        { Item.TentPersonal, 50 },
        { Item.Twine, 5 },
        { Item.Waterskin, 5 },
        { Item.Whistle, 5 },
        { Item.Candle, 1 },
        { Item.Lantern, 30 },
        { Item.LampOil, 5 },
        { Item.Tinderbox, 10 },
        { Item.Torch, 1 }
    }.ToImmutableDictionary();

    public static string AlignmentToString(this int value)
    {
        if (value >= 1 || value <= 5)
            return $"Lawful ({value})";
        if (value >= 6 || value <= 15)
            return $"Neutral ({value})";
        if (value >= 16 || value <= 20)
            return $"Chaos ({value})";
        else
            throw new ArgumentOutOfRangeException("Expecte value between 1-20");
    }

    public static string ArmorToString(this int value)
    {
        if (value >= 1 || value <= 3)
            return $"No armor ({value})";
        if (value >= 4 || value <= 14)
            return $"Gambeson ({value})";
        if (value >= 15 || value <= 19)
            return $"Brigadine ({value})";
        if (value >= 19 || value <= 20)
            return $"Chain ({value})";
        else
            throw new ArgumentOutOfRangeException("Expecte value between 1-20");
    }

    public static string HelmetAndShieldToString(this int value)
    {
        if (value >= 1 || value <= 13)
            return $"None ({value})";
        if (value >= 14 || value <= 16)
            return $"Helmet ({value})";
        if (value >= 17 || value <= 19)
            return $"Shield ({value})";
        if (value == 20)
            return $"Helmet and Shield ({value})";
        else
            throw new ArgumentOutOfRangeException("Expecte value between 1-20");
    }

}
