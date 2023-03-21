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
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(GearManager), Member = "RegisterForOnGearItemAdded")]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<GearItem> m_OnGearItemRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(GearManager), Member = "RegisterForOnGearItemRemoved")]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 3)]
	public static void Add(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearManager), Member = "ShouldDeleteActiveGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	public static void DeleteAllActive()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "Update")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "Update")]
	[CalledBy(Type = typeof(Harvestable), Member = "Harvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyMarkedObjects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "OnDropPlaceMeshAnimationComplete")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Addressables), Member = "ReleaseInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GearManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DestroyGearObject(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearItem), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	public static void Remove(GearItem gi)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "CreateSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void Deserialize(GearSaveList list, List<GearItem> loadedItems)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 2)]
	public static void MaybeAddToDroppedDecoys(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearManager), Member = "Remove")]
	[CallerCount(Count = 2)]
	public static void RemovedFromDroppedDecoys(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemAdded")]
	public static void RegisterForOnGearItemAdded(Action<GearItem> function)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearManager), Member = "add_m_OnGearItemRemoved")]
	public static void RegisterForOnGearItemRemoved(Action<GearItem> function)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetFrameCountBetweenItemUpdates()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(GearSpawnInOldSaves), Member = "HasSpawned")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool ShouldDeleteActiveGearItem(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "CheckForSpawnInOldSaves")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	public static void DestroyNextUpdate(GearItem gearItem, bool value)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	private static void DestroyMarkedObjects()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "AllScenesLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	public static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void UpdateItems(int start, int endExclusive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GearManager()
	{
	}
}
