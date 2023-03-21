using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class Skill_Rifle : Skill
{
	public int[] m_CriticalHitChanceIncrease;

	public int[] m_ConditionRepairBonus;

	public int[] m_ConditionDegradeOnUseReduction;

	public int[] m_AccuracyRangeIncrease;

	public int[] m_DamageIncrease;

	public int[] m_StabilityBonus;

	public int[] m_EffectiveRange;

	public float[] m_AimAssistAngleDegrees;

	public string[] m_AimAssistTierText;

	private static Skill_RifleSaveData m_Skill_RifleSaveData;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
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
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCriticalHitChanceScale()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public int GetConditionRepairBonus()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetAccuracyRangeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetRifleDamageScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	public float GetStabilityBonus()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetBestStabilityBonus()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 2)]
	public float GetEffectiveRange()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float GetConditionDegradeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetAimAssistAngleDegrees()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_Rifle()
	{
	}
}
