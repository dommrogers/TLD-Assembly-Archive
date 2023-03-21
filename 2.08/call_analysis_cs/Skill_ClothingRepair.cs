using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_ClothingRepair : Skill
{
	public GearItem[] m_ConsiderClothing;

	public int[] m_BaseSuccessChance;

	public int[] m_RepairTimePercentDecrease;

	public int[] m_ItemConditionPercentIncrease;

	public int[] m_SewingToolDegradeDecrease;

	private static Skill_ClothingRepairSaveData m_Skill_ClothingRepairSaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int GetBaseChanceSuccess()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float GetRepairTimeScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetItemConditionScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public float GetSewingKitDegradeScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_ClothingRepair()
	{
	}
}
