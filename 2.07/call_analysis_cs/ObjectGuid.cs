using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using UnityEngine;

public class ObjectGuid : PdidObjectBase
{
	private string m_Guid;

	private List<string> m_HistoricalGuids;

	public override string PDID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
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
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	public string GetLegacyID()
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CalledBy(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	public string MaybeRuntimeRegister()
	{
		return null;
	}

	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	public static void MaybeAttachObjectGuidAndRegister(GameObject go, string guid)
	{
	}

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(BreakDown), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Bed), Member = "Serialize")]
	public static string MaybeGetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static ObjectGuid GetObjectGuidFromGO(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 28)]
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
