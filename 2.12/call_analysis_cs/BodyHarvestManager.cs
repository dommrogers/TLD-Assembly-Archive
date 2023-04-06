using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
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

	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public static BodyHarvest GetBodyHarvestFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public static void DeleteAllActive()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public static void Destroy(BodyHarvest bodyHarvest)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 18)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 30)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddBodyHarvest(BodyHarvest bh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeRestoreCorpseState(BodyHarvest bh)
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeRestoreCarcassSite(BodyHarvest bh)
	{
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 2)]
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
