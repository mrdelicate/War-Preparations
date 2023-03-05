Sword original = new Sword(SwordMaterial.Iron, Gemstone.No, 32, 5);

Console.WriteLine(original);
Console.WriteLine(original with { material = SwordMaterial.Steel, gemstone = Gemstone.Amber, swordLengthInch = 34, crossguardWidthInch = 6 });
Console.WriteLine(original with { material = SwordMaterial.Binarium, gemstone = Gemstone.Sapphire });

public record Sword(SwordMaterial material, Gemstone gemstone, int swordLengthInch, int crossguardWidthInch)
{
    public override string ToString() => $"{swordLengthInch} inch {material} sword, with {gemstone} gemstone embedded and a {crossguardWidthInch} inch crossguard";
}

public enum SwordMaterial
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}

public enum Gemstone
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    No
}