using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.Serialization;
using UnityEngine;

public class Skill_Cooking : Skill
{
	public int m_LevelWhereNoCalorieLossFromSmashing;

	public int m_LevelWhereNoParasitesOrFoodPoisoning;

	public int[] m_CaloriePercentBonus;

	public int[] m_CookingTimeReducePercent;

	public int[] m_ReadyTimeIncreasePercent;

	public int[] m_LowConditionChance;

	public int[] m_ConditionMax;

	public GameplayTag m_ConditionSkillCheckGameplayTag;

	public float m_LowConditionMin;

	public float m_LowConditionMax;

	private static Skill_CookingSaveData m_Skill_CookingSaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCalorieScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCookingTimeScale()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetReadyTimeScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetConditionLowConditionChance()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float GetConditionMaxScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "GetCookedHp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float CalculateCondition(float currentHP, float maxHP)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool NoCalorieLossWhenSmashingOpen()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool NoParasitesOrFoodPosioning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	public Skill_Cooking()
	{
	}
}
