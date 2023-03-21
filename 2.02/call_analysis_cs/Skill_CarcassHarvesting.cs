using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Skill_CarcassHarvesting : Skill
{
	public float m_NumHoursHarvestPerSkillPoint;

	public int[] m_MeatTimePercentDecrease;

	public int[] m_HideGutTimePercentDecrease;

	public int[] m_FrozenThresholdPercent;

	private float m_NumHoursToConvertToSkillPoints;

	private static Skill_CarcassHarvestingSaveData m_Skill_CarcassHarvestingSaveData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 3)]
	public int GetFrozenThresholdPercent()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsUnknownMethods(Count = 3)]
	public float GetMeatHarvestTimeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public float GetHideGutHarvestTimeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyHoursToSkill(float hours)
	{
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Skill_CarcassHarvesting()
	{
	}
}
