using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

[Serializable]
public class AfflictionRemedy
{
	public int m_NumRequired;

	public RemedyDefinition m_RemedyDefinition;

	private const string GEAR_PREFIX = "GEAR_";

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CallerCount(Count = 3)]
	public bool PlayerHasRequiredRemedy()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "GetSpriteName")]
	public string GetGearItemName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	public string GetSpriteName()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public bool IsWaterSupply()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string GetDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AfflictionRemedy()
	{
	}
}
