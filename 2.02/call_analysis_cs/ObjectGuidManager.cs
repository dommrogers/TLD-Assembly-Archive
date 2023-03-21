using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectGuidManager
{
	public static Dictionary<string, GameObject> s_GuidsDictionary;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(Placeable), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Register")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Set")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterGuid(string guid, GameObject go)
	{
	}

	[CalledBy(Type = typeof(Placeable), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "DeleteAllActive")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Destroy")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[CalledBy(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnRegisterGuid(string guid)
	{
	}

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject Lookup(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Generate")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Guid), Member = "NewGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string GenerateNewGuidString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ObjectGuidManager()
	{
	}
}
