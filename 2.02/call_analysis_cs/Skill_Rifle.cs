using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

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

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCriticalHitChanceScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public int GetConditionRepairBonus()
	{
		return default(int);
	}

	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetAccuracyRangeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetRifleDamageScale()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsUnknownMethods(Count = 3)]
	public float GetStabilityBonus()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public float GetBestStabilityBonus()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public float GetEffectiveRange()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetConditionDegradeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetAimAssistAngleDegrees()
	{
		return default(float);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Skill_Rifle()
	{
	}
}
