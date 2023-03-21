using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class GearItem : MonoBehaviour
{
	public int m_InstanceID;

	public bool m_BeenInPlayerInventory;

	public bool m_HasBeenOwnedByPlayer;

	public bool m_BeenInContainer;

	public bool m_BeenInspected;

	public bool m_InPlayerInventory;

	public bool m_ItemLooted;

	public bool m_InitialDecayApplied;

	public bool m_IsInSatchel;

	public int m_SatchelIndex;

	public bool m_InsideContainer;

	public float m_NormalizedRevealTimeInContainer;

	public bool m_LockedInContainer;

	[NonSerialized]
	public bool m_IsHidden;

	[NonSerialized]
	public Vector3 m_localScaleAtAwake;

	public AmmoItem m_AmmoItem;

	public AmmoCasingItem m_AmmoCasingItem;

	public ArrowItem m_ArrowItem;

	public BearSpearItem m_BearSpearItem;

	public Bed m_Bed;

	public BlueprintItemUnlock m_BlueprintItemUnlock;

	public BodyHarvestItem m_BodyHarvestItem;

	public BodyHarvest m_BodyHarvest;

	public BowItem m_BowItem;

	public BreakDownItem m_BreakDownItem;

	public CanOpeningItem m_CanOpeningItem;

	public CarryableBody m_CarryableBody;

	public CarryingCapacityBuff m_CarryingCapacityBuff;

	public CharcoalItem m_CharcoalItem;

	public Cleanable m_Cleanable;

	public ClothingItem m_ClothingItem;

	public ConditionOverTimeBuff m_ConditionOverTimeBuff;

	public ConditionRestBuff m_ConditionRestBuff;

	public Cookable m_Cookable;

	public CookingPotItem m_CookingPotItem;

	public DegradeOnUse m_DegradeOnUse;

	public EmergencyStimItem m_EmergencyStim;

	public EnergyBoostItem m_EnergyBoost;

	public EvolveItem m_EvolveItem;

	public FatigueBuff m_FatigueBuff;

	public FireStarterItem m_FireStarterItem;

	public FirstAidItem m_FirstAidItem;

	public FirstPersonItem m_FirstPersonItem;

	public FishingItem m_FishingItem;

	public FlareItem m_FlareItem;

	public FlashlightItem m_FlashlightItem;

	public FoodItem m_FoodItem;

	public FoodWeight m_FoodWeight;

	public ForageItem m_ForageItem;

	public ForceLockItem m_ForceLockItem;

	public FreezingBuff m_FreezingBuff;

	public FuelSourceItem m_FuelSourceItem;

	public HandheldShortwaveItem m_HandheldShortwaveItem;

	public GunItem m_GunItem;

	public Harvest m_Harvest;

	public IceFishingHoleClearItem m_IceFishingHoleClearItem;

	public InProgressCraftItem m_InProgressCraftItem;

	public Inspect m_Inspect;

	public KeroseneLampItem m_KeroseneLampItem;

	public Knowledge m_Knowledge;

	public LiquidItem m_LiquidItem;

	public MatchesItem m_MatchesItem;

	public Millable m_Millable;

	public NarrativeCollectibleItem m_NarrativeCollectibleItem;

	public NoiseMakerItem m_NoiseMakerItem;

	public ShowOnMapItem m_ShowOnMapItem;

	public OwnershipOverride m_OwnershipOverrideItem;

	public PlaceableItem m_PlaceableItem;

	public PowderItem m_PowderItem;

	public PurifyWater m_PurifyWater;

	public Repairable m_Repairable;

	public ResearchItem m_ResearchItem;

	public RopeItem m_RopeItem;

	public Scent m_Scent;

	public Sharpenable m_Sharpenable;

	public SmashableItem m_SmashableItem;

	public SnareItem m_SnareItem;

	public SprayPaintCan m_SprayPaintCan;

	public StackableItem m_StackableItem;

	public StoneItem m_StoneItem;

	public StruggleBonus m_StruggleBonus;

	public ToolsItem m_ToolsItem;

	public TorchItem m_TorchItem;

	public WaterSupply m_WaterSupply;

	public WildlifeItem m_WildlifeItem;

	public WolfIntimidationBuff m_WolfIntimidationBuff;

	public ClimbingBuff m_ClimbingBuff;

	public ProtectionBuff m_ProtectionBuff;

	public MeshRenderer[] m_MeshRenderers;

	public SkinnedMeshRenderer[] m_SkinnedMeshRenderers;

	public ObjectGuid m_ObjectGuid;

	public MissionObjectIdentifier m_MissionObject;

	public OnDroppedInWaterDelegate m_OnDroppedInWater;

	public RadialObjectSpawner m_RadialObjectSpawnerParent;

	public Container m_LastContainer;

	private string m_PlacePointGuid;

	private string m_PlacePointName;

	private bool m_PhysicsEnabled;

	private Rigidbody m_RigidBody;

	private bool m_UnequipInProgress;

	public GearTypeEnum m_Type;

	public List<GearTypeEnum> m_AdditionalTypesInventoryFilter;

	public bool m_ShouldUseProjectilePhysics;

	public bool m_RemainInInventoryOnDrop;

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public GearScarcityEnum m_Scarcity;

	public float m_WeightKG;

	public float m_CurrentHP;

	public float m_MaxHP;

	public float m_DailyHPDecay;

	public float m_ScentIntensity;

	public GearStartCondition m_StartCondition;

	public GearMovementSound m_MovementSoundCategory;

	public string m_PickUpAudio;

	public string m_StowAudio;

	public string m_PutBackAudio;

	public string m_WornOutAudio;

	public string m_CookingSlotPlacementAudio;

	public float m_SpawnChance;

	public float m_GearBreakConditionThreshold;

	public bool m_NonInteractive;

	public ConditionTableManager.ConditionTableType m_ConditionTableType;

	public const float m_DefaultScale = 1f;

	public bool m_DisableFavoriting;

	public bool m_DisableSerialization;

	public bool m_AlwaysHarvestedByPlayer;

	public bool m_PromptsPersistUntilUsed;

	public bool m_AutoEquipOnInteract;

	public bool m_RequiredForMission;

	public string m_CoverflowMainTextureResourcePath;

	public string m_CoverflowDamageTextureResourcePath;

	public string m_CoverflowBlendTextureResourcePath;

	public string m_CoverflowOpenedTextureResourcePath;

	public GearDummyType m_DummyGearType;

	[NonSerialized]
	public string m_GearName;

	private bool m_RolledSpawnChance;

	private bool m_WornOut;

	private bool m_HaltDecay;

	private bool m_HarvestedByPlayer;

	private float m_LastUpdateDamageShaderCondition;

	private bool m_MarkedForNextUpdateDestroy;

	private bool m_StartHasBeenCalled;

	private float m_DecayScalar;

	private float m_LastUpdatedTODHours;

	private bool m_LastUpdatedTODHoursInitialized;

	private const float m_Inv24 = 1f / 24f;

	private bool m_HasBeenEquippedAndUsed;

	private bool m_IsTextureStreamingDisabled;

	private static GearItemSaveDataProxy m_GearItemSaveDataProxy;

	private const int GEAR_ITEM_SAVE_VERSION = 4;

	private const int CLOTH_INFLATION_MULTIPIER = 1;

	private static Collider[] s_InaccessibleResults;

	private static RaycastHit[] s_RaycastResults;

	private static Dictionary<Texture2D, int> s_GearTextureReferenceCounts;

	public string m_DisplayName
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[Calls(Type = typeof(ConditionTableManager), Member = "GetDisplayNameWithCondition")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(GearItem), Member = "RefreshName")]
	[Calls(Type = typeof(AuroraField), Member = "ResetAllAuroraFieldLayerToDefault")]
	[Calls(Type = typeof(GearManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 80)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsUnequipInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeDestroyBodyHarvest()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void AddGearToContainer(GearItem containedGearItem, GearItem newItem)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RemoveGearFromContainer(GearItem gi)
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearManager), Member = "UpdateItems")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void ManualUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool HasPhysicsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 18)]
	public string SerializeRigidBody()
	{
		return null;
	}

	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	public void DeserializeRigidBody(string rigidBodySerialized)
	{
	}

	[Calls(Type = typeof(Inspect), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(ResearchItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SerializeRigidBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PowderItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(Action_RemovePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "Serialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SprayPaintCan), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Millable), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StackableItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LiquidItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmashableItem), Member = "Serialize")]
	[Calls(Type = typeof(GunItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Serialize")]
	[Calls(Type = typeof(WaterSupply), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Millable), Member = "Deserialize")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SprayPaintCan), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inspect), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PowderItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[Calls(Type = typeof(Transform), Member = "set_rotation_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_position_Injected")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GearItem), Member = "AssumeMissionObjectResponsibility")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "Deserialize")]
	[Calls(Type = typeof(LiquidItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StackableItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(Transform), Member = "set_rotation_Injected")]
	[Calls(Type = typeof(Transform), Member = "set_position_Injected")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ObjectGuid), Member = "Set")]
	[Calls(Type = typeof(GearItem), Member = "DeserializeRigidBody")]
	[Calls(Type = typeof(ClothingItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(SnareItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SmashableItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WaterSupply), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(string text, bool applyPositioningFix = true)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnWield(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 3)]
	public void OnBeginUnwield()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnUnwieldComplete()
	{
	}

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Utils), Member = "AabbOverlap")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Physics), Member = "RaycastNonAlloc")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Rigidbody), Member = "ClosestPointOnBounds")]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeAddToLostAndFound()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CalledBy(Type = typeof(Feat_StraightToHeart), Member = "IsHeartItem")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RefreshName()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAttachedToPlacePoint()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	public void MaybeDestroyGearItemAfterMission()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void WearOut()
	{
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	public void Degrade(float hp)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[CallerCount(Count = 3)]
	public void SetNormalizedHP(float condition)
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void DisplayDegradedHUDMessage()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoConditionDamageToPot")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "DegradeToolUsed")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DegradeToolOnUse")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	public void DegradeOnUse()
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CalledBy(Type = typeof(GearItem), Member = "CheckForHoursToBreak")]
	[CalledBy(Type = typeof(Lock), Member = "StartInteractInternal")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	public bool CheckForBreakOnUse()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	public int CheckForHoursToBreak(float decayPerHour, int maxHours)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Lock), Member = "OnForceLockComplete")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(FireManager), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	public void BreakOnUse()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMaxHPFromRepair()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetHasBeenEquippedAndUsed()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldKeepButtonPromptsOnScreen()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void HideOrRevealBasedOnRequiredKnowledge()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameObject InstantiateKnowledge()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetTitleToDisplayWhenSelected()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 134)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDescriptionToDisplayOnInventoryScreen")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextForInspectMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetTextToDisplayWhenSelected()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetDescriptionToDisplayOnInventoryScreen()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWeightDisplay")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWeightArrow")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateItemWeightArrow")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWeightModifierNoWornBonus")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateComparisonArrows")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LiquidItem), Member = "GetLiquidWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetItemWeightIgnoreClothingWornBonusKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWeightModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 33)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LiquidItem), Member = "GetLiquidWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetItemWeightKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWeightModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LiquidItem), Member = "GetLiquidWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetSingleItemWeightKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnTakeWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeStartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayGearItemInsidePickupAudio")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	public void PlayPickUpClip()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetDisplayNameWithoutConditionForInventoryInterfaces()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemPrefixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateQuickSelect")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateSlotLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	public string GetBasicDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(GearManager), Member = "MaybeAddToDroppedDecoys")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearManager), Member = "MaybeAddToDroppedDecoys")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem Drop(int numUnits, bool playSound = true, bool stickToFeet = true)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	public GameObject InstantiateStackable(int numUnits)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "CreateWaterPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject InstantiateWater(GameObject prefab, float volume, LiquidQuality quality)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static GameObject InstantiateDepletedGearPrefab(GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	public void ToggleColliders(bool enable)
	{
	}

	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	public bool PassesFilterType(GearTypeEnum filterType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsBigCarry()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	public bool IsLitFlare()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	public bool IsLitFlashlight()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	public bool IsLitLamp()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	public bool IsLitMatch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsLitNoiseMaker()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	public bool IsLitTorch()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	public bool IsLitLightsource()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsWornOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ForceWornOut()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceNotWornOut()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseMatchesItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(MatchesItem), Member = "UpdateFXTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallerCount(Count = 10)]
	public int GetFPSMeshID()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(GearItemListEntry), Member = "UpdateColors")]
	[CalledBy(Type = typeof(GearItemListEntry), Member = "UpdateColors")]
	[CalledBy(Type = typeof(CookingItemListEntry), Member = "UpdateColors")]
	[CalledBy(Type = typeof(CookingItemListEntry), Member = "UpdateColors")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	public Color GetColorBasedOnCondition()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	public string GetColorStringBasedOnCondition()
	{
		return null;
	}

	[CallerCount(Count = 62)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	public int GetRoundedCondition()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	public int GetRoundedCondition(float normalizedCondition)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void SetHaltDecay(bool haltDecay)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(EvolveItem), Member = "GetEvolvedPercentString")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	public string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public bool RollForFoodPoisoning(float startingCalories)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	public void ApplyBuffs(float normalizedValue)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "GetPercentFuelRemaining")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public string GetItemPostFixForInventoryInterfaces()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	public void MaybeAdjustTransformWithDropDummy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private Vector3 UpdateOrientationForCorpse(ref RaycastHit hit, Vector3 desiredNormal)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GearItem), Member = "UpdateOrientationForCorpse")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	public bool StickToGroundAndOrientOnSlope(Vector3 desiredPosition, NavMeshCheck navMeshCheck, float verticalOffset, bool ignoreCorpseLayer = false)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeCollectSpentArrows")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessTakeBearEarRedux")]
	[CalledBy(Type = typeof(MoveOverlappingGearToPlayer), Member = "Start")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	public bool StickToGroundAtPlayerFeet(Vector3 pos)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInsideContainer()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SkipSpawnChanceRoll()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	public void SkipSpawnChanceRollInitialDecayAndAutoEvolve()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void DisablePhysics()
	{
	}

	[CallerCount(Count = 0)]
	public void MarkAsHarvested()
	{
	}

	[CallerCount(Count = 0)]
	public bool WasHarvested()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void CopyHarvestedState(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetBlendAmountOnly")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetBlendAmountOnly")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTexture")]
	public float GetDamageBlendValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetDamageBlendValue(float blendVal)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	public void UpdateDamageShader()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallsUnknownMethods(Count = 8)]
	public void DropIntoWater(Collider collider, float waterY)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public bool IsUndegradableAccelerant()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void MarkForNextUpdateDestroy(bool value)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsMarkedForNextUpdateDestroy()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetDecayScale(float scale)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayAttachToFireAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	public void MaybePlayCookingSlotPlacementAudio(GearPlacePoint placePoint)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public void OverrideOwnership(string trustId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	public void OverrideGearCondition(GearStartCondition condition, bool pickedUp)
	{
	}

	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "DetachAttachedObjects")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	public void SetPlacePoint(GearPlacePoint placePoint)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(GearItem), Member = "OverrideGearCondition")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	private void RollGearCondition(bool pickedUp)
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void MaybeRollRandomWeightAndCalories()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeFallIntoWater()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsUnknownMethods(Count = 2)]
	private void RollSpawnChance()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private string GetItemPrefixForInventoryInterfaces(bool condition)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsUnknownMethods(Count = 3)]
	private void InitializeLastUpdatedTodHours()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	private void ManualStart()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private void DecayOverTODHours(float deltaTODHours, float scale)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindTargetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybePlaceGear()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ApplyForce(Vector3 force, Vector3 torgue)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	public GearItem Clone()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void EnablePhysics()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool IsWeapon()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTwoHandedWeapon()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	public bool IsDummy()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool Equals(GearItem other)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(GearItem), Member = "OnDestroy")]
	[Calls(Type = typeof(Texture2D), Member = "ClearRequestedMipmapLevel")]
	[Calls(Type = typeof(Texture2D), Member = "set_requestedMipmapLevel")]
	[Calls(Type = typeof(Texture2D), Member = "ClearRequestedMipmapLevel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "GetTexturePropertyNameIDs")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void DisableTextureStreaming(bool disable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "Remove")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public GearItem()
	{
	}
}
