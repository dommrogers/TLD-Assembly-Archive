using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class BodyHarvestManager : MonoBehaviour
{
	public float m_FrozenDecayConditionPerHour;

	public float m_NumHoursToFreezeCarcass;

	public float m_RadiusToThawFromFire;

	public float m_NumHoursToThawFrozenCarcass;

	private static List<BodyHarvest> m_BodyHarvestList;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Awake()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallsUnknownMethods(Count = 4)]
	public static BodyHarvest GetBodyHarvestFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void DeleteAllActive()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	public static void Destroy(BodyHarvest bodyHarvest)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 11)]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void AddBodyHarvest(BodyHarvest bh)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public static void MaybeRestoreCorpseState(BodyHarvest bh)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeRestoreCarcassSite(BodyHarvest bh)
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	private static BodyHarvest InstantiateBodyHarvestGameObject(BodyHarvestSaveData proxy)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BodyHarvestManager()
	{
	}
}
