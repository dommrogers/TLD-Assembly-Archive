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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool HasObject(string objName, Vector3 location)
	{
		return false;
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DisableAll()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DisableAllAndCheckContainers()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 15)]
	public void PruneMissingObjects()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Start")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAllSkipSerialization()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAnySkipSerialization()
	{
		return false;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAnySkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return false;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ExperienceModeType GetExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	private int GetNumObjectsToEnableCurrentXPMode()
	{
		return 0;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetFirstNonZeroPosition")]
	[Calls(Type = typeof(float), Member = "GetHashCode")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 54)]
	private void ActivateRandomObject()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 GetFirstNonZeroPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForSpawnInOldSaves()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void MaybeReroll()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private void RecheckObjectDisablers(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
