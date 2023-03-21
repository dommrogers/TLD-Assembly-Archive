using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	public bool HasObject(string objName, Vector3 location)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 16)]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DisableAll()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void DisableAllAndCheckContainers()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void PruneMissingObjects()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Start")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldAllSkipSerialization()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldAnySkipSerialization()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAnySkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
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

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 54)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckDisableObjectForXPMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	private void ActivateRandomObject()
	{
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void CheckForSpawnInOldSaves()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void MaybeReroll()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(EnableObjectForXPMode), Member = "Update")]
	[Calls(Type = typeof(EnableObjectForXPMode), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void RecheckDisableObjectForXPMode(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RandomSpawnObject()
	{
	}
}
