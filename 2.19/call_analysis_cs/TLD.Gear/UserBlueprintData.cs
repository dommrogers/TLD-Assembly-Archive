using System;
using System.Collections.Generic;
using System.Reflection;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

	[Serializable]
	public class RequiredPowderItem
	{
		public string Powder;

		public float Amount;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public RequiredPowderItem()
		{
		}
	}

	public List<RequiredGearItem> RequiredGear;

	public List<RequiredPowderItem> RequiredPowders;

	public string RequiredTool;

	public List<string> OptionalTools;

	public string CraftedResult;

	public string CraftedIcon;

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

	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private UserBlueprintData()
	{
	}

	[CalledBy(Type = typeof(BlueprintManager), Member = "LoadUserBlueprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserBlueprintData), Member = ".ctor")]
	[Calls(Type = typeof(JsonConvert), Member = "PopulateObject")]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UserBlueprintData), Member = "FindPowderType")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	[Calls(Type = typeof(UserBlueprintData), Member = "MakeRuntimeWwiseEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public static BlueprintData CreateFromJson(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FindPowderType(string powder, Dictionary<string, PowderType> library)
	{
		return false;
	}

	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool FindGearItemPrefab(string gearName, Dictionary<string, GameObject> library)
	{
		return false;
	}

	[CalledBy(Type = typeof(UserBlueprintData), Member = "CreateFromJson")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static AK.Wwise.Event MakeRuntimeWwiseEvent(string eventName)
	{
		return null;
	}
}
