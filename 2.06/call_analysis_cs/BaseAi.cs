using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class BaseAi : MonoBehaviour
{
	public delegate void OnAnimationEvent();

	public enum AnimationCallbackEvent
	{
		DoNothing = 0,
		MooseButtHeadAttackComplete = 1,
		Play_MauledMuffle = 4,
		Stop_MauledMuffle = 5,
		SpearStruggleComplete = 6,
		SpearDisengageReady = 7,
		PassingAttackChomp = 8,
		HowlComplete = 9
	}

	private class AnimationEventDictionary : Dictionary<AnimationCallbackEvent, OnAnimationEvent>
	{
		private class EqualityComparer : IEqualityComparer<AnimationCallbackEvent>
		{
			public static readonly EqualityComparer Default;

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			private EqualityComparer()
			{
			}

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return default(bool);
			}

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public int GetHashCode(AnimationCallbackEvent x)
			{
				return default(int);
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public AnimationEventDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}

	public enum SetupDamageParamsOptions
	{
		None,
		PlayTrigger
	}

	private enum Foot
	{
		Front = 0,
		Back = 2,
		Left = 1,
		Right = 0,
		FrontLeft = 1,
		FrontRight = 0,
		BackLeft = 3,
		BackRight = 2
	}

	private struct FootstepInfo
	{
		public readonly Action<RaycastHit> m_OnRaycastComplete;

		public readonly string m_BoneName;

		public Transform m_Bone;

		public uint m_AudioId;

		public int m_Count;

		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		public FootstepInfo(string boneName, Action<RaycastHit> onRaycastComplete)
		{
		}
	}

	private delegate bool HoldGroundCallback(float radius);

	public enum DamageSide
	{
		DamageSideNone = -1,
		DamageSideLeft,
		DamageSideRight
	}

	public enum AiFleeReason
	{
		Default,
		ThrownStone,
		UnreachableTarget,
		Spear,
		SpearDespawn,
		AfterPassingAttack,
		PackMorale,
		WeaponAim,
		AfterHoldGround,
		PackDisband,
		NoiseMaker,
		FleeTriggerVolume
	}

	public enum WaypointCompletionBehaviouir
	{
		CheckSpawnRegion,
		Restart,
		ChangeState
	}

	private enum State
	{
		Pathfinding,
		Blending,
		Finished
	}

	private enum HoldGroundReason
	{
		None,
		RedFlare,
		Torch,
		SafeHaven,
		NearbyAuroraField,
		InsideAuroraField,
		Spear,
		Fire,
		BlueFlare,
		BlueFlareOnGround,
		RedFlareOnGround,
		TorchOnGround
	}

	public enum FindGroundType
	{
		FirstTime,
		Pathing
	}

	public class PointOfInterest
	{
		public Vector3 m_Location;

		public PointOfInterestAnim m_AnimToPlay;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PointOfInterest()
		{
		}
	}

	public enum PointOfInterestAnim
	{
		Feed,
		SniffAir,
		SniffGround,
		Random
	}

	public bool m_UseAiming;

	public float m_AimingWeight;

	public Transform m_LeftHandTarget;

	public Transform m_RightHandTarget;

	public bool m_UseAimingElboHints;

	public Transform m_LeftElboHint;

	public Transform m_RightElboHint;

	public GameObject m_Weapon;

	public Transform m_AimJoint;

	public float m_WeaponDistanceFromHead;

	public float m_MaxYawAngle;

	public RandomId[] m_RandomIds;

	public string m_FrontLeftBone;

	public string m_FrontRightBone;

	public string m_BackLeftBone;

	public string m_BackRightBone;

	public SnowImprintType m_SnowImprintType;

	public GameObject m_SpeedFromMecanimBone;

	public bool m_SpeedForPathfindingOverride;

	public float m_OverrideSpeed;

	public GameObject m_GameObject_Mouth;

	public GameObject m_BreathEffectPrefab;

	private GameObject m_BreathEffect;

	public BoxCollider m_LeftFallingSideCollider;

	public BoxCollider m_RightFallingSideCollider;

	private int m_FallingSideLayerMask;

	private Collider[] m_FallingSideHits;

	private FootstepTrail m_FootstepTrail;

	private bool m_LastFootstepResult;

	private int m_NextRecentFootPrintIndex;

	private Vector3[] m_RecentFootPrints;

	private float m_NextRandomIdTime;

	private RandomId m_ActiveRandomId;

	private Vector3 m_PreviousForward;

	private float m_turnSpeed;

	private float m_NextUpdateStandingOnMaterialTag;

	private bool m_CanPlayTurn;

	private bool m_CanPlayPitchRoll;

	private bool m_CanPlayTarget;

	public Vector3 m_TurnHeading;

	public float m_TotalTurnAngle;

	public int m_AnimParameter_ActualSpeed;

	public int m_AnimParameter_AiState;

	public int m_AnimParameter_Attack_Trigger;

	public int m_AnimParameter_AttackId;

	public int m_AnimParameter_Corpse;

	public int m_AnimParameter_Dead;

	public int m_AnimParameter_ExitAttack;

	public int m_AnimParameter_Flinch_Trigger;

	public int m_AnimParameter_Howl_Trigger;

	public int m_AnimParameter_Pitch;

	public int m_AnimParameter_RandomId;

	public int m_AnimParameter_RandomId_Trigger;

	public int m_AnimParameter_Roar_Trigger;

	public int m_AnimParameter_Roll;

	public int m_AnimParameter_Sleep;

	public int m_AnimParameter_SniffAir;

	public int m_AnimParameter_SniffGround;

	public int m_AnimParameter_Speed;

	public int m_AnimParameter_StruggleStart;

	public int m_AnimParameter_Hunted2StruggleStart;

	public int m_AnimParameter_StruggleEnd;

	public int m_AnimParameter_TargetHeading;

	public int m_AnimParameter_TargetHeadingSmooth;

	public int m_AnimParameter_TurnAngle;

	public int m_AnimParameter_TurnSpeed;

	public int m_AnimParameter_WanderPauseId;

	public int m_AnimParameter_TapMeter;

	public int m_AnimParameter_StruggleHeight;

	public int m_AnimParameter_Wounded;

	public int m_AnimParameter_IsOnHindLegs;

	public int m_AnimParameter_PropIsRifleRack;

	public int m_AnimParameter_PropIsChair;

	public int m_AnimParameter_IsAiming;

	public int m_AnimParameter_Stunned;

	public int m_AnimParameter_Stunned_Trigger;

	public int m_AnimParameter_MooseStomp_Trigger;

	public int m_AnimParameter_IsInjured;

	public int m_AnimParameter_DamageImpact_Trigger;

	public int m_AnimParameter_DamageBodyPart;

	public int m_AnimParameter_DamageSide;

	public int m_AnimParameter_Trigger_Spear_Struggle_Entry;

	public int m_AnimParameter_Trigger_Spear_Exit_Success;

	public int m_AnimParameter_Trigger_Spear_Exit_Fail;

	public int m_AnimParameter_Trigger_Spear_Exit_Success_Death;

	public int m_AnimParameter_WeaponId;

	public int m_AnimParameter_Trigger_PassingAttack;

	public int m_AnimParameter_Trigger_PassingAttackNpc;

	public int m_AnimParameter_PassingAttackSide;

	public int m_AnimParameter_MoveAgent_DeltaYawAnglePerFrame;

	public int m_AnimParameter_MoveAgent_DeltaHeadAnglePerFrame;

	public int m_AnimParameter_Trigger_Timberwolf_Attack;

	public int m_AnimState_Howl;

	public bool m_AttachToPlayer;

	public float m_AttachBlendInTime;

	public float m_AttachBlendOutTime;

	public static bool s_ManualFrustumCullingEnabled;

	private float m_AnimParameter_Wounded_LastSent;

	private AnimationEventDictionary m_AnimationEventDictionary;

	private DamageSide m_LastDamageSide;

	private int m_LastDamageBodyPart;

	public int m_LastWanderPause;

	private bool m_ImposterAnimatorDisabled;

	private AnimatorCullingMode m_ImposterCullingMode;

	private bool m_RenderersEnabled;

	private FootstepInfo[] m_FootstepInfo;

	public float m_RangeMeleeAttack;

	public float m_RangeMeleeAttackSmallAnimal;

	public float m_RangeMeleeAttackLargeAnimal;

	public float m_PassingAttackRange;

	public float m_PassingAttackRangeNpc;

	public float m_MeleeAttackDamage;

	public float m_AttackChanceAfterNearMissGunshot;

	public float m_AttackChanceAfterNearMissRevolverShot;

	public GameplayTag m_DamageEventTableTag;

	public float m_MinDistanceToKeepWithSafeHaven;

	public float m_MinDistanceToHoldFromInnerRadius;

	public float m_ExtraMarginForStopInField;

	public float m_OuterDistanceFromField;

	public float m_SpeedLimitAtOuterRadius;

	public bool m_UseSlowdownForHold;

	public static bool m_AllowSlowdownForHold;

	public float m_BearAttackAnimationTime;

	public float m_TimberwolfAttackAnimationTime;

	private bool m_PlayingAttackStartAnimation;

	private bool m_PlayedAttackStartAnimation;

	private bool m_BearHuntDoneInitialAttack;

	private float m_NextAllowedAttackDamageTime;

	private bool m_SuppressAttackStartAnimation;

	private bool m_IgnoreFlaresAndFireWhenAttacking;

	private uint m_AttackingLoopAudioID;

	private float m_SpeedWhileStopping;

	private Vector3 m_AdjustedTargetPosition;

	private Vector3 m_DirectionToPlayerWhenSpearDetected;

	private float m_SpeedBeforeStopping;

	private float m_CurrentRadius;

	private bool m_HasBeenInsideField;

	private bool m_HasBeenInNearbyField;

	private List<float> m_LastSlopeUnderPositionList;

	private int m_LastPositionsSize;

	private Vector3 m_EnterAttackPosition;

	private bool m_SpearRaisedTooLate;

	private Vector3 m_LastKnownAttackTargetPosition;

	private bool m_DoPassingAttack;

	private float m_AnimationTime;

	public GameObject m_CarcassPrefab;

	public string m_DisplayName;

	public AiMode m_StartMode;

	public AiMode m_DefaultMode;

	public AiType m_AiType;

	public AiSubType m_AiSubType;

	public AiDifficulty m_AiDifficulty;

	public WildlifeMode m_WildlifeMode;

	public float m_CurrentHP;

	public float m_MaxHP;

	public bool m_Invulnerable;

	public float m_WalkSpeed;

	public float m_StalkSpeed;

	public float m_StalkCatchUpSpeed;

	public float m_StalkSlowlySpeed;

	public float m_ChasePlayerSpeed;

	public float m_RunSpeed;

	public float m_RetreatSpeed;

	public float m_TurnSpeedDegreesPerSecond;

	public string m_EnterStalkingAudio;

	public string m_EnterAttackModeAudio;

	public string m_EnterFleeModeAudio;

	public string m_HoldGroundAudio;

	public string m_FeedingAudio;

	public string m_SleepingAudio;

	public string m_StalkingAudio;

	public string m_StruggleAudio;

	public string m_ChasingAudio;

	public string m_IdleAudio;

	public string m_WanderAudio;

	public string m_HideAndSeekAudio;

	public string m_JoinPackAudio;

	public float m_ImposterDistanceOnScreen;

	public float m_ImposterDistanceOffScreen;

	public bool m_IgnoreCriticalHits;

	public bool m_OverrideXPModeAttackRestrictions;

	public bool m_ScriptedSequenceInterruptible;

	public float m_LostPathFleeDistance;

	public float m_CantReachTargetStandoffDistance;

	public float m_ModelRollScalePercent;

	public float m_ModelRollLimitDegrees;

	public float m_ModelRollFootPenetrationPercent;

	public float m_ModelRollFootPenetrationLimitMeters;

	public float m_NavMeshToTerrainSlopeOffset;

	public float m_NavMeshToTerrainOffsetFudgeFactor;

	public Vector3 m_HeadOffset;

	public AiTarget m_CurrentTarget;

	public Transform m_CachedTransform;

	public AiDifficultySetting m_AiDifficultySetting;

	public AiWolf m_AiWolf;

	public AiBear m_AiBear;

	public AiStag m_AiStag;

	public AiMoose m_AiMoose;

	public AiRabbit m_AiRabbit;

	public Animator m_Animator;

	public CharacterController m_CharacterController;

	public BodyHarvest m_BodyHarvest;

	public PackAnimal m_PackAnimal;

	public HuntedPart2WaypointController m_HuntedPart2WaypointController;

	public BearHuntAiRedux m_BearHuntAiRedux;

	public Vector3 m_SpawnPos;

	public string m_ScriptedSequenceAnimTrigger;

	private bool m_Imposter;

	public string m_MissionIdSerialized;

	private AiMode m_CurrentMode;

	private AiMode m_PreviousMode;

	private float m_TimeInModeSeconds;

	private float m_TimeInModeTODHours;

	private SpawnRegion m_SpawnRegionParent;

	private AiTarget m_AiTarget;

	private float m_AiGoalSpeed;

	private bool m_FirstFrame;

	private int m_StickToGroundCollisionLayerMask;

	private bool m_StartHasBeenCalled;

	private AuroraObjectMaterials m_AuroraObjectMaterials;

	private static BaseAiDataProxy m_BaseAiDataProxy;

	private float m_TorsoHalfWidth;

	public NavMeshAgent m_NavMeshAgentPrefab;

	private NavMeshAgent m_NavMeshAgent;

	private MoveAgent m_MoveAgent;

	private BaseAiData m_DeferredDeserializeData;

	private bool m_RequiresDeferredDeserialize;

	private EmitterProxy m_EmitterProxy;

	private SkinnedMeshRenderer[] m_Renderers;

	private const float VIEWPORT_SCALE_ADJUSTMENT = 0.02f;

	public float m_NumSecondsToReachMaxWoundedLocomotion;

	public int m_ChanceToFleeFromUnseenAttack;

	public float m_ElapsedBleedingOutMinutes;

	public float m_ElapsedWoundedMinutes;

	public bool m_Wounded;

	public float m_BleedOutTimeMinutesForFleeFromTriggerVolume;

	private bool m_BleedingOut;

	private float m_DeathAfterBleeingOutMinutes;

	private BloodTrail m_BloodTrail;

	private DamageSource m_DamageSource;

	public float m_DistanceToSpawnCarcassSite;

	public bool m_ForceToCorpse;

	private float m_EnableContainerTime;

	private float m_TimeInDeadMode;

	private bool m_EnableColliderOnDeath;

	private GUIStyle style;

	public float m_DetectionRange;

	public float m_DetectionFOV;

	public float m_HearFootstepsRange;

	public float m_HearRifleRange;

	public float m_HearCarAlarmRange;

	public float m_SmellRange;

	public float m_DetectionDelayAfterSpearHitSeconds;

	public float m_RangeFromScentFactor;

	public float m_RangeFromScentMax;

	public float m_MaxSurvivorDistanceToPlayerForTargetting;

	private float m_SuppressFootStepDetectionAndSmellSecondsRemaining;

	private float m_TimeLastFootstepHeard;

	private float m_TimeForNextTargetScan;

	public bool m_DisableScanForTargets;

	private float m_RestoreTargetAfterSpearTimerSeconds;

	private bool m_WasHitBySpear;

	private bool m_WasHitBySpearFatal;

	private Action m_SpearStruggleEndAction;

	private bool m_RestoreTargetAfterSpearTimerStarted;

	private NavMeshObstacle m_DodgeObstacle;

	private float m_DodgeTimeoutSeconds;

	private float m_DodgeObstacleRadius;

	private float m_DodgeObstaclePlacementMinOffset;

	private float m_DodgeObstaclePlacementOffsetSeconds;

	private float m_DodgeObstacleMinDistanceFromPlayer;

	private float m_DodgePlayerFacingAngleThreshold;

	private float m_DodgeMaxDistance;

	private float m_DodgeTimeoutTime;

	private float m_DodgePlayerFacingAngleCos;

	private float m_LastDodgePlayerFacingAngle;

	public float m_DetectionRangeWhileFeeding;

	public float m_HearFootstepsRangeWhileFeeding;

	public float m_HearFootstepsRangeWhileSleeping;

	public float m_FeedingHoursMin;

	public float m_FeedingHoursMax;

	public float m_MeatConsumedPerHourKG;

	public GameObject m_FeedingBone;

	private uint m_FeedingAudioID;

	private float m_FeedingDurationHours;

	private BodyHarvest m_TargetBodyHarvest;

	private BaseAi m_TargetBaseAi;

	private float m_ElapsedFeedingHoursToApplyAfterLoad;

	private bool m_FakeFeeding;

	private Vector3 m_FakeFeedingPos;

	private bool m_DidStopAudio;

	public BaseAi m_GroupFleeLeader;

	public int m_FleeChanceWhenTargetDetected;

	public int m_FleeFromFlareBounceDistance;

	public int m_FleeFromTorchBounceDistance;

	public int m_FleeFromStoneBounceDistance;

	public int m_FleeFromArrowImpactDistance;

	public int m_FleeFromFlareGunRoundImpactDistance;

	public int m_ChanceFleeTorchSwing;

	public int m_ChanceFleeBrandSwing;

	public int m_ChanceFleeFlareSwing;

	public int m_ChanceToFleeFromThrownTorch;

	public int m_ChanceToFleeFromThrownFlare;

	public int m_ChanceToFleeFromThrownStone;

	public int m_ChanceToFleeWhenHitByStone;

	public int m_ChanceToFleeFromThrownNoiseMaker;

	public int m_DistanceForDesperationAttack;

	public float m_StopFleeAfterDistance;

	public float m_StopFleeAfterDistanceForStone;

	public float m_StopFleeAfterDistanceForSpear;

	public float m_StopFleeAfterDistanceWhenBleedingOut;

	public float m_StopFleeAfterPassingAttackDistance;

	public float m_StopFleeAfterPackMoraleDistance;

	public float m_StopFleeAfterWeaponAimDistance;

	public float m_StopFleeAfterHoldGroundDistance;

	public float m_StopFleeAfterPackDisbandDistance;

	public float m_MinimumFleeTime;

	public float m_MinimumFleeTimeForStone;

	public bool m_SuppressFleeAudio;

	public bool m_UseRetreatSpeedInFlee;

	public float m_GroupFleeDetectRange;

	public float m_GroupFleeRepeatDetectSeconds;

	public string m_PlayerKnockdownSFX;

	public Vector3 m_FleeFromPos;

	private const float KNOCKDOWN_RADIUS = 2f;

	private const float GROUP_FLEE_EXIT_SECONDS_MIN = 0.5f;

	private const float GROUP_FLEE_EXIT_SECONDS_MAX = 1.5f;

	private const float TIME_TO_START_FLEEING = 1f;

	private const float SECONDS_BEFORE_AUTO_FLEE_TO_SPAWN = 10f;

	private const float AUTO_FLEE_TO_SPAWN_MAX_DISTANCE_FROM_FLEEPOS = 30f;

	private const float AUTO_FLEE_TO_SPAWN_MIN_DISTANCE_FROM_SPAWN = 5f;

	private Vector3 m_FleeToPos;

	private bool m_PickedFleeDestination;

	private bool m_HasPickedForcedFleePos;

	private float m_FleeingForSeconds;

	private float m_FleeingForSecondsSinceLastFleeToSpawnPos;

	private float m_WarnOthersTimer;

	private List<BaseAi> m_GroupFleeFollowers;

	private bool m_HasFoundFirstFleePoint;

	private float[] m_FleeAngleDegreesToTry;

	private int m_FleeAngleIndexToTry;

	private int m_NumAnglesToTryPerFrame;

	private bool m_ExitGroupFleeTimerStarted;

	private float m_ExitGroupFleeTimerSeconds;

	private bool m_UseForcedFleePos;

	private Vector3 m_ForcedFleePos;

	private AiFleeReason m_FleeReason;

	private AreaMarkup m_FleeMarkup;

	private uint m_FleeAudioId;

	public Vector3[] m_Waypoints;

	private int m_TargetWaypointIndex;

	private bool m_HasEnteredFollowWaypoints;

	public WaypointCompletionBehaviouir m_WaypointCompletionBehaviour;

	public AiMode m_WaypointCompleteNextState;

	private Vector3 m_GoToPoint;

	private AiMode m_TargetMode;

	public AiMarker m_AiMarker;

	private bool m_BlendToPoint;

	private float m_GotoPointMovementSpeed;

	private State m_State;

	public bool m_UseHeadLookat;

	public float m_LookWeightHead;

	public float m_LookWeightEyes;

	public float m_LookWeightBody;

	public float m_LookWeightClamp;

	public float m_LookAtDistance;

	private float m_LookWeightMaster;

	public float m_HoldGroundDistance;

	public float m_MinFollowDistance;

	public float m_ComfortableFollowDistance;

	public float m_MaxFollowDistance;

	public float m_HideAndSeekStalkingSpeed;

	public float m_HideAndSeekCirclingSpeed;

	public float m_HideAndSeekRetreatingSpeed;

	public float m_RetreatDistance;

	public float m_CirclingDistance;

	public float m_RetreatPositionMinRadius;

	public float m_RetreatPositionMaxRadius;

	public float m_ChangeDistanceThreshold;

	public float m_HighGroundSearchRadius;

	public float m_PackSeperationDistance;

	public float m_SneakAmbushTime;

	public float m_PassingAttackChance;

	public float m_PassingAttackCameraShakeForce;

	public float m_PassingAttackCameraRollForce;

	public float m_HideAndSeekCooldownTime;

	public float m_MinNewPathCooldownTimeSeconds;

	public float m_MaxNewPathCooldownTimeSeconds;

	public float m_RepathApproachTimeSeconds;

	public float m_HighGroundClosingDistancePercent;

	public bool m_ShouldAlwaysPerformPassingAttack;

	private uint m_HideAndSeekAudioId;

	private bool m_IsRetreating;

	private float m_SneakApproach;

	private float m_SneakAmbushTimer;

	private float m_ClosingDistancePercent;

	private float m_EnterHideAndSeekCooldownTime;

	private float m_NewPathCooldownTimer;

	private AiTarget m_PlayerTarget;

	public float m_FightOrFlightRange;

	public float m_ChanceAttackFightOrFlight;

	public float m_InvestigateAfterHoldDelaySecondsForSafeHaven;

	public float m_HoldGroundMinimumDelaySeconds;

	public float m_HoldGroundCooldownSeconds;

	public float m_HoldForFieldMinimumDelaySeconds;

	public float m_FleeAfterHoldDelaySecondsForAuroraField;

	public float m_ChanceAttackOnSpearTimeout;

	public float m_HoldGroundSpearTimeoutGametimeMins;

	public float m_HoldGroundDistanceFromSpear;

	public float m_HoldGroundOuterDistanceFromSpear;

	public float m_ChanceAttackOnBlueFlareTimeout;

	public float m_HoldGroundBlueFlareTimeoutGametimeMins;

	public float m_HoldGroundDistanceFromBlueFlare;

	public float m_HoldGroundOuterDistanceFromBlueFlare;

	public float m_HoldGroundDistanceFromBlueFlareOnGround;

	public float m_HoldGroundOuterDistanceFromBlueFlareOnGround;

	public float m_ChanceAttackOnFireTimeout;

	public float m_HoldGroundFireTimeoutGametimeMins;

	public float m_HoldGroundDistanceFromFire;

	public float m_HoldGroundOuterDistanceFromFire;

	public float m_ChanceAttackOnFlareTimeout;

	public float m_HoldGroundFlareTimeoutGametimeMins;

	public float m_HoldGroundDistanceFromFlare;

	public float m_HoldGroundOuterDistanceFromFlare;

	public float m_HoldGroundDistanceFromFlareOnGround;

	public float m_HoldGroundOuterDistanceFromFlareOnGround;

	public float m_ChanceAttackOnTorchTimeout;

	public float m_HoldGroundTorchTimeoutGametimeMins;

	public float m_HoldGroundDistanceFromTorch;

	public float m_HoldGroundOuterDistanceFromTorch;

	public float m_HoldGroundDistanceFromTorchOnGround;

	public float m_HoldGroundOuterDistanceFromTorchOnGround;

	private uint m_HoldGroundAudioID;

	private float m_TimeToStopHoldingGroundDueToSpear;

	private float m_TimeToStopHoldingGroundDueToFire;

	private float m_TimeToStopHoldingGroundDueToFlare;

	private float m_TimeToStopHoldingGroundDueToTorch;

	private float m_TimeToStopHoldingGroundDueToSafeHaven;

	private float m_TimeToStopHoldingGroundDueToBlueFlare;

	private bool m_WasHoldingForField;

	private AuroraField m_PlayerSafeHaven;

	private AuroraField m_ContainingAuroraField;

	private float m_TimeToStopHoldingGroundDueToAuroraField;

	private float m_LastTimeWasHoldingGround;

	private HoldGroundReason m_HoldGroundReason;

	private bool m_DelayStopHoldGroundTimers;

	public float m_HowlResponseMinSeconds;

	public float m_HowlResponseMaxSeconds;

	private float m_HowlStartDelay;

	private AiMode m_PostHowlState;

	private uint m_IdleAudioId;

	public Vector3 m_InvestigatePos;

	private bool m_InvestigatePathStarted;

	private const float m_InvestigationRadiusAroundAuroraField = 15f;

	private bool m_ForceInvestigatePos;

	public GameObject m_InvestigateFoodObject;

	public float m_InvestigateFoodEatDistance;

	public float m_InvestigateFoodAvoidFireDistance;

	public float m_InvestigateFoodAvoidTargetDistance;

	public AiTarget m_SmellTarget;

	public float m_MinSmellDistance;

	private float m_TimeNextCheckForSmells;

	private bool m_HasInvestigateSmellPath;

	private Vector3 m_PathingToSmellTargetPos;

	public float m_PackJoinTimeSeconds;

	public float m_PackSkipJoinStateWhenTargetNearbyDistance;

	private uint m_JoinPackAudioId;

	private float m_JoinTimer;

	private bool m_RequestedHowl;

	public GameplayTag m_PassingAttackDamageEventTableTag;

	public float m_PassingAttackAnimTimeout;

	private bool m_TriggeredPassingAttackAnim;

	private float m_PassingAttackAnimTimer;

	private bool m_HasPassingAttackDamageFired;

	private GameObject m_PathTargetTransform;

	private Vector3 m_CurrentGroundNormal;

	private float m_LastPositionY;

	private bool m_OrientOnDead;

	private int m_JobGroundRaycastId;

	public float m_GroundTestRadius;

	public const float RAYCASTGROUNDOFFSET = 2.75f;

	public const float RAYCASTGROUNDOFFSETPATHING = 2f;

	private List<PointOfInterest> m_ActivePointsOfInterest;

	private int m_TargetPointOfInterestIndex;

	private bool m_HasEnteredPatrolPointsOfInterest;

	private bool m_RandomizePointsOfInterest;

	private bool m_IsAnimatingAtPointOfInterest;

	private float m_DurationAtPointOfInterestSeconds;

	private float m_ElapsedTimeAtPointOfInterestSeconds;

	private ScratchingStump m_SelectedStump;

	private Vector3 m_ScratchingPos;

	private const int m_AnimScratchingWanderPauseId = 10;

	private bool m_HasApproachedStump;

	public float m_SleepTimeHours;

	private uint m_SleepingLoopAudioID;

	private float m_ExitSleepModeTime;

	private bool m_Awake;

	public float m_CuriousFollowDistance;

	public float m_CuriousClosestApproachDistance;

	public float m_CuriousLoseInterestChance;

	public float m_CuriousEnterStalkingChance;

	public float m_CuriousRollChangeIntervalMinutes;

	public float m_MaxPlayerApproachDistanceToInvestigateFood;

	public float m_StalkingFollowDistance;

	public float m_StaklingFollowDistanceDecreasePerMinute;

	public float m_StalkingBeginChasingDistance;

	public float m_StalkingBeginChasingWeakTargetDistance;

	public float m_StalkingLoseInterestIntervalMinutes;

	public float m_StalkingLoseInterestChance;

	public float m_BreakSlalkingRange;

	public float m_BreakStalkingTimeSeconds;

	public int m_StalkingChanceWhenTargetDetected;

	public float m_ForceStalkPlayerDistance;

	private uint m_StalkingAudioID;

	private uint m_StalkingLoopAudioID;

	private float m_LostScentTimeSeconds;

	private float m_CurrentStalkingFollowDistance;

	private float m_StalkingPausedUntilTime;

	private float m_TimeToRandomizeStalkingDestination;

	private Vector3 m_StalkingDestination;

	private float m_NextLoseInterestCheckHoursPlayed;

	private bool m_ForceChasePlayerSpeed;

	private bool m_Curious;

	private float m_NextCuriousChangeStateCheckHoursPlayed;

	public static bool s_ForceHuntedStruggleAnim;

	public static bool s_ShouldForceHuntedStruggleDraggingRotation;

	public static float s_ForceHuntedStruggleDraggingFacing;

	public static float s_ForceHuntedStruggleDraggingRoll;

	public float m_IgnoreFootStepsAndSmellsAfterStruggleSeconds;

	public bool m_UseWanderDestinationAfterStruggle;

	public Vector3 m_WanderDestinationAfterStruggle;

	public string m_PlayMauledMuffleAudioId;

	public string m_StopMauledMuffleAudioId;

	public float m_AfterStruggleTimePassStunnedSeconds;

	private uint m_StuggleAudioId;

	private int m_SpearStruggleTapCount;

	private bool m_HasEnteredStruggleOnLastAttack;

	public int m_ChanceStunFromThrownStone;

	public float m_StunSeconds;

	private float m_StunStartTime;

	private Vector3 m_StunPosition;

	public float m_WanderPauseAfterSecondsMin;

	public float m_WanderPauseAfterSecondsMax;

	public bool m_WanderUseTurnRadius;

	public float m_WanderTurnRadius;

	public float m_WanderTurnSegmentAngle;

	public float m_WanderTurnSpeedDegreesPerSecond;

	private bool m_PickedWanderDestination;

	private float m_ElapsedWanderHours;

	private float m_WanderDurationHours;

	private WanderRegion m_WanderRegion;

	private Vector3 m_WanderAroundPos;

	private float m_WanderAroundPosRadius;

	private bool m_WanderingAroundPos;

	private float m_NextCheckMovedDistanceTime;

	private Vector3 m_PositionAtLastMoveCheck;

	private Vector3 m_CurrentWanderPos;

	private int m_WanderCurrentTarget;

	private Vector3[] m_WanderTurnTargets;

	private bool m_UseWanderAwayFromPos;

	private Vector3 m_WanderAwayFromPos;

	private bool m_UseWanderToPos;

	private Vector3 m_WanderToPos;

	private bool m_IsGettingAwayFromAuroraField;

	private float m_NextStumpVisitTimeHours;

	private uint m_WanderAudioId;

	public float m_ChanceIdlePauseWhenWandering;

	public int m_NumWanderPauseAnims;

	private float m_TimeNextWanderPause;

	private int m_ForceWanderPauseId;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateAiming()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void UpdateAimingIk()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	private AvatarIKHint GetHintForGoal(AvatarIKGoal avatarIKGoal)
	{
		return default(AvatarIKHint);
	}

	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	private void SetIkInfo(AvatarIKGoal avatarIKGoal, Transform target, Transform hint, float weight, bool useHint)
	{
	}

	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CallsUnknownMethods(Count = 118)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 67)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	public void Start_Anim()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void UpdateAnim()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	private void UpdateImposterAnimatorCulling()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[CallerCount(Count = 0)]
	public void SetIsOnScreen(bool isOnScreen)
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetIsOnScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	private void EnableSkinnedMeshRenderers(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 26)]
	public void AnimSetTrigger(int id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AnimSetBool(int id, bool value)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaHeadAngleParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaYawAngleParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallerCount(Count = 19)]
	public void AnimSetFloat(int id, float value)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AnimSetFloat(int id, float value, float dampTime, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetRandomFeedingAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	public void AnimSetInt(int id, int value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	public void AnimSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyeWeigth, float clampWeight)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AnimSetLookAtPosition(Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void AnimSetBearSpearTrigger(BearSpearStruggleOutcome outcome)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[Calls(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetTurnAngleParameters")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiStateParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	public void SetAnimationParameters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	public void SetDeltaYawAngleParameter(float deltaAngle)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallerCount(Count = 0)]
	public void SetDeltaHeadAngleParameter(float deltaAngle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void SetSpeedForPathfindingSystem()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void OnIgnoreGlowPitch(int value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnIsOnHindLegs(int value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	public void OnBreathEffect()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[CallerCount(Count = 0)]
	public void OnFootStepFrontLeft(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	public void OnFootStepFrontRight(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public void OnFootStepBackLeft(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public void OnFootStepBackRight(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomId")]
	public void OnGetRandomId()
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerAttach(float blendTime)
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerDetach(float blendTime)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void AnimationEndSniff()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void AnimationEndWanderPause()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	public void ResetWeapon()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	private void HandleFootprintsForDespawn()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void HandleFootprint(string audioEvent, Foot foot)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	private void PlaceFootPrintDecal(Foot foot)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 0)]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontLeft(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 0)]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontRight(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 0)]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackLeft(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 0)]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackRight(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontLeft")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, Foot foot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldPlaceFootPrintDecal()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	private void PlayFootStepAudio(string audioEventName, Foot foot)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateActiveRandomId")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void SetNextRandomIdTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void UpdateActiveRandomId()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnGetRandomId")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[CallerCount(Count = 1)]
	private void GetRandomId()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetSpeedAnimationParameter()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	private void SetTurnSpeedAnimationParameter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 4)]
	public static void SetTurnAngleParameters(Animator animator, float totalTurnAngle, float turnSpeed, Vector3 turnHeading, Vector3 forward, int turnAngleParam)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetTargetHeadingParameter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 0)]
	private float GetFlattenedAngle(Vector3 inVec)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void SetPitchRollParameters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CallerCount(Count = 0)]
	private void SetAnimStateForMoveAgent(MoveState moveState, int animState)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void SetAiStateParameter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	private void SetWoundedParameter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeUpdateStandingOnMaterialTag()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool PositionOverlapsRecentFootprints(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallsUnknownMethods(Count = 2)]
	private void SetCullModeAlways()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ResetDefaultCullmode()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	private void SetDamageImpactParameter(DamageSide side, int bodyPart, SetupDamageParamsOptions setupDamageParamsOptions)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool CanFallToSide(DamageSide side)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetSpeedFromMecanimBone()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "SetCullModeAlways")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnterAttack()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ExitAttack()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	public void StopAttackAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceMode), Member = "GetDamageEventTable")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private static DamageEventTable GetDamageEventsForTag(GameplayTag tag)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageEventsForTag")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	private DamageEventTable GetAttackDamageEvents()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	private void MaybeAdjustTargetPosition(Vector3 targetPosition)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 GetPositionForHold(Vector3 targetPosition, float radius)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private float GetAverageSlope()
	{
		return default(float);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CallerCount(Count = 1)]
	private bool MaybeFleeOnSlope()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void MaybeSpearAttackTooLate()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	public void ProcessAttack()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetCurrentRadiusToHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CallsUnknownMethods(Count = 6)]
	private Vector3 GetCurrentHoldGroundCausePosition(HoldGroundReason reason)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[Calls(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	public void MaybeApplyAttack()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	public float GetModifiedAttackChance(float baseAttackChance)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void AttackStartAnimationDone()
	{
	}

	[CallerCount(Count = 0)]
	public void SuppressAttackStartAnimation()
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public bool AttackOrFleeAfterNearMissGunshot(GunType gt)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	public bool EnterAttackModeIfPossible(Vector3 attackPos, bool suppressAttackStartAnimation)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanBeHitBySpear()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private bool ShouldPlayBearAttackStartAnimation()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldPlayTimberwolfAttackStartAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void PlayMeleeAttackAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateAttackingAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private int GetAttackLineOfSightLayerMask()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float GetSpeedForCurrentRadius(float initialSpeed, float initialRadius, float currentRadius, float innerRadius)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void UpdateSpeedForHoldWithSlowdown()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetOuterRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "IsScaredReason")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	private float GetInnerRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	private bool UpdateForHoldWithSlowdown()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private bool MaybeHoldGroundForSpearForAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	private bool MaybeHoldGroundForTorchForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool MaybeHoldGroundForRedFlareForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool MaybeHoldGroundForFireForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	private bool MaybeHoldGroundForBlueFlareForAttack()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 10)]
	private bool MaybeHoldGroundForAttack(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	private bool MaybeHoldGroundAuroraFieldForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	private bool MaybeHoldGroundDueToSafeHaven()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHoldGround")]
	private bool ShouldHoldGround()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool MaybeForceHoldGround()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[CallsUnknownMethods(Count = 4)]
	private float GetCurrentRadiusToHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private AuroraField GetVisibleFieldNearby(float radius)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool IsFieldVisible(AuroraField field, float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsScaredReason(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	public bool IsTooScaredToAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	public void OnCarcassPickedUp()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "Copy")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	public GearItem SpawnCarcassPickup()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeSpawnCarcassSiteIfFarEnough()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	public void Start_Common()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	private void ProcessCommonPre()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeCollideWithSpear()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeRestoreTargetAfterSpear()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	private void ProcessCommonPost()
	{
	}

	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	private void MaybeDestroyIfFellThroughWorld()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	public void MovedDistance(Vector3 delta)
	{
	}

	[CallerCount(Count = 47)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void ClearTarget()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ReturnToDefaultBehavior()
	{
	}

	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	private void DebugAiStateTrace(AiMode mode, string locationTag)
	{
	}

	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateImposterAnimatorCulling")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[CalledBy(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeMakeWildlifeFlee")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	public bool IsImposter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasUpdated()
	{
		return default(bool);
	}

	[Calls(Type = typeof(MoveAgent), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CreateMoveAgent(Transform parent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Anim")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(CapsuleCollider), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Pathfinding")]
	[Calls(Type = typeof(BaseAiManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	public void Update()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallerCount(Count = 0)]
	public void SetPosition(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_ai_continuouscollision")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	public void SetCollisionMode(CollisionDetectionMode mode)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsMoveAgentEnabled")]
	public bool IsMoveAgent()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 23)]
	public MoveAgent GetMoveAgent()
	{
		return null;
	}

	[Calls(Type = typeof(BaseAi), Member = "IsMoveAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMoveAgentEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 4)]
	public bool IsPlayerFacingAi()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	public bool IsPlayerFacingAi(Vector3 aiToTarget, float dotProductThreshold)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateHeadTrackingIk")]
	[CallerCount(Count = 0)]
	private void OnAnimatorIK()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	public void DoLateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public bool RequiresDeferredDeserialize()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public BaseAiData GetDeferredDeserializeData()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	public void DeferredDeserialize(BaseAiData bad)
	{
	}

	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Serialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	public static BaseAiDataProxy GetBaseAiDataProxyFromText(string text)
	{
		return null;
	}

	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "Start")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 7)]
	public void DeserializeUsingBaseAiDataProxy(BaseAiDataProxy proxy)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	public void ProcessCurrentAiMode()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsInFlashLight()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	public bool IsTimberwolf()
	{
		return default(bool);
	}

	[CallerCount(Count = 195)]
	[CallAnalysisFailed]
	public void SetAiMode(AiMode mode)
	{
	}

	[CallerCount(Count = 0)]
	public AiMode GetAiMode()
	{
		return default(AiMode);
	}

	[CallerCount(Count = 0)]
	public AiMode GetPreviousAiMode()
	{
		return default(AiMode);
	}

	[CallerCount(Count = 0)]
	public float GetTimeInModeSeconds()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallerCount(Count = 1)]
	public void SetSpawnRegionParent(SpawnRegion sr)
	{
	}

	[CallerCount(Count = 0)]
	public SpawnRegion GetSpawnRegionParent()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	public void EnableAuroraMaterials(bool enable)
	{
	}

	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnCarcassPickedUp")]
	[CalledBy(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "OnDespawn")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	public void Despawn()
	{
	}

	[CallerCount(Count = 0)]
	public float GetGoalSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetTurnSpeedDegreesPerSecond()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetGoalSpeed(float speed)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public void SetSpeedOverride(float speedVal)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public WildlifeMode GetWildlifeMode()
	{
		return default(WildlifeMode);
	}

	[CallerCount(Count = 0)]
	public void SetLastDamageSide(DamageSide side)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DamageSide GetLastDamageSide()
	{
		return default(DamageSide);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDrawGizmos()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAiManager), Member = "Remove")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	private void StopLoopingAudio()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void DoCustomModeModifiers()
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CantReachTarget()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start_Damage()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallerCount(Count = 0)]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void SetupDamageForAnim(Vector3 hitPosition, Vector3 hitSource, LocalizedDamage localizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	public float GetBleedingOutMinutesRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(ToxicFogManager._003C_003Ec), Member = "<MaybeKillAllWildlife>b__42_0")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public void ApplyDamage(float damage, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	public bool IsDamageFatal(float damage, DamageSource damageSource)
	{
		return default(bool);
	}

	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void UpdateWounds(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsBleedingOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	public DamageSource GetDamageSource()
	{
		return default(DamageSource);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AdustMovementSpeedForInjury")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	public float GetWoundedAnimParameter()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	public float AdustMovementSpeedForInjury(float baseSpeed)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ForceApplyDamage()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasDeathAnimationFinished()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeCollisionCapsulesLayer")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 36)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnterDead()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ProcessDead()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	private void HandleAuroraMaterials()
	{
	}

	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ExitDead()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	private void ChangeCollisionCapsulesLayer(int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start_AiDebug()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	public void ProcessAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	public bool CanSeeTarget()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	private float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	public void ScanForNewTarget()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnSpearHit(bool isFatal, Action onSpearStruggleEnd)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	public void ScanForSmells()
	{
	}

	[CallerCount(Count = 0)]
	public void IngoreFootStepsAndSmellsForSeconds(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ChangeModeWhenTargetDetected()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool CanBearSeePlayerAfterSpearStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool TargetCanBeIgnored(AiTarget target)
	{
		return default(bool);
	}

	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private bool IgnoreAudioEvent(GameObject sender, Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ProcessGenericAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ProcessFootstepAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ProcessGunshotAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ProcessCarAlarmAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	private float GetDetectionRange()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float GetHearFootstepsRange()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float GetRangeFromScentIntensity(float scentIntensity)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "SmellLost")]
	[CallsUnknownMethods(Count = 6)]
	private bool CanSmellSource(Vector3 sourcePos, AiTarget target)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	private void SetNextSmellCheckTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 2)]
	private void DoTargetDetectedWhileFeeding()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[CallerCount(Count = 1)]
	private bool ShouldScanForSmells()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool AiModeAllowsForSmellDetection()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool CanDodge()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "DisableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "EnableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "DoesPositionIntefereWithAttacks")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerAThreat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeAttemptDodge()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasDodgePlacementTimedOut()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsPlayerAThreat()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool IsMovingTowardsOrAwayFromPlayer(Vector3 moveDirection, Vector3 playerDirection)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private bool DoesPositionIntefereWithAttacks(Vector3 pos, float radius, Vector3 playerPos)
	{
		return default(bool);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void SetDebugSphere(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 ComputeDodgeObstaclePosition(Vector3 pos, Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	private void DisableDodgeObstacle()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	private void EnableDodgeObstacle(Vector3 pos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsUnknownMethods(Count = 2)]
	public void EnterFeeding()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	public void ExitFeeding()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 0)]
	public void ReturnToFeeding()
	{
	}

	[CallerCount(Count = 0)]
	public void SetFakeFeedingPos(Vector3 pos, float feedingDurationHours = -1f)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ProcessFeeding()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetRandomFeedingAnimation()
	{
	}

	[CallerCount(Count = 0)]
	public BodyHarvest GetTargetBodyHarvest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetFeedingTimeRemainingHours()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	public void StopFeedingAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void DecimateCarcass(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldStopFeeding()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void SetBestFeedingTarget(Vector3 feederPos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	private void ProcessFakeFeeding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void ProcessRealFeeding()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	private void MaybeAttackOrHoldGround()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetFeedingPos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	private void TurnTowardsFeedingPos()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private Vector3 GetFeedingPos()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public void SetFleeReason(AiFleeReason reason)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EnterFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void ExitFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopFleeAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool MaybeHandleTimeoutFleeing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedOverride")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ProcessFlee()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	public void MaybeFleeFromArrow(ArrowItem ai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void SetForcedFleePos(Vector3 pos)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAiModeAllowFleeFromThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(ContactPoint), Member = "get_otherCollider")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	public static void MaybeFleeFromThrownItem(GearItem item, ContactPoint[] contacts)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(ScareTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 5)]
	public bool MaybeFleeFromFlareGunRound(FlareGunRoundItem fgri, float rangeScalar)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayEnterFleeAudio()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceFleeFromHeldItem()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetFleeProximityFromNearbyThrownItem(GearItem item)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceFleeFromNearbyThrownItem(GearItem item, bool wasHit)
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	public void MaybeFleeDueToTorchSwing()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	public bool OverrideXpModeAttackRestrictions()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "IsMismatchWildlifeMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CallerCount(Count = 8)]
	public bool IsMismatchWildlifeMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoTargetDetectedWhileFeeding")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	public bool ShouldAlwaysFleeFromCurrentTarget()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickNewGroupFleeLeader")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void BecomeGroupFleeLeader(List<BaseAi> followerList)
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldIgnoreGroupFleeWarning()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private bool KeepFleeingFromTarget()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetStopFleeAfterDistanceForSpear()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private bool MaybePickFleeDestinationFromAreaMarkup(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	private bool PickFleeDesination(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	private bool CheckFleeAngleIsValid(out Vector3 fleePos, Vector3 fleeVec, Vector3 constraintPos, float angleDegreesToTry)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromArrow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private bool CurrentAiModeAllowFleeFromFlareGunRound()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	private bool CurrentAiModeAllowFleeFromThrownItem(GearItem item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private bool CurrentAiModeAllowFleeFromTorchSwing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeAttackPlayerWhenTryingToFlee()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldPlayEnterFleeAudio()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private void WarnOthersNearby()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void PickNewGroupFleeLeader()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool IsGroupFleeLeader()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool CanKnockdownPlayer(AiSubType ast)
	{
		return default(bool);
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	public void FleeFrom(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void FleeFrom(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterFollowWaypoints()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ExitFollowWaypoints()
	{
	}

	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
	public void SetWaypoints(Vector3[] waypoints)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void ProcessFollowWaypoints()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CallerCount(Count = 0)]
	public void PathfindToCurrentTargetWaypoint()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void TeleportToRandomWaypointAndPathfind()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallerCount(Count = 1)]
	private int GetClosestWaypointIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToCurrentTargetWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	private void PathfindToWaypoint(int waypointIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallerCount(Count = 0)]
	private void PathfindToNextWaypoint()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void HandleLastWaypoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ReachedTargetWaypoint()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void MaybeWander()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallerCount(Count = 0)]
	private bool ProcessSafeFollowWaypoints()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosestWaypointIndex")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafeFollowWaypoints")]
	[CallsUnknownMethods(Count = 1)]
	private void DoEnterFollowWaypoints()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	private void DoReachedTargetWaypointBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void GoToPoint(Vector3 point, AiMode targetMode, float movementSpeed)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_NPC_GoTo_Marker")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void GoToAiMarker(AiMarker aiMarker, AiMode targetMode, float movementSpeed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterGoToPoint()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ExitGoToPoint()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ProcessGoToPoint()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateGoToPointPathfinding()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	private void UpdateGoToPointBlending()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	private void OnGotoPointReached()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateHeadTracking()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	public void UpdateHeadTrackingIk()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceSetPlayerTarget()
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	public bool CanPerformPassingAttackChance()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 0)]
	public bool CanPerformPassingAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void EnterHideAndSeek()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 2)]
	private float GetClosingDistancePercent()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 3)]
	private float GetMinFollowDistance()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	private float GetMaxFollowDistance()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	private float GetComfortableFollowDistance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public bool TriggerPassingAttackAnim()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	public void StopHideAndSeekAudio()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallsUnknownMethods(Count = 10)]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[Calls(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	private Vector3 FindTacticalPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private void ResetApproachDistance()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ProcessHideAndSeek()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetEnterCooldownTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	private void ExitHideAndSeek()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool CanEnterHideAndSeekInternal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	public bool CanEnterHideAndSeek()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	public bool MaybeForceHideAndSeek()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 1)]
	private void SetStopHoldGroundTimers()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	public void EnterHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ExitHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	public void StopHoldGroundAudio()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool WasHoldingGroundRecently()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeHoldGroundForField()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool MaybeAttackOrFleeIfHoldGroundForFieldChanged(bool holdGroundForField)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	public void ProcessHoldGround()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundDueToStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForSpear(float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForRedFlare(float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForRedFlareOnGround(float radius)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForBlueFlare(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForBlueFlareOnGround(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForTorch(float radius)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForTorchOnGround(float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool MaybeHoldGroundForFire(float radius)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeHoldGround()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void HoldGroundForMoose()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	private void HoldGroundFightOrFlight()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void HoldGroundCommon(float timeStopHoldingGround, float chanceAttackOnTimeout)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	private void HoldGroundSafeHaven()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	private void HoldGroundInsideAuroraField()
	{
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowsHoldGround()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	private bool IsTargetGoneOrOutOfRange()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	private void MaybeFleeFromHoldGround()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void MaybeEnterHoldGroundForAuroraField()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	private void InitializeHoldForFieldTimers()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ClearHowlStartDelay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHowlDelay()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnAnimationEvent_HowlComplete()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	public float SetHowlStartDelay(float baseTime)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	private void EnterHowl()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ExitHowl()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ProcessHowl()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void AdvanceToNextBehavior()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void EnterIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ExitIdle()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 0)]
	public void ProcessIdle()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void EnterInteractWithProp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ExitInteractWithProp()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ProcessInteractWithProp()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void OnInteractWithPropComplete()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAttachPropInMarker")]
	[CallsUnknownMethods(Count = 17)]
	public Transform FindTransform(string transformName)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseAi), Member = "FindTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void OnAttachPropInMarker()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	public void EnterInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitInvestigate()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	public void ProcessInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void SetInvestigatePos(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ForceInvestigatePos(Vector3 pos)
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeMoveInvestigationPositionOutsideOfField()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	public void EnterInvestigateFood()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	public void ExitInvestigateFood()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	public void StopInvestigateFoodAudio()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	public void ProcessInvestigateFood()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool CloseEnoughToEatObject(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	private void MaybeClearTarget()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void EnterInvestigateSmell()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[CallerCount(Count = 0)]
	public void ExitInvestigateSmell()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ProcessInvestigateSmell()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool SmellLost()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartResponseHowl")]
	public bool MaybeStartOrJoinPackHowl()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 3)]
	private void EnterJoinPack()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void ProcessJoinPack()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	private void ExitJoinPack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageEventsForTag")]
	[CallerCount(Count = 2)]
	private DamageEventTable GetPassingAttackDamageEventTable()
	{
		return null;
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnterPassingAttack()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void ProcessPassingAttack()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_OnPassingAttackChomp")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	private void DoPassingAttackDamage()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void ExitPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void Start_Pathfinding()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsUnknownMethods(Count = 4)]
	public bool TryGetClosestNavmeshPoint(Vector3 position, out Vector3 result)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref result) = null;
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallerCount(Count = 5)]
	public bool CanPlayerBeReached(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	public bool CanPathfindToPosition(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MoveAgentStop()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGoToPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnStumpApproached")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(MoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	public bool StartPath(Vector3 destPos, float movementSpeed, AiTarget overrideTurnTarget = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	public void StickPivotToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	public void OrientPivotToGroundImmediate()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	public void StickCharacterControllerToGround()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[CallerCount(Count = 0)]
	public void OrientCharacterControllerToGroundImmediate()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "LateUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	public void OrientCharacterControllerToGround()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private bool GetHitInfoUnderCharacterControllerFromBatch(out RaycastHit hitInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private float GetLastSafeheight(float y)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	private bool GetHitInfoUnderCharacterController(out RaycastHit hitInfo, FindGroundType findGroundType)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallsUnknownMethods(Count = 4)]
	public SpherecastCommand GetCommandUnderCharacterController()
	{
		return default(SpherecastCommand);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	private bool GetHitInfoUnderPivot(out RaycastHit hitInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 32)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void AlignTransformWithNormal(Vector3 terrainPoint, Vector3 normal, bool isRollConstrained, bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	public void SetJobGroundRaycastId(int id)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 0)]
	public void EnterPatrolPointsOfInterest()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitPatrolPointsOfInterest()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetPointsOfInterest(PointOfInterest[] pointsOfInterest)
	{
	}

	[CallerCount(Count = 0)]
	public void DoRandomOrderPointOfInterest(bool doRandom)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	public void ProcessPatrolPointsOfInterest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafePatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 4)]
	private void PathfindToPointOfInterest(int index)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallerCount(Count = 3)]
	private void PathfindToNextPointOfInterest()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool ReachedTargetPointOfInterest()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessSafePatrolPointsOfInterest()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	private void DoEnterPatrolPointsOfInterest()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void DoReachedTargetPointOfInterestBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void RoarAndReturnToPatrol(Vector3 lastKnownPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterRooted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessRooted()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterScratchingAntlers()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitScratchingAntlers()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnStumpApproached")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsOrientationValid")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void ProcessScratchingAntlers()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CanStickToGround(out Vector3 newPosition, Vector3 desiredPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref newPosition) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public bool IsOrientationValid(ScratchingStump stump)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public void OnStumpApproached(ScratchingStump stump)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnStumpMissed()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	public void OnStumpReached()
	{
	}

	[Calls(Type = typeof(ScratchingStump), Member = "SelectRandomStump")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private bool MaybeSelectScratchingStump(out Vector3 wanderPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void EnterScriptedSequence()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExitScriptedSequence()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ProcessScriptedSequence()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterSleep()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 1)]
	public void ExitSleep()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopSleepingAudio()
	{
	}

	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ProcessSleep()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	public void EnterStalking()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitStalking()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	public void StopStalkingAudio()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateScent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public void ProcessStalking()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	public void MaybeForceStalkPlayer()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateScent()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	private void MaybeEnterAttackModeWhenStalking()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void MaybeInvestigateMeatWhenStalking()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	private bool CanEnterStalking()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateStalkingAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void UpdateStalkingFollowDistance()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetStalkSpeedWhenTrackingPlayer")]
	private void UpdatePathfinding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private float GetStalkSpeedWhenTrackingPlayer(AiTarget playerTarget)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 1)]
	private void MaybeChangeCuriousState()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool EnterStalkingModeIfPossible(Vector3 targetPos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	private void MaybeLoseInterestWhileStalking()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CallsUnknownMethods(Count = 1)]
	private void SetNextChangeCuriousStateCheckTime()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	private void SetNextLoseInterestCheckTime()
	{
	}

	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 GetRandomNavmeshPos(Vector3 pos)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeForceFasterStalkingSpeed()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	private bool UseFixedStalkingSpeed()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallerCount(Count = 0)]
	public void EnterStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessStruggle()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	public void ExitStruggle()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	public void StopStruggleAudio()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	public bool CanEnterPlayerStruggle()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	private void DoPostSpearStruggleBehavior()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private float GetIgnoreFootStepsAndSmellsAfterStruggleSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_SpearStruggleComplete")]
	public void OnSpearStruggleEnd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallerCount(Count = 0)]
	public void OnBearBreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	public bool WasHitBySpear()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool WasHitBySpearFatal()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasEnteredStruggleOnLastAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	public void OnMooseStartStompAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 1)]
	public void OnAnimationEvent_MooseButtHeadAttackComplete()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void OnAnimationEvent_StopMauledMuffle()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_SpearStruggleComplete()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	public void OnAnimationEvent_SpearDisengageReady()
	{
	}

	[CallerCount(Count = 0)]
	public float GetSpearStruggleTapCount()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetSpearStruggleTapCount(int tapCount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public void EnterStunned()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ProcessStunned()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ExitStunned()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "Stun")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAIModeAllowStunFromThrownStone")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void MaybeStunnedByStone(ContactPoint[] contacts)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetStunTimer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void Stun(Vector3 position)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	private bool CurrentAIModeAllowStunFromThrownStone()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private float GetChanceStunFromThrownStone()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsStunTimerActive()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void EnterWander()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	public void ExitWander()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private bool MaybeHoldGroundAuroraField()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetPointsForGradualTurn")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	public void ProcessWander()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	public void StopWanderAudio()
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldBorder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsUnknownMethods(Count = 11)]
	private bool MaybeMoveWanderPosOutsideOfField(out Vector3 wanderToPos, Vector3 originalPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderToPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomWanderDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void WanderAroundPoint(Vector3 pos, float radius, float wanderDuration, bool wanderForever = false)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ForceWanderToPoint(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsWanderingAroundPos()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool PickWanderDestinationAwayFromPoint(out Vector3 wanderPos, Vector3 awayPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetWanderPosAfterStruggle(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsUnknownMethods(Count = 4)]
	private bool PickClosestWanderDestinationAtPoint(out Vector3 wanderPos, Vector3 toPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	private bool PickWanderDestination(out Vector3 wanderPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	private bool PickEmergencyWanderDestination(out Vector3 wanderPos, Vector3 toPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool WanderTimedOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool WanderDoingGradualTurn()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	private void MaybeImposter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsUnknownMethods(Count = 1)]
	public void EnterWanderPaused()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[CallerCount(Count = 0)]
	public void ProcessWanderPaused()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	public void ExitWanderPaused()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetNextWanderPauseTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallerCount(Count = 2)]
	public void MaybeEnterWanderPause()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ForceWanderPause(int wanderPauseId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OnWanderPauseStartBear), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(OnWanderPauseComplete), Member = "OnStateExit")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	public void OnWanderPauseAnimStateExit()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void OnWanderPauseComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsDeduplicatedMethods(Count = 3)]
	public BaseAi()
	{
	}
}
