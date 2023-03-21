using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_CarcassHarvesting : Skill
{
	public float m_NumHoursHarvestPerSkillPoint;

	public int[] m_MeatTimePercentDecrease;

	public int[] m_HideGutTimePercentDecrease;

	public int[] m_FrozenThresholdPercent;

	private float m_NumHoursToConvertToSkillPoints;

	private static Skill_CarcassHarvestingSaveData m_Skill_CarcassHarvestingSaveData;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "IsCarcassTooFrozenToQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	public int GetFrozenThresholdPercent()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float GetMeatHarvestTimeScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float GetHideGutHarvestTimeScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyHoursToSkill(float hours)
	{
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_CarcassHarvesting()
	{
	}
}
