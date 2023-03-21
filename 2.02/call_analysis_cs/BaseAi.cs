using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.AI;

public class BaseAi : MonoBehaviour
{
	public enum WaypointCompletionBehaviouir
	{
		CheckSpawnRegion,
		Restart,
		ChangeState
	}

	public class PointOfInterest
	{
		public Vector3 m_Location;

		public PointOfInterestAnim m_AnimToPlay;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
			[CallerCount(Count = 7)]
			private EqualityComparer()
			{
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			public int GetHashCode(AnimationCallbackEvent x)
			{
				return 0;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 4)]
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

	public Vector3[] m_Waypoints;

	private int m_TargetWaypointIndex;

	private bool m_HasEnteredFollowWaypoints;

	public WaypointCompletionBehaviouir m_WaypointCompletionBehaviour;

	public AiMode m_WaypointCompleteNextState;

	private List<PointOfInterest> m_ActivePointsOfInterest;

	private int m_TargetPointOfInterestIndex;

	private bool m_HasEnteredPatrolPointsOfInterest;

	private bool m_RandomizePointsOfInterest;

	private bool m_IsAnimatingAtPointOfInterest;

	private float m_DurationAtPointOfInterestSeconds;

	private float m_ElapsedTimeAtPointOfInterestSeconds;

	public int m_ChanceStunFromThrownStone;

	public float m_StunSeconds;

	private float m_StunStartTime;

	private Vector3 m_StunPosition;

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

	public DamageEventTable m_AttackDamageEvents;

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

