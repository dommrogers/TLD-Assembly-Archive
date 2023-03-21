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
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
	}

	public override string ID_Legacy
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		set
		{
		}
	}

	public List<string> HistoricalGuids
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public string GetLegacyID()
	{
		return null;
	}

	[CalledBy(Type = typeof(Campfire), Member = "Update")]
	[CalledBy(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CalledBy(Type = typeof(FireManager), Member = "AddCampfire")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "Start")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
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

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UnRegisterAuroraField")]
	[CalledBy(Type = typeof(BreakDown), Member = "Serialize")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Bed), Member = "Serialize")]
	public static string MaybeGetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Serialize")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[CalledBy(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(ScriptLight), Member = "SerializeAll")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	[CalledBy(Type = typeof(Elevator), Member = "SerializeAll")]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "Serialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	public static ObjectGuid GetObjectGuidFromGO(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	private string Get()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ObjectGuid()
	{
	}
}
