using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

public class Skill_ClothingRepair : Skill
{
	public GearItem[] m_ConsiderClothing;

	public int[] m_BaseSuccessChance;

	public int[] m_RepairTimePercentDecrease;

	public int[] m_ItemConditionPercentIncrease;

	public int[] m_SewingToolDegradeDecrease;

	private static Skill_ClothingRepairSaveData m_Skill_ClothingRepairSaveData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public int GetBaseChanceSuccess()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetRepairTimeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public float GetItemConditionScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetSewingKitDegradeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Skill_ClothingRepair()
	{
	}
}
