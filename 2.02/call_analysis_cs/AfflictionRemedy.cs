using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AfflictionRemedy
{
	public int m_NumRequired;

	public RemedyDefinition m_RemedyDefinition;

	private const string GEAR_PREFIX = "GEAR_";

	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	public bool PlayerHasRequiredRemedy()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAfflictionsRemediesParams")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "GetSpriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PlayerHasRemedy")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "IsWaterTreamentInProgress")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	public bool IsWaterSupply()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string GetDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AfflictionRemedy()
	{
	}
}
