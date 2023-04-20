using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay.Tunable;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Pool;

public class Inventory : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GearItem> _003C_003E9__85_0;

		public static Predicate<GearItem> _003C_003E9__86_0;

		public static Predicate<GearItem> _003C_003E9__87_0;

		public static Predicate<GearItem> _003C_003E9__96_0;

		public static Predicate<GearItem> _003C_003E9__97_0;

		public static Predicate<GearItem> _003C_003E9__98_0;

		public static Predicate<GearItem> _003C_003E9__100_0;

		public static Predicate<GearItem> _003C_003E9__101_0;

		public static Predicate<GearItem> _003C_003E9__102_0;

		public static Predicate<GearItem> _003C_003E9__103_0;

		public static Predicate<GearItem> _003C_003E9__105_0;

		public static Comparison<GearItem> _003C_003E9__134_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFlashlight_003Eb__85_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestTorch_003Eb__86_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestBed_003Eb__87_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestBearSpear_003Eb__96_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestStone_003Eb__97_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestBow_003Eb__98_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingTackle_003Eb__100_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingHook_003Eb__101_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingLine_003Eb__102_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestRopeItem_003Eb__103_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestNoiseMakerItem_003Eb__105_0(GearItem gi)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		internal int _003CRemoveBestQualityAmmoForWeapon_003Eb__134_0(GearItem lhs, GearItem rhs)
		{
			return 0;
		}
	}

	private PanelReference<Panel_Inventory> m_InventoryPanel;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExaminePanel;

	public List<GearItemObject> m_Items;

	public List<GearItem> m_ItemsToDestroy;

	public const float UseWaterFromGeneralSupply = -1f;

	public const string ITEM_ADDED_EVENT_NAME = "Inventory_ItemAdded";

	public const string ITEM_REMOVED_EVENT_NAME = "Inventory_ItemRemoved";

	public const string ITEM_EQUIPPED_EVENT_NAME = "Inventory_ItemEquipped";

	public const string FIRED_EQUIPPED_WEAPON_EVENT_NAME = "Inventory_FiredEquippedWeapon";

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

	private List<WeightReductionBuff> m_WeightReductionBuffs;

	private static InventorySaveDataProxy m_InventorySaveDataProxy;

	private const int INV_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static InventoryItemSaveData[] m_InventoryItemSaveDataPool;

	public const int NUM_QUICK_SELECT_SLOTS = 4;

	public GameObject[] m_QuickSelectSlots;

	public event Action<GearItem> m_OnInventoryItemAdded
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(WeightReductionBuff), Member = "Awake")]
		[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Start")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(WeightReductionBuff), Member = "OnDestroy")]
		[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "OnDestroy")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<GearItem> m_OnInventoryItemRemoved
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(WeightReductionBuff), Member = "Awake")]
		[CalledBy(Type = typeof(Inventory), Member = "Start")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Inventory), Member = "add_m_OnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "ProcessItems")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "TryStackingItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Inventory), Member = "HanksHack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem FindByInstanceID(int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(Inventory), Member = "UpdateQuickSelectionSlots")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 18)]
	public void AddGear(GearItem gi, bool enableNotificationFlag = false)
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
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveGear(GameObject go, bool toContainer)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveGameObjectInInventory(GameObject objectToRemove)
	{
	}

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyGear(GameObject go)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetStartGear")]
	[CalledBy(Type = typeof(Inventory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ResetStartGear), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	public float GetCurrentTotalScentIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 5)]
	private float GetExtraScentIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "IsActive")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "InitializeTargets")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(WeightReductionBuff), Member = "GetTargetsByWeight")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
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
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetHighestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetLowestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetHighestConditionGearThatMatchesCanOpeningType(CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GearInInventory(string gearName, int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public GearItem GearInInventoryAtCondition(string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(BreakDown), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	public bool HasNonRuinedItem(string gearName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	[CalledBy(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CalledBy(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(BlueprintData), Member = "GetToolsAvailableToCraft")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetNonRuinedItem(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void GearInInventory(string gearName, List<GearItem> gear)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumMatches()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumFlares(FlareType type)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumTorches()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumStones()
	{
		return 0;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumNoiseMakers()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int NumGearInInventory(string gearName)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int NumGearInInventory(GearItemData gearItemData)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(Inventory), Member = "GetNumMatches")]
	public int GetNumGearWithName(string gearName)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveUnits(GearItem gi, int numUnits)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[CalledBy(Type = typeof(Condition_CheckInventoryItemCondition), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveGearFromInventory(string gearName, int numUnits)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
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
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[CallsUnknownMethods(Count = 1)]
	public int GetAmmoAvailableForWeapon(GearItem weapon)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeaponSingle")]
	[CallsUnknownMethods(Count = 1)]
	public int RemoveAmmoForWeaponSingle(GearItem weapon)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeapon")]
	[CallsUnknownMethods(Count = 1)]
	public List<int> RemoveAmmoForWeapon(GearItem weapon, int ammoNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddToPotableWaterSupply(float volumeLiters)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStrikeMatchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestMatches()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestMatches(MatchesType matchesType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestFlare(FlareType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFlashlight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestTorch()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestBed()
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestLamp()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetFirstItem(Predicate<GearItem> match)
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlashlight")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestTorch")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingTackle")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingHook")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingLine")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CallerCount(Count = 9)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetBestItemByCurrentHP(Predicate<GearItem> match)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestBearSpear")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestStone")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestBow")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestNoiseMakerItem")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetBestItemByNormalizedCondition(Predicate<GearItem> match)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRevolver")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRifle")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlareGun")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetBestGun(GunType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	public GearItem GetBestRevolver()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	public GearItem GetBestRifle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	public GearItem GetBestFlareGun()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestBearSpear()
	{
		return null;
	}

	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestStone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestBow()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoDecoyMessage")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestDecoy()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFishingTackle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFishingHook()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFishingLine()
	{
		return null;
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionStarted")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestRopeItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestStuggleBonusItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestNoiseMakerItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetLowestConditionArrow(GearItemData arrowData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasRawMeat()
	{
		return false;
	}

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 3)]
	public GearItem GetPotableWaterSupply()
	{
		return null;
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 3)]
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
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetActive(GearItem gi, bool active)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
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
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 18)]
	public void HideInventoryItem(GearItem gi, bool hide)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AdjustForSlope(Vector3 origin, ref Vector3 target)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "CanDropAndScatterItem")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Inventory), Member = "AdjustForSlope")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public int DropAndScatterItems(int count, float minRadius, float maxRadius, GearItem forceDropItem, int minAngleDegrees, int maxAngleDegrees)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public void OnConsumed(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedReishiTea()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedOldMansBeardDressing()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressScentIndicator(bool shouldSuppress)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
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
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "UpdateAudio")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void ProcessItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWeightRTPCs()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanDropAndScatterItem(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 23)]
	private void PositionAndRotateScatteredItem(GearItem item, Vector3 dropPosition, Vector3 dropNormal)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldMakeItemInHandsActive(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 2)]
	private void HanksHack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForGunType")]
	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public int GetAmmoAvailableForWeapon(GunType gunType)
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeapon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public List<int> RemoveBestQualityAmmoForWeapon(GunType gunType, int ammoNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeaponSingle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	public int RemoveBestQualityAmmoForWeaponSingle(GunType gunType)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void InitQuickSelectSlots()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateQuickSelectionSlots()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool AssignedToQuickSlot(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "AssignedToQuickSlot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 12)]
	private void QuickSelectionHandleInventoryItemRemoval(GameObject deader)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Inventory()
	{
	}
}
