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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CompareTo(AfflictionButton toCompare)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDisplayNameLocId(AfflictionType affType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	public static string SpriteNameFromAfflictionType(AfflictionType affType)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "GetDisplayName")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	public static string LocalizedNameFromAfflictionType(AfflictionType affType, int index)
	{
		return null;
	}

	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetDescriptionLocId(AfflictionType affType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "GetAfflictionDefinitionByName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDisplayName(AfflictionType affType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CanUpdateColor")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(Affliction), Member = "IsBadAffliction")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	public static bool IsBeneficial(AfflictionType affType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasAfflictionOfCategory")]
	public static bool IsBadAffliction(AfflictionType affType)
	{
		return default(bool);
	}
}
