using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class GearManager
{
	public static List<GearItem> m_Gear;

	public static List<GearItem> m_DroppedDecoys;

	public static GameObject m_GearCategory;

	public static float m_DecayScale;

	private static List<GearItem> m_GearToDestroy;

	private static int m_CurrentIndex;

	private static int m_NumProcessPerFrame;

	public static event Action<GearItem> m_OnGearItemAdded
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public static event Action<GearItem> m_OnGearItemRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Add(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearManager), Member = "ShouldDeleteActiveGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void DeleteAllActive()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyMarkedObjects")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "OnDropPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Action_EmptyContainersInScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[Calls(Type = typeof(Addressables), Member = "ReleaseInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GearManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	public static void DestroyGearObject(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearItem), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	public static void Remove(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string Serialize()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	public static void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	public static void Deserialize(GearSaveList list, List<GearItem> loadedItems)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void MaybeAddToDroppedDecoys(GearItem gi)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearManager), Member = "Remove")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 1)]
	public static void RemovedFromDroppedDecoys(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public static void RegisterForOnGearItemAdded(Action<GearItem> function)
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void RegisterForOnGearItemRemoved(Action<GearItem> function)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetFrameCountBetweenItemUpdates()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[CallsUnknownMethods(Count = 3)]
	private static bool ShouldDeleteActiveGearItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	public static void DestroyNextUpdate(GearItem gearItem, bool value)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallerCount(Count = 1)]
	private static void DestroyMarkedObjects()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	public static void UpdateAll()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "ManualUpdate")]
	private static void UpdateItems(int start, int endExclusive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GearManager()
	{
	}
}
