using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gear;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Inventory : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GearItem> _003C_003E9__84_0;

		public static Predicate<GearItem> _003C_003E9__85_0;

		public static Predicate<GearItem> _003C_003E9__86_0;

		public static Predicate<GearItem> _003C_003E9__95_0;

		public static Predicate<GearItem> _003C_003E9__96_0;

		public static Predicate<GearItem> _003C_003E9__97_0;

		public static Predicate<GearItem> _003C_003E9__99_0;

		public static Predicate<GearItem> _003C_003E9__100_0;

		public static Predicate<GearItem> _003C_003E9__101_0;

		public static Predicate<GearItem> _003C_003E9__102_0;

		public static Predicate<GearItem> _003C_003E9__104_0;

		public static Comparison<GearItem> _003C_003E9__134_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFlashlight_003Eb__84_0(GearItem gi)
		{
			return default(bool);
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CGetBestTorch_003Eb__85_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestBed_003Eb__86_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestBearSpear_003Eb__95_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestStone_003Eb__96_0(GearItem gi)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		internal bool _003CGetBestBow_003Eb__97_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingTackle_003Eb__99_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingHook_003Eb__100_0(GearItem gi)
		{
			return default(bool);
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestFishingLine_003Eb__101_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestRopeItem_003Eb__102_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetBestNoiseMakerItem_003Eb__104_0(GearItem gi)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		internal int _003CRemoveBestQualityAmmoForWeapon_003Eb__134_0(GearItem lhs, GearItem rhs)
		{
			return default(int);
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

	private static InventorySaveDataProxy m_InventorySaveDataProxy;

	private const int INV_ITEM_SAVE_DATA_POOL_LEN = 512;

	private static InventoryItemSaveData[] m_InventoryItemSaveDataPool;

	public const int NUM_QUICK_SELECT_SLOTS = 4;

	public GameObject[] m_QuickSelectSlots;

	public event Action<GearItem> m_OnInventoryItemAdded
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	public event Action<GearItem> m_OnInventoryItemRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	public void Start()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool TryStackingItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(Inventory), Member = "HanksHack")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Inventory), Member = "TryStackingItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(Inventory), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "IsDummy")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	public GearItem FindByInstanceID(int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(Inventory), Member = "UpdateQuickSelectionSlots")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(DespawnWhenRuined), Member = "MaybeDespawnWhenRuined")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "BreakOnUse")]
	[CallerCount(Count = 12)]
	public bool GameObjectInInventory(GameObject searchItem)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HandleInteractionChoice")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "AddToWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GearManager), Member = "RemovedFromDroppedDecoys")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void AddGear(GearItem gi, bool enableNotificationFlag = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RemoveGear(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ResetControls")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	[Calls(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGameObjectInInventory")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RemoveGear(GameObject go, bool toContainer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveGameObjectInInventory(GameObject objectToRemove)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[CallerCount(Count = 37)]
	public void DestroyGear(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_OverrideStartGear), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetStartGear")]
	[CalledBy(Type = typeof(Action_ResetStartGear), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	public void DestroyAllGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	public float GetCurrentTotalScentIntensity()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private float GetExtraWeightKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Inventory), Member = "GetCurrentTotalScentIntensity")]
	[CalledBy(Type = typeof(Panel_HUD.ScentIndicator), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public GearItem GetHighestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem GetLowestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetHighestConditionGearThatMatchesCanOpeningType(CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 21)]
	public GearItem GearInInventory(string gearName, int numUnits)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[CallsUnknownMethods(Count = 3)]
	public GearItem GearInInventoryAtCondition(string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(BreakDown), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public bool HasNonRuinedItem(string gearName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlueprintData), Member = "GetToolsAvailableToCraft")]
	[CalledBy(Type = typeof(BlueprintData), Member = "GetToolsAvailableToCraft")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Harvestable), Member = "GetRequiredTool")]
	public GearItem GetNonRuinedItem(string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshTools")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void GearInInventory(string gearName, List<GearItem> gear)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumMatches()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	public int GetNumFlares(FlareType type)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public int GetNumTorches()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "UpdateStackLabel")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public int GetNumStones()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateStackStatus")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumNoiseMakers()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	public int NumGearInInventory(string gearName)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallerCount(Count = 0)]
	public int NumGearInInventory(GearItemData gearItemData)
	{
		return default(int);
	}

	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(Inventory), Member = "GetNumMatches")]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNumFlares")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	public int GetNumGearWithName(string gearName)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	public int GetMeasurableTotalByType(string type)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	public void RemoveUnits(GearItem gi, int numUnits)
	{
	}

	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_GetWeightOfItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition_CheckInventoryItemCondition), Member = "OnCheck")]
	[CalledBy(Type = typeof(CraftingRequirementMultiTool), Member = "AddToolOptions")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveGearFromInventory(string gearName, int numUnits)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	public int GetAmmoAvailableForGunType(GunType gunType)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_HasUnloadedAmmo")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	public int GetAmmoAvailableForWeapon(GearItem weapon)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeaponSingle")]
	[CallsUnknownMethods(Count = 1)]
	public int RemoveAmmoForWeaponSingle(GearItem weapon)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public List<int> RemoveAmmoForWeapon(GearItem weapon, int ammoNeeded)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpWater")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "BoilingWaterCompleted")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "PurifyingWaterCompleted")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddToPotableWaterSupply(float volumeLiters)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStrikeMatchAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public GearItem GetBestMatches()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem GetBestMatches(MatchesType matchesType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestFlare(FlareType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetBestFlashlight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestTorch()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GearItem GetBestBed()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestLamp()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private GearItem GetFirstItem(Predicate<GearItem> match)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingTackle")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingLine")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingHook")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestTorch")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlashlight")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	private GearItem GetBestItemByCurrentHP(Predicate<GearItem> match)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetBestBearSpear")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestStone")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestBow")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestNoiseMakerItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	private GearItem GetBestItemByNormalizedCondition(Predicate<GearItem> match)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlareGun")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRifle")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRevolver")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestBearSpear()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestStone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestBow()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoDecoyMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public GearItem GetBestDecoy()
	{
		return null;
	}

	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem GetBestFishingTackle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFishingHook()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetBestFishingLine()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionStarted")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public GearItem GetBestRopeItem()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetBestStuggleBonusItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetBestNoiseMakerItem()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BowItem), Member = "CanEquipWithArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetLowestConditionArrow()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool HasRawMeat()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallsUnknownMethods(Count = 9)]
	public GearItem GetClosestMatchStackable(GearItemData itemData, float normalizedHP)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void HideInventoryItem(GearItem gi, bool hide)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public void AdjustForSlope(Vector3 origin, ref Vector3 target)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_scatter_item_in_hands")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Inventory), Member = "AdjustForSlope")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(Inventory), Member = "CanDropAndScatterItem")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	public int DropAndScatterItems(int count, float minRadius, float maxRadius, GearItem forceDropItem, int minAngleDegrees, int maxAngleDegrees)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void OnConsumed(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasConsumedReishiTea()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasConsumedOldMansBeardDressing()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressScentIndicator(bool shouldSuppress)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "Update")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Update")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SnareItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Inventory), Member = "Update")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(FlareItem), Member = "Update")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Inventory), Member = "ShouldMakeItemInHandsActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	private void ProcessItems()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void MaybeUpdateWeightRTPCs()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanDropAndScatterItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void PositionAndRotateScatteredItem(GearItem item, Vector3 dropPosition, Vector3 dropNormal)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[CalledBy(Type = typeof(Inventory), Member = "ProcessItems")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldMakeItemInHandsActive(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	private void HanksHack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForGunType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetAmmoAvailableForWeapon(GunType gunType)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeapon")]
	[CallsUnknownMethods(Count = 17)]
	public List<int> RemoveBestQualityAmmoForWeapon(GunType gunType, int ammoNeeded)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeaponSingle")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public int RemoveBestQualityAmmoForWeaponSingle(GunType gunType)
	{
		return default(int);
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "QuickSelectionHandleInventoryItemRemoval")]
	[CallsUnknownMethods(Count = 2)]
	private bool AssignedToQuickSlot(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemObject), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "AssignedToQuickSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void QuickSelectionHandleInventoryItemRemoval(GameObject deader)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Inventory()
	{
	}
}
