using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Interactions;
using TLD.Serialization;
using TLD.UI.Generics;
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
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(PlayerManager), Member = "UpdateLookAt")]
		[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
		[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
		[Calls(Type = typeof(LookAtTargetForTime), Member = "TweenValue")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LookAtTargetForTime), Member = "TweenValue")]
		public void Update()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(LookAtTargetForTime), Member = "Update")]
		[CalledBy(Type = typeof(LookAtTargetForTime), Member = "Update")]
		[CallsUnknownMethods(Count = 3)]
		private float TweenValue(float factor, UITweener.Method tweenMethod, bool steeperCurves)
		{
			return default(float);
		}

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
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

	private sealed class _003C_003Ec__DisplayClass781_0
	{
		public PlayerManager _003C_003E4__this;

		public PlayerAnimation.OnAnimationEvent throwCompleteCallback;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass781_0()
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

	public bool PlayerHasMoved
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

	public bool PlayerHasTurned
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public IInteraction ActiveInteraction
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public GearItem m_ItemInHands
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
		[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
		[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
		[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
		[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(GearItem), Member = "Drop")]
		[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
		set
		{
		}
	}

	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ApplyPumpkinPieBuff(float instantPercentDecrease, float rateScale, float durationHours, float durationMaxHours)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ApplyCarryingCapacityBuff(CarryingCapacityBuff.BuffValues values)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshBackpackDisplay")]
	[CallsUnknownMethods(Count = 5)]
	public bool HasSpecialCarryingCapacityGear(GearItemData gearItemData)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveCarryingCapacityBuff()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(PlayerManager), Member = "GetAllSpecialCarryingCapacityBuffItems")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UpdateCarryingBuff()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "GetWornWolfIntimidationClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBuffDurations(Panel_HUD hud, float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowBuffLossNotification")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateConditonBuffDuration(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	public bool IsPumpkinPieBuffActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWolfDecreaseAttackChancePercentagePointsBuff()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(StatusBar), Member = "IsBuffActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Condition), Member = "HasBuff")]
	public bool FreezingBuffActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool FatigueBuffActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberMedThresholdKG")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberHighThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumberLowThresholdKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityWhenExhaustedKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "IsCapacityBuffed")]
	[CallerCount(Count = 14)]
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

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetFatigueBuffTimeRemainingHours()
	{
		return default(float);
	}

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

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetConditionRestBuffTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetConditionRestBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetPumpkinPieBuffTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetPumpkinPieBuffTimeRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateClimbingBuff()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetClimbingBuffSprainOddsModifier()
	{
		return default(float);
	}

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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	public static int GetNumLayersForClothingRegion(ClothingRegion clothingRegion)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ClothingItem), Member = "MaybeGetWetOnGround")]
	public float GetWetnessIncreasePerHour()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetWetnessIncreasePerHour")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(ClothingItem), Member = "IsNearFire")]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateClothingWetness()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "GetWarmth")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClothingItem), Member = "GetWindproof")]
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
	[CallsUnknownMethods(Count = 2)]
	public bool GetWarnClothingCanBeDamaged()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyPercentDamageToWornClothing(float normalizedDamage)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CalledBy(Type = typeof(Weather), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	public void ApplyDamageToWornClothing(float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 2)]
	public float GetWornClothingToughness()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ClothingItem), Member = "TakeOff")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	public void TakeOffClothingItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnUseClothingItem")]
	[CalledBy(Type = typeof(ClothingItem), Member = "PickedUp")]
	[CalledBy(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeUpdateDamageProtection")]
	[CallsUnknownMethods(Count = 5)]
	public void PutOnClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RepairSuccessful")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsWearingPerfectClothesInAllSlots")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	public void MaybeUnlockResoluteOutfitterAchievement()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsWearingClothingItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CalledBy(Type = typeof(AchievementManager), Member = "WentToSleep")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWearingClothingName(string itemName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(ClothingItem), Member = "TakeOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[CallsUnknownMethods(Count = 2)]
	private bool UseClothingItem(GearItem gi, ClothingLayer layerToPutOn = ClothingLayer.NumLayers)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetEmptyLayerForRegion")]
	[CallerCount(Count = 0)]
	public bool HasFreeSlotForClothingItem(ClothingItem ci)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ClothingItem), Member = "PickedUp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HasFreeSlotForClothingItem")]
	[CallsUnknownMethods(Count = 2)]
	private ClothingLayer GetEmptyLayerForRegion(ClothingRegion region, ClothingLayer minLayer, ClothingLayer maxLayer)
	{
		return default(ClothingLayer);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_debug_clothing")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 26)]
	public void OutputWornClothing()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem GetWornWolfIntimidationClothing()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 2)]
	public GearItem GetWornCarryingCapacityBuffClothing()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void GetAllWornCarryingCapacityBuffClothing(List<GearItem> carryingCapacityBuffs)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[CallsUnknownMethods(Count = 6)]
	public void GetAllSpecialCarryingCapacityBuffItems(List<GearItem> carryingCapacityBuffs)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateClimbingBuff")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	public GearItem GetClimbingBuffClothing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetClothingSprintReduction()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumWetClothes()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SelectDefaultSlot")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	public GearItem GetClothingInSlot(ClothingRegion region, ClothingLayer layer)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "CheckForHide")]
	[CalledBy(Type = typeof(ClimbingBuff), Member = "IsActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallsUnknownMethods(Count = 1)]
	public FootwearType GetFootwearType()
	{
		return default(FootwearType);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CalledBy(Type = typeof(SprainProtection), Member = "UpdateSprainProtection")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public CramponsState GetCramponsState()
	{
		return default(CramponsState);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(PlayerManager), Member = "GetNumLayersForClothingRegion")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDamageReductionFromExteriorClothing()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition), Member = "GetDamageReductionForCause")]
	[CalledBy(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	public float GetDamageReductionFromExteriorLegFeet()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUnlockResoluteOutfitterAchievement")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsWearingPerfectClothesInAllSlots()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 2)]
	private float GetWornClothingRegionToughness(int regionIndex)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPercentDamageToWornClothingRegion")]
	[Calls(Type = typeof(DamageProtection), Member = "MaybeApplyClothingDamageProtection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	private void ApplyPercentDamageToTopMostLayer(int regionIndex, float normalizedDamage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyDamageToWornClothingRegion")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(Burns), Member = "ApplyClothingDamage")]
	[CalledBy(Type = typeof(Burns), Member = "ApplyClothingDamage")]
	[Calls(Type = typeof(GearItem), Member = "Degrade")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(BurnsElectric), Member = "ApplyClothingDamage")]
	private void ApplyDamageToTopMostLayer(int regionIndex, float damage, DamageReason damageReason = DamageReason.Unknown)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorClothing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetDamageReductionFromExteriorLegFeet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeSetSoundSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetAudioSwitchOfOuterLayer")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseAltTexture")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollLayer_Astrid")]
	[CalledBy(Type = typeof(ClothingSlot), Member = "ShouldUseThirdAltTexture")]
	public GearItem GetTopLayerGear(ClothingRegion region)
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void GetAllClothingInRegion(ClothingRegion region, List<GearItem> gearItems)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 2)]
	public bool RegionHasFullFrozenInnerLayer(ClothingRegion region)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	public bool RegionHasFullWetInnerLayer(ClothingRegion region)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Frostbite), Member = "UpdateFrostbite")]
	[CallsUnknownMethods(Count = 2)]
	public bool RegionHasNonFrozenClothing(ClothingRegion region)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseGroupType), Member = "get_GroupId")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TakeOffClothingItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PutOnClothingItem")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetSoundSwitch(ClothingRegion region)
	{
	}

	[CallerCount(Count = 0)]
	private uint GetLastAudioSwitchForRegion(ClothingRegion region)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	private void SetLastAudioSwitchForRegion(ClothingRegion region, uint id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTopLayerGear")]
	[CallerCount(Count = 0)]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SpawnFirstPersonItems")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "CalculateClampedYaw")]
	[Calls(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterIndoorSpaceTrigger(IndoorSpaceTrigger Trigger)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(IndoorSpaceTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnRightHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnLeftHandProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "MaybeSpawnShoulderProp")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "UpdateBulletsForReload")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	private void SpawnFirstPersonItems()
	{
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyAllGear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetStartGear()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithClosestDistanceToPredator")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateActiveInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRotateCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateClothingWetness")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBuffDurations")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeUpdateWiseWithPlayerElevation")]
	[Calls(Type = typeof(LookAtTargetForTime), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateIfPlayerHasMoved")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPositionAfterLoad")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "get_autoSimulation")]
	[Calls(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ForceIntoVehicleSilent")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(PlayerVoice), Member = "SetPlayerVoicePersona")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SplineManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "UpdateFromUnderCrosshair")]
	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueOptionsAnimationTree), Member = "UpdateClosestToCenter")]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "EnterShelterAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(LeanToManager), Member = "EnterLeanToAfterFadeOutCommon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[CalledBy(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	public void TeleportPlayer(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 309)]
	[CallsUnknownMethods(Count = 2)]
	public PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CallerCount(Count = 122)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CinematicManager), Member = "IsPlaying")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[Calls(Type = typeof(CinematicManager), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "IsPlayingNonInterruptableAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	public bool PlayerIsInvisibleToAi()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "UpdateEstimatedCaloriesBurnedLabel")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshCalorieLabels")]
	public float CalculateModifiedCalorieBurnRate(float baseBurnRate)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[Calls(Type = typeof(Feat), Member = "IsUnlockedAndEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsDismantlingShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsRepairingShelter")]
	public void UpdateCalorieBurnRate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShouldShowAlternateColor")]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybePlayHeavyBreathingLoop")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	public bool PlayerCantSprintBecauseOfInjury()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public bool PlayerCanSprint()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CalledBy(Type = typeof(GearMessage), Member = "Update")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(Frostbite), Member = "CalculateBodyTemperatureWithoutClothing")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "UpdateFoodPoisoning")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShortenMessageTimeDueToQueue")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CalledBy(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(Thirst), Member = "Update")]
	[CalledBy(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	public bool PlayerIsSleeping()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(GameManager), Member = "IsMovementLockedBecauseOfLantern")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerIsSprinting()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetFootStepsRangeScale")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerVelocityRTPC")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateCalorieBurnRate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateModifiedCalorieBurnRate")]
	[CalledBy(Type = typeof(Fatigue), Member = "UpdateHeavyBreathing")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Fatigue), Member = "MaybeCatchBreath")]
	public bool PlayerIsWalking()
	{
		return default(bool);
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[CallsUnknownMethods(Count = 2)]
	public bool PlayerIsCrouched()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(HUDManager), Member = "ShouldHideCrossHairs")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCanSprint")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[Calls(Type = typeof(vp_StateManager), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsHarvestingCarcass()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	public bool PlayerIsClimbing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool PlayerIsInElevator()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "AllowStaminaToRecover")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsStateEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool PlayerIsSwingingFirstPersonItem()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitToPoint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitTopOrBottom")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "RequestExitAfterFall")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateTransitionOut")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public bool GetStickToGroundPosition(Vector3 testPos, out Vector3 groundPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	public bool GetStickToGroundPositionAfterLoad(Vector3 testPos, out Vector3 groundPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRepositionPlayerIfFellThroughWorld")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterAfterFadeOut")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitShelterDueToStruggle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_teleport")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(LeanToManager), Member = "ExitLeanToAfterFadeOut")]
	public void StickPlayerToGround()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GroundCharacterInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPositionAfterLoad")]
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

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "AddToYaw")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void MaybeRotateCamera()
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerCheat()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasCheated()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetZoomDamping()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "DoRest")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "CheckPassTimeErrorMessage")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CabinFever), Member = "UpdateCabinFeverTimeTracker")]
	public bool InHibernationPreventionIndoorEnvironment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsCharacterControllerEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerInVehicle), Member = "ExitVehicleAfterFadeOut")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybeBlendToSyncBone")]
	[CalledBy(Type = typeof(Action_LerpToSyncBone), Member = "MaybePopToSync")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	public void EnableCharacterController()
	{
	}

	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_DisableCharacterController), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerInVehicle), Member = "EnterVehicleCommon")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveSpawnPoints(PlayerSpawnPoints playerSpawnPoints)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public static GameObject PickRandomSpawnPoint()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(HUDManager), Member = "DoNotRenderHUD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayTextState")]
	private void UpdateHUDText(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateTransitionIn")]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "RequestClosestPointOnSpline")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TeleportPlayerAfterSceneLoad")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "FindGameObjectsWithTag")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldForcePlayerSpawnToDefault")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool GetTeleportTransformAfterSceneLoad(out Vector3 position, out Quaternion rotation)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref position) = null;
		System.Runtime.CompilerServices.Unsafe.As<Quaternion, @null>(ref rotation) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PickRandomSpawnPoint")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private SceneLoadSource TeleportPlayerAfterSceneLoad()
	{
		return default(SceneLoadSource);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybePlayLandAudio()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerGroundMaterialSwitch")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeSetPlayerFootwearSwitch")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	public void OnLandFromFall(float fallFromHeight, float damageOverride)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void OnTakeDamage(float condition, float given, float taken, DamageSource damageSource)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetFootwearType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCramponsState")]
	public void MaybeSetPlayerFootwearSwitch()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "PlayFootStepSound")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void MaybeSetPlayerGroundMaterialSwitch(string tag)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 0)]
	private bool ShouldSaveGameAfterTeleport()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldForcePlayerSpawnToDefault()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void MaybeUpdateWiseWithClosestDistanceToPredator()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeUpdateWiseWithPlayerElevation()
	{
	}

	[CallerCount(Count = 0)]
	public void SkipDelaySpawnAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	private void MaybePlayDelayedSpawnAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsUnknownMethods(Count = 3)]
	private bool AllowInteractionWithObjects()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void KnockedDownByAI(AiSubType aiSubType)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateStamina")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[CallsUnknownMethods(Count = 3)]
	public float GetNormalizedSprintReduction()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsStealthed")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	public bool IsPlayerInStealthArea()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerIsStealthed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public bool IsHoldingWildlifeItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStaminaAim()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsStaminaAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStaminaAimPercent()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStaminaAimDropThresholdPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void OnPostDeserializeForEpisodeMigration()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StickPlayerToGroundAfterLoad")]
	[CallsUnknownMethods(Count = 8)]
	private void GroundCharacterInternal(Vector3 groundPos)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
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
		return default(bool);
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

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void LogPlayerPosition()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "OnCollectibleNoteReadingClickBack")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void OnCollectibleNoteReadingClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CallsUnknownMethods(Count = 2)]
	public void RevealOnPolaroidDiscovery(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void MaybeRevealPolaroidDiscoveryOnClose()
	{
	}

	[Calls(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookingState")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[Calls(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideCollectibleNote")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public void ExitInspectGearMode(bool hardExit)
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Container), Member = "ShowItemsAfterSearch")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartInspectMode")]
	[CalledBy(Type = typeof(EvolveItem), Member = "DoEvolution")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeWithCallback")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromContainer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromFishingHole")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromHarvestable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearModeFromCookingPot")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 30)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayPutBackAudio")]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCollectibleNote")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromInspectToContainer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "OnCollectibleNoteReadingClickBack")]
	[Calls(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[Calls(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayStowFromInspectAudio")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldContainerDisallowEquipAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[Calls(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "FadeInLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	private void UpdateInspectGear(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInspectModeActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public GearItem GearItemBeingInspected()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public void RestoreTransformFromLastInspection(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void MaybeEnableInspectModeMesh(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	public static void MaybeDisableInspectModeMesh(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void RestoreOriginalTransform(Transform t)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 2)]
	private void SetGearTransformForInspection()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	private void UpdateGearTransformForInspection()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsDeduplicatedMethods(Count = 30)]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitInspectGearMode")]
	private void SetActiveAllLabels(Panel_HUD hud, bool active)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SetActiveInfoArea(Panel_HUD hud, bool showStandard)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void NoteToggleReadMode(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ResearchItem), Member = "GetSkillNameLocalized")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 62)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(FoodItem), Member = "GetTemperatureTextForInspectMode")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldContainerDisallowEquipAction")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPickup")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeReplaceGearItemForLabels")]
	[CallsDeduplicatedMethods(Count = 71)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EvolveItem), Member = "GetTimeToDryStringInventory")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "get_Description")]
	[Calls(Type = typeof(ResearchItem), Member = "IsResearchComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HoverIconsToShow), Member = "GetSpriteNameForHoverIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	private void InitLabelsForGear(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingPotItem), Member = "IsCookingSomething")]
	private void MaybeReplaceGearItemForLabels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 7)]
	private void FadeInLabels(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Inspect), Member = "GetUrgency")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybePlayInspectModeVoiceOver()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CookingPotItem), Member = "PlayPutBackFromInspectAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	private void PlayPutBackAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void PlayStowAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemCanEquipInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 3)]
	private void AttemptEquipGearItem()
	{
	}

	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void TransferGearFromInspectToContainer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayStowAudio")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "DestroyGear")]
	private void TransferGearFromContainerToInventory()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetActiveAllLabels")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	private bool CanPickup(Panel_HUD hud)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private bool ShouldContainerDisallowEquipAction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	private void RefreshGamepadPrompts(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "Toggle")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateAimingStaminaBar")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	public bool IsCancelableActionInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsClickHoldActive()
	{
		return default(bool);
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

	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_stow_item")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Stow")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToExitPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	public bool StowItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 30)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	private void DoDelayedInteractionEnd(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StowItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
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

	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoDelayedInteractionEnd")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unstow")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldStowOrUnstowForInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Skill_Archery), Member = "CanFireBowWhileCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillArchery")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	private void ItemInHandsDuringInteractionEndInternal(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "OnPickUp")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CollectArrows")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndAddToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemShouldEquipOnPickup")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "MaybeShowHudMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public bool ProcessPickupItemInteraction(GearItem item, bool forceEquip, bool skipAudio)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenDropCurrent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	public void ProcessPickupWithNoInspectScreen(GearItem pickupItem, bool immediate)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_StowItemsInHand), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Carry")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Unequip")]
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

	[Calls(Type = typeof(NarrativeCollectibleItem), Member = "MaybeShowHudMessage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[Calls(Type = typeof(GearItem), Member = "GetBasicDisplayNameForInventoryInterfaces")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ProcessPickupWithNoInspectScreenEquip()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	private void OnProcessPickupWinNoInspectEquipComplete()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	public void ResetPickup()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldShowClickHoldBackpiece()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[Calls(Type = typeof(OwnershipManager), Member = "IsUnowned")]
	[CallerCount(Count = 1)]
	public HoverTextState GetInteractiveObjectDisplayTextState()
	{
		return default(HoverTextState);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	public string GetInteractiveObjectDisplayText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private GameObject GetInteractiveObjectNearCrosshairs(float maxRange)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	public bool HasInteractiveObjectUnderCrossHair()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "RespectContrainsts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 1)]
	private GameObject GetInteractiveObjectWithConstraints(GameObject interactiveObject)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	private void FindInteractiveObject(RaycastHit hit, ref GearItem gi, ref GameObject interactiveObj)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 44)]
	[Calls(Type = typeof(PlayerManager), Member = "ShouldSuppressCrosshairs")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "GetTopParentWithLayer")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public GameObject GetInteractiveObjectUnderCrosshairs(float maxRange)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[Calls(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[CallerCount(Count = 2)]
	public void InteractiveObjectsProcess()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(PlayerManager), Member = "GetInteractiveObjectWithConstraints")]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[CallsUnknownMethods(Count = 5)]
	private void FindInteractiveObject(float range)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "FindInteractiveObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetForcedInteraction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetInteraction")]
	[CalledBy(Type = typeof(LoadingZone), Member = "DeactivateLoadingZone")]
	[CalledBy(Type = typeof(LoadingZone), Member = "ActivateLoadingZone")]
	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	private void SetCurrentInteraction(IInteraction interaction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	public void SetForcedInteraction(IInteraction interaction)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "TryCancelHoldInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateActiveInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetCurrentInteraction")]
	private void ResetInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldCancelHoldInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateActiveInteraction")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	public void TryCancelHoldInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void InteractiveObjectsProcessAltFire()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectUnderCrosshairCanLightTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	public bool InteractiveObjectsProcessInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptEquipGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "AssignSlot")]
	public bool ItemCanEquipInHands(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcess")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 3)]
	public float ComputeModifiedPickupRange(float range)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private bool ItemShouldEquipOnPickup(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool PlayerHoldingTorchThatCanBeLit()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	public bool ObjectUnderCrosshairCanLightTorch()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectNearCrosshairs")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "IsHoveringInteractiveObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HasInteractiveObjectUnderCrossHair")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldSuppressCrosshairs()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreen")]
	[Calls(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseMatchesItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(StoneItem), Member = "OnThrowComplete")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "IsWeaponAvailable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetWeapon")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SetWeaponAvailable")]
	public void EquipItem(GearItem gi, bool fromDeserialize)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void OnEquipItemBegin()
	{
	}

	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRestoreSaveItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ExitDialogueMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
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
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RestrictHeldItems")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(HeldItemRestriction), Member = "IsRestricted")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "MaybeStowItemInHand")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	public bool IsHeldItemRestricted(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HeldItemRestrictionTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(PlayerManager), Member = "IsHeldItemRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	public bool CanHolsterItem(GearItem gi)
	{
		return default(bool);
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

	[CalledBy(Type = typeof(BodyCarry), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unequip_immediate")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BeginReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(Action_SetCinematicProperties), Member = "SetProperty")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(BodyCarry), Member = "SetupCarryState")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[CalledBy(Type = typeof(BodyCarry), Member = "ReadyForPlacementDropAnimation")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeStowItemInHand")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[CalledBy(Type = typeof(TimelinePlayback), Member = "AttemptToStowPlayerItemInHand")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 16)]
	public void UnequipImmediate(bool saveLastItem)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_UnequipItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "PauseLight")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetCameraLayer")]
	public void AutoUnequipItemInHandsBeforeInteraction(bool pauseFlare = true)
	{
	}

	[CalledBy(Type = typeof(AnimatedInteraction), Member = "DoOnInteractionComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_RetrieveLastItemInHands), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "EndClimbing")]
	[CalledBy(Type = typeof(PlayPlayerTimelineOnInteract), Member = "OnTimelineEnded")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipLastItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	public void AutoEquipItemInHandsAfterInteraction()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	public static void TurnLightOffImmediate(bool pauseFlare, GearItem gi)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void PauseLight(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ResumeLight(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(Action_TriggerAnimatedInteraction), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ShowHideHands), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AutoUnequipItemInHandsBeforeInteraction")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnDrop")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "StopAudioForEquippedItem")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_hands")]
	[CalledBy(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	public void UnequipItemInHandsSkipAnimation()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(TorchItem), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopAudioForEquippedItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Ignite_Cancel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "CancelAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "InitializeStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(TorchItem), Member = "CancelIgnite")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void CancelItemInHandsAction(bool cancelByUser)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 3)]
	public void UnequipItemInHandsForPlacement()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ExitInterfaceAndOpenSafe")]
	[CallerCount(Count = 2)]
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
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "UseBedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseClothingItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFPSMeshItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool UseInventoryItem(GearItem gi, float volumeAvailable = -1f, bool suppressWeaponsErrorMessage = false)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallsUnknownMethods(Count = 1)]
	public bool TryAddToExistingStackable(GearItem gearToAdd, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Inventory), Member = "GetClosestMatchStackable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public bool TryAddToExistingStackable(GearItem gearToAdd, float normalizedCondition, int numUnits, out GearItem existingGearItem)
	{
		existingGearItem = null;
		return default(bool);
	}

	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnDoActionSecondary")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TransferGearFromContainerToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "CookingPotPickUpCallback")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "PickedUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GearItem AddItemToPlayerInventory(GearItem gi, bool trackItemLooted = true, bool enableNotificationFlag = false)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public float GetFoodCaloriesTotal()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CanRefuel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	public float GetTotalLiters(GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCapacityLiters(GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CookingCompleted")]
	public float AddLiquidToInventory(float litersToAdd, GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "OnRefuel")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefuelFinished")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	public float DeductLiquidFromInventory(float literDeduction, GearLiquidTypeEnum liquidType)
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "HarvestSuccessful")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PowderItem), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PowderItem), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void AddPowderToInventory(float amount, GearPowderType type)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	public float DeductPowderFromInventory(float deduction, GearPowderType type)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Enable")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallsUnknownMethods(Count = 4)]
	public float GetTotalPowderWeight(GearPowderType type)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_gear_add_type")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_toughclothes")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_buffs_add_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_add_all_gear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bow")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearspear")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "LoadGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bow")]
	public GearItem AddItemCONSOLE(string name, int count)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseSelectedItem")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "OnUseMatches")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(TorchItem), Member = "StopBurningAudioLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "ActionFinished")]
	[CallerCount(Count = 9)]
	public void ConsumeUnitFromInventory(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	public bool UseSmashableItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Burns), Member = "BurnsEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(BurnsElectric), Member = "BurnsElectricEnd")]
	[Calls(Type = typeof(SprainPain), Member = "TakePainKillers")]
	[Calls(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesEnd")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(InfectionRisk), Member = "TakeAntiseptic")]
	private void TreatAffliction(FirstAidItem firstAidItem, AfflictionType afflictionType, AfflictionBodyArea location, int afflictionId)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	private void FirstAidConsumed(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyAlternateRemedy")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "ApplyStandardRemedy")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "DeductLiquidFromInventory")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RemoveFirstAidItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "FirstAidConsumed")]
	[Calls(Type = typeof(PlayerManager), Member = "FirstAidConsumed")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	public void OnFirstAidComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsTreatingAffliction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnEatingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQualityString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void OnDrinkWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveWater(WaterSupply ws, float removedLiters)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWaterPurificationItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	public void OnPurifyWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OpenAndUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnFoodOpeningComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "PickUpCookedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSmashableItem")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	public void OnSmashComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(MultiplyNighttimeParticleOpacity), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public float GetHeldLightIntensity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(HeightFogSettings), Member = "ApplyLightSources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public Color GetHeldLightColor()
	{
		return default(Color);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DrinkFromWaterSupply")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	private float CalculateWaterVolumeToDrink(float availableLiters)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	private bool UseWeaponInventoryItem(GearItem gi, bool suppressWeaponsErrorMessage = false)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	public void OpenAndUseFoodInventoryItem(GearItem gi, CanOpeningItem gearOpenedWith)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 3)]
	private bool CanUseFoodInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFoodOpeningComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanUseFoodInventoryItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private bool UseFoodInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateWaterVolumeToDrink")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private bool DrinkFromWaterSupply(WaterSupply ws, float volumeAvailable)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(FireManager), Member = "InstantiateCampFire")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private bool UseFireStarterInventoryItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CallsUnknownMethods(Count = 3)]
	private bool UseFPSMeshItem(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	private bool UseMatchesItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	public bool TreatAfflictionWithFirstAid(FirstAidItem firstAidItem, Affliction afflictionSelected)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private bool UseFirstAidItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private bool UseBedItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	private bool PlaceSnare(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "OnPurifyWaterComplete")]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	private bool UseWaterPurificationItem(GearItem gi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private bool UseSprayPaintCan(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool PlaceCookingPot(GearItem gi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlashlightItem), Member = "IsLit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "UpdateWhileInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "LightPositionFixUp")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetFPSItemGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	private void UpdateItemInHands()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	private void UnequipItemInHandsInternal()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnExtinguishComplete()
	{
	}

	[Calls(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeDropAndResetCurrentWeapon")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalCompleteResetWeapon")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnTakeTorch")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SwitchWeapon")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "ResetEffects")]
	[Calls(Type = typeof(FlashlightItem), Member = "PlayTurnOffAudio")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	public void OnUnequipItemInHandInternalComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(Panel_Harvest), Member = "MaybeReturnAmmoOrFuelToInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	public GearItem InstantiateItemInPlayerInventory(AssetReferenceGearItem assetReference, int units = 1, float normalizedCondition = -1f, bool enableNotificationFlag = false, bool craftInProgress = false)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "SetNormalizedHP")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StackableItem), Member = "FindBestFitForUnits")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public GearItem InstantiateItemInPlayerInventory(GearItem gearItemPrefab, int units = 1, float normalizedCondition = -1f, bool enableNotificationFlag = false, bool craftInProgress = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	public GearItem InstantiateItemAtPlayersFeet(AssetReferenceGearItem assetReference, int numUnits)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Harvestable), Member = "EnterInspectMode")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "MaybeInstantiateDummyCookingPot")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[CalledBy(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "MaybeSpawnGearItemForInspectMode")]
	public GearItem InstantiateItemAtPlayersFeet(GearItem gearItemPrefab, int numUnits)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GearItem InstantiateItemAtLocation(AssetReferenceGearItem assetReference, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "RemoveDisabler")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	public GearItem InstantiateItemAtLocation(GearItem gearItemPrefab, int numUnits, Vector3 position, bool stickToGround)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldDestroyFoodAfterEating(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsReadyToEquip")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	private void MaybeUpdateEquipItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(CinematicManager), Member = "IsReady")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeUpdateEquipItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[Calls(Type = typeof(PlayerAnimation), Member = "GetFPCinematicManager")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	private bool IsReadyToEquip()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool HasSavedItemInHands()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(FoodItem), Member = "DoGearHarvestAfterFinishEating")]
	[Calls(Type = typeof(GearItem), Member = "ApplyBuffs")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillCooking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEatingComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFoodInventoryItem")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat_StraightToHeart), Member = "IncrementItemConsumed")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "HandleEatingCompleteStackableFoodItem")]
	private void EatingComplete_Internal(bool success, bool playerCancel, float progress)
	{
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	private void HandleEatingCompleteStackableFoodItem(GearItem foodItem)
	{
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "CanDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckIfInsideBlockPlacement")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CheckIfCanDropGearItem(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckIfCanDropGearItem")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldShowSprayPaintCan()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool IsInDecalPlacementMode()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CleanupDecalToRemove")]
	public bool StartPlaceDecal(GearItem gearItem, ProjectileType decalShape, DecalColour decalColour, float placementDistance)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToRemoveDecalInPlace")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessRemoveObjectPressed")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	public void EraseDecal(DecalProjectorInstance decalInstance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessReloadAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	private void CleanupDecalToRemove()
	{
	}

	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateOverlappingDecalInPlace")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	private void UpdatePlaceDecal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleNowhereToHideEventSpecificBehaviour(DecalProjectorInstance decalInstance)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "GetIntersectedSprayPaintDecal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	private void AttemptToPlaceDecal()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	private void AttemptToRemoveDecalInPlace()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 3)]
	public void StopSprayPaintAudio()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(CharcoalItem), Member = "HasSurveyVisibility")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(ToxicFogManager), Member = "SetSecondsInCurrentRegion")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "TrySpawnDecalObject")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddProjectorInstanceBoundsInfo")]
	private void OnCompletedDecalPlaceDown()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void OnDecalDeserialized(DecalProjectorInstance decal)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
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
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelDecalPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideRemoveDecalPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void ExitDecalPlacement()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	private void CancelDecalPlacement(bool forceCancel = false)
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void SuspendDecalPlacement()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(BodyCarry), Member = "CancelPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateInventoryOnPlacement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	private void UpdatePlacementDistance()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanPlaceCookingItemOnPoint(GearItem obj)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool IsOverCreatureOrRemains(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybeAdjustTransformWithDropDummy")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 60)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapBoxNonAlloc")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Physics), Member = "ComputePenetration")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckForButtomPromptUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetGearPlacePoint")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PlayerManager), Member = "IsOverCreatureOrRemains")]
	[Calls(Type = typeof(PlayerManager), Member = "IsOverCreatureOrRemains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "CanBodyBePlaced")]
	[CallsDeduplicatedMethods(Count = 57)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(GearPlacePoint), Member = "IsAuthorizedPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateObjectToPlaceTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	private MeshLocationCategory DoPositionCheck()
	{
		return default(MeshLocationCategory);
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateCrosshair")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "ComputeModifiedPickupRange")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	public bool CanPlaceMeshImmediately(GearItem gearItem)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	private void UpdateObjectToPlaceTransform(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_PlacementMode_Place")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[CallsUnknownMethods(Count = 10)]
	private bool PlaceImmediately()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "PlaceMeshInWorld")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	private float GetDefaultPlacementDistance()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseBedItem")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "GetDefaultPlacementDistance")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnBedRoll")]
	public bool StartPlaceMesh(GameObject objectToPlace, PlaceMeshFlags flags)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[Calls(Type = typeof(PlayerManager), Member = "TintObject")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(BodyCarry), Member = "ShowError")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnPlaceRockCache")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBedRoll")]
	[CalledBy(Type = typeof(Panel_BedRollSelect), Member = "OnUseBearSkin")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFireStarterInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceSnare")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceCookingPot")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(BodyCarry), Member = "MaybePlace")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSnowShelter")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlacementDistance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(PlayerManager), Member = "InitializeRenderers")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Campfire), Member = "OnEnteredPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public bool StartPlaceMesh(GameObject objectToPlace, float placementDistance, PlaceMeshFlags flags)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
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
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceMesh")]
	public void AttemptToPlaceObject()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "DeactivateAllWeapons")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Reset")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCurrentPlaceable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AttemptToPlaceMesh()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[CallerCount(Count = 0)]
	public void ProcessRemoveObjectPressed()
	{
	}

	[CalledBy(Type = typeof(LoadingZone), Member = "OnTriggerStay")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(LoadingZone), Member = "ActivateLoadingZone")]
	[Calls(Type = typeof(PlayerManager), Member = "SetBedRolledMesh")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "HideLightFromMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreTransform")]
	public void StowOrDropPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsInternal")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "UnwieldBegin")]
	[CalledBy(Type = typeof(GearItem), Member = "OnBeginUnwield")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "EnterPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitDecalPlacement")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallerCount(Count = 13)]
	public void CancelPlacementMode()
	{
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	private void CancelPlaceMesh()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "ExitPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "MaybePlayCookingSlotPlacementAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "CleanUpPlaceMesh")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "CancelPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "OnExitedPlaceMesh")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(PlayerManager), Member = "RestoreOriginalTint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCache), Member = "Destroy")]
	[Calls(Type = typeof(SnowShelter), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "DestroyFireObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearPlacePoint), Member = "FindGearAtPlacePoint")]
	[Calls(Type = typeof(GearPlacePoint), Member = "ItemPlaced")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanTo), Member = "Destroy")]
	public void ExitMeshPlacement()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlaceImmediately")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "InteractionFinished")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void CleanUpPlaceMesh()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public bool ItemInHandsPlaceable()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	public string GetPlaceMeshFireButtonString()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	public bool IsInPlacementMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public bool IsInMeshPlacementMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(Utils), Member = "InputControlRotate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void RotateCurrentPlaceable()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CalledBy(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[CalledBy(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	public bool ObjectToPlaceInInventory()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsRendererBeingPlaced(Renderer renderer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	private bool VisPointVisible(Transform xform)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool VisPointsAllVisible(GameObject parent)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetLayerMaskForPlacementPosition")]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsPlacementPositionValid(GameObject go, bool alreadyPlaced)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[Calls(Type = typeof(PlayerManager), Member = "LeanToExitBlocked")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterExitBlocked")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPositionOverGround")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(PlayerManager), Member = "CampfireTooCloseToPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPositionOverGround")]
	[Calls(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCacheManager), Member = "CanPlaceRockCache")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "VisPointsAllVisible")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private MeshLocationCategory CalculateGhostedMeshValidPosition(Vector3 normal)
	{
		return default(MeshLocationCategory);
	}

	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 17)]
	private void PrepareGhostedObject(bool usePlacementMeshVariant)
	{
	}

	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void MaybeDropMeshAtPlayerFeet()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "PlaceBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnPlaceMeshAnimationEvent")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RockCache), Member = "OnBuild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 57)]
	[Calls(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_FireStart), Member = "SetFireplaceInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void PlaceMeshInWorld()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetPropertyBlockForMeshLocationCategory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ResetPlacementColors")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TintObject")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CalledBy(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetPlacementColors")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void InitializePropertyBlocks()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	private MaterialPropertyBlock GetPropertyBlockForMeshLocationCategory(MeshLocationCategory category)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "InitializePropertyBlocks")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	private void TintObject(GameObject go, MeshLocationCategory locationCategory)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	private void RestoreOriginalTint(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetBedPlacedMesh(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bed), Member = "SetState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsUnknownMethods(Count = 1)]
	private void SetBedRolledMesh(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetCampfirePlacedMesh(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetSnarePlacedMesh(GameObject go)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ObjectToPlaceIsKeroseneLamp()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsFlare()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ObjectToPlaceIsFlashlight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ObjectToPlaceIsTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private static int GetLayerMaskForPlaceMeshRaycast()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "CollectMasks")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	public static int GetLayerMaskForPlacementPosition()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool InvalidCampfireRequiredToBeWithinVolume(Vector3 worldPosition)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 4)]
	private bool CampfireTooCloseToPlayer(Vector3 campfirePos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 3)]
	private bool SnowShelterTooCloseToPlayer(Vector3 shelterPos)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 21)]
	private bool SnowShelterNotOnGroundSnow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private bool SnowShelterTooLow()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 5)]
	private bool SnowShelterExitBlocked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 4)]
	private bool LeanToTooCloseToPlayer(Vector3 shelterPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool LeanToNotOnGroundSnow()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 5)]
	private bool LeanToExitBlocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	private bool BedrollOnIce()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private bool IsPositionOverGround()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "get_localBounds")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(PlayerManager), Member = "CheckBoundsAgainstObjectsThatBlockPlacement")]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	private Collider ObjectToPlaceOverlapsWithObjectsThatBlockPlacement(Vector3 normal)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "BoxCast")]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private Collider CheckBoundsAgainstObjectsThatBlockPlacement(Vector3 worldPos, Vector3 localExtents, Quaternion rotation)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private bool ObjectToPlaceOverlapsSnowShelter()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 6)]
	private bool ObjectToPlaceOverlapsLeanTo()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ObjectToPlaceOverlapsWithInteractiveProp()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetColliderUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "CompareTag")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CallsUnknownMethods(Count = 9)]
	private bool ObjectToPlaceIsOnBrokenIce()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private GearPlacePoint GetGearPlacePoint(GameObject go, Vector3 searchPos)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RestoreTransform()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StowOrDropPlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "SetDamageBlendValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "HideEffects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	private void HideLightFromMesh(bool hide)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldDoVisPointsCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "IsPlacementPositionValid")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 1)]
	private void AssignComponents(GameObject go, bool alreadyPlaced)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void InitializeRenderers()
	{
	}

	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestCollider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CanPlaceMeshImmediately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(PlayerManager), Member = "AssignComponents")]
	[Calls(Type = typeof(Utils), Member = "AreCollidersActiveAndEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private void InitializeObjectToPlace(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CanPlaceCookingItemOnPoint")]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void CheckForButtomPromptUpdate(GearPlacePoint gpp)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGearFromInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "FindByInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetNonPotableWaterSupply")]
	private void UpdateInventoryOnPlacement()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ItemInHandsThrowable()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "StickToGroundAtPlayerFeet")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_drop_lit_item_in_hands")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_LowerItemsInHand), Member = "OnItemInHandStowed")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DropLitItemInHand(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "DropItemFromHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDuplicateItemBeforeDrop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	public void DropLitItemToPlacementZone(DropLitItemsOptions options, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DropCurrentItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	public void Drop(GameObject go, bool useGravity = true)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	public void DropToPlacementZone(GameObject go, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetGravity")]
	private static void DropRigidBody(GameObject go, bool useGravity = true)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropRigidBody")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "RetrievePlacedItemToHands")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(HeldItemInPlacementZone), Member = "ResetGravity")]
	public static void SetGravity(GameObject go, bool useGravity)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(StoneItem), Member = "Throw")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Toggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "CanTransitionToState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Throw(GearItem gi, PlayerAnimation.OnAnimationEvent throwCompleteCallback = null)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass781_0), Member = "<Throw>b__0")]
	[Calls(Type = typeof(Rigidbody), Member = "set_drag")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularDrag")]
	[Calls(Type = typeof(StoneItem), Member = "SetThrown")]
	[Calls(Type = typeof(Utils), Member = "SetIsKinematic")]
	[Calls(Type = typeof(TorchItem), Member = "DisableRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetFPSItem")]
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

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeAdjustShotPositionForNearShot")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Drop")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseThrownObject")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "set_m_ItemInHands")]
	[Calls(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromItemData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	private GameObject ReleaseFromHands(GameObject go)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private GearItem InstantiateCopyOfThrownObject(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemToPlacementZone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	[Calls(Type = typeof(PlayerManager), Member = "TurnLightOffImmediate")]
	[Calls(Type = typeof(GearItem), Member = "Clone")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DropLitItemInHand")]
	private void MaybeDuplicateItemBeforeDrop(DropLitItemsOptions options)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ReleaseFromHands")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public static Vector3 MaybeAdjustShotPositionForNearShot(Vector3 emissionPos, Vector3 firePos, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private static Vector3 AdjustNearShotFirePosition(RaycastHit hit, Vector3 testDir)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float GetNearDistanceShot(Vector3 weaponSpaceEmissionPosition)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	public PlayerManager()
	{
	}
}
