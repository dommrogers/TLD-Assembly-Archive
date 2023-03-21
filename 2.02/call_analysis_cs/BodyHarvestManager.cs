using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BodyHarvestManager : MonoBehaviour
{
	public float m_FrozenDecayConditionPerHour;

	public float m_NumHoursToFreezeCarcass;

	public float m_RadiusToThawFromFire;

	public float m_NumHoursToThawFrozenCarcass;

	private static List<BodyHarvest> m_BodyHarvestList;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static BodyHarvest GetBodyHarvestFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public static void DeleteAllActive()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static void Destroy(BodyHarvest bodyHarvest)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(BodyHarvestSaveList), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddBodyHarvest(BodyHarvest bh)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public static void MaybeRestoreCorpseState(BodyHarvest bh)
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	public static void MaybeRestoreCarcassSite(BodyHarvest bh)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	private static BodyHarvest InstantiateBodyHarvestGameObject(BodyHarvestSaveData proxy)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BodyHarvestManager()
	{
	}
}
