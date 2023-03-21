using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectGuidManager
{
	public static Dictionary<string, GameObject> s_GuidsDictionary;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Set")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Register")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Register")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Placeable), Member = "Deserialize")]
	public static void RegisterGuid(string guid, GameObject go)
	{
	}

	[CalledBy(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Destroy")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "DeleteAllActive")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Placeable), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	public static void UnRegisterGuid(string guid)
	{
	}

	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject Lookup(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(ObjectGuid), Member = "Generate")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CreateCustomDecal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Guid), Member = "NewGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	public static string GenerateNewGuidString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ObjectGuidManager()
	{
	}
}
