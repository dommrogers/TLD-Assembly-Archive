using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectGuid : MonoBehaviour
{
	private string m_Guid;

	private List<string> m_HistoricalGuids;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Awake")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CalledBy(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	public void Register()
	{
	}

	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	public void Generate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public string Get()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Campfire), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	public void Set(string guid)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public void Restore(string guid)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool HasHistoricalGuid(string guid)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AddHistoricalGuid(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int HistoricalCount()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ObjectGuid()
	{
	}
}
