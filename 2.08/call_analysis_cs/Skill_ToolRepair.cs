using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_ToolRepair : Skill
{
	public int[] m_BaseSuccessChance;

	public int[] m_RepairTimePercentDecrease;

	public int[] m_ItemConditionPercentIncrease;

	private static Skill_ToolRepairSaveData m_Skill_ToolRepairSaveData;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetBaseChanceSuccess()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public float GetRepairTimeScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public float GetItemConditionScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_ToolRepair()
	{
	}
}
