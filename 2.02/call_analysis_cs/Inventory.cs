using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class Inventory : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	public const int NUM_QUICK_SELECT_SLOTS = 4;

	public GameObject[] m_QuickSelectSlots;

	public List<GearItemObject> m_Items;

	public List<GearItem> m_ItemsToDestroy;

	public const float UseWaterFromGeneralSupply = -1f;

	private float m_MinimumViableWaterAmount;

	private GearItem m_WaterSupplyPotable;

	private GearItem m_WaterSupplyNotPotable;

	private float m_WeightGeneral;

	private float m_WeightMetal;

	private float m_WeightWater;

	private float m_WeightWood;

	private float m_TotalWeight;

	private float m_WeightGeneral_LastSent;

	private float m_WeightMetal_LastSent;

	private float m_WeightWater_LastSent;

	private float m_WeightWood_LastSent;

	private bool m_StartHasBeenCalled;

	private bool m_ForceOverrideWeight;

	private float m_OverridedWeight;

	private float m_TotalScentIntensity;

	private bool m_ConsumedCoffee;

	private bool m_ConsumedRosehipTea;

	private bool m_ConsumedReishiTea;

	private bool m_ConsumedOldMansBeardDressing;

	private bool m_SuppressScentIndicator;

	private static InventorySaveDataProxy m_InventorySaveDataProxy;

	private const int INV_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static InventoryItemSaveData[] m_InventoryItemSaveDataPool;

	public event Action<GearItem> m_OnInventoryItemRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void InitQuickSelectSlots()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateQuickSelectionSlots()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool AssignedToQuickSlot(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "AssignedToQuickSlot")]
	private void QuickSelectionHandleInventoryItemRemoval(GameObject deader)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "MaybeUpdateWeightRTPCs")]
	[Calls(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GearInInventoryAtCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	private bool TryStackingItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Inventory), Member = "Start")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Inventory), Member = "TryStackingItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	public GearItem FindByInstanceID(int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "UpdateQuickSelectionSlots")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	public bool GameObjectInInventory(GameObject searchItem)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 59)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void AddGear(GameObject go, bool enableNotificationFlag = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RemoveGear(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RemoveDuplicatedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	public void RemoveGear(GameObject go, bool toContainer)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void RemoveGameObjectInInventory(GameObject objectToRemove)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	public void DestroyGear(GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ResetStartGear")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ResetStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	public float GetCurrentTotalScentIntensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private float GetExtraWeightKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(Inventory), Member = "GetCurrentTotalScentIntensity")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[CalledBy(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	private float GetExtraScentIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	public float GetTotalWeightKG()
	{
		return default(float);
	}

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetHighestConditionGearThatMatchesName")]
	public GearItem GetHighestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(Utils), Member = "GetLowestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetLowestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetHighestConditionGearThatMatchesCanOpeningType")]
	public GearItem GetHighestConditionGearThatMatchesCanOpeningType(CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GearInInventory")]
	public GearItem GearInInventory(string gearName, int numUnits)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GearInInventoryAtCondition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GearInInventoryAtCondition(string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Utils), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	public bool HasNonRuinedItem(string gearName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "GetToolsAvailableToCraft")]
	[Calls(Type = typeof(Utils), Member = "GetNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "GetToolsAvailableToCraft")]
	public GearItem GetNonRuinedItem(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GearInList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	public GearItem[] GearInInventory(string gearName)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetNumMatches")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetNumMatches()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	public int GetNumFlares(FlareType type)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public int GetNumTorches()
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetNumStones")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	public int GetNumStones()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public int GetNumNoiseMakers()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "CanCraftItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[CalledBy(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "NumGearInList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	public int NumGearInInventory(string gearName)
	{
		return default(int);
	}

	[Calls(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	public void RemoveUnits(GearItem gi, int numUnits)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_CheckInventoryItemCondition), Member = "OnCheck")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void RemoveGearFromInventory(string gearName, int numUnits)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetAmmoAvailableForWeapon")]
	[CallerCount(Count = 0)]
	public int GetAmmoAvailableForGunType(GunType gunType)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetAmmoAvailableForWeapon")]
	public int GetAmmoAvailableForWeapon(GearItem weapon)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RemoveBestQualityAmmoForWeaponSingle")]
	[CallsUnknownMethods(Count = 2)]
	public int RemoveAmmoForWeaponSingle(GearItem weapon)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RemoveBestQualityAmmoForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public List<int> RemoveAmmoForWeapon(GearItem weapon, int ammoNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CallsUnknownMethods(Count = 2)]
	public bool AddToPotableWaterSupply(float volumeLiters)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStrikeMatchAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestMatches")]
	[CallerCount(Count = 2)]
	public GearItem GetBestMatches()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestMatches")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	public GearItem GetBestMatches(MatchesType matchesType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlare")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	public GearItem GetBestFlare(FlareType type)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlashlight")]
	[CallerCount(Count = 0)]
	public GearItem GetBestFlashlight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestTorch")]
	public GearItem GetBestTorch()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestBed()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetBestLamp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestLamp()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetBestRevolver")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetBestRevolver()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestRifle")]
	public GearItem GetBestRifle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestBearSpear")]
	public GearItem GetBestBearSpear()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlareGun")]
	public GearItem GetBestFlareGun()
	{
		return null;
	}

	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[Calls(Type = typeof(Utils), Member = "GetBestStone")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestStone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestBow")]
	public GearItem GetBestBow()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestDecoy")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoDecoyMessage")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	public GearItem GetBestDecoy()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingTackle")]
	public GearItem GetBestFishingTackle()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetBestFishingHook")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetBestFishingHook()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingLine")]
	public GearItem GetBestFishingLine()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestRopeItem")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionStarted")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	public GearItem GetBestRopeItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestStruggleBonusItem")]
	public GearItem GetBestStuggleBonusItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestNoiseMaker")]
	public GearItem GetBestNoiseMakerItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "CanEquipWithArrow")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLowestConditionArrow")]
	public GearItem GetLowestConditionArrow()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "HasRawMeat")]
	public bool HasRawMeat()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public GearItem GetPotableWaterSupply()
	{
		return null;
	}

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 5)]
	public GearItem GetNonPotableWaterSupply()
	{
		return null;
	}

	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	public GearItem GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public bool AddToWaterSupply(float numLiters, LiquidQuality quality)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	public void SetActive(GearItem gi, bool active)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ArrowItem), Member = "Reset")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	public void HideInventoryItem(GearItem gi, bool hide)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	public void AdjustForSlope(Vector3 origin, ref Vector3 target)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Inventory), Member = "AdjustForSlope")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "CanDropAndScatterItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	public int DropAndScatterItems(int count, float minRadius, float maxRadius, GearItem forceDropItem, int minAngleDegrees, int maxAngleDegrees)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestGearItemWithName")]
	public GearItem GetBestGearItemWithName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void SetOverrideGearWeight(float weight)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetOverrideGearWeight()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	public void OnConsumed(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void OnFirstAidCompleted(GearItem gearItem)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedCoffee()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedRosehipTea()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasConsumedReishiTea()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasConsumedOldMansBeardDressing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressScentIndicator(bool shouldSuppress)
	{
	}

	[Calls(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SnareItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private void ProcessItems()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWeightRTPCs()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanDropAndScatterItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	private void PositionAndRotateScatteredItem(GearItem item, Vector3 dropPosition, Vector3 dropNormal)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	private bool ShouldMakeItemInHandsActive(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	private void HanksHack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public static SubCategory MapCategories(GearTypeEnum gearTypeEnum)
	{
		return default(SubCategory);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public Inventory()
	{
	}
}
