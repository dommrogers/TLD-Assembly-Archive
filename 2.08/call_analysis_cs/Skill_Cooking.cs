using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_Cooking : Skill
{
	public int m_LevelWhereNoCalorieLossFromSmashing;

	public int m_LevelWhereNoParasitesOrFoodPoisoning;

	public int[] m_CaloriePercentBonus;

	public int[] m_CookingTimeReducePercent;

	public int[] m_ReadyTimeIncreasePercent;

	private static Skill_CookingSaveData m_Skill_CookingSaveData;

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

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCalorieScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public float GetCookingTimeScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetReadyTimeScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool NoCalorieLossWhenSmashingOpen()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool NoParasitesOrFoodPosioning()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_Cooking()
	{
	}
}
