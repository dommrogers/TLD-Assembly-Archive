using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
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

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[CalledBy(Type = typeof(ContainerManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	public void UpdateContainer()
	{
	}

	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
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

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	public void MaybeDestroyContainerAfterMission()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	public static void DeserializeContentsToPos(string text, Vector3 pos, List<GearItem> loadedItems)
	{
	}

	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveGear(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	public void RemoveGear(GearItem gi, bool toInventory)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DestroyGear(GearItem gi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_EmptyContainersInScene), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	public float GetTotalWeightKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "SearchCallback")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Container), Member = "InstantiateContents")]
	public void ShowContainerContents()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void ShowItemsAfterSearch()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 6)]
	public void BeginContainerOpen()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "CancelHold")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
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
	private void PlayAnimation(string animation)
	{
	}

	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Condition_IsContainerUnlocked), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	public bool IsLocked()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(RockCacheInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(CarryableBody), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsInspected()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkAsInspected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public bool ContainsFoodItems()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "GetClosestMatchStackable")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool AddToExistingStackable(string name, float normalizedCondition, int numUnits, GearItem gearToAdd = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	private void InstantiateGearPrefabInContainer(GameObject prefab)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public WaterSupply GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	public void PopulateContents()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void InstantiateContents()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[CallsUnknownMethods(Count = 3)]
	public int GetTotalCalories()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool AllFoodItemsAreNatural()
	{
		return default(bool);
	}

	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetHoursFuel()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[CallsUnknownMethods(Count = 3)]
	private GameObject GetPrefabFromScriptedItems(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(GameModeFilterExtensions), Member = "PassesGameModeFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void PopulateWithScriptedGear()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Container), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "IsSafeLocked")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void PlayContainerCloseSound()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	protected void MaybePlayInspectionAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int GetNumGearWithName(string gearName)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetPowderItemAmount(GearPowderType type)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	public void GetItems(List<GearItem> list)
	{
	}

	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	public void GetItems(GearItemComponentFilter gearItemComponentFilter, List<GearItem> list)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Container()
	{
	}
}
