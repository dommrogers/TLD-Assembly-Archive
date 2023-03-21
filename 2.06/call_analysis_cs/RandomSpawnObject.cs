using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class RandomSpawnObject : MonoBehaviour
{
	public GameObject[] m_ObjectList;

	public int[] m_Weights;

	public GameObject m_OldSaveObject;

	public bool m_OldSaveRerollIfNoneActive;

	public float m_RerollAfterGameHours;

	public int m_NumObjectsToEnablePilgrim;

	public int m_NumObjectsToEnableVoyageur;

	public int m_NumObjectsToEnableStalker;

	public int m_NumObjectsToEnableInterloper;

	public bool m_HadSaveData;

	public float m_ElapsedHoursAtLastReroll;

	private bool m_SucessfullyLoadedObject;

	private bool m_Inited;

	private bool m_Rerolled;

	private bool m_SpawnedOldSaveGearItem;

	private bool m_ShouldAllSkipSerialization;

	private readonly List<IShouldDisableForCurrentMode> m_Disablers;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[CallerCount(Count = 1)]
	public bool HasObject(string objName, Vector3 location)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DisableAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void DisableAllAndCheckContainers()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void PruneMissingObjects()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Start")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAllSkipSerialization()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool ShouldAnySkipSerialization()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAnySkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	public static ExperienceModeType GetExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	private int GetNumObjectsToEnableCurrentXPMode()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 58)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetFirstNonZeroPosition")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	private void ActivateRandomObject()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private Vector3 GetFirstNonZeroPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	private void CheckForSpawnInOldSaves()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	public void MaybeReroll()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallsUnknownMethods(Count = 4)]
	private void RecheckObjectDisablers(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public RandomSpawnObject()
	{
	}
}
