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

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			private EqualityComparer()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public int GetHashCode(AnimationCallbackEvent x)
			{
				return default(int);
			}
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void UpdateAiming()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 12)]
	public void UpdateAimingIk()
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	private AvatarIKHint GetHintForGoal(AvatarIKGoal avatarIKGoal)
	{
		return default(AvatarIKHint);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private void SetIkInfo(AvatarIKGoal avatarIKGoal, Transform target, Transform hint, float weight, bool useHint)
	{
	}

	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 67)]
	[CallerCount(Count = 1)]
	public void Start_Anim()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	public void UpdateAnim()
	{
	}

	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallerCount(Count = 30)]
	public void AnimSetTrigger(int id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AnimSetBool(int id, bool value)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 20)]
	public void AnimSetFloat(int id, float value)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AnimSetFloat(int id, float value, float dampTime, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitWanderPaused")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetRandomFeedingAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	public void AnimSetInt(int id, int value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void AnimSetBearSpearTrigger(BearSpearStruggleOutcome outcome)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "SetTurnAngleParameters")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiStateParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	public void SetAnimationParameters()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	public void SetDeltaYawAngleParameter(float deltaAngle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	public void SetDeltaHeadAngleParameter(float deltaAngle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	public void SetSpeedForPathfindingSystem()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void OnIgnoreGlowPitch(int value)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnIsOnHindLegs(int value)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void OnBreathEffect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public void OnFootStepFrontLeft(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public void OnFootStepFrontRight(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	public void OnFootStepBackLeft(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsUnknownMethods(Count = 1)]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetWeapon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleFootprintsForDespawn()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void HandleFootprint(string audioEvent, Foot foot)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RaycastManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast_Internal")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	private void PlaceFootPrintDecal(Foot foot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontLeft(RaycastHit hitOut)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontRight(RaycastHit hitOut)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackLeft(RaycastHit hitOut)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackRight(RaycastHit hitOut)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontRight")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontLeft")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, Foot foot)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallerCount(Count = 0)]
	private bool ShouldPlaceFootPrintDecal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	private void PlayFootStepAudio(string audioEventName, Foot foot)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void SetNextRandomIdTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void UpdateActiveRandomId()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnGetRandomId")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void GetRandomId()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	private void SetSpeedAnimationParameter()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void SetTurnSpeedAnimationParameter()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	public static void SetTurnAngleParameters(Animator animator, float totalTurnAngle, float turnSpeed, Vector3 turnHeading, Vector3 forward, int turnAngleParam)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
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

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	private void SetPitchRollParameters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void SetAnimStateForMoveAgent(MoveState moveState, int animState)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallerCount(Count = 1)]
	private void SetAiStateParameter()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void SetWoundedParameter()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	private void MaybeUpdateStandingOnMaterialTag()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private bool PositionOverlapsRecentFootprints(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallerCount(Count = 1)]
	private void SetCullModeAlways()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetDefaultCullmode()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[CallerCount(Count = 2)]
	private void SetDamageImpactParameter(DamageSide side, int bodyPart, SetupDamageParamsOptions setupDamageParamsOptions)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	private bool CanFallToSide(DamageSide side)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	private float GetSpeedFromMecanimBone()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "SetCullModeAlways")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	public void EnterAttack()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	public void ExitAttack()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	public void StopAttackAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	[Calls(Type = typeof(ExperienceMode), Member = "GetDamageEventTable")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static DamageEventTable GetDamageEventsForTag(GameplayTag tag)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageEventsForTag")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	private DamageEventTable GetAttackDamageEvents()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 5)]
	private void MaybeAdjustTargetPosition(Vector3 targetPosition)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private Vector3 GetPositionForHold(Vector3 targetPosition, float radius)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float GetAverageSlope()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 5)]
	private bool MaybeFleeOnSlope()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void MaybeSpearAttackTooLate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 33)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	public void ProcessAttack()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetCurrentRadiusToHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	private Vector3 GetCurrentHoldGroundCausePosition(HoldGroundReason reason)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackDamageEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public void MaybeApplyAttack()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
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

	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	public bool AttackOrFleeAfterNearMissGunshot(GunType gt)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
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
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public bool CanBeHitBySpear()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldPlayBearAttackStartAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	private bool ShouldPlayTimberwolfAttackStartAnimation()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	private void PlayMeleeAttackAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateAttackingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
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

	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSpeedForHoldWithSlowdown()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetOuterRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsScaredReason")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	private float GetInnerRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	private bool UpdateForHoldWithSlowdown()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeHoldGroundForSpearForAttack()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 0)]
	private bool MaybeHoldGroundForTorchForAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool MaybeHoldGroundForRedFlareForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	private bool MaybeHoldGroundForFireForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool MaybeHoldGroundForBlueFlareForAttack()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	private bool MaybeHoldGroundForAttack(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	private bool MaybeHoldGroundAuroraFieldForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	private bool MaybeHoldGroundDueToSafeHaven()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private bool ShouldHoldGround()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	public bool MaybeForceHoldGround()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private float GetCurrentRadiusToHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	private AuroraField GetVisibleFieldNearby(float radius)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private bool IsFieldVisible(AuroraField field, float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsScaredReason(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "Copy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public GearItem SpawnCarcassPickup()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	private void MaybeSpawnCarcassSiteIfFarEnough()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	public void Start_Common()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	private void ProcessCommonPre()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	private void MaybeCollideWithSpear()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeRestoreTargetAfterSpear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ProcessCommonPost()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	private void MaybeDestroyIfFellThroughWorld()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void MovedDistance(Vector3 delta)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ClearTarget()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ReturnToDefaultBehavior()
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void DebugAiStateTrace(AiMode mode, string locationTag)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateImposterAnimatorCulling")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeMakeWildlifeFlee")]
	[CallerCount(Count = 14)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool CreateMoveAgent(Transform parent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Anim")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[Calls(Type = typeof(CapsuleCollider), Member = "get_radius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "Add")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public void Start()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[Calls(Type = typeof(BaseAi), Member = "IsMoveAgent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	public void Update()
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	public void SetPosition(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void SetCollisionMode(CollisionDetectionMode mode)
	{
	}

	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsMoveAgentEnabled")]
	public bool IsMoveAgent()
	{
		return default(bool);
	}

	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public MoveAgent GetMoveAgent()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsMoveAgent")]
	public bool IsMoveAgentEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public bool IsPlayerFacingAi()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsPlayerFacingAi(Vector3 aiToTarget, float dotProductThreshold)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "UpdateHeadTrackingIk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	private void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	public void DeferredDeserialize(BaseAiData bad)
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BaseAiDataProxy GetBaseAiDataProxyFromText(string text)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "Start")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	public void DeserializeUsingBaseAiDataProxy(BaseAiDataProxy proxy)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	public void ProcessCurrentAiMode()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	public bool IsInFlashLight()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool IsTimberwolf()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStruggle")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAiStateSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterJoinPack")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "EnterWander")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "ExitStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 205)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "InRangeOfTargetWaypoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "ExitDead")]
	[Calls(Type = typeof(BaseAi), Member = "ExitAttack")]
	[Calls(Type = typeof(BaseAi), Member = "IsStunTimerActive")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void EnableAuroraMaterials(bool enable)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "OnDespawn")]
	[CalledBy(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnCarcassPickedUp")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(WildlifeItemInteraction), Member = "PerformInteraction")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
	public void SetSpeedOverride(float speedVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WildlifeMode GetWildlifeMode()
	{
		return default(WildlifeMode);
	}

	[CallerCount(Count = 0)]
	public void SetLastDamageSide(DamageSide side)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DamageSide GetLastDamageSide()
	{
		return default(DamageSide);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void OnDrawGizmos()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAiManager), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	private void StopLoopingAudio()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	private void DoCustomModeModifiers()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
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
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CalledBy(Type = typeof(ToxicFogManager._003C_003Ec), Member = "<MaybeKillAllWildlife>b__42_0")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	public void ApplyDamage(float damage, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDamageFatal(float damage, DamageSource damageSource)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public DamageSource GetDamageSource()
	{
		return default(DamageSource);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "AdustMovementSpeedForInjury")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	public float GetWoundedAnimParameter()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeCollisionCapsulesLayer")]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ParticleSystem), Member = "Stop")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 35)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void EnterDead()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ProcessDead()
	{
	}

	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	private void HandleAuroraMaterials()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 4)]
	public void ExitDead()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsUnknownMethods(Count = 7)]
	private void ChangeCollisionCapsulesLayer(int layer)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start_AiDebug()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ProcessAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallerCount(Count = 4)]
	public bool CanSeeTarget()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	private float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ScanForNewTarget()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnSpearHit(bool isFatal, Action onSpearStruggleEnd)
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
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
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	private void ChangeModeWhenTargetDetected()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private bool CanBearSeePlayerAfterSpearStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	private bool TargetCanBeIgnored(AiTarget target)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	private bool IgnoreAudioEvent(GameObject sender, Vector3 pos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 1)]
	private void ProcessGenericAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void ProcessFootstepAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	private void ProcessGunshotAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "SmellLost")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 3)]
	private bool CanSmellSource(Vector3 sourcePos, AiTarget target)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	private void SetNextSmellCheckTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallerCount(Count = 0)]
	private void DoTargetDetectedWhileFeeding()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private bool CanDodge()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "DisableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "EnableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "DoesPositionIntefereWithAttacks")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerAThreat")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeAttemptDodge()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool HasDodgePlacementTimedOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool DoesPositionIntefereWithAttacks(Vector3 pos, float radius, Vector3 playerPos)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Conditional("__DEBUG")]
	private void SetDebugSphere(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Vector3 ComputeDodgeObstaclePosition(Vector3 pos, Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void DisableDodgeObstacle()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	private void EnableDodgeObstacle(Vector3 pos)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 3)]
	private void SetBestFeedingTarget(Vector3 feederPos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	private void ProcessFakeFeeding()
	{
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	private void ProcessRealFeeding()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void MaybeAttackOrHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetFeedingPos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	private void TurnTowardsFeedingPos()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private Vector3 GetFeedingPos()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public void SetFleeReason(AiFleeReason reason)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnterFlee()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	public void ExitFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopFleeAudio()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	public bool MaybeHandleTimeoutFleeing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHandleTimeoutFleeing")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedOverride")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ProcessFlee()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	public void MaybeFleeFromArrow(ArrowItem ai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void SetForcedFleePos(Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAiModeAllowFleeFromThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(ContactPoint), Member = "get_otherCollider")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	public static void MaybeFleeFromThrownItem(GearItem item, ContactPoint[] contacts)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ScareTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CallsDeduplicatedMethods(Count = 6)]
	public bool MaybeFleeFromFlareGunRound(FlareGunRoundItem fgri, float rangeScalar)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayEnterFleeAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	private float GetChanceFleeFromHeldItem()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	private float GetFleeProximityFromNearbyThrownItem(GearItem item)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallerCount(Count = 1)]
	private float GetChanceFleeFromNearbyThrownItem(GearItem item, bool wasHit)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public void MaybeFleeDueToTorchSwing()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public bool OverrideXpModeAttackRestrictions()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "IsMismatchWildlifeMode")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	public bool IsMismatchWildlifeMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoTargetDetectedWhileFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldAlwaysFleeFromCurrentTarget()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickNewGroupFleeLeader")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void BecomeGroupFleeLeader(List<BaseAi> followerList)
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldIgnoreGroupFleeWarning()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	private bool KeepFleeingFromTarget()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private float GetStopFleeAfterDistanceForSpear()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private bool MaybePickFleeDestinationFromAreaMarkup(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool PickFleeDesination(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromFlareGunRound()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void MaybeAttackPlayerWhenTryingToFlee()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldPlayEnterFleeAudio()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void WarnOthersNearby()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void PickNewGroupFleeLeader()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsGroupFleeLeader()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool CanKnockdownPlayer(AiSubType ast)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromFlareGunRound")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ExitFollowWaypoints()
	{
	}

	[CalledBy(Type = typeof(Action_SetBaseAiWaypointPath), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	public void SetWaypoints(Vector3[] waypoints)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	public void ProcessFollowWaypoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	public void PathfindToCurrentTargetWaypoint()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	public void TeleportToRandomWaypointAndPathfind()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallsUnknownMethods(Count = 4)]
	private int GetClosestWaypointIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToCurrentTargetWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallerCount(Count = 7)]
	private void PathfindToWaypoint(int waypointIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[CallsUnknownMethods(Count = 1)]
	private void PathfindToNextWaypoint()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	private void HandleLastWaypoint()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private bool ReachedTargetWaypoint()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWanderRegion")]
	private void MaybeWander()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	private bool ProcessSafeFollowWaypoints()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafeFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosestWaypointIndex")]
	[CallerCount(Count = 2)]
	private void DoEnterFollowWaypoints()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[CallerCount(Count = 0)]
	private void DoReachedTargetWaypointBehavior()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void GoToPoint(Vector3 point, AiMode targetMode, float movementSpeed)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_NPC_GoTo_Marker")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void GoToAiMarker(AiMarker aiMarker, AiMode targetMode, float movementSpeed)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void EnterGoToPoint()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ExitGoToPoint()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void UpdateHeadTracking()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void UpdateHeadTrackingIk()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceSetPlayerTarget()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 2)]
	public bool CanPerformPassingAttackChance()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPerformPassingAttack()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 2)]
	private void EnterHideAndSeek()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
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
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	private float GetMaxFollowDistance()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	private float GetComfortableFollowDistance()
	{
		return default(float);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[Calls(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
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
	[Calls(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
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
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	private void ProcessHideAndSeek()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void SetEnterCooldownTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void ExitHideAndSeek()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[CallerCount(Count = 2)]
	private bool CanEnterHideAndSeekInternal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CallerCount(Count = 3)]
	public bool CanEnterHideAndSeek()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool MaybeForceHideAndSeek()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CallerCount(Count = 2)]
	private void SetStopHoldGroundTimers()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnterHoldGround()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool WasHoldingGroundRecently()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	private bool MaybeHoldGroundForField()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	private bool MaybeAttackOrFleeIfHoldGroundForFieldChanged(bool holdGroundForField)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	public void ProcessHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	private bool MaybeHoldGroundDueToStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	private bool MaybeHoldGroundForSpear(float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeHoldGroundForRedFlare(float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	private bool MaybeHoldGroundForRedFlareOnGround(float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	private bool MaybeHoldGroundForBlueFlare(float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	private bool MaybeHoldGroundForBlueFlareOnGround(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForTorch(float radius)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForTorchOnGround(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForFire(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	private void MaybeHoldGround()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void HoldGroundForMoose()
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	private void HoldGroundFightOrFlight()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	private void HoldGroundCommon(float timeStopHoldingGround, float chanceAttackOnTimeout)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	private void HoldGroundSafeHaven()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void HoldGroundInsideAuroraField()
	{
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowsHoldGround()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsTargetGoneOrOutOfRange()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void MaybeFleeFromHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeEnterHoldGroundForAuroraField()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeHoldForFieldTimers()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ClearHowlStartDelay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessHowl()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	private void AdvanceToNextBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 1)]
	public void EnterIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ExitIdle()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	public void ProcessIdle()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterInteractWithProp()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ExitInteractWithProp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessInteractWithProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnInteractWithPropComplete()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAttachPropInMarker")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public Transform FindTransform(string transformName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "FindTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void OnAttachPropInMarker()
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 5)]
	public void EnterInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitInvestigate()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void ProcessInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void SetInvestigatePos(Vector3 pos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ForceInvestigatePos(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeMoveInvestigationPositionOutsideOfField()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	public void EnterInvestigateFood()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ExitInvestigateFood()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopInvestigateFoodAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CloseEnoughToEatObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void ProcessInvestigateFood()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CloseEnoughToEatObject(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	private void MaybeClearTarget()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void EnterInvestigateSmell()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	public void ExitInvestigateSmell()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void ProcessInvestigateSmell()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private bool SmellLost()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool MaybeStartOrJoinPackHowl()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	private void EnterJoinPack()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	private void EnterPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessPassingAttack()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "GetPassingAttackDamageEventTable")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_OnPassingAttackChomp")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPassingAttack")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	private void DoPassingAttackDamage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void ExitPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public void Start_Pathfinding()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool TryGetClosestNavmeshPoint(Vector3 position, out Vector3 result)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref result) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanPlayerBeReached(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanPathfindToPosition(Vector3 pos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallerCount(Count = 35)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveAgentStop()
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 21)]
	public bool StartPath(Vector3 destPos, float movementSpeed, AiTarget overrideTurnTarget = null)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	public void StickPivotToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	public void OrientPivotToGroundImmediate()
	{
	}

	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	public void StickCharacterControllerToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	public void OrientCharacterControllerToGroundImmediate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "LateUpdate")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	public void OrientCharacterControllerToGround()
	{
	}

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

	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	private bool GetHitInfoUnderPivot(out RaycastHit hitInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void AlignTransformWithNormal(Vector3 terrainPoint, Vector3 normal, bool isRollConstrained, bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	public void SetJobGroundRaycastId(int id)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterPatrolPointsOfInterest()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitPatrolPointsOfInterest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SetPointsOfInterest(PointOfInterest[] pointsOfInterest)
	{
	}

	[CallerCount(Count = 0)]
	public void DoRandomOrderPointOfInterest(bool doRandom)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	public void ProcessPatrolPointsOfInterest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafePatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void PathfindToPointOfInterest(int index)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	private void PathfindToNextPointOfInterest()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsUnknownMethods(Count = 4)]
	private bool ReachedTargetPointOfInterest()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ProcessSafePatrolPointsOfInterest()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CallsUnknownMethods(Count = 2)]
	private void DoEnterPatrolPointsOfInterest()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DoReachedTargetPointOfInterestBehavior()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	private void RoarAndReturnToPatrol(Vector3 lastKnownPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterRooted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessRooted()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallerCount(Count = 0)]
	public void EnterScratchingAntlers()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitScratchingAntlers()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnStumpApproached")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "IsOrientationValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	public void ProcessScratchingAntlers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStickToGround(out Vector3 newPosition, Vector3 desiredPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref newPosition) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public bool IsOrientationValid(ScratchingStump stump)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public void OnStumpApproached(ScratchingStump stump)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnStumpMissed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public void OnStumpReached()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScratchingStump), Member = "SelectRandomStump")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeSelectScratchingStump(out Vector3 wanderPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterScriptedSequence()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void ExitScriptedSequence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessScriptedSequence()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	public void ProcessSleep()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[CallsUnknownMethods(Count = 3)]
	public void EnterStalking()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopStalkingAudio()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateScent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	public void ProcessStalking()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public void MaybeForceStalkPlayer()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateScent()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	private void MaybeEnterAttackModeWhenStalking()
	{
	}

	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	private void MaybeInvestigateMeatWhenStalking()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	private bool CanEnterStalking()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateStalkingAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateStalkingFollowDistance()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "GetStalkSpeedWhenTrackingPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	private void UpdatePathfinding()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CallsUnknownMethods(Count = 5)]
	private float GetStalkSpeedWhenTrackingPlayer(AiTarget playerTarget)
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeChangeCuriousState()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool EnterStalkingModeIfPossible(Vector3 targetPos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeLoseInterestWhileStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	private void SetNextChangeCuriousStateCheckTime()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	[CallsUnknownMethods(Count = 1)]
	private void SetNextLoseInterestCheckTime()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	private Vector3 GetRandomNavmeshPos(Vector3 pos)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	private void MaybeForceFasterStalkingSpeed()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	private bool UseFixedStalkingSpeed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessStruggle()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ExitStruggle()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	public void StopStruggleAudio()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 8)]
	public bool CanEnterPlayerStruggle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	private void DoPostSpearStruggleBehavior()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetIgnoreFootStepsAndSmellsAfterStruggleSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_SpearStruggleComplete")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSpearStruggleEnd()
	{
	}

	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void OnMooseStartStompAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 1)]
	public void OnAnimationEvent_MooseButtHeadAttackComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnAnimationEvent_PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnAnimationEvent_StopMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	public void OnAnimationEvent_SpearStruggleComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterStunned()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessStunned()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ExitStunned()
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAIModeAllowStunFromThrownStone")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "Stun")]
	public static void MaybeStunnedByStone(ContactPoint[] contacts)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetStunTimer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsStunTimerActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	public void EnterWander()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsUnknownMethods(Count = 2)]
	public void ExitWander()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private bool MaybeHoldGroundAuroraField()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(AiUtils), Member = "GetPointsForGradualTurn")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	public void ProcessWander()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopWanderAudio()
	{
	}

	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldBorder")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeMoveWanderPosOutsideOfField(out Vector3 wanderToPos, Vector3 originalPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderToPos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ForceWanderToPoint(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsWanderingAroundPos()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
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

	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool PickWanderDestination(out Vector3 wanderPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	public void ProcessWanderPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	public void ExitWanderPaused()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWander")]
	[CallsUnknownMethods(Count = 1)]
	public void SetNextWanderPauseTime()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeEnterWanderPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ForceWanderPause(int wanderPauseId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OnWanderPauseStartBear), Member = "OnStateEnter")]
	[CalledBy(Type = typeof(OnWanderPauseComplete), Member = "OnStateExit")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	public void OnWanderPauseAnimStateExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnWanderPauseComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public BaseAi()
	{
	}
}
