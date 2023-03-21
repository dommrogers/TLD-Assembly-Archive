using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
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

	public float m_SpawnChance;

	public bool m_IsCorpse;

	public bool m_CanStickToGroundAfterBreakdown;

	public InventoryFilterType m_DefaultFilter;

	public bool m_FilterLocked;

	public GearType m_ShowOnlyGearType;

	public bool m_OnlyShowSpecifiedGearType;

	public ContainerSelectionMode m_StartSelectionMode;

	public bool m_StartInspected;

	public string m_OpenAudio;

	public string m_CloseAudio;

	public string m_SearchAudio;

	private LootTableData m_LootTableData;

	private LootTableData m_LockedLootTableData;

	private LootTable m_LootTablePrefab;

	private LootTable m_LockedLootTablePrefab;

	public float m_ChanceEmpty;

	public int m_MinRandomItems;

	public int m_MaxRandomItems;

	public int m_MinRandomItemsLocked;

	public int m_MaxRandomItemsLocked;

	public bool m_SkipInspectVO;

	public float m_DecayScalar;

	public string m_MissionSupplyObjectiveId;

	public MissionObjectIdentifier m_MissionObject;

	private PanelReference<Panel_Container> m_ContainerPanel;

	protected bool m_Inspected;

	private bool m_CanNeverBeOpened;

	private Lock m_Lock;

	private SafeCracking m_Safe;

	private bool m_RolledSpawnChance;

	private bool m_NotPopulated;

	protected bool m_SearchInProgress;

	protected bool m_OpenInProgress;

	private LootTableData m_LootTable;

	private bool m_PendingClose;

	private bool m_IsAnimating;

	private ObjectAnim[] m_ObjectAnims;

	private bool m_StartHasBeenCalled;

	private float m_SearchTimeRemaining;

	private PlayerControlMode m_RestoreControlMode;

	private uint m_SearchAudioID;

	private List<string> m_GearToInstantiate;

	private static ContainerSaveDataProxy m_ContainerSaveDataProxy;

	private const int CONTAINER_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static ContainerItemSaveData[] m_ContainerItemSaveDataPool;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(ContainerManager), Member = "UpdateAll")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	public void UpdateContainer()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	public void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void DeserializeAdditive(string text, List<GearItem> loadedItems)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallsUnknownMethods(Count = 1)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void MaybeDestroyContainerAfterMission()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	public static void DeserializeContentsToPos(string text, Vector3 pos, List<GearItem> loadedItems)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 16)]
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

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Action_EmptyContainersInScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	public void RemoveGear(GearItem gi, bool toInventory)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	public void DestroyGear(GearItem gi)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	public float GetTotalWeightKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SearchCallback")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	public void ShowContainerContents()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowItemsAfterSearch()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void BeginContainerOpen()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "CancelHold")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void BeginContainerClose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopSearchAudio()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerClose")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void PlayAnimation(string animation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MakeCanNeverBeOpened()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanNeverBeOpened()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Condition_IsContainerUnlocked), Member = "OnCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public SafeCracking GetSafe()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSafeLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(CarryableBody), Member = "InitializeInteraction")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ContainsFoodItems()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "GetClosestMatchStackable")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool AddToExistingStackable(string name, float normalizedCondition, int numUnits, GearItem gearToAdd = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void InstantiateGearPrefabInContainer(GameObject prefab)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public WaterSupply GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	public void PopulateContents()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InstantiateContents()
	{
	}

	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetTotalCalories()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[CallsUnknownMethods(Count = 2)]
	public bool AllFoodItemsAreNatural()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public float GetHoursFuel()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject GetPrefabFromScriptedItems(string name)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(GameModeFilterExtensions), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void PopulateWithScriptedGear()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "IsSafeLocked")]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private void PopulateWithRandomGear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	protected void PlayContainerOpenSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	protected void PlayContainerCloseSound()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void MaybePlayInspectionAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int GetNumGearWithName(string gearName)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetPowderItemAmount(GearPowderType type)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetLiquidItemAmount(GearLiquidTypeEnum type)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	public int GetMeasurableTotalByType(string type)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void GetItems(List<GearItem> list)
	{
	}

	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void GetItems(GearItemComponentFilter gearItemComponentFilter, List<GearItem> list)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public Container()
	{
	}
}
