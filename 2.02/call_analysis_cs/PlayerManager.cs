using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
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
		[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UpdateLookAt")]
		[Calls(Type = typeof(LookAtTargetForTime), Member = "TweenValue")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LookAtTargetForTime), Member = "TweenValue")]
		[CallsDeduplicatedMethods(Count = 4)]
		public void Update()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CalledBy(Type = typeof(LookAtTargetForTime), Member = "Update")]
		[CalledBy(Type = typeof(LookAtTargetForTime), Member = "Update")]
		[CallsUnknownMethods(Count = 3)]
		private float TweenValue(float factor, UITweener.Method tweenMethod, bool steeperCurves)
		{
			return default(float);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		private float BounceLogic(float val)
		{
			return default(float);
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

	private sealed class _003C_003Ec__DisplayClass604_0
	{
		public PlayerManager _003C_003E4__this;

		public PlayerAnimation.OnAnimationEvent throwCompleteCallback;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass604_0()
		{
		}

		[Calls(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	private float m_PumpkinPieBuffHoursRemaining;

	private float m_PumpkinPieBuffHoursDuration;

	private float m_ConditionPerHourHoursRemaining;

	private float m_ConditionPerHourHoursDuration;

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

	public float m_WarmthBonusFromClothing;

	public float m_WindproofBonusFromClothing;

	public static float m_ForcedMobilityReduction;

	private const int MAX_CLOTHING_REGIONS = 8;

	private const int MAX_CLOTHING_LAYERS = 4;

	private GearItem[,] m_Clothing;

	private uint m_LastUpperBodySoundSwitch;

	private uint m_LastLowerBodySoundSwitch;

	private List<GearItem> m_GearItemList;

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

	private float m_LabelAlpha_Fast;

	private float m_LabelAlpha_MediumFast;

	private float m_LabelAlpha_Medium;

	private float m_LabelAlpha_Slow;

	private float m_LabelAlpha_Slowest;

	private float m_FadeInAlphaPerSecond;

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

	public GameObject m_InteractiveObjectUnderCrosshair;

	public GameObject m_InteractiveObjectNearCrosshair;

	public LoadingZone m_LoadingZone;

	public Vector3 m_LocationOfLastInteractHit;

	public GameObject m_UneditedObjectUnderCrosshair;

	public Harvestable m_HarvestableInProgress;

	public Container m_ContainerBeingSearched;

	public OpenClose m_OpenCloseInProgress;

	public LoadScene m_LoadSceneInProgress;

	public Lock m_ForceLockInProgress;

	public VehicleDoor m_VehicleDoorInProgress;

	public IceFishingHole m_IceFishingInProgress;

	public RadioTower m_RadioTowerInProgress;

	public RockCache m_RockCacheInProgress;

	private bool m_EquipLastItemInHandsAfterInteraction;

	private bool m_RaiseItemInHandsAfterInteraction;

	public bool m_ItemInHandsRestorePending;

	private bool m_PickupIsImmediate;

	public GearItem m_PickupGearItem;

	private const int MAX_SPHERECAST_HITS = 16;

	private RaycastHit[] m_SphereCastHits;

	private bool m_DoInteractionEndNextFrame;

	private bool m_ShowCustomHoverText;

	private List<MeshCollider> m_MeshColliders;

	private List<Transform> m_Transforms;

	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	public float m_FallbackStackConditionDifferenceConstaint;

	public GearItem m_LastUnequippedItem;

	public bool m_UsedItemFromFirstAidPanel;

	private GearItem m_ItemInHandsInternal;

	private string m_TreatmentSuccessAudio;

	private string m_TreatmentFailedAudio;

	private string m_GunpowderPrefabName;

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

	private CarryableBody m_ObjectToPlaceBody;

	private RadialObjectSpawner m_ObjectToPlaceRadialSpawner;

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

	public bool m_StartGearApplied;

	public Vector3 m_SaveGamePosition;

	public Quaternion m_SaveGameRotation;

	public IndoorSpaceTrigger m_IndoorSpaceTrigger;

	public List<StealthZoneTrigger> m_StealthZoneTriggers;

	public bool m_DoTeleportAfterSceneLoad;

	public bool m_InRunMode;

	public bool m_Ghost;

	public bool m_God;

	public VoicePersona m_VoicePersona;

	public StartGear m_StartGear;

	public AiTarget m_AiTarget;

	public float m_CaloriesHarvestedToday;

	public bool m_SceneTransitionStarted;

	public GameRegion m_StartingRegion;

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

	public List<ActionsToBlock> m_ActionsToBlockInDarkness;

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

	private FootwearType m_LastPlayerFootwearType;

	private bool m_LastPlayererFootwearTypeValid;

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

	private bool m_NearPlaneOverridden;

	private int m_StickPlayerToGroundDelay;

	private SceneLoadSource m_SceneLoadSource;

	private List<IndoorSpaceTrigger> m_IndoorSpaceTriggers;

	private static PlayerManagerSaveDataProxy m_PlayerManagerSaveDataProxy;

	private PlayerControlMode m_RestoreControlMode;

	private bool m_HasControlModeToRestore;

	public GearItem m_ItemInHands
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
		[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
		[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
		[Calls(Type = typeof(GearItem), Member = "OnWield")]
		[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GearItem), Member = "OnUnwieldComplete")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyPumpkinPieBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyFreezingBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyFatigueBuff(float instantPercentDecrease, float rateScale, float durationHours, string causeLocID, float durationMaxHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetFatigueBuffCauseLocID()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ApplyConditionRestBuff(float percentBonus, float restHours, float durationMaxHours)
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
	[CallsUnknownMethods(Count = 3)]
	public bool HasSpecialCarryingCapacityGear(string gearName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveCarryingCapacityBuff()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateCarryingBuff()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornWolfIntimidationClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	public void UpdateBuffDurations(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[CallsUnknownMethods(Count = 4)]
	public void UpdateConditonBuffDuration(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetFreezingRateScaleBuff")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "HasBuff")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	public bool IsPumpkinPieBuffActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	public float GetFreezingRateScaleBuff()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetFatigueRateScaleBuff()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetConditionPercentBonus()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWolfFleeIncreasePercentagePointsBuff()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetWolfDecreaseAttackChancePercentagePointsBuff()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	public bool FreezingBuffActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool FatigueBuffActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLowThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberMedThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityWhenExhaustedKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Encumber), Member = "IsCapacityBuffed")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberHighThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	public float GetCarryCapacityKGBuff()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetConditionPerHourBonus()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void RemoveBuffsCONSOLE()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetFatigueBuffTimeRemainingHours()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetFatigueBuffTimeRemainingHours()
	{
	}

	[CallerCount(Count = 0)]
	public float GetFatigueBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetFreezingBuffTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetFreezingBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetConditionRestBuffTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetConditionRestBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetPumpkinPieBuffTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetPumpkinPieBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetConditionPerHourTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetConditionPerHourRemainingNormalized()
	{
		return default(float);
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateClimbingBuff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffSprainOddsModifier()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffStaminaPerSecondModifier()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetClimbingBuffWeakIceTimeSecondsModifier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsWearingPerfectClothesInAllSlots")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	public static int GetNumLayersForClothingRegion(ClothingRegion clothingRegion)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStage")]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CallsUnknownMethods(Count = 2)]
	public float GetWetnessIncreasePerHour()
	{
		return default(float);
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	public void UpdateClothingWetness()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UpdateBonusValuesFromWornClothing()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToTopMostLayer")]
	[CallerCount(Count = 0)]
	public void ApplyPercentDamageToWornClothingRegion(ClothingRegion region, float normalizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyDamageToTopMostLayer")]
	public void ApplyDamageToWornClothingRegion(ClothingRegion region, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	public bool GetWarnClothingCanBeDamaged()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 8)]
	public void ApplyPercentDamageToWornClothing(float normalizedDamage)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	public void ApplyDamageToWornClothing(float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public float GetWornClothingToughness()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[CalledBy(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void TakeOffClothingItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CalledBy(Type = typeof(ClothingItem), Member = "PickedUp")]
	[CalledBy(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	public void PutOnClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	public void MaybeUnlockResoluteOutfitterAchievement()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsWearingClothingItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public bool IsWearingClothingName(string itemName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool UseClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasFreeSlotForClothingItem(ClothingItem ci)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "HasFreeSlotForClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ClothingItem), Member = "PickedUp")]
	private ClothingLayer GetEmptyLayerForRegion(ClothingRegion region, ClothingLayer minLayer, ClothingLayer maxLayer)
	{
		return default(ClothingLayer);
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_clothing")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public void OutputWornClothing()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public GearItem GetWornWolfIntimidationClothing()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 10)]
	public GearItem GetWornCarryingCapacityBuffClothing()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void GetAllWornCarryingCapacityBuffClothing(List<GearItem> carryingCapacityBuffs)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[CallsUnknownMethods(Count = 13)]
	public void GetAllSpecialCarryingCapacityBuffItems(List<GearItem> carryingCapacityBuffs)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClimbingBuff")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public GearItem GetClimbingBuffClothing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	public float GetClothingSprintReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumWetClothes()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectDefaultSlot")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdateSlotInfo")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	public GearItem GetClothingInSlot(ClothingRegion region, ClothingLayer layer)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public FootwearType GetFootwearType()
	{
		return default(FootwearType);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CalledBy(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public CramponsState GetCramponsState()
	{
		return default(CramponsState);
	}

	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public float GetDamageReductionFromExteriorClothing()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetDamageReductionFromExteriorLegFeet()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CallsUnknownMethods(Count = 5)]
	public bool IsWearingPerfectClothesInAllSlots()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetWornClothingRegionToughness(int regionIndex)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothingRegion")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ApplyPercentDamageToTopMostLayer(int regionIndex, float normalizedDamage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothingRegion")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(Burns), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(Burns), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	private void ApplyDamageToTopMostLayer(int regionIndex, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetSwitchValueOfOuterLayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForChangeLayer")]
	public GearItem GetTopLayerGear(ClothingRegion region)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void GetAllClothingInRegion(ClothingRegion region, List<GearItem> gearItems)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 7)]
	public bool RegionHasFullFrozenInnerLayer(ClothingRegion region)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool RegionHasFullWetInnerLayer(ClothingRegion region)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 7)]
	public bool RegionHasNonFrozenClothing(ClothingRegion region)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetSoundSwitch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetSwitchValueOfOuterLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetSoundSwitch")]
	private void MaybeSetSoundSwitch(ClothingRegion region)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void SetSoundSwitch(uint switchGroup, uint switchValue)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[CallsUnknownMethods(Count = 3)]
	private uint GetSwitchValueOfOuterLayer(ClothingRegion region)
	{
		return default(uint);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LogAiDamage(GameObject damageReceiver, float condition, float damageGiven, float damageTaken, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LogAiFleeFromItem(BaseAi ai, GearItem item, bool wasHit, float fleeChance, float roll, float distance, float fleeDistance)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool RangedApproximate(float a, float b, float range)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LogPlayerDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[CallerCount(Count = 0)]
	public void EnableDebugPosition(bool enabled, float frequencyInSeconds)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsUnknownMethods(Count = 21)]
	private void LogPlayerPosition()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void MaybeFlushPlayerDamage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void FlushPlayerDamage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void EnableDebugLookAt(bool enabled, bool useHighlight)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetDebugLookAtDisplayName()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void UpdateDebugLookAtObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void AssignDebugLookAtMaterialProperties(bool enabled, Renderer[] renderers)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallsUnknownMethods(Count = 14)]
	public void InitInspectGearMode()
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

	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetCallback(CallbackDelegate callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SaveGearItemTransformInInspectSpace(Transform t)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "OnCollectibleNoteReadingClickBack")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RevealOnPolaroidDiscovery(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	public void MaybeRevealPolaroidDiscoveryOnClose()
	{
	}

	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CallsUnknownMethods(Count = 62)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "CancelSearch")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void ExitInspectGearMode(bool hardExit)
	{
	}

	[CalledBy(Type = typeof(Container), Member = "RevealGearItem")]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CallsUnknownMethods(Count = 83)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeWithCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromFishingHole")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromHarvestable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessTakeBearEarRedux")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void EnterInspectGearMode(GearItem gear, Container c, IceFishingHole hole, Harvestable h, CookingPotItem pot)
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "DoSpecialActionFromInspectMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[CallsUnknownMethods(Count = 82)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "OnCollectibleNoteReadingClickBack")]
	[Calls(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldContainerDisallowEquipAction")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "FadeInLabels")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateInspectGear()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInspectModeActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GearItem GearItemBeingInspected()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 26)]
	public void RestoreTransformFromLastInspection(GearItem gi)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void MaybeEnableInspectModeMesh(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static void MaybeDisableInspectModeMesh(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RestoreOriginalTransform(Transform t)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 3)]
	private void SetGearTransformForInspection()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	private void UpdateGearTransformForInspection()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 31)]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveInfoArea")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 78)]
	private void SetActiveAllLabels(bool active)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "NoteToggleReadMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void SetActiveInfoArea(bool showStandard)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveInfoArea")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void NoteToggleReadMode()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	private void InitLabelsForGear()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeReplaceGearItemForLabels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 45)]
	private void FadeInLabels()
	{
	}

	[Calls(Type = typeof(Inspect), Member = "GetUrgency")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybePlayInspectModeVoiceOver()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void PlayPutBackAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PlayStowAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 3)]
	private void AttemptEquipGearItem()
	{
	}

	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	private void TransferGearFromInspectToContainer()
	{
	}

	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void TransferGearFromContainerToInventory()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	private bool CanPickup()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldContainerDisallowEquipAction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	private void RefreshGamepadPrompts()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Toggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public bool IsCancelableActionInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsClickHoldActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LoadScene), Member = "Cancel")]
	[CallsUnknownMethods(Count = 1)]
	public void CancelLoadScene()
	{
	}

	[CallerCount(Count = 0)]
	public void ClearRestoreItemInHandsAfterInteraction()
	{
	}

	[CallerCount(Count = 0)]
	public bool WillRestoreItemInHandsAfterInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Stow")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_stow_item")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 8)]
	public bool StowItem()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Stow")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	public void ItemInHandsDuringInteractionStart()
	{
	}

	[CallerCount(Count = 0)]
	public void ItemInHandsDuringInteractionEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallsUnknownMethods(Count = 2)]
	private void DoDelayedInteractionEnd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	private bool ShouldStowOrUnstowForInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoDelayedInteractionEnd")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unstow")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ItemInHandsDuringInteractionEndInternal()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndAddToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	public bool ProcessPickupItemInteraction(GearItem item, bool forceEquip, bool skipAudio)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLightsource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ProcessInspectablePickupItem(GearItem pickupItem)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ProcessPickupWithNoInspectScreen(GearItem pickupItem, bool immediate)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
	public void ProcessPickupWithNoInspectScreenDropCurrent(PlayerAnimation.OnAnimationEvent nextEvent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	private void OnUnequipItemInHandInternalCompleteResetWeapon()
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void ProcessPickupWithNoInspectScreenEquip()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void OnProcessPickupWinNoInspectEquipComplete()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetPickup()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(RockCache), Member = "OnOpen")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Container), Member = "ForceLock")]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	[Calls(Type = typeof(Container), Member = "StartSafeCrackingInterface")]
	[Calls(Type = typeof(Container), Member = "IsLockedOrSafeIsUncracked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "InstantiateContents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "IsLocked")]
	public bool ProcessContainerInteraction(Container c)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(LoadScene), Member = "StartInteract")]
	[Calls(Type = typeof(LoadScene), Member = "ForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	public bool ProcessLoadSceneInteraction(LoadScene ls)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void ProcessTakeBearEarRedux(BearHuntAiRedux bhairedux)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Action_ShowPanel), Member = "MaybeShowBodyHarvest")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoBodyHarvest")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybePerformCompletionAction")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessTakeBearEarRedux")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	public bool ProcessBodyHarvestInteraction(BodyHarvest bh, bool playBookEndAnim)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Panel_Rest), Member = "StartRest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	public bool ProcessBedInteraction(Bed b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireInteractCallback")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetCampFireInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Campfire), Member = "CanFeedFire")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "SetFireSourceToLightTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public bool ProcessCampfireInteraction(Campfire cf)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "FireInteractCallback")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerAttemptToFeedFire")]
	[Calls(Type = typeof(Panel_FireStart), Member = "EnableAfterDelay")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(WoodStove), Member = "FireBurningInside")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(WoodStove), Member = "Open")]
	[Calls(Type = typeof(Panel_TorchLight), Member = "SetFireSourceToLightTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ProcessWoodStoveInteraction(WoodStove ws)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "OnClick")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool ProcessIceFishingHoleInteraction(IceFishingHole ifh)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Panel_PickWater), Member = "SetWaterSourceForTaking")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool ProcessWaterSourceInteraction(WaterSource source)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(OpenClose), Member = "StartInteract")]
	[Calls(Type = typeof(OpenClose), Member = "ForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "CanInteract")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ProcessOpenCloseInteraction(OpenClose oc)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AudioToggle), Member = "TurnOn")]
	public bool ProcessAudioToggleInteraction(AudioToggle at)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OpenClose), Member = "CanInteract")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CallsUnknownMethods(Count = 7)]
	public bool ShouldShowClickHoldBackpiece()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "CanInteract")]
	public HoverTextState GetInteractiveObjectDisplayTextState(GameObject interactiveObject)
	{
		return default(HoverTextState);
	}

	[Calls(Type = typeof(Chair), Member = "GetHoverText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "GetHoverText")]
	[Calls(Type = typeof(Forge), Member = "GetHoverText")]
	[Calls(Type = typeof(Harvestable), Member = "GetHoverText")]
	[Calls(Type = typeof(VehicleDoor), Member = "GetHoverText")]
	[Calls(Type = typeof(IceFishingHole), Member = "GetHoverText")]
	[Calls(Type = typeof(OpenClose), Member = "GetHoverText")]
	[Calls(Type = typeof(OpenClose), Member = "CanInteract")]
	[Calls(Type = typeof(WoodStove), Member = "GetHoverText")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(LoadScene), Member = "GetHoverText")]
	[Calls(Type = typeof(SnowShelter), Member = "GetHoverText")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "ShowHoverButtonPrompts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "GetHoverText")]
	[Calls(Type = typeof(Cairn), Member = "GetHoverText")]
	[Calls(Type = typeof(CookingSlot), Member = "CanBeInteractedWith")]
	[Calls(Type = typeof(TrackableCache), Member = "GetHoverText")]
	[Calls(Type = typeof(MillingMachine), Member = "GetHoverText")]
	[Calls(Type = typeof(Elevator), Member = "GetHoverText")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "GetHoverText")]
	[Calls(Type = typeof(CellToilet), Member = "GetHoverText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "GetHoverText")]
	[Calls(Type = typeof(LeanTo), Member = "GetHoverText")]
	[Calls(Type = typeof(Campfire), Member = "GetHoverText")]
	[Calls(Type = typeof(WolfDen), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 105)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(DummyInteractiveObject), Member = "GetInteractionText")]
	[Calls(Type = typeof(DummyInteractiveObject), Member = "GetInteractionText")]
	[Calls(Type = typeof(InteractionOverride), Member = "IsActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(InteractionOverride), Member = "GetInteractionText")]
	[Calls(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InteractionOverride), Member = "GetInteractionText")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "GetHoverText")]
	[Calls(Type = typeof(NPC), Member = "GetHoverText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarryableBody), Member = "GetHoverText")]
	[Calls(Type = typeof(CarryableBody), Member = "CanInteract")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(BodyHarvest), Member = "GetHoverText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "GetHoverText")]
	[Calls(Type = typeof(Container), Member = "GetInteractiveDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(SnareItem), Member = "GetHoverText")]
	public string GetInteractiveObjectDisplayText(GameObject interactiveObject)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void EnableHoverTextForButtonPrompts(bool enable)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private GameObject GetInteractiveObjectNearCrosshairs(float maxRange)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HastInteractiveObjectUnderCrossHair()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "RespectContrainsts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "RespectContrainsts")]
	private GameObject GetInteractiveObjectWithConstraints(GameObject interactiveObject)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private void FindInteractiveObject(RaycastHit hit, ref GearItem gi, ref GameObject interactiveObj)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 95)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GameObject GetInteractiveObjectUnderCrosshairs(float maxRange)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	public void InteractiveObjectsProcess()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void InteractiveObjectsProcessAltFire()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	private void MaybeStartPlaceMesh(GearItem gi)
	{
	}

	[Calls(Type = typeof(RadioTower), Member = "ProcessInteraction")]
	[Calls(Type = typeof(SwitchBox), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "ProcessInteraction")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "ProcessInteraction")]
	[Calls(Type = typeof(RopeClimbPoint), Member = "ProcessInteraction")]
	[Calls(Type = typeof(AmmoWorkBench), Member = "ProcessInteraction")]
	[Calls(Type = typeof(VehicleDoor), Member = "StartInteract")]
	[Calls(Type = typeof(Forge), Member = "ProcessInteraction")]
	[Calls(Type = typeof(BreakDown), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Chair), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessIceFishingHoleInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessOpenCloseInteraction")]
	[Calls(Type = typeof(OpenClose), Member = "CanInteract")]
	[Calls(Type = typeof(WorkBench), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessAudioToggleInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelter), Member = "ProcessInteraction")]
	[Calls(Type = typeof(CookingSlot), Member = "CanBeInteractedWith")]
	[Calls(Type = typeof(Keypad), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessWaterSourceInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(LoadingZone), Member = "StartInteract")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RopeExitPoint), Member = "ProcessInteraction")]
	[Calls(Type = typeof(RockCache), Member = "StartInteraction")]
	[Calls(Type = typeof(CellToilet), Member = "ProcessInteraction")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "ProcessInteraction")]
	[Calls(Type = typeof(LeanTo), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "ProcessInteraction")]
	[Calls(Type = typeof(MillingMachine), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(NPC), Member = "ProcessInteraction")]
	[Calls(Type = typeof(TrackableCache), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Cairn), Member = "ProcessInteraction")]
	[Calls(Type = typeof(WildlifeItem), Member = "ProcessInteraction")]
	[Calls(Type = typeof(WolfDen), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessLoadSceneInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessContainerInteraction")]
	[Calls(Type = typeof(InteractionOverride), Member = "IsActive")]
	[Calls(Type = typeof(PlayPlayerTimelineOnInteract), Member = "ProcessInteraction")]
	[Calls(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Phone), Member = "ProcessInteraction")]
	[Calls(Type = typeof(SendMissionEventObject), Member = "ProcessInteraction")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(BodyCarry), Member = "CanInteractWithObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 101)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InteractionOverride), Member = "ProcessInteraction")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessInteraction")]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(CarryableBody), Member = "CanInteract")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[Calls(Type = typeof(Harvestable), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(BodyCarry), Member = "ProcessInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessBedInteraction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Bed), Member = "IsOccupied")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "ProcessInteraction")]
	[Calls(Type = typeof(BehaviourTreeInteraction), Member = "ProcessInteraction")]
	[Calls(Type = typeof(CookingPotItem), Member = "ShouldProcessInteractionInternal")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	public bool InteractiveObjectsProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void PlayerOpenContainer(Container c)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "SetFireContainer")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "EnableAfterDelay")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessCampfireInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public void PlayerAttemptToFeedFire(GameObject go, float delaySeconds)
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "EnableAfterDelay")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireContainer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void PlayerAttemptToStartFire(GameObject go, float delaySeconds)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CallsUnknownMethods(Count = 1)]
	public bool ItemCanEquipInHands(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public float ComputeModifiedPickupRange(float range)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerHoldingTorchThatCanBeLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ObjectUnderCrosshairCanLightTorch()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ItemShouldEquipOnPickup(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessWoodStoveInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectUnderCrosshairCanLightTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectUnderCrosshairCanLightTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessCampfireInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DidUseFireToLightHeldTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public bool PlayerHoldingTorchThatCanBeLit()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HastInteractiveObjectUnderCrossHair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldSuppressCrosshairs()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseMatchesItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 58)]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	public void EquipItem(GearItem gi, bool fromDeserialize)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	public void OnEquipItemBegin()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_PlayTimeline.Action_SetCinematicProperties), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRestoreSaveItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayTimeline.Action_SetCinematicProperties), Member = "OnExecute")]
	[CalledBy(Type = typeof(HeldItemRestrictionTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RestrictHeldItems")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(HeldItemRestriction), Member = "IsRestricted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	public bool IsHeldItemRestricted(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void RestrictHeldItems(HeldItemRestriction restriction)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool CanHolsterItemInHand()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	public bool CanHolsterItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[CallsUnknownMethods(Count = 2)]
	public void UnequipItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	public void MaybeRestoreSaveItemInHands()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unequip_immediate")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(Action_PlayTimeline.Action_SetCinematicProperties), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	public void UnequipImmediate(bool saveLastItem)
	{
	}

	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PauseLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	public void AutoUnequipItemInHandsBeforeInteraction(bool pauseFlare = true)
	{
	}

	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "ResumeLight")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void AutoEquipItemInHandsAfterInteraction()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CallerCount(Count = 2)]
	public static void TurnLightOffImmediate(bool pauseFlare, GearItem gi)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	private void PauseLight(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResumeLight(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	public void UnequipItemInHandsSkipAnimation()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(TorchItem), Member = "StopIgniteLoop")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "StopIgniteAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlareItem), Member = "StopLoopingAudio")]
	public void StopAudioForEquippedItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	public void CancelItemInHandsAction(bool cancelByUser)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	public void UnequipItemInHandsForPlacement()
	{
	}

	[CallerCount(Count = 0)]
	public void ClearLastUnequippedItem()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[Calls(Type = typeof(PlayerManager), Member = "UseBedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 28)]
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool UseInventoryItem(GearItem gi, float volumeAvailable = -1f, bool suppressWeaponsErrorMessage = false)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryCraftInProgress")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetClosestMatchStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem AddToExistingStackable(string itemName, float normalizedCondition, int numUnits, GearItem gearToAdd = null)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public GearItem AddToExistingStackable(GearItem gearToAdd, int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotPickUpCallback")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	public GearItem AddItemToPlayerInventory(GearItem gi, bool trackItemLooted = true, bool enableNotificationFlag = false)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallerCount(Count = 0)]
	public GearItem InstantiateItemInPlayerInventory(string itemName, bool enableNotificationFlag = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem InstantiateItemInPlayerInventoryWithCondition(string itemName, int units, float condition, bool enableNotificationFlag = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrustManager), Member = "MaybeHandleItemTheft")]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public GearItem InstantiateItemInPlayerInventory(GearItem gi, int numUnits, bool enableNotificationFlag = false)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	[CallerCount(Count = 47)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GearItem InstantiateItemInPlayerInventory(string itemName, int numUnits, bool enableNotificationFlag = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryInternal")]
	public GearItem InstantiateItemInPlayerInventoryCraftInProgress(string itemName, bool enableNotificationFlag = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	public GearItem InstantiateItemAtPlayersFeet(string itemName, int numUnits)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	public GearItem InstantiateItemAtPlayersFeet(GameObject prefab, int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem InstatiateItemAtLocation(string itemName, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	public GearItem InstatiateItemAtLocation(GameObject prefab, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	public float GetFoodCaloriesTotal()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "CanCraftItem")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "RefreshCraftingRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRefuel")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	public float GetTotalLiters(GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public float GetCapacityLiters(GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	public float AddLiquidToInventory(float litersToAdd, GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	public float DeductLiquidFromInventory(float literDeduction, GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PowderItem), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PowderItem), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	public void AddPowderToInventory(float amount, GearPowderType type)
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float DeductPowderFromInventory(float deduction, GearPowderType type)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	public float GetTotalPowderWeight(GearPowderType type)
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_add_all_gear")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem AddItemCONSOLE(string name, int count)
	{
		return null;
	}

	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseMatches")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	public void ConsumeUnitFromInventory(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	public bool UseSmashableItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[CallsUnknownMethods(Count = 55)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(SprainPain), Member = "TakePainKillers")]
	[Calls(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	private void TreatAffliction(FirstAidItem firstAidItem, AfflictionType afflictionType, AfflictionBodyArea location, int afflictionId)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	private void FirstAidConsumed(GearItem gi)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RemoveFirstAidItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "FirstAidConsumed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "FirstAidConsumed")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	public void OnFirstAidComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool IsTreatingAffliction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnEatingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(PlayerManager), Member = "RemoveWater")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnDrinkWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "UseWater")]
	public void RemoveWater(WaterSupply ws, float removedLiters)
	{
	}

	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PurifyWater), Member = "Use")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnPurifyWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnFoodOpeningComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	public void OnSmashComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetHeldLightIntensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public Color GetHeldLightColor()
	{
		return default(Color);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CallsUnknownMethods(Count = 8)]
	private float CalculateWaterVolumeToDrink(float availableLiters)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool UseWeaponInventoryItem(GearItem gi, bool suppressWeaponsErrorMessage = false)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void OpenAndUseFoodInventoryItem(GearItem gi, CanOpeningItem gearOpenedWith)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private bool CanUseFoodInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private bool UseFoodInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateWaterVolumeToDrink")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool DrinkFromWaterSupply(WaterSupply ws, float volumeAvailable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private bool UseFireStarterInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	private bool UseFPSMeshItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	private bool UseMatchesItem(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FirstAidItem), Member = "DeductHealing")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	public bool TreatAfflictionWithFirstAid(FirstAidItem firstAidItem, Affliction afflictionSelected)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private bool UseFirstAidItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	private bool UseBedItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 9)]
	private bool PlaceSnare(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	private bool UseWaterPurificationItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 6)]
	private bool UseSprayPaintCan(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	private bool PlaceCookingPot(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSMeshGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 89)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSMeshGameObject")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSMeshGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	private void UpdateItemInHands()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[CallsUnknownMethods(Count = 8)]
	private void UnequipItemInHandsInternal()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void OnExtinguishComplete()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnUnequipItemInHandInternalComplete()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryCraftInProgress")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventoryWithCondition")]
	private GearItem InstantiateItemInPlayerInventoryInternal(string itemName, int numUnits, bool craftInProgress, float condition, bool enableNotificationFlag = false)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldDestroyFoodAfterEating(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateEquipItem()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(CinematicManager), Member = "IsReady")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	private bool IsReadyToEquip()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool HasSavedItemInHands()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnEatingComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[Calls(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[CallsUnknownMethods(Count = 80)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	private void EatingComplete_Internal(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstatiateItemAtLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void HandleEatingCompleteStackableFoodItem(GearItem foodItem)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckIfInsideBlockPlacement")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[CallsUnknownMethods(Count = 7)]
	public bool CheckIfCanDropGearItem()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckIfCanDropGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	private bool CheckIfInsideBlockPlacement(Vector3 position, float radius)
	{
		return default(bool);
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CallsUnknownMethods(Count = 4)]
	public bool ShouldShowSprayPaintCan()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	public bool IsInDecalPlacementMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "TintDecalDuringPlacement")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddSprayPaintDecal")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public bool StartPlaceDecal(GearItem gearItem, ProjectileType decalShape, DecalColour decalColour, float placementDistance)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[CallsUnknownMethods(Count = 13)]
	public void EraseDecal(DecalProjectorInstance decalInstance)
	{
	}

	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ProcessReloadAction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallsUnknownMethods(Count = 4)]
	private void CleanupDecalToRemove()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "TintDecalDuringPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	private void UpdatePlaceDecal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallsUnknownMethods(Count = 3)]
	private void HandleNowhereToHideEventSpecificBehaviour(DecalProjectorInstance decalInstance)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecalProjectorInstance), Member = "GetBounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	private void UpdateOverlappingDecalInPlace()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsUnknownMethods(Count = 1)]
	private void TintDecalDuringPlacement(DecalProjectorInstance decalInstance, MeshLocationCategory newCategory)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void TintPlacedDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private Color GetColourForDecalColour(DecalColour decalColour)
	{
		return default(Color);
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SprayPaintCan), Member = "ReduceHealthForPaint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprayPaintCan), Member = "ReduceHealthForPaint")]
	private void AttemptToPlaceDecal()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessRemoveObjectPressed")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	private void AttemptToRemoveDecalInPlace()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 4)]
	public void StopSprayPaintAudio()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	private void OnCompletedDecalPlaceDown()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnDecalDeserialized(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CallsUnknownMethods(Count = 3)]
	public void OnDecalRemoved(DecalProjectorInstance decal)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDecalPlacedownInterrupted()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[CalledBy(Type = typeof(PlayableBehaviourUpdatePlacementDecalReveal), Member = "ProcessFrame")]
	public void UpdatePlacementDecalReveal(float amount, bool isErasing)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void ExitDecalPlacement()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDecalPlacedownInterrupted")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void CancelDecalPlacement(bool forceCancel = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsUnknownMethods(Count = 2)]
	public void SuspendDecalPlacement()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BodyCarry), Member = "CancelPlacement")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	public void UpdatePlaceMesh()
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	public void SetPlacementColors(Color validColor, Color invalidColor)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	[CallerCount(Count = 0)]
	public void ResetPlacementColors()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	private void UpdatePlacementDistance()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanPlaceCookingItemOnPoint(GearItem obj)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private bool IsOverCreatureOrRemains(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 140)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_rotation_Injected")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_rotation_Injected")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "set_rotation_Injected")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Physics), Member = "ComputePenetration")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(Vector3), Member = "op_Division")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Dot")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsOverCreatureOrRemains")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PlayerManager), Member = "GetGearPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "IsOverCreatureOrRemains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_rotation_Injected")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position_Injected")]
	private MeshLocationCategory DoPositionCheck()
	{
		return default(MeshLocationCategory);
	}

	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	public bool CanPlaceMeshImmediately(GearItem gearItem)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateObjectToPlaceTransform(Vector3 position, Quaternion rotation)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private bool PlaceImmediately()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	private void OnPlaceMeshAnimationEvent()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 4)]
	private void OnPlaceMeshAnimationComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeStartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	private float GetDefaultPlacementDistance()
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseBedItem")]
	public bool StartPlaceMesh(GameObject objectToPlace, PlaceMeshFlags flags)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceRockCache")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeStartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybePlace")]
	[CallsUnknownMethods(Count = 47)]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Campfire), Member = "OnEnteredPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool StartPlaceMesh(GameObject objectToPlace, float placementDistance, PlaceMeshFlags flags)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanPlaceCurrentPlaceable()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	public void AttemptToPlaceObject()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AttemptToPlaceMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	public void ProcessRemoveObjectPressed()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LoadingZone), Member = "Activate")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	public void StowOrDropPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "OnBeginUnwield")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "UnwieldBegin")]
	public void CancelPlacementMode()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void CancelPlaceMesh()
	{
	}

	[Calls(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(Campfire), Member = "OnExitedPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(BodyCarry), Member = "CancelPlacement")]
	[Calls(Type = typeof(LeanTo), Member = "Destroy")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreOriginalTint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ExitMeshPlacement()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	public void CleanUpPlaceMesh()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	public bool ItemInHandsPlaceable()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshFireButtonString()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	public string GetPlaceMeshAltFireButtonString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string GetPlaceMeshRotateLeftButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshRotateRightButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshRotateMouseScrollButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetPlaceMeshHolsterButtonString()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public string GetPlaceMeshReloadButtonString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public GameObject GetObjectToPlace()
	{
		return null;
	}

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	public bool IsInPlacementMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsInMeshPlacementMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "InputControlRotate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	public void RotateCurrentPlaceable()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[CalledBy(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	public bool ObjectToPlaceInInventory()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsRendererBeingPlaced(Renderer renderer)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlaceMeshRaycast")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "VisPointsAllVisible")]
	[CallsUnknownMethods(Count = 13)]
	private bool VisPointVisible(Transform xform)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "VisPointVisible")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool VisPointsAllVisible(GameObject parent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsPlacementPositionValid(GameObject go, bool alreadyPlaced)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterTooLow")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterExitBlocked")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToExitBlocked")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "CampfireTooCloseToPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPositionOverGround")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Campfire), Member = "TooWindyToStart")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPositionOverGround")]
	[Calls(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "VisPointsAllVisible")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private MeshLocationCategory CalculateGhostedMeshValidPosition(Vector3 normal)
	{
		return default(MeshLocationCategory);
	}

	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CallsUnknownMethods(Count = 47)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	private void PrepareGhostedObject(bool usePlacementMeshVariant)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeDropMeshAtPlayerFeet()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CallsUnknownMethods(Count = 94)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 43)]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetCampFireInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCache), Member = "OnBuild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlaceMeshInWorld()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TintObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetPropertyBlockForMeshLocationCategory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetPlacementColors")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetPlacementColors")]
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
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	private void TintObject(GameObject go, MeshLocationCategory locationCategory)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 3)]
	private void RestoreOriginalTint(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetBedPlacedMesh(GameObject go)
	{
	}

	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetBedRolledMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[CallsUnknownMethods(Count = 2)]
	private void SetCampfirePlacedMesh(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetSnarePlacedMesh(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ObjectToPlaceIsKeroseneLamp()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsFlare()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsFlashlight()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ObjectToPlaceIsTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "VisPointVisible")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	private static int GetLayerMaskForPlaceMeshRaycast()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlaceMeshRaycast")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetLayerMaskForPlacementPosition()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool InvalidCampfireRequiredToBeWithinVolume(Vector3 worldPosition)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 7)]
	private bool CampfireTooCloseToPlayer(Vector3 campfirePos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool SnowShelterTooCloseToPlayer(Vector3 shelterPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool SnowShelterNotOnGroundSnow()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	private bool SnowShelterTooLow()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 10)]
	private bool SnowShelterExitBlocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool LeanToTooCloseToPlayer(Vector3 shelterPos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsUnknownMethods(Count = 14)]
	private bool LeanToNotOnGroundSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private bool LeanToExitBlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool BedrollOnIce()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	private bool IsPositionOverGround()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	private Collider ObjectToPlaceOverlapsWithObjectsThatBlockPlacement(Vector3 normal)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlaceMeshRaycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "BoxCast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private Collider CheckBoundsAgainstObjectsThatBlockPlacement(Vector3 worldPos, Vector3 localExtents, Quaternion rotation)
	{
		return null;
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool ObjectToPlaceOverlapsSnowShelter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool ObjectToPlaceOverlapsLeanTo()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	private bool ObjectToPlaceOverlapsWithInteractiveProp()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	private bool ObjectToPlaceIsOnBrokenIce()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private GearPlacePoint GetGearPlacePoint(GameObject go, Vector3 searchPos)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 14)]
	private void RestoreTransform()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(TorchItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "HideEffects")]
	private void HideLightFromMesh(bool hide)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldDoVisPointsCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	private void AssignComponents(GameObject go, bool alreadyPlaced)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsUnknownMethods(Count = 12)]
	private void InitializeRenderers()
	{
	}

	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetLargestCollider")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InitializeObjectToPlace(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CheckForButtomPromptUpdate(GearPlacePoint gpp)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void UpdateInventoryOnPlacement()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ItemInHandsThrowable()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_lit_item_in_hands")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnItemInHandStowed")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	public void DropLitItemInHand(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	public void DropLitItemToPlacementZone(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	public void Drop(GameObject go, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	public void DropToPlacementZone(GameObject go, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private static void DropRigidBody(GameObject go, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ResetGravity")]
	public static void SetGravity(GameObject go, bool useGravity)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(StoneItem), Member = "Throw")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Throw(GearItem gi, PlayerAnimation.OnAnimationEvent throwCompleteCallback = null)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass604_0), Member = "<Throw>b__0")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSMeshID")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	private void ReleaseThrownObject()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeAdjustShotPositionForNearShot")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private GameObject ReleaseFromHands(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private GearItem InstantiateCopyOfThrownObject(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	private void MaybeDuplicateItemBeforeDrop(DropLitItemsOptions options)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public static Vector3 MaybeAdjustShotPositionForNearShot(Vector3 emissionPos, Vector3 firePos, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static Vector3 AdjustNearShotFirePosition(RaycastHit hit, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static float GetNearDistanceShot(Vector3 weaponSpaceEmissionPosition)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void ExitIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFirstFrame()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsStickPlayerToGroundPending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsTeleportPending()
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(Renderer), Member = "set_lightProbeProxyVolumeOverride")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	private void SpawnFirstPersonItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetStartGear()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithPlayerElevation")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithClosestDistanceToPredator")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybePlayLandAudio")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(LookAtTargetForTime), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(Physics), Member = "get_autoSimulation")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(RegionManager), Member = "GetSceneFilename")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetGlobalSaveGameFormatVersion")]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CallsUnknownMethods(Count = 4)]
	public void DeserializePostSceneLoadFixup()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SplineManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateFromUnderCrosshair")]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	public void TeleportPlayer(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 304)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 137)]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	public void SetControlMode(PlayerControlMode mode)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	public bool ControlModeAllowsInterface()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetStatusBarsLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsStatusBarsLocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	public bool PlayerIsDead()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "IsLoading")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "IsPlayingNonInterruptableAnimation")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	public bool PlayerIsInvisibleToAi()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	public float CalculateModifiedCalorieBurnRate(float baseBurnRate)
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	public void UpdateCalorieBurnRate()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAlternateColor")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public bool PlayerCantSprintBecauseOfInjury()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[Calls(Type = typeof(PlayerMovement), Member = "GetSprintStaminaRemainingAsPercentage")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public bool PlayerCanSprint()
	{
		return default(bool);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool PlayerIsSleeping()
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public bool PlayerIsSprinting()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetFootStepsRangeScale")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	public bool PlayerIsWalking()
	{
		return default(bool);
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 5)]
	public bool PlayerIsCrouched()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[CallerCount(Count = 7)]
	public bool PlayerIsZooming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsBreakingDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsBuildingShelter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	public bool PlayerIsRepairingShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LeanTo), Member = "Update")]
	[CalledBy(Type = typeof(SnowShelter), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsDismantlingShelter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool PlayerIsBuildingLeanTo()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool PlayerIsRepairingLeanTo()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsDismantlingLeanTo()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsRotatingLeanTo()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsHarvestingCarcass()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 27)]
	public bool PlayerIsClimbing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	public bool PlayerIsInElevator()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AllowStaminaToRecover")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	public bool PlayerIsSwingingFirstPersonItem()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitTopOrBottom")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitToPoint")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	public bool GetStickToGroundPosition(Vector3 testPos, out Vector3 groundPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool GetStickToGroundPositionAfterLoad(Vector3 testPos, out Vector3 groundPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	public void StickPlayerToGround()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPositionAfterLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
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

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetZoomDamping()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool InHibernationPreventionIndoorEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsCharacterControllerEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	public void EnableCharacterController()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnExecute")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DisableCharacterController()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void RemoveSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	public static GameObject PickRandomSpawnPoint()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ForceHideHoverText()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	private void UpdateHUDText()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldForcePlayerSpawnToDefault")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CalledBy(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "FindGameObjectsWithTag")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool GetTeleportTransformAfterSceneLoad(out Vector3 position, out Quaternion rotation)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rotation) = null;
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 65)]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "PickRandomSpawnPoint")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	private SceneLoadSource TeleportPlayerAfterSceneLoad()
	{
		return default(SceneLoadSource);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallAnalysisFailed]
	private void MaybePlayLandAudio()
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[CallsUnknownMethods(Count = 11)]
	public void OnLandFromFall(float fallFromHeight, float damageOverride)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetAutoWalkingEnabled")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnTakeDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetCramponsSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetFootwearSwitch")]
	public void MaybeSetPlayerFootwearSwitch()
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void MaybeSetPlayerGroundMaterialSwitch(string tag)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void SaveCurrentControlMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void MaybeRestoreControlMode()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldSaveGameAfterTeleport()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	private bool ShouldForcePlayerSpawnToDefault()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUpdateWiseWithClosestDistanceToPredator()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
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
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybePlayDelayedSpawnAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsUnknownMethods(Count = 3)]
	private bool AllowInteractionWithObjects()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private GameRegion FindStartRegion()
	{
		return default(GameRegion);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(RegionManager), Member = "GetRegionFromString")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotFilesInCreationOrder")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	private GameRegion FindStartRegionFromFileData()
	{
		return default(GameRegion);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void MaybeRepositionPlayerIfFellThroughWorld()
	{
	}

	[CallerCount(Count = 0)]
	public bool GetShowingUnknownTimeOfDay()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ShowUnknownTimeOfDay(bool showUnknownTimeOfDay)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Knockdown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void KnockedDownByAI(AiSubType aiSubType)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsUnknownMethods(Count = 10)]
	public float GetNormalizedSprintReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsStealthed")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool IsPlayerInStealthArea()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsStealthed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsHoldingWildlifeItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanStaminaAim()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsStaminaAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public float GetStaminaAimPercent()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetStaminaAimDropThresholdPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void OnPostDeserializeForEpisodeMigration()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 27)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	private void GroundCharacterInternal(Vector3 groundPos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 99)]
	public PlayerManager()
	{
	}
}
