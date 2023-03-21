using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Interactions;
using TLD.PDID;
using TLD.SaveState;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class GearItem : MonoBehaviour, IInteraction, ITorchLightInteraction
{
	private const int GEAR_ITEM_SAVE_VERSION = 4;

	public const string ITEM_PLACED_EVENT_NAME = "GearItem_Placed";

	public const float DEFAULT_DECAY_SCALE = 1f;

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

	private string m_DisplayNameOverrideLocID;

	private string m_DescriptionOverrideLocID;

	private float _003CWeightKG_003Ek__BackingField;

	private float _003CCurrentHP_003Ek__BackingField;

	private GearItemData m_GearItemData;

	public bool m_DisableSerialization;

	private float m_SpawnChance;

	private GearStartCondition m_StartCondition;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	private PanelReference<Panel_IceFishing> m_IceFishingPanel;

	private PanelReference<Panel_Inventory> m_InventoryPanel;

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

	private bool m_HasBeenEquippedAndUsed;

	private bool m_IsTextureStreamingDisabled;

	private static GearItemSaveDataProxy m_GearItemSaveDataProxy;

	private static Collider[] s_InaccessibleResults;

	private static RaycastHit[] s_RaycastResults;

	private static Dictionary<Texture2D, int> s_GearTextureReferenceCounts;

	public static readonly int s_DamageBlendAmountShaderID;

	private bool _003CCanInteract_003Ek__BackingField;

	private bool _003CNonInteractive_003Ek__BackingField;

	public string DisplayName
	{
		[CallAnalysisFailed]
		[CallerCount(Count = 108)]
		get
		{
			return null;
		}
	}

	public string DisplayNameWithCondition
	{
		[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
		[Calls(Type = typeof(ConditionTable), Member = "GetDisplayNameWithCondition")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
		[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
		[CalledBy(Type = typeof(GearItem), Member = "GetDescriptionToDisplayOnInventoryScreen")]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
		[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
		[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public GearItemData GearItemData
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public bool DisableSerialization
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public float WeightKG
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float CurrentHP
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string HoverText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GearItem), Member = "GetHoverText")]
		get
		{
			return null;
		}
	}

	public bool IsEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool CanInteract
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool NonInteractive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "CacheComponents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(AuroraField), Member = "ResetAllAuroraFieldLayerToDefault")]
	[Calls(Type = typeof(GearManager), Member = "Add")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 19)]
	public void CacheComponents()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CallerCount(Count = 1)]
	public void SetLocalizationOverride(string displayNameOverrideLocID, string descriptionOverrideLocID)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsUnequipInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDestroyBodyHarvest()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void AddGearToContainer(GearItem containedGearItem, GearItem newItem)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void RemoveGearFromContainer(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(GearManager), Member = "UpdateItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasPhysicsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public string SerializeRigidBody()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void DeserializeRigidBody(string rigidBodySerialized)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "CreateSaveData")]
	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Serialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(FoodItem), Member = "Serialize")]
	[Calls(Type = typeof(ClothingItem), Member = "Serialize")]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(CookingPotItem), Member = "Serialize")]
	[Calls(Type = typeof(GearItem), Member = "SerializeRigidBody")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "DeserializeRigidBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[Calls(Type = typeof(FlareItem), Member = "Deserialize")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "ReduceFuel")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(TorchItem), Member = "Deserialize")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(CookingPotItem), Member = "Deserialize")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "set_rotation")]
	[Calls(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 26)]
	public void Deserialize(string text, bool applyPositioningFix = true)
	{
	}

	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Action_RemovePlayerInventory), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public GearSaveData CreateSaveData()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWield(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 1)]
	public void OnBeginUnwield()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnUnwieldComplete()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Rigidbody), Member = "ClosestPointOnBounds")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(Utils), Member = "AabbOverlap")]
	[Calls(Type = typeof(Physics), Member = "RaycastNonAlloc")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 35)]
	public void MaybeAddToLostAndFound()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAttachedToPlacePoint()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeDestroyGearItemAfterMission()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void WearOut()
	{
	}

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CallsUnknownMethods(Count = 1)]
	public void Degrade(float hp)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_object_hp_percent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CallsUnknownMethods(Count = 2)]
	public void SetNormalizedHP(float condition, bool roundToWholeNumber = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayDegradedHUDMessage()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoConditionDamageToPot")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "DegradeToolUsed")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DegradeToolOnUse")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CallerCount(Count = 16)]
	public void DegradeOnUse()
	{
	}

	[CalledBy(Type = typeof(Lock), Member = "PrepareForceLock")]
	[CalledBy(Type = typeof(GearItem), Member = "CheckForHoursToBreak")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	public bool CheckForBreakOnUse()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "CheckForBreakOnUse")]
	public int CheckForHoursToBreak(float decayPerHour, int maxHours)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Lock), Member = "FinishForceLock")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(FireManager), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void BreakOnUse()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnSelectRepairTool")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetMaxHPFromRepair()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetHasBeenEquippedAndUsed()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldKeepButtonPromptsOnScreen()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetTitleToDisplayWhenSelected()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetDescriptionToDisplayOnInventoryScreen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextForInspectMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 130)]
	public string GetTextToDisplayWhenSelected()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetDescriptionToDisplayOnInventoryScreen()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 41)]
	public float GetItemWeightKG(bool ignoreClothingBonus = false)
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public float GetSingleItemWeightKG(bool ignoreClothingBonus = false)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "CalculateLiquidWeight")]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWeightModifierNoWornBonus")]
	[CallsUnknownMethods(Count = 7)]
	public float GetItemWeightKG(float stackMultiplier, bool ignoreClothingBonus = false)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float CalculateLiquidWeight(float liters, GearLiquidTypeEnum liquidType)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float RoundItemWeight(float weight)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayGearItemInsidePickupAudio")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnTakeWaterComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayPickUpClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateSlotLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetBasicDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(GearManager), Member = "MaybeAddToDroppedDecoys")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 18)]
	public GearItem Drop(int numUnits, bool playSound = true, bool stickToFeet = true)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem InstantiateStackable(int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject InstantiateWater(GameObject prefab, float volume, LiquidQuality quality)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject InstantiateDepletedGearPrefab(GameObject prefab)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "FindGearItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(GearItem), Member = "SetInteractive")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SetInteractive")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ToggleColliders(bool enable)
	{
	}

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedCondition(float hp)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGearType(GearType type)
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EnumExtensions.EnumFlagIterator<>), Member = ".ctor")]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	[CallsUnknownMethods(Count = 11)]
	public bool IsAnyGearType(GearType types)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBigCarry()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitFlare()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitFlashlight()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitLamp()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitMatch()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitNoiseMaker()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsLitTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	public bool IsLitLightsource()
	{
		return false;
	}

	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CallsUnknownMethods(Count = 1)]
	public void ExtinguishLitItem()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsWornOut()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ForceWornOut()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceNotWornOut()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public FPSItem GetFPSItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingItemListEntry), Member = "UpdateColors")]
	[CalledBy(Type = typeof(GearItemListEntry), Member = "UpdateColors")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateIcons")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshSelectedActionTool")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 2)]
	public Color GetColorBasedOnCondition()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	public string GetColorStringBasedOnCondition()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetRoundedCondition()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetRoundedCondition(float normalizedCondition)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public void SetHaltDecay(bool haltDecay)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 1)]
	public bool RollForFoodPoisoning(float startingCalories)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyBuffs(float normalizedValue)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[CallsUnknownMethods(Count = 3)]
	public string GetItemPostFixForInventoryInterfaces()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	public void MaybeAdjustTransformWithDropDummy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private Vector3 UpdateOrientationForCorpse(ref RaycastHit hit, Vector3 desiredNormal)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GearItem), Member = "UpdateOrientationForCorpse")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 17)]
	public bool StickToGroundAndOrientOnSlope(Vector3 desiredPosition, NavMeshCheck navMeshCheck, float verticalOffset, bool ignoreCorpseLayer = false)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearHuntAiRedux), Member = "TakeBearEar")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(MoveOverlappingGearToPlayer), Member = "Start")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeCollectSpentArrows")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public bool StickToGroundAtPlayerFeet(Vector3 pos)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInsideContainer()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SkipSpawnChanceRoll()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void SkipSpawnChanceRollInitialDecayAndAutoEvolve()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 1)]
	public void DisablePhysics()
	{
	}

	[CallerCount(Count = 0)]
	public void MarkAsHarvested()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool WasHarvested()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyHarvestedState(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "SetPaperDollTextureBlendMap")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDamageBlendValue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetDamageBlendValue(float hp)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void SetDamageBlendValue(float blendVal)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateDamageShader()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void DropIntoWater(Collider collider, float waterY)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsUndegradableAccelerant()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void MarkForNextUpdateDestroy(bool value)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsMarkedForNextUpdateDestroy()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetDecayScale(float scale)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayAttachToFireAudio")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void MaybePlayCookingSlotPlacementAudio(GearPlacePoint placePoint)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OverrideOwnership(string trustId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	public void OverrideGearCondition(GearStartCondition condition, bool pickedUp)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(BreakDown), Member = "DetachAttachedObjects")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public void SetPlacePoint(GearPlacePoint placePoint)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CalledBy(Type = typeof(GearItem), Member = "OverrideGearCondition")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(float), Member = "GetHashCode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void RollGearCondition(bool pickedUp)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(float), Member = "GetHashCode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeRollRandomWeightAndCalories()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeFallIntoWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RollSpawnChance()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	private string GetItemPrefixForInventoryInterfaces(bool condition)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeLastUpdatedTodHours()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ManualStart()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 4)]
	private void DecayOverTODHours(float deltaTODHours, float scale)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindTargetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybePlaceGear()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ApplyForce(Vector3 force, Vector3 torgue)
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem Clone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 2)]
	public void EnablePhysics()
	{
	}

	[CalledBy(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[CallerCount(Count = 1)]
	public bool IsWeapon()
	{
		return false;
	}

	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(DisableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGunOrAmmoOrCasingOfType(GunType gunType)
	{
		return false;
	}

	[CalledBy(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTwoHandedWeapon()
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDummy()
	{
		return false;
	}

	[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	public bool Equals(GearItem other)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "OnDestroy")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Container), Member = "InstantiateGearPrefabInContainer")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Material), Member = "GetTexturePropertyNameIDs")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Texture2D), Member = "ClearRequestedMipmapLevel")]
	[Calls(Type = typeof(Texture2D), Member = "set_requestedMipmapLevel")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	public void DisableTextureStreaming(bool disable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearManager), Member = "Remove")]
	[Calls(Type = typeof(GearItem), Member = "DisableTextureStreaming")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetGearDisplayName(string gearPrefabName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void InitializeInteraction()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "get_HoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[Calls(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	[Calls(Type = typeof(EvolveItem), Member = "GetEvolvedPercentString")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[CallsUnknownMethods(Count = 3)]
	private string GetHoverStateText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateInteraction()
	{
	}

	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public bool PerformInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void TryStartPlaceMeshInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void HideInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "ToggleColliders")]
	public void SetInteractive(bool interactive, bool invisibleToRaycasts)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanLightTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "GetWaterPlacementValues")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(GearItem), Member = "GetGearDisplayName")]
	[CalledBy(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemCONSOLE")]
	[CalledBy(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(Action_AddGearItem), Member = "OnExecute")]
	[CalledBy(Type = typeof(UserBlueprintData), Member = "FindGearItemPrefab")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static GearItem LoadGearItemPrefab(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static GearItem InstantiateGearItem(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GearItem()
	{
	}
}
