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

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
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

	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "Initialize")]
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
	[Calls(Type = typeof(RandomSpawnObject), Member = "RecheckObjectDisablers")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "FindObject")]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private static void SetActiveAll<T>(GameObject obj, Predicate<T> ShouldBeActive) where T : Component
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetActive")]
	public void DisableAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void DisableAllAndCheckContainers()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAnySkipSerialization()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAnySkipSerialization")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetNumObjectsToEnableCurrentXPMode")]
	[CallsUnknownMethods(Count = 1)]
	public static ExperienceModeType GetExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[Calls(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 1)]
	private int GetNumObjectsToEnableCurrentXPMode()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CallsUnknownMethods(Count = 4)]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
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

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[CallsUnknownMethods(Count = 2)]
	private void CheckForSpawnInOldSaves()
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RandomSpawnObject()
	{
	}
}
