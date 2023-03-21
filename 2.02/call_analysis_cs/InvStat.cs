using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class InvStat
{
	public enum Identifier
	{
		Strength,
		Constitution,
		Agility,
		Intelligence,
		Damage,
		Crit,
		Armor,
		Health,
		Mana,
		Other
	}

	public enum Modifier
	{
		Added,
		Percent
	}

	public Identifier id;

	public Modifier modifier;

	public int amount;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string GetName(Identifier i)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetDescription(Identifier i)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int CompareArmor(InvStat a, InvStat b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int CompareWeapon(InvStat a, InvStat b)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public InvStat()
	{
	}
}
