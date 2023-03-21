using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Interactions;
using TLD.PDID;
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
		[CallerCount(Count = 107)]
		get
		{
			return null;
		}
	}

	public string DisplayNameWithCondition
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
		[Calls(Type = typeof(ConditionTable), Member = "GetDisplayNameWithCondition")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCollectibleList")]
		[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshReadPanel")]
		[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(GearItem), Member = "GetDescriptionToDisplayOnInventoryScreen")]
		[CalledBy(Type = typeof(ItemDescriptionPage), Member = "BuildItemDescription")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
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
			return default(bool);
		}
	}

	public float WeightKG
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(float);
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
			return default(float);
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
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool CanInteract
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool NonInteractive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GearManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[Calls(Type = typeof(GearItem), Member = "RollGearCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "CacheComponents")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 73)]
	public void CacheComponents()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	public void SetLocalizationOverride(string displayNameOverrideLocID, string descriptionOverrideLocID)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsUnequipInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	private void MaybeDestroyBodyHarvest()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void AddGearToContainer(GearItem containedGearItem, GearItem newItem)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	private void RemoveGearFromContainer(GearItem gi)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "IsCurrent")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(GearManager), Member = "DestroyNextUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[CalledBy(Type = typeof(GearManager), Member = "UpdateItems")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[Calls(Type = typeof(GearItem), Member = "RemoveGearFromContainer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	public void ManualUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasPhysicsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string SerializeRigidBody()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_mass")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	public void DeserializeRigidBody(string rigidBodySerialized)
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(CookingPotItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Serialize")]
	[Calls(Type = typeof(GearItem), Member = "SerializeRigidBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "CreateSaveData")]
	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(Inventory), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ClothingItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Bed), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_rotation")]
	[Calls(Type = typeof(GearItem), Member = "IsUndegradableAccelerant")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "AddGearToContainer")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(OwnershipOverride), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(GearItem), Member = "ManualStart")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindTargetPlacePoint")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "DoDryOrFreeze")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "UpdateHeatPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DeserializeRigidBody")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 43)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(FlareItem), Member = "Deserialize")]
	[Calls(Type = typeof(Bed), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EvolveItem), Member = "CanEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "DoRoll")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	public void Deserialize(string text, bool applyPositioningFix = true)
	{
	}

	[CalledBy(Type = typeof(GearManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Action_RemovePlayerInventory), Member = "OnExecute")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "Serialize")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	public GearSaveData CreateSaveData()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void OnWield(bool immediate)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnBeginUnwield()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public void OnUnwieldComplete()
	{
	}

	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "AabbOverlap")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Physics), Member = "RaycastNonAlloc")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 29)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Rigidbody), Member = "ClosestPointOnBounds")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "AddGearToNearestContainer")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	public void MaybeAddToLostAndFound()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAttachedToPlacePoint()
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	public void MaybeDestroyGearItemAfterMission()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeRuinFood")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_object_hp_percent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(GearItem), Member = "WearOut")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallerCount(Count = 4)]
	public void SetNormalizedHP(float condition, bool roundToWholeNumber = true)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void DisplayDegradedHUDMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairFinished")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "DegradeToolUsedForRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "DegradeToolUsed")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DegradeToolOnUse")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 15)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(CookingPotItem), Member = "DoConditionDamageToPot")]
	public void DegradeOnUse()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(GearItem), Member = "CheckForHoursToBreak")]
	[CalledBy(Type = typeof(Lock), Member = "PrepareForceLock")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DetermineTimeForToolBreak")]
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

	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Lock), Member = "FinishForceLock")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "ApplyWearToTool")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvest")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFireStriker")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseFlintAndSteel")]
	[CalledBy(Type = typeof(FireManager), Member = "ExitFireStarting")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateQuarter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "GameObjectInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	public void BreakOnUse()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool ShouldKeepButtonPromptsOnScreen()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetTitleToDisplayWhenSelected()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 131)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmthAndWindchillBonusString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDescriptionToDisplayOnInventoryScreen")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextForInspectMode")]
	public string GetTextToDisplayWhenSelected()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	public string GetDescriptionToDisplayOnInventoryScreen()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 46)]
	public float GetItemWeightKG(bool ignoreClothingBonus = false)
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public float GetSingleItemWeightKG(bool ignoreClothingBonus = false)
	{
		return default(float);
	}

	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWeightModifierNoWornBonus")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "CalculateLiquidWeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public float GetItemWeightKG(float stackMultiplier, bool ignoreClothingBonus = false)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 1)]
	private float CalculateLiquidWeight(float liters, GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float RoundItemWeight(float weight)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnTakeWaterComplete")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayGearItemInsidePickupAudio")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectClothingSlot")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetItemPostFixForInventoryInterfaces")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetItemPrefixForInventoryInterfaces")]
	public string GetDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateSlotLabel")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public string GetBasicDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[Calls(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeDestroyBodyHarvest")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeDropDepletedItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnDropItem")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "DropGear")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "DropAndPlaceItem")]
	[Calls(Type = typeof(GearManager), Member = "MaybeAddToDroppedDecoys")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "InstantiateStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GearManager), Member = "MaybeAddToDroppedDecoys")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem Drop(int numUnits, bool playSound = true, bool stickToFeet = true)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public GearItem InstantiateStackable(int numUnits)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "CreateWaterPlacement")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "InstantiateAndDropWaterBottle")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject InstantiateWater(GameObject prefab, float volume, LiquidQuality quality)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject InstantiateDepletedGearPrefab(GameObject prefab)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "TrackGearItem")]
	[CalledBy(Type = typeof(GearItemInteractabilityControl), Member = "SetInteractive")]
	[CalledBy(Type = typeof(GearItem), Member = "SetInteractive")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "HideItemBeingCooked")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "InspectModeCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	public void ToggleColliders(bool enable)
	{
	}

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public float GetNormalizedCondition(float hp)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "ItemPassesFilter")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[CalledBy(Type = typeof(GearItem), Member = "IsAnyGearType")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ItemPassesFilter")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsGearType(GearType type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	public bool IsAnyGearType(GearType types)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsBigCarry()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	public bool IsLitFlare()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	public bool IsLitFlashlight()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	public bool IsLitLamp()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	public bool IsLitMatch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	public bool IsLitNoiseMaker()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PauseLight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[CalledBy(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[CalledBy(Type = typeof(Weather), Member = "IsTooDarkForAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "IsValidItemToPlace")]
	public bool IsLitTorch()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallerCount(Count = 1)]
	public bool IsLitLightsource()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallerCount(Count = 4)]
	public void ExtinguishLitItem()
	{
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "ProcessItemInHandDetonated")]
	public FPSItem GetFPSItem()
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Color GetColorBasedOnCondition()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	public string GetColorStringBasedOnCondition()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallsUnknownMethods(Count = 2)]
	public int GetRoundedCondition()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetRoundedCondition(float normalizedCondition)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void SetHaltDecay(bool haltDecay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public bool RollForFoodPoisoning(float startingCalories)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[Calls(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[Calls(Type = typeof(FatigueBuff), Member = "Apply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FreezingBuff), Member = "Apply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ApplyBuffs(float normalizedValue)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameWithoutConditionForInventoryInterfaces")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshToolSelection")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetItemPostFixForInventoryInterfaces()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	public void MaybeAdjustTransformWithDropDummy()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Vector3 UpdateOrientationForCorpse(ref RaycastHit hit, Vector3 desiredNormal)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CalledBy(Type = typeof(Inventory), Member = "DropAndScatterItems")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[Calls(Type = typeof(GearItem), Member = "UpdateOrientationForCorpse")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled")]
	public bool StickToGroundAndOrientOnSlope(Vector3 desiredPosition, NavMeshCheck navMeshCheck, float verticalOffset, bool ignoreCorpseLayer = false)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeCollectSpentArrows")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDropMeshAtPlayerFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MoveOverlappingGearToPlayer), Member = "Start")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(BearHuntAiRedux), Member = "TakeBearEar")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
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
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SpawnCarcassPickup")]
	public void SkipSpawnChanceRollInitialDecayAndAutoEvolve()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallsUnknownMethods(Count = 1)]
	public void CopyHarvestedState(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "SetBlendAmountOnly")]
	public float GetDamageBlendValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "UpdateGrubMeshVisualCondition")]
	public float GetDamageBlendValue(float hp)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	public void SetDamageBlendValue(float blendVal)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "UpdateRepair")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CleanSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "SharpenSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateActionProgressBar")]
	[CalledBy(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[CalledBy(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	public void UpdateDamageShader()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallsUnknownMethods(Count = 6)]
	public void DropIntoWater(Collider collider, float waterY)
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
	[CalledBy(Type = typeof(CookingPotItem), Member = "PlayAttachToFireAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCookingSlotSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void MaybePlayCookingSlotPlacementAudio(GearPlacePoint placePoint)
	{
	}

	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "Break")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ResetPlacedGear")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "CheckForPlacedGearAfterLoad")]
	[CalledBy(Type = typeof(BreakDown), Member = "DetachAttachedObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybePlaceGear")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "Update")]
	public void SetPlacePoint(GearPlacePoint placePoint)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(GearItem), Member = "OverrideGearCondition")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	private void RollGearCondition(bool pickedUp)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void MaybeRollRandomWeightAndCalories()
	{
	}

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private void MaybeFallIntoWater()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void RollSpawnChance()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "GetDisplayNameForInventoryInterfaces")]
	[CallsUnknownMethods(Count = 3)]
	private string GetItemPrefixForInventoryInterfaces(bool condition)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeLastUpdatedTodHours()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[Calls(Type = typeof(GearItem), Member = "InitializeLastUpdatedTodHours")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "RollSpawnChance")]
	private void ManualStart()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	private void DecayOverTODHours(float deltaTODHours, float scale)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearPlacePoint), Member = "PlaceGear")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindFirstEmptyPlacePoint")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindTargetPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybePlaceGear()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "ApplyForcesToGear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyForce(Vector3 force, Vector3 torgue)
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Deserialize")]
	public GearItem Clone()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnablePhysics()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool IsWeapon()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DisableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(DisableObjectForGameMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 8)]
	public bool IsGunOrAmmoOrCasingOfType(GunType gunType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool IsTwoHandedWeapon()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "AddGearToContainer")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsDummy()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public bool Equals(GearItem other)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Container), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Texture2D), Member = "ClearRequestedMipmapLevel")]
	[CalledBy(Type = typeof(GearItem), Member = "OnDestroy")]
	[Calls(Type = typeof(Texture2D), Member = "set_requestedMipmapLevel")]
	[Calls(Type = typeof(Texture2D), Member = "ClearRequestedMipmapLevel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "GetTexturePropertyNameIDs")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	public static string GetGearDisplayName(string gearPrefabName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[CallsUnknownMethods(Count = 3)]
	public void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GearItem), Member = "get_HoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "GetHoverStateText")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	private string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "GetHoverText")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextPostfix")]
	[Calls(Type = typeof(EvolveItem), Member = "GetEvolvedPercentString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWetnessString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	private string GetHoverStateText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateInteraction()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public bool PerformInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	public void TryStartPlaceMeshInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1446)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public bool CanLightTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public static GearItem LoadGearItemPrefab(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "DeserializeContentsToPos")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "HanksHack")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[CalledBy(Type = typeof(Container), Member = "DeserializeAdditive")]
	[CalledBy(Type = typeof(Action_RestorePlayerInventory), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem InstantiateGearItem(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GearItem()
	{
	}
}
