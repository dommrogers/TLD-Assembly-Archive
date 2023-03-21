using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class RandomSpawnObject : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GearItem> _003C_003E9__21_0;

		public static Predicate<BodyHarvest> _003C_003E9__21_1;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CLoadObject_003Eb__21_0(GearItem c)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		internal bool _003CLoadObject_003Eb__21_1(BodyHarvest c)
		{
			return default(bool);
		}
	}

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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	public bool HasObject(string objName, Vector3 location)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 8)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private static void SetActiveAll<T>(GameObject obj, Predicate<T> ShouldBeActive) where T : Component
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	public void DisableAll()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void DisableAllAndCheckContainers()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	public void PruneMissingObjects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Start")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallerCount(Count = 2)]
	public bool ShouldAllSkipSerialization()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAnySkipSerialization()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAnySkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
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

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	private void ActivateRandomObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetFirstNonZeroPosition()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void CheckForSpawnInOldSaves()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	public void MaybeReroll()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CallsUnknownMethods(Count = 4)]
	private void RecheckObjectDisablers(GameObject go)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RandomSpawnObject()
	{
	}
}
