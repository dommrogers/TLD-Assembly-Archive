using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;

public class Skill_Revolver : Skill
{
	public int[] m_CriticalHitChanceIncrease;

	public int[] m_ConditionRepairBonus;

	public int[] m_ConditionDegradeOnUseReduction;

	public int[] m_DamageIncrease;

	public int[] m_RecoilCompensation;

	public float[] m_AimAssistAngleDegrees;

	public int[] m_StruggleBonus;

	public string[] m_AimAssistTierText;

	private static Skill_RevolverSaveData m_Skill_RevolverSaveData;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public int GetConditionRepairBonus()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 0)]
	public float GetRecoilScale()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public float GetRevolverDamageScale()
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnRevolverShotPercent")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	public float GetStruggleBonus()
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_Revolver()
	{
	}
}
