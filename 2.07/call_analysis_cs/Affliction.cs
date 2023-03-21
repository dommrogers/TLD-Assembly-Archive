using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public struct Affliction
{
	public readonly string m_Cause;

	public readonly AfflictionType m_AfflictionType;

	public readonly AfflictionBodyArea m_Location;

	public readonly int m_Id;

	private readonly bool m_IsValid;

	public static readonly int AfflictionBodyAreaCount;

	public static readonly int AfflictionTypesCount;

	public static Affliction InvalidAffliction;

	public const string DEFINITION_ASSET_PREFIX = "Affliction_";

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	public Affliction(AfflictionType afflictionType, string causeLocalizationId, AfflictionBodyArea location, int id)
	{
	}

	[CallerCount(Count = 0)]
	public Affliction(string cause)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool CompareTo(Affliction toCompare)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool CompareTo(AfflictionButton toCompare)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetDisplayNameLocId(AfflictionType affType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SpriteNameFromAfflictionType(AfflictionType affType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Affliction), Member = "GetDisplayName")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string LocalizedNameFromAfflictionType(AfflictionType affType, int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetDescriptionLocId(AfflictionType affType)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	public static string GetDisplayName(AfflictionType affType)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	public static bool IsBeneficial(AfflictionType affType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	public static bool IsRisk(AfflictionType affType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	public static bool AfflictionTypeIsBuff(AfflictionType affType)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	public static bool IsBadAffliction(AfflictionType affType)
	{
		return default(bool);
	}
}
