using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Feat_FireMaster : Feat
{
	public int m_NumFiresRequired;

	public int m_DefaultFireStartingSkillLevel;

	private static int m_NumFiresStarted;

	private static Feat_FireMasterSaveData m_Feat_FireMasterSaveData;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

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
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ValidateSaveData(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public int GetDefaultFireStartingSkillLevel()
	{
		return default(int);
	}

	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void IncrementFiresStarted(int count)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public override string GetDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	public override string GetShortDescription()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsUnlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override float GetNormalizedProgress()
	{
		return default(float);
	}

	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Skill_Firestarting), Member = "Deserialize")]
	[CalledBy(Type = typeof(Skill), Member = "Start")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "SetNormalizedProgress")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "IncrementFiresStarted")]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillFireStarting")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public void MaybeUpdateFireStartingSkillLevel()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Feat_FireMaster()
	{
	}
}
