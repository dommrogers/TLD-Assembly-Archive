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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public bool PlayerHasRequiredRemedy()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsWaterSupply()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayName()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public AfflictionRemedy()
	{
	}
}
