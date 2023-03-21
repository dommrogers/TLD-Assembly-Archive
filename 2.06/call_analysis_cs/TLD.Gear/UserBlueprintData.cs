using System;
using System.Collections.Generic;
using System.Reflection;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using UnityEngine;

namespace TLD.Gear;

[Serializable]
public class UserBlueprintData
{
	[Serializable]
	public class RequiredGearItem
	{
		public string Item;

		public int Count;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public RequiredGearItem()
		{
		}
	}

	public List<RequiredGearItem> RequiredGear;

	public string RequiredTool;

	public List<string> OptionalTools;

	public string CraftedResult;

	public int CraftedResultCount;

	public int DurationMinutes;

	public string CraftingAudio;

	public float KeroseneLitersRequired;

	public float GunpowderKGRequired;

	public bool RequiresLight;

	public bool Locked;

	public bool IgnoreLockInSurvival;

	public bool AppearsInStoryOnly;

	public bool AppearsInSurvivalOnly;

	public SkillType AppliedSkill;

	public SkillType ImprovedSkill;

	public CraftingLocation RequiredCraftingLocation;

	public bool RequiresLitFire;

	public bool CanIncreaseRepairSkill;

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private UserBlueprintData()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadUserBlueprint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	[Calls(Type = typeof(UserBlueprintData), Member = "MakeRuntimeWwiseEvent")]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	[Calls(Type = typeof(JsonConvert), Member = "PopulateObject")]
	[Calls(Type = typeof(UserBlueprintData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	public static BlueprintData CreateFromJson(string text)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	private static bool FindGearItemPrefab(string gearName, Dictionary<string, GameObject> library)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsUnknownMethods(Count = 6)]
	private static AK.Wwise.Event MakeRuntimeWwiseEvent(string eventName)
	{
		return null;
	}
}
