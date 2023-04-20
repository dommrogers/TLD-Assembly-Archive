using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Gameplay.Tunable;
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

	private List<GameObject> m_GearToInstantiate;

	private static ContainerSaveDataProxy m_ContainerSaveDataProxy;

	private const int CONTAINER_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static ContainerItemSaveData[] m_ContainerItemSaveDataPool;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[Calls(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateContainer()
	{
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(Container), Member = "MaybeDestroyContainerAfterMission")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromName")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 22)]
	public void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromName")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public void DeserializeAdditive(string text, List<GearItem> loadedItems)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeDestroyContainerAfterMission()
	{
	}

	[CalledBy(Type = typeof(ContainerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeContentsToPos(string text, Vector3 pos, List<GearItem> loadedItems)
	{
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	public void AddGear(GearItem gi)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveGear(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CalledBy(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Container), Member = "DestroyAllGear")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveGear(GearItem gi, bool toInventory)
	{
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DestroyGear(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Action_EmptyContainersInScene), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	public float GetTotalWeightKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SearchCallback")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowContainerContents()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void ShowItemsAfterSearch()
	{
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void BeginContainerOpen()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "CancelHold")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerClose")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayAnimation(string animation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void MakeCanNeverBeOpened()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanNeverBeOpened()
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Condition_IsContainerUnlocked), Member = "OnCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLocked()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SafeCracking GetSafe()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSafeLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(CarryableBody), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "ShowActionPanel")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "GetHoverText")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEmpty()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInspected()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void MarkAsInspected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public bool ContainsFoodItems()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StackableItem), Member = "GetClosestMatchStackable")]
	[Calls(Type = typeof(StackableItem), Member = "CanAddToExistingStackable")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddToExistingStackable(GearItem gearToAdd, float normalizedCondition, int numUnits)
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 21)]
	private void InstantiateGearPrefabInContainer(GameObject prefab)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearItemsStoredInSceneByPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	private void InstantiateContents()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[CalledBy(Type = typeof(Action_ContainerGetCalories), Member = "DoContainerCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public int GetTotalCalories()
	{
		return 0;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[CalledBy(Type = typeof(Action_ContainerAllFoodIsNatural), Member = "DoContainerCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool AllFoodItemsAreNatural()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_container_test")]
	[CalledBy(Type = typeof(Action_ContainerGetFuelHours), Member = "DoContainerCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetHoursFuel()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(Container), Member = "GetPrefabFromScriptedItems")]
	private GameObject GetPrefabFromName(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "GetPrefabFromName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsUnknownMethods(Count = 3)]
	private GameObject GetPrefabFromScriptedItems(string gearName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameModeFilterExtensions), Member = "PassesGameModeFilter")]
	[Calls(Type = typeof(DisableForCurrentModeExtensions), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PopulateWithScriptedGear()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateContents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[Calls(Type = typeof(float), Member = "GetHashCode")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	[Calls(Type = typeof(Container), Member = "IsSafeLocked")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 11)]
	private void PopulateWithRandomGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void PlayContainerOpenSound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void PlayContainerCloseSound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected void MaybePlayInspectionAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int GetNumGearWithName(string gearName)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetPowderItemAmount(GearPowderType type)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLiquidItemAmount(GearLiquidTypeEnum type)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	public int GetMeasurableTotalByType(string type)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void GetItems(List<GearItem> list)
	{
	}

	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CalledBy(Type = typeof(Action_LockItems), Member = "DoContainerLock")]
	[CalledBy(Type = typeof(Action_DestroyLockedItems), Member = "DoDestroyContainerLockedItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void GetItems(GearItemComponentFilter gearItemComponentFilter, List<GearItem> list)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Container()
	{
	}
}
