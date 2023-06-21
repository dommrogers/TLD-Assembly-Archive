using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.AI;
using TLD.AddressableAssets;
using TLD.BigCarry;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Interactions;
using TLD.SaveState;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
	public class IngestedCarryCapacityBuff
	{
		public float m_HoursRemaining;

		public float m_HoursDuration;

		public string m_BuffTypeLocId;

		public CarryingCapacityBuff.BuffValues m_BuffValues;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public IngestedCarryCapacityBuff()
		{
		}
	}

	[Serializable]
	private class ClothingRegionSwitchDefault
	{
		public ClothingRegion m_Region;

		public Switch m_Switch;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ClothingRegionSwitchDefault()
		{
		}
	}

	public enum InventoryInstantiateFlags
	{
		None = 0,
		EnableNotificationFlag = 1,
		CraftInProgress = 2,
		DoNotStack = 4
	}

	public struct LookAtTargetForTime
	{
		public float m_FrameTimeSeconds;

		public bool m_ShouldRestoreCameraOrientation;

		public float m_TimeRemaining;

		public UITweener.Method m_TtweenInMethod;

		public bool m_SteeperCurvesIn;

		public UITweener.Method m_TweenOutMethod;

		public bool m_SteeperCurvesOut;

		public Quaternion m_RestoreCameraOrientation;

		public Quaternion m_CameraTargetOrientation;

		public float m_BlendInTime;

		public float m_BlendOutTime;

		[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UpdateLookAt")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LookAtTargetForTime), Member = "TweenValue")]
		[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
		[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public void Update()
		{
		}

		[CalledBy(Type = typeof(LookAtTargetForTime), Member = "Update")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private float TweenValue(float factor, UITweener.Method tweenMethod, bool steeperCurves)
		{
			return 0f;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		private float BounceLogic(float val)
		{
			return 0f;
		}
	}

	[Serializable]
	public struct DecalColourInfo
	{
		public DecalColour m_ColourType;

		public Color m_Color;
	}

	public enum DropLitItemsOptions
	{
		None = 0,
		KeepItemInInventory = 1,
		DeleteDroppedItemWhenTimelineEnds = 4
	}

	private sealed class _003C_003Ec__DisplayClass795_0
	{
		public PlayerManager _003C_003E4__this;

		public PlayerAnimation.OnAnimationEvent throwCompleteCallback;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass795_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CThrow_003Eb__0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CThrow_003Eb__1()
		{
		}
	}

	private const string LOCID_BUFFLOSSHEADER = "GAMEPLAY_BuffLossHeader";

	private const string LOCID_CARRYCAPACITYBUFF = "GAMEPLAY_CarryBuffType";

	private const string LOCID_CARRYCAPACITYDEBUFF = "GAMEPLAY_CarryDebuffType";

	private float m_FreezingRateScale;

	private float m_PumpkinPieFreezingRateScale;

	private float m_FatigueRateScale;

	private float m_ConditonPercentBonus;

	private float m_IncreaseWolfFleePercentagePoints;

	private float m_DecreaseWolfAttackChancePercentagePoints;

	private float m_ConditionPerHourBonus;

	private float m_FatigueBuffHoursRemaining;

	private float m_FatigueBuffHoursDuration;

	private string m_FatigueBuffCauseLocID;

	private float m_FreezingBuffHoursRemaining;

	private float m_FreezingBuffHoursDuration;

	private float m_ConditionRestBuffHoursRemaining;

	private float m_ConditionRestBuffHoursDuration;

	private string m_ConditionRestBuffCauseLocID;

	private float m_PumpkinPieBuffHoursRemaining;

	private float m_PumpkinPieBuffHoursDuration;

	private float m_ConditionPerHourHoursRemaining;

	private float m_ConditionPerHourHoursDuration;

	private List<IngestedCarryCapacityBuff> m_IngestedCarryCapacityBuffList;

	private float m_ClimbingBuffSprainOddsModifier;

	private float m_ClimbingBuffStaminaPerSecondModifier;

	private float m_ClimbingBuffWeakIceTimeSecondsModifier;

	private CarryingCapacityBuff.BuffValues m_CarryingCapacityBuffValues;

	private List<GearItem> m_WornCarryingCapacityGearItemList;

	private List<GearItem> m_SpecialCarryingCapacityGearItemList;

	public float m_WetnessPercentPerHourLightSnow;

	public float m_WetnessPercentPerHourHeavySnow;

	public float m_WetnessPercentPerHourBlizzard;

	public float m_ClothingWeightWhenWornModifier;

	private List<ClothingRegionSwitchDefault> m_RegionSwitchDefaults;

	public float m_WarmthBonusFromClothing;

	public float m_WindproofBonusFromClothing;

	private const int MAX_CLOTHING_REGIONS = 8;

	private const int MAX_CLOTHING_LAYERS = 4;

	private readonly GearItem[,] m_Clothing;

	private readonly uint[] m_LastSoundSwitchByRegion;

	private readonly List<GearItem> m_GearItemList;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private PanelReference<Panel_Actions> m_Actions;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_Affliction> m_Affliction;

	private PanelReference<Panel_BreakDown> m_BreakDown;

	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	private PanelReference<Panel_CanOpening> m_CanOpening;

	private PanelReference<Panel_FireStart> m_FireStart;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	private PanelReference<Panel_LeanToBuild> m_LeanToBuild;

	private PanelReference<Panel_LeanToInteract> m_LeanToInteract;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	private PanelReference<Panel_PickWater> m_PickWater;

	private PanelReference<Panel_SnowShelterBuild> m_SnowShelterBuild;

	private PanelReference<Panel_SnowShelterInteract> m_SnowShelterInteract;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	public bool m_StartGearApplied;

	public Vector3 m_SaveGamePosition;

	public Quaternion m_SaveGameRotation;

	public IndoorSpaceTrigger m_IndoorSpaceTrigger;

	public List<StealthZoneTrigger> m_StealthZoneTriggers;

	public bool m_DoTeleportAfterSceneLoad;

	public bool m_InRunMode;

	public bool m_Ghost;

	public bool m_God;

	public StartGear m_StartGear;

	public AiTarget m_AiTarget;

	public float m_CaloriesHarvestedToday;

	public bool m_SceneTransitionStarted;

	public List<int> m_KnownCodes;

	public SerializableBounds m_LimitCampfiresToBounds;

	public bool m_AllowPanelInteraction;

	[NonSerialized]
	public bool m_ForceAIFlee;

	[NonSerialized]
	public bool m_SuspendConditionUpdate;

	[NonSerialized]
	public bool m_ForceHideDiscoveryText;

	[NonSerialized]
	public bool m_DisableAllSpeech;

	public static VoicePersona m_VoicePersona;

	public List<ActionsToBlock> m_ActionsToBlockInDarkness;

	public GameplayTag m_BlockRandomWeatherTag;

	[NonSerialized]
	public bool m_FreezeMovement;

	public float m_ChanceToPlayContainerInspectVO;

	public static string m_ForceSpawnPointName;

	public static bool m_PlayerDebug;

	private static List<PlayerSpawnPoints> m_PlayerSpawnPoints;

	public string m_KnockdownVO;

	public float m_DamageAmountThresholdToStopAutoWalk;

	private float m_PlacementDistanceFromPlayerCamera;

	private const float INTERIOR_SPAWN_RAYCAST_DISTANCE = 50f;

	private const int STICK_TO_GROUND_STEPS = 10;

	private PlayerControlMode m_ControlMode;

	private bool m_FirstFrame;

	private float m_SwayTime;

	private float m_SwayDuration;

	private float m_SwayAngle;

	private float m_SwayTotal;

	private float m_TimeSinceYawChange;

	private float m_SwayPreviousYaw;

	private bool m_SwayRight;

	private bool m_CheatsUsed;

	private float m_LastClosestPredatorDistanceSentToWise;

	private float m_LastPlayerElevationSentToWise;

	private int m_DelayedSpawnAudioCountdown;

	private string m_DelayedSpawnAudio;

	private bool m_SkipDelaySpawnAudio;

	private string m_LastPlayerGroundMaterialTag;

	private CramponsState m_LastPlayerCramponsState;

	private bool m_LastPlayerCramponsStateValid;

	private bool m_TeleportPending;

	private Vector3 m_TeleportPendingPosition;

	private Quaternion m_TeleportPendingRotation;

	private bool m_RestorePlayerToClosestSnowShelter;

	private Vector3 m_RestoreSnowShelterPos;

	private bool m_RestorePlayerToClosestLeanTo;

	private Vector3 m_RestoreLeanToPos;

	private bool m_StartHasBeenCalled;

	private bool m_ShowUnknownTimeOfDay;

	private bool m_CachedUnstow;

	private bool m_StatusBarsLocked;

	private Vector3 m_LastPlayerPosition;

	private Vector2 m_LastPlayerAngle;

	private bool _003CPlayerHasMoved_003Ek__BackingField;

	private bool _003CPlayerHasTurned_003Ek__BackingField;

	private bool m_NearPlaneOverridden;

	private int m_StickPlayerToGroundDelay;

	private SceneLoadSource m_SceneLoadSource;

	private List<IndoorSpaceTrigger> m_IndoorSpaceTriggers;

	private static PlayerManagerSaveDataProxy m_PlayerManagerSaveDataProxy;

	public bool m_DebugDamage;

	public bool m_DebugProjectile;

	public bool m_DebugPosition;

	public bool m_DebugLookAt;

	public bool m_DebugLookAtHighlight;

	private float m_DebugPositionSecondsToNextLog;

	public static float m_DebugPositionLogDefaultFrequencyInSeconds;

	public float m_DebugPositionLogFrequencyInSeconds;

	public bool m_InspectingFromHarvestable;

	public bool m_ReadingNote;

	public Vector2 m_InspectModeMouseSensitivity;

	public Vector2 m_InspectModeControllerSensitivity;

	public float m_TimeBeforeStow;

	private bool m_StowTriggered;

	private GearItem m_Gear;

	private Container m_Container;

	private IceFishingHole m_IceFishingHole;

	private Harvestable m_Harvestable;

	private CookingPotItem m_CookingPotItem;

	private Inspect m_Inspect;

	private Vector3 m_RestorePos;

	private Quaternion m_RestoreRot;

	private ShadowCastingMode m_RestoreCastsShadows;

	private bool m_CanAddToInventory;

	private bool m_PlayedInspectModeVoiceOver;

	private bool m_SkipRestoreItemInHandsOnExit;

	private float[] m_InspectFadeAlphas;

	private float m_TimeInInspectMode;

	private float m_FadeInAlphaTimer;

	private float m_StoredFieldOfView;

	private vp_FPSWeapon m_StoredWeapon;

	private Transform m_CachedParent;

	private Vector3 m_OriginalLocalScale;

	private bool m_InspectModeActive;

	private int m_NoInteractionDuringInspectFrameCounter;

	private CallbackDelegate m_Callback;

	private Quaternion m_GearItemRotationInInspectSpace;

	private Vector3 m_GearItemPositionInInspectSpace;

	private const string m_LeaveItLocId = "GAMEPLAY_LeaveIt";

	private float m_CurrentLiquidVolume;

	private List<GearItem> m_MaybeShowGearItemOnMapLaterList;

	public Vector3 m_LocationOfLastInteractHit;

	private IInteraction _003CActiveInteraction_003Ek__BackingField;

	private bool _003CIsInteractionNearCrosshair_003Ek__BackingField;

	private List<IInteraction> m_InteractionResults;

	private bool m_IsForcedInteractionActive;

	private bool m_IsHoldInteractionActive;

	private PlayerControlMode m_InteractionRestoreControlMode;

	private bool m_EquipLastItemInHandsAfterInteraction;

	private bool m_RaiseItemInHandsAfterInteraction;

	public bool m_ItemInHandsRestorePending;

	private bool m_PickupIsImmediate;

	public GearItem m_PickupGearItem;

	private const int MAX_SPHERECAST_HITS = 16;

	private RaycastHit[] m_SphereCastHits;

	private bool m_DoInteractionEndNextFrame;

	private List<MeshCollider> m_MeshColliders;

	private List<Transform> m_Transforms;

	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	public float m_FallbackStackConditionDifferenceConstaint;

	public GearItem m_LastUnequippedItem;

	public bool m_UsedItemFromFirstAidPanel;

	private GearItem m_ItemInHandsInternal;

	private string m_TreatmentSuccessAudio;

	private string m_TreatmentFailedAudio;

	private bool m_FoodPoisoningOnEatingComplete;

	private WaterSupply m_WaterSourceToDrinkFrom;

	private float m_WaterToDrinkLiters;

	private float m_HealingOnFirstAidComplete;

	private FirstAidItem m_FirstAidItemUsed;

	private Affliction m_AfflictionSelected;

	private GearItem m_PurifyWaterItemUsed;

	private GearItem m_SmashableItemUsed;

	private GearItem m_FoodItemOpened;

	private GearItem m_FoodItemEaten;

	private GearItem m_EmergencyStimUsed;

	private float m_FoodItemEatenStartingCalories;

	private float m_FoodItemEatenStartingWeight;

	private GearItem m_QueuedEquipItem;

	private bool m_HasSavedItemInHands;

	private bool m_RestoreSavedItemInHandsPending;

	private Vector3 m_LastDropCheckPosition;

	private bool m_LastDropCheckResult;

	private Collider[] m_DropCheckColliders;

	public HeldItemRestriction m_HeldItemRestriction;

	private bool m_IsLookAtTargetForTimeActive;

	private LookAtTargetForTime m_LookAtTargetForTime;

	private Color m_DecalPlacementValidColour;

	private Color m_DecalPlacementValidInRangeOfTransitionColour;

	private Color m_DecalPlacementInvalidColour;

	private Color m_DecalPlacementOnTopOfAnotherColour;

	private DecalColourInfo[] m_DecalColours;

	private string m_StopPaintAudioID;

	private string m_StopEraseAudioID;

	public float m_PlaceDecalRotationDegreesPerSecond;

	public float m_PlaceDecalMouseWheelRotationDegrees;

	private ProjectileType m_DecalToPlaceShape;

	private DecalColour m_DecalToPlaceColour;

	private DecalProjectorInstance m_DecalToPlace;

	private DecalProjectorInstance m_DecalToErase;

	private DecalProjectorInstance m_CurrentOverlappingDecal;

	private GearItem m_DecalPlacementGearItem;

	[NonSerialized]
	public bool m_HasEverSprayPainted;

	public float m_DefaultPlacementDistance;

	public float m_FarPlacementDistanceMultiplier;

	public float m_MaxSlopeDegreesForPlacement;

	public float m_PlaceMeshRotationDegreesPerSecond;

	public float m_PlaceMeshMouseWheelRotationDegrees;

	public GameObject m_OscarPrefab;

	private GameObject m_ObjectToPlace;

	private List<Collider> m_ObjectToPlaceColliders;

	private List<Renderer> m_ObjectToPlaceRenderers;

	private GearItem m_ObjectToPlaceGearItem;

	private Campfire m_ObjectToPlaceCampfire;

	private Bed m_ObjectToPlaceBed;

	private SnowShelter m_ObjectToPlaceSnowShelter;

	private LeanTo m_ObjectToPlaceLeanTo;

	private RockCache m_ObjectToPlaceRockCache;

	private RadialObjectSpawner m_ObjectToPlaceRadialSpawner;

	private BigCarryItem m_ObjectToPlaceBigCarryItem;

	private IceFishingHole m_ObjectToPlaceIceFishingHole;

	private MaterialPropertyBlock m_ValidTintMaterialPropertyBlock;

	private MaterialPropertyBlock m_InvalidTintMaterialPropertyBlock;

	private MeshLocationCategory m_MeshLocationCategory;

	private bool m_PendingMeshPlacement;

	private float m_PendingMeshPlacementElapsedTime;

	private float m_UnmodifiedPlacementDistance;

	private float m_PlacementDistance;

	private float m_PlacementDistanceFar;

	private bool m_PlacedMesh;

	private GearPlacePoint m_LastGearPlacePoint;

	private Bed m_LastBed;

	private Transform m_RestoreParent;

	private Vector3 m_RestorePosition;

	private Quaternion m_RestoreRotation;

	private int m_RestoreLayer;

	private Quaternion m_RotationInCameraSpace;

	private bool m_SkipCancel;

	private bool m_IsPlacingCookableOnCookingSlot;

	private bool m_UpdatedInventoryOnPlacement;

	private BlockPlacement m_LastBlockedPlacement;

	private float m_RotationAngle;

	private bool m_AlreadyPlaced;

	private List<Renderer> m_TintedRenderers;

	private readonly int m_TintColorID;

	private readonly int m_TintColorGlowID;

	private static Collider[] s_IndoorTriggerDetectionResults;

	private static Color s_DefaultMeshPlacementValidColour;

	private static Color s_DefaultMeshPlacementInvalidColour;

	private static Color m_CurrentMeshPlacementValidColour;

	private static Color m_CurrentMeshPlacementInvalidColour;

	private GearItem m_ThrownItem;

	public float m_ThrowForce;

	public float m_ThrowTorque;

	protected vp_Timer m_ThrowTimer;

	public bool PlayerHasMoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool PlayerHasTurned
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

	public IInteraction ActiveInteraction
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool IsInteractionNearCrosshair
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

	public GearItem m_ItemInHands
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(GearItem), Member = "Drop")]
		[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
		[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
		[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
		[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
		[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyPumpkinPieBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyFreezingBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyFatigueBuff(float instantPercentDecrease, float rateScale, float durationHours, string causeLocID, float durationMaxHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public string GetFatigueBuffCauseLocID()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ApplyConditionRestBuff(float percentBonus, float restHours, float durationMaxHours, string causeLocID)
	{
	}

	[CallerCount(Count = 0)]
	public void ApplyConditionOverTimeBuff(float conditionPerHourBonus, float numHours, float durationMaxHours)
	{
	}

	[CallerCount(Count = 0)]
	public void ApplyWolfIntimidationBuff(float increaseFleePercentagePoints, float decreaseAttackChancePercentagePoints)
	{
	}

	[CallerCount(Count = 0)]
	public void RemoveWolfIntimidationBuff()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyCarryingCapacityBuff(CarryingCapacityBuff.BuffValues values)
	{
	}

	[CalledBy(Type = typeof(TLD.Gear.IngestedCarryCapacityBuff), Member = "Apply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyIngestedCarryCapacityBuff(float delta, float durationHours, string typeLocId)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public bool HasSpecialCarryingCapacityGear(GearItemData gearItemData)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveCarryingCapacityBuff()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	[CallsUnknownMethods(Count = 14)]
	public void UpdateCarryingBuff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public bool HasIngestedCarryCapacityBuff()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public bool HasIngestedCarryCapacityDebuff()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	public float GetIngestedCarryCapacityBuffDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	public float GetIngestedCarryCapacityBuffDurationNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	public float GetIngestedCarryCapacityDebuffDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	public float GetIngestedCarryCapacityDebuffDurationNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityBuffDuration")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityBuffDurationNormalized")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityDebuffDuration")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetIngestedCarryCapacityDebuffDurationNormalized")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeApplyIngestedCarryCapacityBuffAndDebuff")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 8)]
	private void GetBestIngestedCarryCapacityBuffAndDebuff(out IngestedCarryCapacityBuff bestBuff, out IngestedCarryCapacityBuff bestDebuff)
	{
		bestBuff = null;
		bestDebuff = null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetBestIngestedCarryCapacityBuffAndDebuff")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeApplyIngestedCarryCapacityBuffAndDebuff()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornWolfIntimidationClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateBuffDurations(Panel_HUD hud, float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateIngestedCarryCapacityBuffs(Panel_HUD hud, float hoursDelta)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateConditonBuffDuration(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 5)]
	public bool IsPumpkinPieBuffActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public float GetFreezingRateScaleBuff()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetFatigueRateScaleBuff()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetConditionPercentBonus()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWolfFleeIncreasePercentagePointsBuff()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWolfDecreaseAttackChancePercentagePointsBuff()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "HasBuff")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 4)]
	public bool FreezingBuffActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool FatigueBuffActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Encumber), Member = "IsCapacityBuffed")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityWhenExhaustedKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLowThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberMedThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberHighThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCarryCapacityKGBuff()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetConditionPerHourBonus()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void RemoveBuffsCONSOLE()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetFatigueBuffTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void ResetFatigueBuffTimeRemainingHours()
	{
	}

	[CallerCount(Count = 0)]
	public float GetFatigueBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetFreezingBuffTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetFreezingBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetConditionRestBuffTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetConditionRestBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 1)]
	public string GetConditionRestBuffCauseLocID()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPumpkinPieBuffTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetPumpkinPieBuffTimeRemainingNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetConditionPerHourTimeRemainingHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetConditionPerHourRemainingNormalized()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyClimbingBuff(ClimbingBuff cb)
	{
	}

	[CallerCount(Count = 0)]
	public void RemoveClimbingBuff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateClimbingBuff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffSprainOddsModifier()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffStaminaPerSecondModifier()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffWeakIceTimeSecondsModifier()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CallerCount(Count = 2)]
	public static int GetNumLayersForClothingRegion(ClothingRegion clothingRegion)
	{
		return 0;
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWetnessIncreasePerHour()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateClothingWetness()
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateBonusValuesFromWornClothing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	public void ApplyPercentDamageToWornClothingRegion(ClothingRegion region, float normalizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	public void ApplyDamageToWornClothingRegion(ClothingRegion region, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetWarnClothingCanBeDamaged()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyPercentDamageToWornClothing(float normalizedDamage)
	{
	}

	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyDamageToWornClothing(float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 2)]
	public float GetWornClothingToughness()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "TakeOff")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[CallsUnknownMethods(Count = 5)]
	public void TakeOffClothingItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "PutOn")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 5)]
	public void PutOnClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingPerfectClothesInAllSlots")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeUnlockResoluteOutfitterAchievement()
	{
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWearingClothingItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWearingClothingName(string itemName)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[CallsUnknownMethods(Count = 2)]
	private bool UseClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFreeSlotForClothingItem(ClothingItem ci)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HasFreeSlotForClothingItem")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private ClothingLayer GetEmptyLayerForRegion(ClothingRegion region, ClothingLayer minLayer, ClothingLayer maxLayer)
	{
		return default(ClothingLayer);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_clothing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 26)]
	public void OutputWornClothing()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetWornWolfIntimidationClothing()
	{
		return null;
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetWornCarryingCapacityBuffClothing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public void GetAllWornCarryingCapacityBuffClothing(List<GearItem> carryingCapacityBuffs)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	public void GetAllSpecialCarryingCapacityBuffItems(List<GearItem> carryingCapacityBuffs)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClimbingBuff")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClimbingBuff), Member = "IsActive")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetClimbingBuffClothing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetClothingSprintReduction()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumWetClothes()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectDefaultSlot")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetClothingInSlot(ClothingRegion region, ClothingLayer layer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	public bool HasFootwearOn()
	{
		return false;
	}

	[CalledBy(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	public CramponsState GetCramponsState()
	{
		return default(CramponsState);
	}

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDamageReductionFromExteriorClothing()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallsUnknownMethods(Count = 1)]
	public float GetDamageReductionFromExteriorLegFeet()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsWearingPerfectClothesInAllSlots()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 2)]
	private float GetWornClothingRegionToughness(int regionIndex)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothingRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyPercentDamageToTopMostLayer(int regionIndex, float normalizedDamage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(Burns), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothingRegion")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyDamageToTopMostLayer(int regionIndex, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CalledBy(Type = typeof(ClimbingBuff), Member = "IsActive")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HasFootwearOn")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetAudioSwitchOfOuterLayer")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetTopLayerGear(ClothingRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	public void GetAllClothingInRegion(ClothingRegion region, List<GearItem> gearItems)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 2)]
	public bool RegionHasFullFrozenInnerLayer(ClothingRegion region)
	{
		return false;
	}

	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 2)]
	public bool RegionHasFullWetInnerLayer(ClothingRegion region)
	{
		return false;
	}

	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool RegionHasNonFrozenClothing(ClothingRegion region)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public void MaybeSetPlayerFootwearSwitch()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetAudioSwitchOfOuterLayer")]
	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetSoundSwitch(ClothingRegion region)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private uint GetLastAudioSwitchForRegion(ClothingRegion region)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetLastAudioSwitchForRegion(ClothingRegion region, uint id)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Switch GetAudioSwitchOfOuterLayer(ClothingRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	private void SetSoundSwitch(uint switchGroup, uint switchValue)
	{
	}

	[CallerCount(Count = 0)]
	private bool GetShouldApplyStartGear()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ExitIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFirstFrame()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsStickPlayerToGroundPending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsTeleportPending()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void SpawnFirstPersonItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetStartGear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPositionAfterLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(Physics), Member = "get_autoSimulation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateIfPlayerHasMoved")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateActiveInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithClosestDistanceToPredator")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithPlayerElevation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(LookAtTargetForTime), Member = "Update")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CallsUnknownMethods(Count = 3)]
	public void DeserializePostSceneLoadFixup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateFromUnderCrosshair")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[Calls(Type = typeof(SplineManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void TeleportPlayer(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 309)]
	[CallsUnknownMethods(Count = 2)]
	public PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[CallerCount(Count = 120)]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsUnknownMethods(Count = 5)]
	public void SetControlMode(PlayerControlMode mode)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[CallerCount(Count = 1)]
	public bool ControlModeAllowsInterface()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetStatusBarsLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsStatusBarsLocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool PlayerIsDead()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeekInternal")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "IsPlayingNonInterruptableAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "IsLoading")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	public bool PlayerIsInvisibleToAi()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[CallsUnknownMethods(Count = 3)]
	public float CalculateModifiedCalorieBurnRate(float baseBurnRate)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsUnknownMethods(Count = 23)]
	public void UpdateCalorieBurnRate()
	{
	}

	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CallsUnknownMethods(Count = 4)]
	public bool PlayerCantSprintBecauseOfInjury()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[CallsUnknownMethods(Count = 9)]
	public bool PlayerCanSprint()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(Infection), Member = "UpdateInfection")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShortenMessageTimeDueToQueue")]
	[CalledBy(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsSleeping()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "UpdateSprintState")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateTemperatureBonusFromRunning")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "ModifyChanceForSprinting")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetBodyCarryMovementMultiplier")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AllowStaminaToRecover")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 5)]
	public bool PlayerIsSprinting()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetFootStepsRangeScale")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 6)]
	public bool PlayerIsWalking()
	{
		return false;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 2)]
	public bool PlayerIsCrouched()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 3)]
	public bool PlayerIsZooming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsBreakingDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsBuildingShelter()
	{
		return false;
	}

	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsRepairingShelter()
	{
		return false;
	}

	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsDismantlingShelter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsBuildingLeanTo()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsRepairingLeanTo()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsDismantlingLeanTo()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsRotatingLeanTo()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsHarvestingCarcass()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool PlayerIsClimbing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool PlayerIsInElevator()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AllowStaminaToRecover")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[CallsUnknownMethods(Count = 5)]
	public bool PlayerIsSwingingFirstPersonItem()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitToPoint")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitTopOrBottom")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetStickToGroundPosition(Vector3 testPos, out Vector3 groundPos)
	{
		groundPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetStickToGroundPositionAfterLoad(Vector3 testPos, out Vector3 groundPos)
	{
		groundPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void StickPlayerToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPositionAfterLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void StickPlayerToGroundAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceLockCamera()
	{
	}

	[CallerCount(Count = 0)]
	public void ForceRotateCamera()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeRotateCamera()
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerCheat()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasCheated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetZoomDamping()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	public bool InHibernationPreventionIndoorEnvironment()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsCharacterControllerEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 4)]
	public void EnableCharacterController()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 4)]
	public void DisableCharacterController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 20)]
	public static GameObject PickRandomSpawnPoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ResetHoverText")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateHUDText(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "FindGameObjectsWithTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldForcePlayerSpawnToDefault")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public bool GetTeleportTransformAfterSceneLoad(out Vector3 position, out Quaternion rotation)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "PickRandomSpawnPoint")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private SceneLoadSource TeleportPlayerAfterSceneLoad()
	{
		return default(SceneLoadSource);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybePlayLandAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void OnLandFromFall(float fallFromHeight, float damageOverride)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnTakeDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	public void MaybeSetPlayerGroundMaterialSwitch(string tag)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldSaveGameAfterTeleport()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldForcePlayerSpawnToDefault()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeUpdateWiseWithClosestDistanceToPredator()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeUpdateWiseWithPlayerElevation()
	{
	}

	[CallerCount(Count = 0)]
	public void SkipDelaySpawnAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybePlayDelayedSpawnAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsUnknownMethods(Count = 3)]
	private bool AllowInteractionWithObjects()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeRepositionPlayerIfFellThroughWorld()
	{
	}

	[CallerCount(Count = 0)]
	public bool GetShowingUnknownTimeOfDay()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ShowUnknownTimeOfDay(bool showUnknownTimeOfDay)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void KnockedDownByAI(AiSubType aiSubType)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsStealthed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsPlayerInStealthArea()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsStealthed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHoldingWildlifeItem()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStaminaAim()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsStaminaAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStaminaAimPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStaminaAimDropThresholdPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void OnPostDeserializeForEpisodeMigration()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void GroundCharacterInternal(Vector3 groundPos)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateIfPlayerHasMoved()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LogAiDamage(GameObject damageReceiver, float condition, float damageGiven, float damageTaken, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LogAiFleeFromItem(BaseAi ai, GearItem item, bool wasHit, float fleeChance, float roll, float distance, float fleeDistance)
	{
	}

	[CallerCount(Count = 0)]
	private bool RangedApproximate(float a, float b, float range)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LogPlayerDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[CallerCount(Count = 0)]
	public void EnableDebugPosition(bool enabled, float frequencyInSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void LogPlayerPosition()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void MaybeFlushPlayerDamage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void FlushPlayerDamage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void EnableDebugLookAt(bool enabled, bool useHighlight)
	{
	}

	[CallerCount(Count = 0)]
	public string GetDebugLookAtDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UpdateDebugLookAtObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void AssignDebugLookAtMaterialProperties(bool enabled, Renderer[] renderers)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void InitInspectGearMode(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearModeWithCallback(GearItem gear, CallbackDelegate callback)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearMode(GearItem gear)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearModeFromContainer(GearItem gear, Container c)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearModeFromFishingHole(GearItem gear, IceFishingHole hole)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearModeFromHarvestable(GearItem gear, Harvestable h)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	public void EnterInspectGearModeFromCookingPot(GearItem gear, CookingPotItem pot)
	{
	}

	[CallerCount(Count = 0)]
	public void SetCallback(CallbackDelegate callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SaveGearItemTransformInInspectSpace(Transform t)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "OnCollectibleNoteReadingClickBack")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CallsUnknownMethods(Count = 2)]
	public void RevealOnPolaroidDiscovery(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeRevealPolaroidDiscoveryOnClose()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GearItem), Member = "ResetLocalScale")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItemData), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[Calls(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 17)]
	public void ExitInspectGearMode(bool hardExit)
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CollectFish")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeWithCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromFishingHole")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromHarvestable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromCookingPot")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 30)]
	private void EnterInspectGearMode(GearItem gear, Container c, IceFishingHole hole, Harvestable h, CookingPotItem pot)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldContainerDisallowEquipAction")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanPickupItemWhileCooking")]
	[Calls(Type = typeof(CookingPotItem), Member = "DestroyGearItemBeingCooked")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowConfirmPanel")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "OnCollectibleNoteReadingClickBack")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateInspectGear(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInspectModeActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public GearItem GearItemBeingInspected()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	public void RestoreTransformFromLastInspection(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeEnableInspectModeMesh(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeDisableInspectModeMesh(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "ResetLocalScale")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void RestoreOriginalTransform(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetGearTransformForInspection()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateGearTransformForInspection()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 33)]
	private void SetActiveAllLabels(Panel_HUD hud, bool active)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetActiveInfoArea(Panel_HUD hud, bool showStandard)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void NoteToggleReadMode(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "CanPickupItemWhileCooking")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldContainerDisallowEquipAction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(HoverIconsToShow), Member = "GetSpriteNameForHoverIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(EvolveItem), Member = "GetTimeToDryStringInventory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextForInspectMode")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(DishEffectInfo), Member = "ShowDishBenefits")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 64)]
	[CallsUnknownMethods(Count = 62)]
	private void InitLabelsForGear(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeReplaceGearItemForLabels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void FadeInLabels(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Inspect), Member = "GetUrgency")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybePlayInspectModeVoiceOver()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayPutBackAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PlayStowAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[CallsUnknownMethods(Count = 3)]
	private void AttemptEquipGearItem()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void TransferGearFromInspectToContainer()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[CallsUnknownMethods(Count = 1)]
	private void TransferGearFromContainerToInventory()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanPickup(Panel_HUD hud)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldContainerDisallowEquipAction()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshGamepadPrompts(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Toggle")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsCancelableActionInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsClickHoldActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ClearRestoreItemInHandsAfterInteraction()
	{
	}

	[CallerCount(Count = 0)]
	public bool WillRestoreItemInHandsAfterInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_stow_item")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Stow")]
	[CallsUnknownMethods(Count = 3)]
	public bool StowItem()
	{
		return false;
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Stow")]
	[CallsUnknownMethods(Count = 3)]
	public void ItemInHandsDuringInteractionStart()
	{
	}

	[CallerCount(Count = 0)]
	public void ItemInHandsDuringInteractionEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallsUnknownMethods(Count = 1)]
	private void DoDelayedInteractionEnd(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldStowOrUnstowForInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoDelayedInteractionEnd")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(Skill_Archery), Member = "CanFireBowWhileCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unstow")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CallsUnknownMethods(Count = 6)]
	private void ItemInHandsDuringInteractionEndInternal(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndAddToInventory")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "MaybeShowHudMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool ProcessPickupItemInteraction(GearItem item, bool forceEquip, bool forceEquipImmediate, bool skipAudio)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "SetupFPH")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessPickupWithNoInspectScreen(GearItem pickupItem, bool immediate)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "HandleItemInHands")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void ProcessPickupWithNoInspectScreenDropCurrent(PlayerAnimation.OnAnimationEvent nextEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallsUnknownMethods(Count = 1)]
	private void OnUnequipItemInHandInternalCompleteResetWeapon()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "MaybeShowHudMessage")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessPickupWithNoInspectScreenEquip()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnProcessPickupWinNoInspectEquipComplete()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallerCount(Count = 1)]
	public void ResetPickup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldShowClickHoldBackpiece()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[CallsUnknownMethods(Count = 2)]
	public HoverTextState GetInteractiveObjectDisplayTextState()
	{
		return default(HoverTextState);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	public string GetInteractiveObjectHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public string GetInteractiveObjectHoldText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 17)]
	private GameObject GetInteractiveObjectNearCrosshairs(float maxRange)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	public bool HasInteractiveObjectUnderCrossHair()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "RespectContrainsts")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private GameObject GetInteractiveObjectWithConstraints(GameObject interactiveObject)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	private void FindInteractiveObject(RaycastHit hit, ref GearItem gi, ref GameObject interactiveObj)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 34)]
	public GameObject GetInteractiveObjectUnderCrosshairs(float maxRange)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[CallsUnknownMethods(Count = 3)]
	public void InteractiveObjectsProcess()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void FindInteractiveObject(float range)
	{
	}

	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(LoadingZone), Member = "ActivateLoadingZone")]
	[CalledBy(Type = typeof(LoadingZone), Member = "DeactivateLoadingZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetForcedInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetInteraction")]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCurrentInteraction(IInteraction interaction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	public void SetForcedInteraction(IInteraction interaction)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TryCancelHoldInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateActiveInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	private void ResetInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldCancelHoldInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateActiveInteraction")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void TryCancelHoldInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void InteractiveObjectsProcessAltFire()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectUnderCrosshairCanLightTorch")]
	[CallsUnknownMethods(Count = 15)]
	public bool InteractiveObjectsProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	public bool ItemCanEquipInHands(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public float ComputeModifiedPickupRange(float range)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ItemShouldEquipOnPickup(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerHoldingTorchThatCanBeLit()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public bool ObjectUnderCrosshairCanLightTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HasInteractiveObjectUnderCrossHair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	private bool ShouldSuppressCrosshairs()
	{
		return false;
	}

	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseMatchesItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void EquipItem(GearItem gi, bool fromDeserialize)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnEquipItemBegin()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRestoreSaveItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 3)]
	public void EquipLastItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	public GearItem GetItemInHandsToRestoreAfterInteraction()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ClearHeldItemRestriction()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RestrictHeldItems")]
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HeldItemRestriction), Member = "IsRestricted")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHeldItemRestricted(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(HeldItemRestrictionTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	public void RestrictHeldItems(HeldItemRestriction restriction)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool CanHolsterItemInHand()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanHolsterItem(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallsUnknownMethods(Count = 1)]
	public void UnequipItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	public void MaybeRestoreSaveItemInHands()
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unequip_immediate")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "StartCrafting")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "FinishDrop")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 3)]
	public void UnequipImmediate(bool saveLastItem)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PauseLight")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 3)]
	public void AutoUnequipItemInHandsBeforeInteraction(bool pauseFlare = true)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "RestoreItemInHands")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	public void AutoEquipItemInHandsAfterInteraction()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CallsUnknownMethods(Count = 1)]
	public static void TurnLightOffImmediate(bool pauseFlare, GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CallsUnknownMethods(Count = 1)]
	private void PauseLight(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void ResumeLight(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	public void UnequipItemInHandsSkipAnimation()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[CallsUnknownMethods(Count = 1)]
	public void StopAudioForEquippedItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CallsUnknownMethods(Count = 8)]
	public void CancelItemInHandsAction(bool cancelByUser)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 2)]
	public void UnequipItemInHandsForPlacement()
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "ExitInterfaceAndOpenSafe")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallerCount(Count = 2)]
	public void ClearLastUnequippedItem()
	{
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "UseBedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public bool UseInventoryItem(GearItem gi, float volumeAvailable = -1f, bool suppressWeaponsErrorMessage = false)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackableItem), Member = "GetStackCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	public bool TryAddToExistingStackable(GearItem gearToAdd, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StackableItem), Member = "GetClosestMatchStackable")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CallsUnknownMethods(Count = 1)]
	public bool TryAddToExistingStackable(GearItem gearToAdd, float normalizedCondition, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return false;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "PickupTackle")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotPickUpCallback")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarters")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_CookWater), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StackableItem), Member = "GetStackCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiatePrefabForObjectPool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "OnAddedToBackPack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public GearItem AddItemToPlayerInventory(GearItem gi, bool trackItemLooted = true, bool enableNotificationFlag = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public float GetFoodCaloriesTotal()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
	public float GetTotalLiters(GearLiquidTypeEnum liquidType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetCapacityLiters(GearLiquidTypeEnum liquidType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public float AddLiquidToInventory(float litersToAdd, GearLiquidTypeEnum liquidType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public float DeductLiquidFromInventory(float literDeduction, GearLiquidTypeEnum liquidType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductWaterFromInventory")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	public float DeductLiquidFromInventory(float literDeduction, LiquidType liquidType)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	private float DeductWaterFromInventory(float literDeduction, LiquidQuality liquidQuality)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PowderItem), Member = "Add")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public GearItem AddPowderToInventory(float amount, PowderType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(CraftingOperation), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public float DeductPowderFromInventory(float deduction, PowderType type)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForPowder")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalPowderWeight")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTotalPowderWeight(PowderType type)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_add_all_gear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearspear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bow")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toughclothes")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem AddItemCONSOLE(string name, int count, float normalizedCondition = 1f)
	{
		return null;
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseMatches")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 2)]
	public void ConsumeUnitFromInventory(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	public bool UseSmashableItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(SprainPain), Member = "TakePainKillers")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 20)]
	private void TreatAffliction(FirstAidItem firstAidItem, AfflictionType afflictionType, AfflictionBodyArea location, int afflictionId)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CallerCount(Count = 2)]
	private void FirstAidConsumed(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void RemoveFirstAidItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "FirstAidConsumed")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CallsUnknownMethods(Count = 6)]
	public void OnFirstAidComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsTreatingAffliction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 1)]
	public void OnEatingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void OnDrinkWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveWater(WaterSupply ws, float removedLiters)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnPurifyWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OpenAndUseFoodInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	public void OnFoodOpeningComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseSmashableItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 5)]
	public void OnSmashComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetHeldLightIntensity()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public Color GetHeldLightColor()
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	private float CalculateWaterVolumeToDrink(float availableLiters)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	private bool UseWeaponInventoryItem(GearItem gi, bool suppressWeaponsErrorMessage = false)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	public void OpenAndUseFoodInventoryItem(GearItem gi, CanOpeningItem gearOpenedWith)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 6)]
	private bool CanUseFoodInventoryItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private bool UseFoodInventoryItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateWaterVolumeToDrink")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool DrinkFromWaterSupply(WaterSupply ws, float volumeAvailable)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(FireManager), Member = "InstantiateCampFire")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private bool UseFireStarterInventoryItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 3)]
	private bool UseFPSMeshItem(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 2)]
	private bool UseMatchesItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "GetMaxHPModifier")]
	[Calls(Type = typeof(FirstAidItem), Member = "DeductHealing")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	public bool TreatAfflictionWithFirstAid(FirstAidItem firstAidItem, Affliction afflictionSelected)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallsUnknownMethods(Count = 3)]
	private bool UseFirstAidItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool UseBedItem(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool PlaceSnare(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "OnPurifyWaterComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	private bool UseWaterPurificationItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	private bool UseSprayPaintCan(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool PlaceCookingPot(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateItemInHands()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 2)]
	private void UnequipItemInHandsInternal()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallsUnknownMethods(Count = 1)]
	public void OnExtinguishComplete()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(HandheldShortwaveItem), Member = "OnAddedToBackPack")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 2)]
	public void OnUnequipItemInHandInternalComplete()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 1)]
	public GearItem InstantiateItemInPlayerInventory(GearItem gearItem, int units = 1, float normalizedCondition = 1f, InventoryInstantiateFlags flags = InventoryInstantiateFlags.None)
	{
		return null;
	}

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadTypedAsset")]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(StackableItem), Member = "FindBestFitForUnits")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public GearItem InstantiateItemInPlayerInventory(AssetReferenceGearItem assetReference, int units = 1, float normalizedCondition = 1f, InventoryInstantiateFlags flags = InventoryInstantiateFlags.None)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public GearItem InstantiateItemAtPlayersFeet(GearItem gearItemPrefab, int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GearItem InstantiateItemAtPlayersFeet(AssetReferenceGearItem assetReference, int numUnits)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem InstantiateItemAtLocation(GearItem gearItemPrefab, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "InstantiateGearItem")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public GearItem InstantiateItemAtLocation(AssetReferenceGearItem assetReference, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldDestroyFoodAfterEating(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	private void MaybeUpdateEquipItem()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(CinematicManager), Member = "IsReady")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsReadyToEquip()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool HasSavedItemInHands()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnEatingComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[Calls(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[Calls(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void EatingComplete_Internal(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleEatingCompleteStackableFoodItem(GearItem foodItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckIfInsideBlockPlacement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool CheckIfCanDropGearItem(GearItem gi)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CheckIfCanDropGearItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckIfInsideBlockPlacement(Vector3 position, float radius)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void RequestLookAtTarget(LookAtTargetForTime lookAtTargetForTime)
	{
	}

	[CallerCount(Count = 0)]
	public void StopLookAtTarget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LookAtTargetForTime), Member = "Update")]
	private void UpdateLookAt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldShowSprayPaintCan()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool IsInDecalPlacementMode()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	[CallerCount(Count = 2)]
	public bool StartPlaceDecal(GearItem gearItem, ProjectileType decalShape, DecalColour decalColour, float placementDistance)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessRemoveObjectPressed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EraseDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessReloadAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallsUnknownMethods(Count = 1)]
	private void CleanupDecalToRemove()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdatePlaceDecal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleNowhereToHideEventSpecificBehaviour(DecalProjectorInstance decalInstance)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateOverlappingDecalInPlace()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void TintDecalDuringPlacement(DecalProjectorInstance decalInstance, MeshLocationCategory newCategory)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void TintPlacedDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Color GetColourForDecalColour(DecalColour decalColour)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void AttemptToPlaceDecal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	private void AttemptToRemoveDecalInPlace()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void StopSprayPaintAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CallsUnknownMethods(Count = 4)]
	private void OnCompletedDecalPlaceDown()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsUnknownMethods(Count = 3)]
	public void OnDecalDeserialized(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDecalRemoved(DecalProjectorInstance decal)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDecalPlacedownInterrupted()
	{
	}

	[CallerCount(Count = 0)]
	public void UpdatePlacementDecalReveal(float amount, bool isErasing)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 3)]
	private void ExitDecalPlacement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallsUnknownMethods(Count = 2)]
	private void CancelDecalPlacement(bool forceCancel = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsUnknownMethods(Count = 2)]
	public void SuspendDecalPlacement()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "CancelPlacement")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdatePlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	public void SetPlacementColors(Color validColor, Color invalidColor)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	public void ResetPlacementColors()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	private void UpdatePlacementDistance()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanPlaceCookingItemOnPoint(GearItem obj)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsOverCreatureOrRemains(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PlayerManager), Member = "IsOverCreatureOrRemains")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(PlayerManager), Member = "GetGearPlacePoint")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(FishingHolePlacementArea), Member = "GetActivePlacementSettings")]
	[Calls(Type = typeof(FishingHolePlacementArea), Member = "IsPointInside")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Physics), Member = "ComputePenetration")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 54)]
	[CallsUnknownMethods(Count = 58)]
	private MeshLocationCategory DoPositionCheck()
	{
		return default(MeshLocationCategory);
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	public bool CanPlaceMeshImmediately(GearItem gearItem)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateObjectToPlaceTransform(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private bool PlaceImmediately()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 2)]
	private void OnPlaceMeshAnimationEvent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	private void OnPlaceMeshAnimationComplete()
	{
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformAlternativeInteraction")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	private float GetDefaultPlacementDistance()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseBedItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	public bool StartPlaceMesh(GameObject objectToPlace, PlaceMeshFlags flags)
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformAlternativeInteraction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceRockCache")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceIceFishingHole")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "MaybeBeginPlacement")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(Campfire), Member = "OnEnteredPlaceMesh")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 19)]
	public bool StartPlaceMesh(GameObject objectToPlace, float placementDistance, PlaceMeshFlags flags)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigCarrySystem), Member = "ShowError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanPlaceCurrentPlaceable()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[CallsUnknownMethods(Count = 2)]
	public void AttemptToPlaceObject()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 5)]
	private void AttemptToPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void ProcessRemoveObjectPressed()
	{
	}

	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(LoadingZone), Member = "ActivateLoadingZone")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[CallsUnknownMethods(Count = 3)]
	public void StowOrDropPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[CalledBy(Type = typeof(GearItem), Member = "OnBeginUnwield")]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "UnwieldBegin")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(BigCarrySystem), Member = "Drop")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[CallsUnknownMethods(Count = 3)]
	public void CancelPlacementMode()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallerCount(Count = 1)]
	private void CancelPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreOriginalTint")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(LeanTo), Member = "Destroy")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(Campfire), Member = "OnExitedPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BigCarrySystem), Member = "CancelPlacement")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ExitMeshPlacement()
	{
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void CleanUpPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 7)]
	public bool ItemInHandsPlaceable()
	{
		return false;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshFireButtonString()
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshAltFireButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshRotateLeftButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshRotateRightButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshRotateMouseScrollButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshHolsterButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshReloadButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GameObject GetObjectToPlace()
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool IsInPlacementMode()
	{
		return false;
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool IsInMeshPlacementMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "InputControlRotate")]
	public void RotateCurrentPlaceable()
	{
	}

	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CalledBy(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[CallsUnknownMethods(Count = 2)]
	public bool ObjectToPlaceInInventory()
	{
		return false;
	}

	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRendererBeingPlaced(Renderer renderer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private bool VisPointVisible(Transform xform)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 26)]
	private bool VisPointsAllVisible(GameObject parent)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsPlacementPositionValid(GameObject go, bool alreadyPlaced)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "VisPointsAllVisible")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPositionOverGround")]
	[Calls(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToExitBlocked")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterExitBlocked")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PlayerManager), Member = "CampfireTooCloseToPlayer")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 24)]
	private MeshLocationCategory CalculateGhostedMeshValidPosition(Vector3 normal)
	{
		return default(MeshLocationCategory);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 12)]
	private void PrepareGhostedObject(bool usePlacementMeshVariant)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDropMeshAtPlayerFeet()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigCarrySystem), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireplaceInteraction")]
	[Calls(Type = typeof(IceFishingHole), Member = "OnBuild")]
	[Calls(Type = typeof(RockCache), Member = "OnBuild")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[CallsDeduplicatedMethods(Count = 47)]
	[CallsUnknownMethods(Count = 43)]
	private void PlaceMeshInWorld()
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetPlacementColors")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetPlacementColors")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetPropertyBlockForMeshLocationCategory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TintObject")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void InitializePropertyBlocks()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	private MaterialPropertyBlock GetPropertyBlockForMeshLocationCategory(MeshLocationCategory category)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void TintObject(GameObject go, MeshLocationCategory locationCategory)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreOriginalTint(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetBedPlacedMesh(GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetBedRolledMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetCampfirePlacedMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetSnarePlacedMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsKeroseneLamp()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsFlare()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsFlashlight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsTorch()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private static int GetLayerMaskForPlaceMeshRaycast()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CallerCount(Count = 3)]
	public static int GetLayerMaskForPlacementPosition()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool InvalidCampfireRequiredToBeWithinVolume(Vector3 worldPosition)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool CampfireTooCloseToPlayer(Vector3 campfirePos)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool SnowShelterTooCloseToPlayer(Vector3 shelterPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private bool SnowShelterNotOnGroundSnow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool SnowShelterTooLow()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool SnowShelterExitBlocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool LeanToTooCloseToPlayer(Vector3 shelterPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	private bool LeanToNotOnGroundSnow()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool LeanToExitBlocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private bool BedrollOnIce()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsPositionOverGround()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "get_localBounds")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 21)]
	private Collider ObjectToPlaceOverlapsWithObjectsThatBlockPlacement(Vector3 normal)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "BoxCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private Collider CheckBoundsAgainstObjectsThatBlockPlacement(Vector3 worldPos, Vector3 localExtents, Quaternion rotation)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectToPlaceOverlapsSnowShelter()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectToPlaceOverlapsLeanTo()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 17)]
	private bool ObjectToPlaceOverlapsWithInteractiveProp()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private bool ObjectToPlaceIsOnBrokenIce()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private GearPlacePoint GetGearPlacePoint(GameObject go, Vector3 searchPos)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void RestoreTransform()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "HideEffects")]
	[Calls(Type = typeof(FlareItem), Member = "HideEffects")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(TorchItem), Member = "HideEffects")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[CallsUnknownMethods(Count = 1)]
	private void HideLightFromMesh(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldDoVisPointsCheck()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AssignComponents(GameObject go, bool alreadyPlaced)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeRenderers()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Utils), Member = "GetLargestCollider")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void InitializeObjectToPlace(GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckForButtomPromptUpdate(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateInventoryOnPlacement()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool ItemInHandsThrowable()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_lit_item_in_hands")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnItemInHandStowed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 7)]
	public void DropLitItemInHand(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessMovingHeldItemToZone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DropLitItemToPlacementZone(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CallsUnknownMethods(Count = 1)]
	public void Drop(GameObject go, bool useGravity = true)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CallsUnknownMethods(Count = 1)]
	public void DropToPlacementZone(GameObject go, bool useGravity = true)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static void DropRigidBody(GameObject go, bool useGravity = true)
	{
	}

	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ProcessPickingUpPlacedItem")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ResetGravity")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetGravity(GameObject go, bool useGravity)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[CalledBy(Type = typeof(StoneItem), Member = "Throw")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Throw(GearItem gi, PlayerAnimation.OnAnimationEvent throwCompleteCallback = null)
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass795_0), Member = "<Throw>b__0")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	private void ReleaseThrownObject()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeAdjustShotPositionForNearShot")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 20)]
	private GameObject ReleaseFromHands(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private GearItem InstantiateCopyOfThrownObject(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeDuplicateItemBeforeDrop(DropLitItemsOptions options)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static Vector3 MaybeAdjustShotPositionForNearShot(Vector3 emissionPos, Vector3 firePos, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private static Vector3 AdjustNearShotFirePosition(RaycastHit hit, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static float GetNearDistanceShot(Vector3 weaponSpaceEmissionPosition)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 5)]
	public PlayerManager()
	{
	}
}
