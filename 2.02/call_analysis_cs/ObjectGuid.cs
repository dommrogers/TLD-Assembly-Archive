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

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CalledBy(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "Awake")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void Register()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Generate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public string Get()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Campfire), Member = "Deserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "RegisterGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Set(string guid)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public void Restore(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasHistoricalGuid(string guid)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddHistoricalGuid(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int HistoricalCount()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ObjectGuid()
	{
	}
}
