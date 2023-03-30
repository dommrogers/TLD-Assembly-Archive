using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.PDID;
using UnityEngine;

public class ObjectGuid : PdidObjectBase
{
	private string m_Guid;

	private List<string> m_HistoricalGuids;

	public override string PDID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public override string ID_Legacy
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	public List<string> HistoricalGuids
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public string GetLegacyID()
	{
		return null;
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CalledBy(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 2)]
	public string MaybeRuntimeRegister()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "SetGuid")]
	[CalledBy(Type = typeof(CustomSpawnedItemChild), Member = "SetGuid")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeAttachObjectGuidAndRegister(GameObject go, string guid)
	{
	}

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[CalledBy(Type = typeof(Bed), Member = "Serialize")]
	[CalledBy(Type = typeof(BreakDown), Member = "Serialize")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "Awake")]
	[CalledBy(Type = typeof(CustomSpawnedItemChild), Member = "Awake")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string MaybeGetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public static ObjectGuid GetObjectGuidFromGO(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 32)]
	private string Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ObjectGuid()
	{
	}
}
