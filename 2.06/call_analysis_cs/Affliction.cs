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

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDisplayNameLocId(AfflictionType affType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	public static string SpriteNameFromAfflictionType(AfflictionType affType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Affliction), Member = "GetDisplayName")]
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

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string GetDisplayName(AfflictionType affType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Affliction), Member = "IsBadAffliction")]
	public static bool IsBeneficial(AfflictionType affType)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	public static bool IsRisk(AfflictionType affType)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public static bool AfflictionTypeIsBuff(AfflictionType affType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	public static bool IsBadAffliction(AfflictionType affType)
	{
		return default(bool);
	}
}
