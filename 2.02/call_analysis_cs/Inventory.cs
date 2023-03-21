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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void InitQuickSelectSlots()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateQuickSelectionSlots()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool AssignedToQuickSlot(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "AssignedToQuickSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void QuickSelectionHandleInventoryItemRemoval(GameObject deader)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "MaybeUpdateWeightRTPCs")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 41)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(Utils), Member = "GearInInventoryAtCondition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool TryStackingItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "TryStackingItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(Utils), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Inventory), Member = "HanksHack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public GearItem FindByInstanceID(int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(Inventory), Member = "UpdateQuickSelectionSlots")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool GameObjectInInventory(GameObject searchItem)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 59)]
	public void AddGear(GameObject go, bool enableNotificationFlag = false)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RemoveGear(GameObject go)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RemoveDuplicatedItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void RemoveGear(GameObject go, bool toContainer)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void RemoveGameObjectInInventory(GameObject objectToRemove)
	{
	}

	[CallerCount(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DestroyGear(GameObject go)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetStartGear")]
	[CalledBy(Type = typeof(Inventory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ResetStartGear), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	public float GetCurrentTotalScentIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private float GetExtraWeightKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[CalledBy(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "GetCurrentTotalScentIntensity")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private float GetExtraScentIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	public float GetTotalWeightKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetGearItemsForRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowPlaceItemRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseEmergencyStim")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldShowSprayPaintCan")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Utils), Member = "GetHighestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetHighestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetLowestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetLowestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetHighestConditionGearThatMatchesCanOpeningType")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetHighestConditionGearThatMatchesCanOpeningType(CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(Elevator), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "HasValidCrankItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UseItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UseSelectedItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UseItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UseSelectedItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "MaybeUseNextTreatmentItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairHasRequiredMaterial")]
	[CalledBy(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "OnRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshMaterialsTable")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HasValveHandleInInventory")]
	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Utils), Member = "GearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GearInInventory(string gearName, int numUnits)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GearInInventoryAtCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GearInInventoryAtCondition(string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasNonRuinedItem(string gearName)
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintItem), Member = "GetToolsAvailableToCraft")]
	[CalledBy(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CalledBy(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetNonRuinedItem(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GearInList")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem[] GearInInventory(string gearName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetNumMatches")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumMatches()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumFlares(FlareType type)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public int GetNumTorches()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetNumStones")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumStones()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public int GetNumNoiseMakers()
	{
		return 0;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(BowItem), Member = "GetNumArrowsInInventory")]
	[CalledBy(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "CanCraftItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshWaterSources")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "HasMaterialsForRepair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Utils), Member = "NumGearInList")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int NumGearInInventory(string gearName)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumGearWithName(string gearName)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetMeasurableTotalByType(string type)
	{
		return 0;
	}

	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveUnits(GearItem gi, int numUnits)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[CalledBy(Type = typeof(Condition_CheckInventoryItemCondition), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CalledBy(Type = typeof(LeanTo), Member = "BuildFinished")]
	[CalledBy(Type = typeof(LeanTo), Member = "RepairFinished")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildFinished")]
	[CalledBy(Type = typeof(RockCache), Member = "BuildCallback")]
	[CalledBy(Type = typeof(SnowShelter), Member = "BuildFinished")]
	[CalledBy(Type = typeof(SnowShelter), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ConsumeMaterialsUsedForRepair")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ConsumeMaterials")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "ConsumeMaterialsUsedForRepair")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "BuildFinished")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveUnits")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(Action_RemoveGearItem), Member = "OnExecute")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void RemoveGearFromInventory(string gearName, int numUnits)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetAmmoAvailableForWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetAmmoAvailableForGunType(GunType gunType)
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetAmmoAvailableForWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetAmmoAvailableForWeapon(GearItem weapon)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RemoveBestQualityAmmoForWeaponSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int RemoveAmmoForWeaponSingle(GearItem weapon)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RemoveBestQualityAmmoForWeapon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public List<int> RemoveAmmoForWeapon(GearItem weapon, int ammoNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AddToPotableWaterSupply(float volumeLiters)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStrikeMatchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetBestMatches")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestMatches()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetBestMatches")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestMatches(MatchesType matchesType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlare")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFlare(FlareType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlashlight")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFlashlight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestTorch")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestTorch()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestBed()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestLamp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestLamp()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestRevolver")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestRevolver()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestRifle")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestRifle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestBearSpear")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestBearSpear()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestFlareGun")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFlareGun()
	{
		return null;
	}

	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetBestStone")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestStone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestBow")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestBow()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoDecoyMessage")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetBestDecoy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestDecoy()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingTackle")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFishingTackle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingHook")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFishingHook()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFishingLine()
	{
		return null;
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionStarted")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetBestRopeItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestRopeItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestStruggleBonusItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestStuggleBonusItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestNoiseMaker")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestNoiseMakerItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(BowItem), Member = "CanEquipWithArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetLowestConditionArrow")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetLowestConditionArrow()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "HasRawMeat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasRawMeat()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public GearItem GetClosestMatchStackable(string name, float normalizedHP)
	{
		return null;
	}

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public GearItem GetPotableWaterSupply()
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartBoilingWater")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpSnow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[CalledBy(Type = typeof(PurifyWater), Member = "Use")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "GetBoilableWaterSupply")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "GetBoilableWaterSupply")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "MeltingSnowCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "AwardPartialAmount")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnTakeWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWaterSourceInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(Inventory), Member = "GetWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public GearItem GetNonPotableWaterSupply()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	public GearItem GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddToWaterSupply(float numLiters, LiquidQuality quality)
	{
		return false;
	}

	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(ArrowItem), Member = "Reset")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 49)]
	public void HideInventoryItem(GearItem gi, bool hide)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AdjustForSlope(Vector3 origin, ref Vector3 target)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "CanDropAndScatterItem")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Inventory), Member = "AdjustForSlope")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	public int DropAndScatterItems(int count, float minRadius, float maxRadius, GearItem forceDropItem, int minAngleDegrees, int maxAngleDegrees)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetBestGearItemWithName")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnConsumed(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidCompleted(GearItem gearItem)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedCoffee()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedRosehipTea()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasConsumedReishiTea()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasConsumedOldMansBeardDressing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetSuppressScentIndicator(bool shouldSuppress)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(ClothingItem), Member = "Update")]
	[Calls(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Update")]
	[Calls(Type = typeof(SnareItem), Member = "Update")]
	[Calls(Type = typeof(TorchItem), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	private void ProcessItems()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeUpdateWeightRTPCs()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanDropAndScatterItem(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 35)]
	private void PositionAndRotateScatteredItem(GearItem item, Vector3 dropPosition, Vector3 dropNormal)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private bool ShouldMakeItemInHandsActive(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public Inventory()
	{
	}
}
