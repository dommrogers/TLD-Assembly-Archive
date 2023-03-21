using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.PDID;
using UnityEngine;

public class ObjectGuid : PdidObjectBase
{
	private string m_Guid;

	private List<string> m_HistoricalGuids;

	public override string PDID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
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
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	public List<string> HistoricalGuids
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 61)]
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
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeAttachObjectGuidAndRegister(GameObject go, string guid)
	{
	}

	[CallerCount(Count = 56)]
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
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string MaybeGetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "Serialize")]
	[CalledBy(Type = typeof(Elevator), Member = "SerializeAll")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CalledBy(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[CalledBy(Type = typeof(ScriptLight), Member = "SerializeAll")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Serialize")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public static ObjectGuid GetObjectGuidFromGO(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 53)]
	private string Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ObjectGuid()
	{
	}
}
