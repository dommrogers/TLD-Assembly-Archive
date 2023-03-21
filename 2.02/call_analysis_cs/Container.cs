using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class Container : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	public List<GearItemObject> m_Items;

	public GameObject[] m_ScriptedItemPrefabs;

	public GameModeFilter[] m_ScriptedItemFilter;

	public string m_ContainerFilterName;

	public string m_ContainerSortName;

	public bool m_DestoryPending;

	public bool m_Restored;

	public bool m_MarkedInactiveInSaveData;

	public LocalizedString m_LocalizedDisplayName;

	public float m_CapacityKG;

	public float m_SearchTimeSeconds;

	public float m_OpenDelaySeconds;

	public float m_SpawnChance;

	public bool m_IsCorpse;

	public bool m_CanStickToGroundAfterBreakdown;

	public InventoryFilterType m_DefaultFilter;

	public bool m_FilterLocked;

	public GearTypeEnum m_ShowOnlyGearType;

	public bool m_OnlyShowSpecifiedGearType;

	public ContainerSelectionMode m_StartSelectionMode;

	public bool m_StartInspected;

	public string m_OpenAudio;

	public string m_CloseAudio;

	public string m_SearchAudio;

	public LootTable m_LootTablePrefab;

	public LootTable m_LockedLootTablePrefab;

	public LootTable m_LootTableStoryPrefab;

	public LootTable m_LockedLootTableStoryPrefab;

	public float m_ChanceEmpty;

	public int m_MinRandomItems;

	public int m_MaxRandomItems;

	public int m_MinRandomItemsLocked;

	public int m_MaxRandomItemsLocked;

	public bool m_SkipInspectVO;

	public float m_DecayScalar;

	public string m_MissionSupplyObjectiveId;

	public MissionObjectIdentifier m_MissionObject;

	protected bool m_Inspected;

	private bool m_CanNeverBeOpened;

	private Lock m_Lock;

	private SafeCracking m_Safe;

	private RockCache m_RockCache;

	private bool m_RolledSpawnChance;

	private bool m_NotPopulated;

	protected bool m_SearchInProgress;

	protected bool m_OpenInProgress;

	private LootTable m_LootTable;

	private bool m_PendingClose;

	private ObjectAnim[] m_ObjectAnims;

	private bool m_StartHasBeenCalled;

	private float m_SearchTimeRemaining;

	private PlayerControlMode m_RestoreControlMode;

	private uint m_SearchAudioID;

	private List<string> m_GearToInstantiate;

	private static ContainerSaveDataProxy m_ContainerSaveDataProxy;

	private const int CONTAINER_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static ContainerItemSaveData[] m_ContainerItemSaveDataPool;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnDisable()
	{
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "UpdateAll")]
	[Calls(Type = typeof(Container), Member = "CancelSearch")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Container), Member = "OnContainerSearchComplete")]
	[Calls(Type = typeof(Container), Member = "OnOpenComplete")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void UpdateContainer()
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	public void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void DeserializeAdditive(string text, List<GearItem> loadedItems)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void MaybeDestroyContainerAfterMission()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static void DeserializeContentsToPos(string text, Vector3 pos, List<GearItem> loadedItems)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	public void AddGear(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RemoveGear(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	public void RemoveGear(GearItem gi, bool toInventory)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	public void DestroyGear(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_EmptyContainersInScene), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DestroyAllGear()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Utils), Member = "GetTotalWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	public float GetTotalWeightKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(TrustManager), Member = "AddToTrustValue")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OwnershipManager), Member = "GetTrustId")]
	public void OnContainerSearchComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Container), Member = "OnContainerSearchComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ShowItemsAfterSearch()
	{
	}

	[Calls(Type = typeof(Container), Member = "BeginContainerInteraction")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Container), Member = "BeginContainerInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public virtual bool Open()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public void OnOpenComplete()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public virtual bool Close()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MakeCanNeverBeOpened()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool CanNeverBeOpened()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CallsUnknownMethods(Count = 8)]
	public void ForceLock()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "OnLockBroken")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsLockedOrSafeIsUncracked()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CalledBy(Type = typeof(Condition_IsContainerUnlocked), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsSafe()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsSafeLocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(Container), Member = "OnLockBroken")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CallsUnknownMethods(Count = 8)]
	public void StartSafeCrackingInterface()
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CarryableBody), Member = "CanInteract")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInspected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkAsInspected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ContainsFoodItems")]
	public bool ContainsFoodItems()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetAmmoAvailableForWeapon")]
	public int GetAmmoCountForGunType(GunType gunType)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "GetClosestMatchStackable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool AddToExistingStackable(string name, float normalizedCondition, int numUnits, GearItem gearToAdd = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallerCount(Count = 1)]
	public void InstantiateGearPrefabInContainer(GameObject prefab)
	{
	}

	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[CalledBy(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public string GetInteractiveActionText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetInteractiveDisplayText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public WaterSupply GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void CancelSearch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "MaybeRevealItemDuringSearch")]
	public void ResumeSearch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	public void PopulateContents()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SearchCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTable), Member = "GetPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void InstantiateContents()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetTotalCalories()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool AllFoodItemsAreNatural()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetHoursFuel()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private GameObject GetPrefabFromScriptedItems(string name)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	private GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[Calls(Type = typeof(Utils), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void PopulateWithScriptedGear()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "IsLockedOrSafeIsUncracked")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PopulateWithRandomGear()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	protected void PlayContainerOpenSound()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void PlayContainerCloseSound()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Container), Member = "Open")]
	[CallsUnknownMethods(Count = 6)]
	protected void MaybePlayInspectionAudio()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeExitSearch()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "ResumeSearch")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Container), Member = "RevealGearItem")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeRevealItemDuringSearch()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Container), Member = "MaybeRevealItemDuringSearch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	private void RevealGearItem(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasGearWithoutInspect()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[Calls(Type = typeof(Utils), Member = "NumGearInList")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public int GetNumGearWithName(string gearName)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	public int GetMeasurableTotalByType(string type)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public void GetItems(List<GearItem> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void GetItems(GearItemComponentFilter gearItemComponentFilter, List<GearItem> list)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Container), Member = "StartSafeCrackingInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "IsLockedOrSafeIsUncracked")]
	private void OnLockBroken()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Container), Member = "Open")]
	[CalledBy(Type = typeof(Container), Member = "Open")]
	[CallsUnknownMethods(Count = 14)]
	private void BeginContainerInteraction(float searchTimeSeconds, string LocID)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Container()
	{
	}
}