	public DamageEventTable m_PassingAttackDamageEvents;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterFollowWaypoints()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ExitFollowWaypoints()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 77)]
	public void SetWaypoints(Vector3[] waypoints)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[CallsUnknownMethods(Count = 3)]
	public void ProcessFollowWaypoints()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 3)]
	public void PathfindToCurrentTargetWaypoint()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public void TeleportToRandomWaypointAndPathfind()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private int GetClosestWaypointIndex()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 3)]
	private void PathfindToWaypoint(int waypointIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 3)]
	private void PathfindToNextWaypoint()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpawnRegion), Member = "ShouldSleepInDenAfterWaypointLoop")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(Array), Member = "Resize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void HandleLastWaypoint()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private bool ReachedTargetWaypoint()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWanderRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeWander()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	private bool ProcessSafeFollowWaypoints()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafeFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosestWaypointIndex")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void DoEnterFollowWaypoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 3)]
	private void DoReachedTargetWaypointBehavior()
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

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetPointsOfInterest(PointOfInterest[] pointsOfInterest)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DoRandomOrderPointOfInterest(bool doRandom)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ProcessPatrolPointsOfInterest()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafePatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterPatrolPointsOfInterest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void PathfindToPointOfInterest(int index)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private void PathfindToNextPointOfInterest()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private bool ReachedTargetPointOfInterest()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessSafePatrolPointsOfInterest()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DoEnterPatrolPointsOfInterest()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DoReachedTargetPointOfInterestBehavior()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void RoarAndReturnToPatrol(Vector3 lastKnownPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EnterStunned()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessStunned()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitStunned()
	{
	}

	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAIModeAllowStunFromThrownStone")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "Stun")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static void MaybeStunnedByStone(ContactPoint[] contacts)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetStunTimer()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Stun(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallerCount(Count = 1)]
	private bool CurrentAIModeAllowStunFromThrownStone()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private float GetChanceStunFromThrownStone()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsStunTimerActive()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void UpdateAiming()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 24)]
	public void UpdateAimingIk()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private AvatarIKHint GetHintForGoal(AvatarIKGoal avatarIKGoal)
	{
		return default(AvatarIKHint);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	private void SetIkInfo(AvatarIKGoal avatarIKGoal, Transform target, Transform hint, float weight, bool useHint)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 61)]
	[CallsUnknownMethods(Count = 150)]
	public void Start_Anim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateAnim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateImposterAnimatorCulling()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	public void SetIsOnScreen(bool isOnScreen)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetIsOnScreen")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableSkinnedMeshRenderers(bool isEnabled)
	{
	}

	[CallerCount(Count = 26)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetTrigger(int id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AnimSetBool(int id, bool value)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaYawAngleParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaHeadAngleParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetFloat(int id, float value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetFloat(int id, float value, float dampTime, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetRandomFeedingAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetInt(int id, int value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsUnknownMethods(Count = 1)]
	public void AnimSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyeWeigth, float clampWeight)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetLookAtPosition(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void AnimSetBearSpearTrigger(BearSpearStruggleOutcome outcome)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetSpeedForPathfindingSystem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public void OnBreathEffect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void AnimationEndSniff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void AnimationEndWanderPause()
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetWeapon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleFootprintsForDespawn()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void HandleFootprint(string audioEvent, Foot foot)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 34)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackRight")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "PositionOverlapsRecentFootprints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, Foot foot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldPlaceFootPrintDecal()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void PlayFootStepAudio(string audioEventName, Foot foot)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateActiveRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetNextRandomIdTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateActiveRandomId()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnGetRandomId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void GetRandomId()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetSpeedAnimationParameter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void SetTurnSpeedAnimationParameter()
	{
	}

	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void SetTurnAngleParameters(Animator animator, float totalTurnAngle, float turnSpeed, Vector3 turnHeading, Vector3 forward, int turnAngleParam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Utils), Member = "AngleDir")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void SetTargetHeadingParameter()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetFlattenedAngle(Vector3 inVec)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetFlattenedAngle")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 1)]
	private void SetPitchRollParameters()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetAnimStateForMoveAgent(MoveState moveState, int animState)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SetAiStateParameter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetWoundedParameter()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateStandingOnMaterialTag()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool PositionOverlapsRecentFootprints(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCullModeAlways()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetDefaultCullmode()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetDamageImpactParameter(DamageSide side, int bodyPart, SetupDamageParamsOptions setupDamageParamsOptions)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private bool CanFallToSide(DamageSide side)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private float GetSpeedFromMecanimBone()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(BaseAi), Member = "SetCullModeAlways")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void EnterAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void ExitAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopAttackAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeAdjustTargetPosition(Vector3 targetPosition)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 GetPositionForHold(Vector3 targetPosition, float radius)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetAverageSlope()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private bool MaybeFleeOnSlope()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeSpearAttackTooLate()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(BaseAi), Member = "RoarAndReturnToPatrol")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 30)]
	public void ProcessAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetCurrentRadiusToHoldGroundCause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private Vector3 GetCurrentHoldGroundCausePosition(HoldGroundReason reason)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[Calls(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(LoadScene), Member = "Cancel")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 53)]
	public void MaybeApplyAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetModifiedAttackChance(float baseAttackChance)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void AttackStartAnimationDone()
	{
	}

	[CallerCount(Count = 0)]
	public void SuppressAttackStartAnimation()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 31)]
	public bool AttackOrFleeAfterNearMissGunshot(GunType gt)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool EnterAttackModeIfPossible(Vector3 attackPos, bool suppressAttackStartAnimation)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanBeHitBySpear()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool ShouldPlayBearAttackStartAnimation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldPlayTimberwolfAttackStartAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void PlayMeleeAttackAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAttackingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetAttackLineOfSightLayerMask()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetSpeedForCurrentRadius(float initialSpeed, float initialRadius, float currentRadius, float innerRadius)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateSpeedForHoldWithSlowdown()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float GetOuterRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsScaredReason")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float GetInnerRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool UpdateForHoldWithSlowdown()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool MaybeHoldGroundForSpearForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private bool MaybeHoldGroundForTorchForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private bool MaybeHoldGroundForRedFlareForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private bool MaybeHoldGroundForFireForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private bool MaybeHoldGroundForBlueFlareForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeHoldGroundForAttack(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	private bool MaybeHoldGroundAuroraFieldForAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private bool MaybeHoldGroundDueToSafeHaven()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private bool ShouldHoldGround()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool MaybeForceHoldGround()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private float GetCurrentRadiusToHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private AuroraField GetVisibleFieldNearby(float radius)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsFieldVisible(AuroraField field, float radius)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsScaredReason(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 67)]
	public bool IsTooScaredToAttack()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	public void OnCarcassPickedUp()
	{
	}

	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BodyHarvest), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	public GearItem SpawnCarcassPickup()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "CanSpawnCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeSpawnCarcassSiteIfFarEnough()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start_Common()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessCommonPre()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeCollideWithSpear()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeRestoreTargetAfterSpear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	private void ProcessCommonPost()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeDestroyIfFellThroughWorld()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MovedDistance(Vector3 delta)
	{
	}

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ClearTarget()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ReturnToDefaultBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start_Damage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void SetupDamageForAnim(Vector3 hitPosition, Vector3 hitSource, LocalizedDamage localizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	public float GetBleedingOutMinutesRemaining()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(TypeFullName = "ToxicFogManager.<>c", Member = "<MaybeKillAllWildlife>b__56_0")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 32)]
	public void ApplyDamage(float damage, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsDamageFatal(float damage, DamageSource damageSource)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void UpdateWounds(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsBleedingOut()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DamageSource GetDamageSource()
	{
		return default(DamageSource);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "AdustMovementSpeedForInjury")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetWoundedAnimParameter()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float AdustMovementSpeedForInjury(float baseSpeed)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool ForceApplyDamage()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasDeathAnimationFinished()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeCollisionCapsulesLayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallsUnknownMethods(Count = 62)]
	public void EnterDead()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ProcessDead()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleAuroraMaterials()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitDead()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private void ChangeCollisionCapsulesLayer(int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start_AiDebug()
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	public bool CanSeeTarget()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	private float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	public void ScanForNewTarget()
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void OnSpearHit(bool isFatal, Action onSpearStruggleEnd)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public void ScanForSmells()
	{
	}

	[CallerCount(Count = 0)]
	public void IngoreFootStepsAndSmellsForSeconds(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	private void ChangeModeWhenTargetDetected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanBearSeePlayerAfterSpearStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private bool TargetCanBeIgnored(AiTarget target)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IgnoreAudioEvent(GameObject sender, Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessGenericAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void ProcessFootstepAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessGunshotAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessCarAlarmAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	private float GetDetectionRange()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float GetHearFootstepsRange()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetRangeFromScentIntensity(float scentIntensity)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "SmellLost")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private bool CanSmellSource(Vector3 sourcePos, AiTarget target)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetNextSmellCheckTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DoTargetDetectedWhileFeeding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private bool ShouldScanForSmells()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool AiModeAllowsForSmellDetection()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanDodge()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerAThreat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "DoesPositionIntefereWithAttacks")]
	[Calls(Type = typeof(BaseAi), Member = "EnableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "DisableDodgeObstacle")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeAttemptDodge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasDodgePlacementTimedOut()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private bool IsPlayerAThreat()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsMovingTowardsOrAwayFromPlayer(Vector3 moveDirection, Vector3 playerDirection)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool DoesPositionIntefereWithAttacks(Vector3 pos, float radius, Vector3 playerPos)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void SetDebugSphere(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 ComputeDodgeObstaclePosition(Vector3 pos, Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void DisableDodgeObstacle()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void EnableDodgeObstacle(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnterFeeding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	public void ExitFeeding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ReturnToFeeding()
	{
	}

	[CallerCount(Count = 0)]
	public void SetFakeFeedingPos(Vector3 pos, float feedingDurationHours = -1f)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessFeeding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetRandomFeedingAnimation()
	{
	}

	[CallerCount(Count = 0)]
	public BodyHarvest GetTargetBodyHarvest()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetFeedingTimeRemainingHours()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopFeedingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void DecimateCarcass(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldStopFeeding()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void SetBestFeedingTarget(Vector3 feederPos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessFakeFeeding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetBestFeedingTarget")]
	[Calls(Type = typeof(BaseAi), Member = "DecimateCarcass")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void ProcessRealFeeding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeAttackOrHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetFeedingPos")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void TurnTowardsFeedingPos()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private Vector3 GetFeedingPos()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public void SetFleeReason(AiFleeReason reason)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void EnterFlee()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ExitFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StopFleeAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool MaybeHandleTimeoutFleeing()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHandleTimeoutFleeing")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedOverride")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 36)]
	public void ProcessFlee()
	{
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeFleeFromArrow(ArrowItem ai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void SetForcedFleePos(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(ContactPoint), Member = "get_otherCollider")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAiModeAllowFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public static void MaybeFleeFromThrownItem(GearItem item, ContactPoint[] contacts)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(ScareTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 3)]
	public bool MaybeFleeFromFlareGunRound(FlareGunRoundItem fgri, float rangeScalar)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void PlayEnterFleeAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private float GetChanceFleeFromHeldItem()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private float GetFleeProximityFromNearbyThrownItem(GearItem item)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private float GetChanceFleeFromNearbyThrownItem(GearItem item, bool wasHit)
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[CallerCount(Count = 1)]
	public void MaybeFleeDueToTorchSwing()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool OverrideXpModeAttackRestrictions()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "IsMismatchWildlifeMode")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsMismatchWildlifeMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoTargetDetectedWhileFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public bool ShouldAlwaysFleeFromCurrentTarget()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickNewGroupFleeLeader")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void BecomeGroupFleeLeader(List<BaseAi> followerList)
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldIgnoreGroupFleeWarning()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "GetStopFleeAfterDistanceForSpear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private bool KeepFleeingFromTarget()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private float GetStopFleeAfterDistanceForSpear()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 19)]
	private bool MaybePickFleeDestinationFromAreaMarkup(out Vector3 fleePos)
	{
		fleePos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private bool PickFleeDesination(out Vector3 fleePos)
	{
		fleePos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	private bool CheckFleeAngleIsValid(out Vector3 fleePos, Vector3 fleeVec, Vector3 constraintPos, float angleDegreesToTry)
	{
		fleePos = default(Vector3);
		return false;
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromArrow()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromFlareGunRound()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CurrentAiModeAllowFleeFromThrownItem(GearItem item)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromTorchSwing()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeAttackPlayerWhenTryingToFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldPlayEnterFleeAudio()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 35)]
	private void WarnOthersNearby()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void PickNewGroupFleeLeader()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsGroupFleeLeader()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool CanKnockdownPlayer(AiSubType ast)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void FleeFrom(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void FleeFrom(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void GoToPoint(Vector3 point, AiMode targetMode, float movementSpeed)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_NPC_GoTo_Marker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void GoToAiMarker(AiMarker aiMarker, AiMode targetMode, float movementSpeed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterGoToPoint()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ExitGoToPoint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessGoToPoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateGoToPointPathfinding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void UpdateGoToPointBlending()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void OnGotoPointReached()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void UpdateHeadTracking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateHeadTrackingIk()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ForceSetPlayerTarget()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool CanPerformPassingAttackChance()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPerformPassingAttack()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void EnterHideAndSeek()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetClosingDistancePercent()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetMinFollowDistance()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetMaxFollowDistance()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetComfortableFollowDistance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public bool TriggerPassingAttackAnim()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopHideAndSeekAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[Calls(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 22)]
	private Vector3 FindTacticalPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private void ResetApproachDistance()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	private void ProcessHideAndSeek()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetEnterCooldownTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitHideAndSeek()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	private bool CanEnterHideAndSeekInternal()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanEnterHideAndSeek()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public bool MaybeForceHideAndSeek()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void SetStopHoldGroundTimers()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EnterHoldGround()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopHoldGroundAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool WasHoldingGroundRecently()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeHoldGroundForField()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool MaybeAttackOrFleeIfHoldGroundForFieldChanged(bool holdGroundForField)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public void ProcessHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool MaybeHoldGroundDueToStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingRaisedSpear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool MaybeHoldGroundForSpear(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeHoldGroundForRedFlare(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private bool MaybeHoldGroundForRedFlareOnGround(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeHoldGroundForBlueFlare(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private bool MaybeHoldGroundForBlueFlareOnGround(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitTorch")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeHoldGroundForTorch(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(HashSet<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private bool MaybeHoldGroundForTorchOnGround(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool MaybeHoldGroundForFire(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void HoldGroundForMoose()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void HoldGroundFightOrFlight()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void HoldGroundCommon(float timeStopHoldingGround, float chanceAttackOnTimeout)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void HoldGroundSafeHaven()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void HoldGroundInsideAuroraField()
	{
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowsHoldGround()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsTargetGoneOrOutOfRange()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeFleeFromHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeEnterHoldGroundForAuroraField()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void InitializeHoldForFieldTimers()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ClearHowlStartDelay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHowlDelay()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnAnimationEvent_HowlComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public float SetHowlStartDelay(float baseTime)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnterHowl()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void ExitHowl()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessHowl()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void AdvanceToNextBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void EnterIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitIdle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ProcessIdle()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void EnterInteractWithProp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ExitInteractWithProp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ProcessInteractWithProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnInteractWithPropComplete()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnAttachPropInMarker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public Transform FindTransform(string transformName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "FindTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public void OnAttachPropInMarker()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void EnterInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitInvestigate()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeMoveInvestigationPositionOutsideOfField()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public void EnterInvestigateFood()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitInvestigateFood()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopInvestigateFoodAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(BaseAi), Member = "CloseEnoughToEatObject")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	public void ProcessInvestigateFood()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool CloseEnoughToEatObject(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeClearTarget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnterInvestigateSmell()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	public void ExitInvestigateSmell()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SmellLost")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void ProcessInvestigateSmell()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private bool SmellLost()
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartResponseHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool MaybeStartOrJoinPackHowl()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void EnterJoinPack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void ProcessJoinPack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ExitJoinPack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	private void EnterPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessPassingAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_OnPassingAttackChomp")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void DoPassingAttackDamage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void ExitPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void Start_Pathfinding()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public bool TryGetClosestNavmeshPoint(Vector3 position, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool CanPlayerBeReached(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPathfindToPosition(Vector3 pos)
	{
		return false;
	}

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void MoveAgentStop()
	{
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(MoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public bool StartPath(Vector3 destPos, float movementSpeed, AiTarget overrideTurnTarget = null)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[CallsDeduplicatedMethods(Count = 8)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void StickCharacterControllerToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	public void OrientCharacterControllerToGroundImmediate()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "LateUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterControllerFromBatch")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OrientCharacterControllerToGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool GetHitInfoUnderCharacterControllerFromBatch(out RaycastHit hitInfo)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[CallerCount(Count = 0)]
	private float GetLastSafeheight(float y)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool GetHitInfoUnderCharacterController(out RaycastHit hitInfo, FindGroundType findGroundType)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public SpherecastCommand GetCommandUnderCharacterController()
	{
		return default(SpherecastCommand);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool GetHitInfoUnderPivot(out RaycastHit hitInfo)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "SetLookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 43)]
	private void AlignTransformWithNormal(Vector3 terrainPoint, Vector3 normal, bool isRollConstrained, bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	public void SetJobGroundRaycastId(int id)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterRooted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ProcessRooted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	public void EnterScratchingAntlers()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitScratchingAntlers()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "OnStumpApproached")]
	[Calls(Type = typeof(BaseAi), Member = "IsOrientationValid")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void ProcessScratchingAntlers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanStickToGround(out Vector3 newPosition, Vector3 desiredPosition)
	{
		newPosition = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public bool IsOrientationValid(ScratchingStump stump)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 21)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnStumpReached()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScratchingStump), Member = "SelectRandomStump")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private bool MaybeSelectScratchingStump(out Vector3 wanderPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterScriptedSequence()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitScriptedSequence()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ProcessScriptedSequence()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterSleep()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitSleep()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopSleepingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessSleep()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void StopStalkingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateStalkingFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateScent")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	public void ProcessStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void MaybeForceStalkPlayer()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateScent()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	private void MaybeEnterAttackModeWhenStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 22)]
	private void MaybeInvestigateMeatWhenStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	private bool CanEnterStalking()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateStalkingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateStalkingFollowDistance()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "GetStalkSpeedWhenTrackingPlayer")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdatePathfinding()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private float GetStalkSpeedWhenTrackingPlayer(AiTarget playerTarget)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeChangeCuriousState()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool EnterStalkingModeIfPossible(Vector3 targetPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeLoseInterestWhileStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetNextChangeCuriousStateCheckTime()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetNextLoseInterestCheckTime()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetRandomNavmeshPos(Vector3 pos)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeForceFasterStalkingSpeed()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool UseFixedStalkingSpeed()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void EnterStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ProcessStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ExitStruggle()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopStruggleAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public bool CanEnterPlayerStruggle()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void DoPostSpearStruggleBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private float GetIgnoreFootStepsAndSmellsAfterStruggleSeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_SpearStruggleComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void OnSpearStruggleEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnBearBreakStruggle()
	{
	}

	[CallerCount(Count = 0)]
	public bool WasHitBySpear()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool WasHitBySpearFatal()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasEnteredStruggleOnLastAttack()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	public void OnMooseStartStompAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnAnimationEvent_MooseButtHeadAttackComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAnimationEvent_PlayMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAnimationEvent_StopMauledMuffle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	public void OnAnimationEvent_SpearStruggleComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "SpearDisengageReady")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnAnimationEvent_SpearDisengageReady()
	{
	}

	[CallerCount(Count = 0)]
	public float GetSpearStruggleTapCount()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetSpearStruggleTapCount(int tapCount)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public void EnterWander()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ExitWander()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool MaybeHoldGroundAuroraField()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[Calls(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetPointsForGradualTurn")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetClosestActiveFieldDistance")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 25)]
	public void ProcessWander()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopWanderAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldBorder")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 16)]
	private bool MaybeMoveWanderPosOutsideOfField(out Vector3 wanderToPos, Vector3 originalPosition)
	{
		wanderToPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomWanderDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
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
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private bool PickWanderDestinationAwayFromPoint(out Vector3 wanderPos, Vector3 awayPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetWanderPosAfterStruggle(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool PickClosestWanderDestinationAtPoint(out Vector3 wanderPos, Vector3 toPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 28)]
	private bool PickWanderDestination(out Vector3 wanderPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool PickEmergencyWanderDestination(out Vector3 wanderPos, Vector3 toPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool WanderTimedOut()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool WanderDoingGradualTurn()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeImposter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitWanderPaused()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWander")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetNextWanderPauseTime()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void MaybeEnterWanderPause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ForceWanderPause(int wanderPauseId)
	{
	}

	[CalledBy(Type = typeof(OnWanderPauseComplete), Member = "OnStateExit")]
	[CalledBy(Type = typeof(OnWanderPauseStartBear), Member = "OnStateEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CallsUnknownMethods(Count = 1)]
	public void OnWanderPauseAnimStateExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnWanderPauseComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	private void DebugAiStateTrace(AiMode mode, string locationTag)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateImposterAnimatorCulling")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeMakeWildlifeFlee")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsImposter()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasUpdated()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MoveAgent), Member = "Initialize")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 47)]
	public bool CreateMoveAgent(Transform parent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Anim")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 17)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Pathfinding")]
	[Calls(Type = typeof(BaseAiManager), Member = "Add")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(CapsuleCollider), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CallsUnknownMethods(Count = 1)]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsUnknownMethods(Count = 1)]
	public void SetPosition(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetRotation(Quaternion rotation)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void SetCollisionMode(CollisionDetectionMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsMoveAgent()
	{
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(AiUtils), Member = "PointTowardsDirection")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(PackAnimal), Member = "Start")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(SpeedForPathfinding), Member = "OnStateUpdate")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MoveAgent GetMoveAgent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsMoveAgentEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public bool IsPlayerFacingAi()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsPlayerFacingAi(Vector3 aiToTarget, float dotProductThreshold)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "UpdateHeadTrackingIk")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	private void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	public void DoLateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public bool RequiresDeferredDeserialize()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public BaseAiData GetDeferredDeserializeData()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void DeferredDeserialize(BaseAiData bad)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Serialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[Calls(Type = typeof(PackAnimal), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 45)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BaseAiDataProxy GetBaseAiDataProxyFromText(string text)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	public void DeserializeUsingBaseAiDataProxy(BaseAiDataProxy proxy)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void ProcessCurrentAiMode()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsInFlashLight()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTimberwolf()
	{
		return false;
	}

	[CallerCount(Count = 193)]
	[Calls(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "InRangeOfTargetWaypoint")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "IsStunTimerActive")]
	[Calls(Type = typeof(BaseAi), Member = "ExitAttack")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "ExitFlee")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "ExitStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "EnterWander")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInteractWithProp")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "EnterHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "EnterJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAiStateSwitch")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 35)]
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
		return 0f;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableAuroraMaterials(bool enable)
	{
	}

	[CalledBy(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnCarcassPickedUp")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "Reset")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "OnDespawn")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void Despawn()
	{
	}

	[CallerCount(Count = 0)]
	public float GetGoalSpeed()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetTurnSpeedDegreesPerSecond()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetGoalSpeed(float speed)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSpeedOverride(float speedVal)
	{
	}

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
	public DamageSide GetLastDamageSide()
	{
		return default(DamageSide);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(BaseAiManager), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	private void StopLoopingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWolfFleeModifier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void DoCustomModeModifiers()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	private void CantReachTarget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 41)]
	public BaseAi()
	{
	}
}
