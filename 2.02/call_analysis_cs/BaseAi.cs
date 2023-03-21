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
		[CallerCount(Count = 2)]
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
			[CallerCount(Count = 2)]
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

		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
		[CalledBy(Type = typeof(BaseAi), Member = "Start_Anim")]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ExitFollowWaypoints()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public void SetWaypoints(Vector3[] waypoints)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetWaypoint")]
	[CallerCount(Count = 0)]
	public void ProcessFollowWaypoints()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	public void PathfindToCurrentTargetWaypoint()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 13)]
	public void TeleportToRandomWaypointAndPathfind()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private int GetClosestWaypointIndex()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextWaypoint")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(SpawnRegion), Member = "ShouldSleepInDenAfterWaypointLoop")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void HandleLastWaypoint()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private bool ReachedTargetWaypoint()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetWaypointBehavior")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
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

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafeFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "GetClosestWaypointIndex")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetWaypointCircuit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	private void DoEnterFollowWaypoints()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 3)]
	private void DoReachedTargetWaypointBehavior()
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

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(Action_SetBearPatrolPointsOfInterest), Member = "DoWork")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetPointsOfInterest(PointOfInterest[] pointsOfInterest)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DoRandomOrderPointOfInterest(bool doRandom)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetPointOfInterest")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	public void ProcessPatrolPointsOfInterest()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessSafePatrolPointsOfInterest")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterPatrolPointsOfInterest")]
	private void PathfindToPointOfInterest(int index)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	private void PathfindToNextPointOfInterest()
	{
	}

	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool ReachedTargetPointOfInterest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool ProcessSafePatrolPointsOfInterest()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToPointOfInterest")]
	private void DoEnterPatrolPointsOfInterest()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	private void DoReachedTargetPointOfInterestBehavior()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void RoarAndReturnToPatrol(Vector3 lastKnownPosition)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void EnterStunned()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ProcessStunned()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ExitStunned()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BaseAi), Member = "Stun")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAIModeAllowStunFromThrownStone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void MaybeStunnedByStone(ContactPoint[] contacts)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetStunTimer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void Stun(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStunnedByStone")]
	[CallerCount(Count = 1)]
	private bool CurrentAIModeAllowStunFromThrownStone()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private float GetChanceStunFromThrownStone()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool IsStunTimerActive()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void UpdateAiming()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[Calls(Type = typeof(BaseAi), Member = "SetIkInfo")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsUnknownMethods(Count = 24)]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void UpdateAimingIk()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private AvatarIKHint GetHintForGoal(AvatarIKGoal avatarIKGoal)
	{
		return default(AvatarIKHint);
	}

	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Animator), Member = "SetIKPositionWeight")]
	private void SetIkInfo(AvatarIKGoal avatarIKGoal, Transform target, Transform hint, float weight, bool useHint)
	{
	}

	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(FootstepInfo), Member = ".ctor")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsUnknownMethods(Count = 150)]
	[CallsDeduplicatedMethods(Count = 61)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public void Start_Anim()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	public void UpdateAnim()
	{
	}

	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetIsOnScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateWolf")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaHeadAngleParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDeltaYawAngleParameter")]
	[CallerCount(Count = 13)]
	public void AnimSetFloat(int id, float value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void AnimSetFloat(int id, float value, float dampTime, float deltaTime)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetRandomFeedingAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AnimSetLookAtPosition(Vector3 pos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[CallAnalysisFailed]
	public void SetAnimationParameters()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallerCount(Count = 0)]
	public void SetDeltaYawAngleParameter(float deltaAngle)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallerCount(Count = 0)]
	public void SetDeltaHeadAngleParameter(float deltaAngle)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSpeedForPathfindingSystem()
	{
	}

	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(ParticleSystem), Member = "Play")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void OnBreathEffect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[DeduplicatedMethod]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallerCount(Count = 0)]
	public void OnFootStepFrontLeft(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[CallerCount(Count = 0)]
	public void OnFootStepFrontRight(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
	[CallerCount(Count = 0)]
	public void OnFootStepBackLeft(string audioEventName)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "PlaceFootPrintDecal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PlayFootStepAudio")]
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
	[CallerCount(Count = 2)]
	public void AnimationEndSniff()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void AnimationEndWanderPause()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeTriggerEvent")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CallerCount(Count = 2)]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetWeapon()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[CallerCount(Count = 0)]
	private void HandleFootprintsForDespawn()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void HandleFootprint(string audioEvent, Foot foot)
	{
	}

	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
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

	[Calls(Type = typeof(BaseAi), Member = "PositionOverlapsRecentFootprints")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_FrontLeft")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted_BackRight")]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, Foot foot)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldPlaceFootPrintDecal()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepBackLeft")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontRight")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnFootStepFrontLeft")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void PlayFootStepAudio(string audioEventName, Foot foot)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateActiveRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomId")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetNextRandomIdTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	private void UpdateActiveRandomId()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnGetRandomId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextRandomIdTime")]
	private void GetRandomId()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void SetSpeedAnimationParameter()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[CallsUnknownMethods(Count = 3)]
	private void SetTurnSpeedAnimationParameter()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void SetTurnAngleParameters(Animator animator, float totalTurnAngle, float turnSpeed, Vector3 turnHeading, Vector3 forward, int turnAngleParam)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Utils), Member = "AngleDir")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetTargetHeadingParameter()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPitchRollParameters")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private float GetFlattenedAngle(Vector3 inVec)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetFlattenedAngle")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(BaseAi), Member = "GetFlattenedAngle")]
	private void SetPitchRollParameters()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void SetAnimStateForMoveAgent(MoveState moveState, int animState)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SetAiStateParameter()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	private void SetWoundedParameter()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeUpdateStandingOnMaterialTag()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnPlaceFootPrintDecalRaycastCompleted")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetDefaultCullmode()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[Calls(Type = typeof(BaseAi), Member = "CanFallToSide")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetupDamageForAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetDamageImpactParameter(DamageSide side, int bodyPart, SetupDamageParamsOptions setupDamageParamsOptions)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	private bool CanFallToSide(DamageSide side)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private float GetSpeedFromMecanimBone()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetCullModeAlways")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	public void EnterAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ExitAttack()
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitAttack")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopAttackAudio()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetPositionForHold")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void MaybeAdjustTargetPosition(Vector3 targetPosition)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	private Vector3 GetPositionForHold(Vector3 targetPosition, float radius)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float GetAverageSlope()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	private bool MaybeFleeOnSlope()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(BearSpearItem), Member = "GetAngleBetweenSpearAndBearHeadings")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeSpearAttackTooLate()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(BaseAi), Member = "RoarAndReturnToPatrol")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
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
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	public void ProcessAttack()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetCurrentRadiusToHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	private Vector3 GetCurrentHoldGroundCausePosition(HoldGroundReason reason)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(LoadScene), Member = "Cancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "Begin")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpearAttackTooLate")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	public void MaybeApplyAttack()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	public bool AttackOrFleeAfterNearMissGunshot(GunType gt)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Action_ForceAIToAttackPlayer), Member = "DoWork")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[CallsUnknownMethods(Count = 6)]
	public bool EnterAttackModeIfPossible(Vector3 attackPos, bool suppressAttackStartAnimation)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "DistanceToNearestSpearable")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanBeHitBySpear()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "GetAttackLineOfSightLayerMask")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayBearAttackStartAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldPlayTimberwolfAttackStartAnimation()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	private void PlayMeleeAttackAudio()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void UpdateAttackingAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private int GetAttackLineOfSightLayerMask()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetSpeedForCurrentRadius(float initialSpeed, float initialRadius, float currentRadius, float innerRadius)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateSpeedForHoldWithSlowdown()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	private float GetOuterRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsScaredReason")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	private float GetInnerRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "UpdateSpeedForHoldWithSlowdown")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private bool UpdateForHoldWithSlowdown()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool MaybeHoldGroundForSpearForAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	private bool MaybeHoldGroundForTorchForAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	private bool MaybeHoldGroundForRedFlareForAttack()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 1)]
	private bool MaybeHoldGroundForFireForAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForAttack")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private bool MaybeHoldGroundForBlueFlareForAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetOuterRadiusForHoldGroundCause")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpearForAttack")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFireForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareForAttack")]
	[CallsUnknownMethods(Count = 3)]
	private bool MaybeHoldGroundForAttack(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallerCount(Count = 1)]
	private bool MaybeHoldGroundAuroraFieldForAttack()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAdjustTargetPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	private bool MaybeHoldGroundDueToSafeHaven()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	private float GetCurrentRadiusToHoldGroundCause(HoldGroundReason reason)
	{
		return default(float);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	private AuroraField GetVisibleFieldNearby(float radius)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	private bool IsFieldVisible(AuroraField field, float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool IsScaredReason(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 67)]
	[Calls(Type = typeof(BaseAi), Member = "GetInnerRadiusForHoldGroundCause")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	public bool IsTooScaredToAttack()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CallerCount(Count = 0)]
	public void OnCarcassPickedUp()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(BodyHarvest), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "SkipSpawnChanceRollInitialDecayAndAutoEvolve")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CallerCount(Count = 1)]
	public GearItem SpawnCarcassPickup()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "HasSpawnedCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "CanSpawnCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeSpawnCarcassSiteIfFarEnough()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	public void Start_Common()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateWounds")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	private void ProcessCommonPre()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearSpearItem), Member = "UpdateCollision")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeCollideWithSpear()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void MaybeRestoreTargetAfterSpear()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	private void ProcessCommonPost()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeDestroyIfFellThroughWorld()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	public void MovedDistance(Vector3 delta)
	{
	}

	[CallerCount(Count = 53)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	public void ClearTarget()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ReturnToDefaultBehavior()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Start_Damage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	public void SetupDamageForAnim(Vector3 hitPosition, Vector3 hitSource, LocalizedDamage localizedDamage)
	{
	}

	[CallerCount(Count = 0)]
	public float GetBleedingOutMinutesRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyOneTimeDamage")]
	[CalledBy(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(ArrowItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnStruggleHitEnd")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[CalledBy(Type = typeof(ToxicFogManager._003C_003Ec), Member = "<MaybeKillAllWildlife>b__56_0")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WolfTap")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "ApplyContinuousDamage")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public void ApplyDamage(float damage, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[CalledBy(Type = typeof(BearSpearItem), Member = "IsDamageFatal")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	public bool IsDamageFatal(float damage, DamageSource damageSource)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "SetDamageImpactParameter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	public void UpdateWounds(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public float GetNormalizedCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsBleedingOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	public DamageSource GetDamageSource()
	{
		return default(DamageSource);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetWoundedParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "AdustMovementSpeedForInjury")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[CallerCount(Count = 4)]
	public float GetWoundedAnimParameter()
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float AdustMovementSpeedForInjury(float baseSpeed)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetail), Member = "Register")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeCollisionCapsulesLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 62)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 38)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FootstepTrail), Member = "Close")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void EnterDead()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ProcessDead()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleAuroraMaterials()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void ExitDead()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void ChangeCollisionCapsulesLayer(int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start_AiDebug()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "IgnoreAudioEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	public void ProcessAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	public bool CanSeeTarget()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(NPC), Member = "FindNearest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	public void ScanForNewTarget()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BearSpearItem), Member = "OnAiCollidedWithSpear")]
	[Calls(Type = typeof(PlayerStruggle), Member = "BeginSpearStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnSpearHit(bool isFatal, Action onSpearStruggleEnd)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessIdle")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public void ScanForSmells()
	{
	}

	[CallerCount(Count = 0)]
	public void IngoreFootStepsAndSmellsForSeconds(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[Calls(Type = typeof(AiTarget), Member = "IsAmbient")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IncrementWaypoint")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ChangeModeWhenTargetDetected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanBearSeePlayerAfterSpearStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldScanForSmells")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	private bool TargetCanBeIgnored(AiTarget target)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool IgnoreAudioEvent(GameObject sender, Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	private void ProcessGenericAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ProcessFootstepAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAudioEvent")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ProcessGunshotAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float GetRangeFromScentIntensity(float scentIntensity)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "SmellLost")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private bool CanSmellSource(Vector3 sourcePos, AiTarget target)
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitInvestigateSmell")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	private void SetNextSmellCheckTime()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	private void DoTargetDetectedWhileFeeding()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanDodge()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerAThreat")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "DisableDodgeObstacle")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "EnableDodgeObstacle")]
	[Calls(Type = typeof(BaseAi), Member = "DoesPositionIntefereWithAttacks")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	private void MaybeAttemptDodge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HasDodgePlacementTimedOut()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool IsPlayerAThreat()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsMovingTowardsOrAwayFromPlayer(Vector3 moveDirection, Vector3 playerDirection)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	private bool DoesPositionIntefereWithAttacks(Vector3 pos, float radius, Vector3 playerPos)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 2)]
	private void SetDebugSphere(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	private Vector3 ComputeDodgeObstaclePosition(Vector3 pos, Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void DisableDodgeObstacle()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void EnableDodgeObstacle(Vector3 pos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterFeeding()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetFeedingTimeRemainingHours()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitFeeding")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StopFeedingAudio()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DecimateCarcass(float hours)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldStopFeeding()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private void SetBestFeedingTarget(Vector3 feederPos)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	private void ProcessFakeFeeding()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "DecimateCarcass")]
	[Calls(Type = typeof(BaseAi), Member = "DecimateCarcass")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetBestFeedingTarget")]
	private void ProcessRealFeeding()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[CallerCount(Count = 3)]
	private void MaybeAttackOrHoldGround()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessRealFeeding")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BaseAi), Member = "GetFeedingPos")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void TurnTowardsFeedingPos()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CallsUnknownMethods(Count = 8)]
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
	[Calls(Type = typeof(BaseAi), Member = "PlayEnterFleeAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	public void EnterFlee()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ExitFlee()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void StopFleeAudio()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool MaybeHandleTimeoutFleeing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeAttackPlayerWhenTryingToFlee")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedOverride")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHandleTimeoutFleeing")]
	public void ProcessFlee()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(ArrowItem), Member = "MaybeScareWildlife")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public void MaybeFleeFromArrow(ArrowItem ai)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void SetForcedFleePos(Vector3 pos)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CurrentAiModeAllowFleeFromThrownItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDetonation")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[Calls(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(ContactPoint), Member = "get_otherCollider")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public static void MaybeFleeFromThrownItem(GearItem item, ContactPoint[] contacts)
	{
	}

	[CalledBy(Type = typeof(ScareTrigger), Member = "OnTriggerEnter")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "InflictDamage")]
	[CallerCount(Count = 3)]
	public bool MaybeFleeFromFlareGunRound(FlareGunRoundItem fgri, float rangeScalar)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ProcessHitByPlayer")]
	[CallsUnknownMethods(Count = 1)]
	public void PlayEnterFleeAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceFleeFromHeldItem()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	private float GetFleeProximityFromNearbyThrownItem(GearItem item)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetChanceFleeFromNearbyThrownItem(GearItem item, bool wasHit)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public void MaybeFleeDueToTorchSwing()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool OverrideXpModeAttackRestrictions()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "IsMismatchWildlifeMode")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	public bool IsMismatchWildlifeMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoTargetDetectedWhileFeeding")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsMoose")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldAlwaysFleeFromCurrentTarget()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickNewGroupFleeLeader")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetStopFleeAfterDistanceForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	private bool KeepFleeingFromTarget()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "KeepFleeingFromTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private float GetStopFleeAfterDistanceForSpear()
	{
		return default(float);
	}

	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	private bool MaybePickFleeDestinationFromAreaMarkup(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private bool PickFleeDesination(out Vector3 fleePos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref fleePos) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CurrentAiModeAllowFleeFromThrownItem(GearItem item)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowFleeFromTorchSwing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "GetWoundedAnimParameter")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeAttackPlayerWhenTryingToFlee()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 0)]
	private bool ShouldPlayEnterFleeAudio()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void WarnOthersNearby()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "BecomeGroupFleeLeader")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PickNewGroupFleeLeader()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool IsGroupFleeLeader()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool CanKnockdownPlayer(AiSubType ast)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromArrow")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnReleased")]
	public void FleeFrom(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void FleeFrom(Vector3 pos)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void GoToPoint(Vector3 point, AiMode targetMode, float movementSpeed)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_NPC_GoTo_Marker")]
	[CallsUnknownMethods(Count = 4)]
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
	[CallerCount(Count = 2)]
	public void ExitGoToPoint()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 2)]
	public void UpdateHeadTracking()
	{
	}

	[Calls(Type = typeof(Animator), Member = "SetLookAtWeightInternal")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimatorIK")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "CheckIfInIKPass")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void UpdateHeadTrackingIk()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void ForceSetPlayerTarget()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	public bool CanPerformPassingAttackChance()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	public bool CanPerformPassingAttack()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnterHideAndSeek()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	private float GetClosingDistancePercent()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float GetMinFollowDistance()
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	private float GetMaxFollowDistance()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float GetComfortableFollowDistance()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	public bool TriggerPassingAttackAnim()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitHideAndSeek")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallsUnknownMethods(Count = 2)]
	public void StopHideAndSeekAudio()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 8)]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "FindShortestDistanceToPlayerSide")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	private Vector3 FindTacticalPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private void ResetApproachDistance()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
	[Calls(Type = typeof(BaseAi), Member = "GetClosingDistancePercent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[CallerCount(Count = 0)]
	private void ExitHideAndSeek()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	private bool CanEnterHideAndSeekInternal()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	public bool CanEnterHideAndSeek()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public bool MaybeForceHideAndSeek()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	private void SetStopHoldGroundTimers()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterHoldGround()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ExitHoldGround()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	public void StopHoldGroundAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool WasHoldingGroundRecently()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	private bool MaybeHoldGroundForField()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private bool MaybeAttackOrFleeIfHoldGroundForFieldChanged(bool holdGroundForField)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetStopHoldGroundTimers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "HoldGroundSafeHaven")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	public void ProcessHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundDueToStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingRaisedSpear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	private bool MaybeHoldGroundForSpear(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool MaybeHoldGroundForRedFlare(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private bool MaybeHoldGroundForRedFlareOnGround(float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool MaybeHoldGroundForBlueFlare(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private bool MaybeHoldGroundForBlueFlareOnGround(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitTorch")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool MaybeHoldGroundForTorch(float radius)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private bool MaybeHoldGroundForTorchOnGround(float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	private bool MaybeHoldGroundForFire(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlareOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorchOnGround")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToStruggle")]
	private void MaybeHoldGround()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	private void HoldGroundForMoose()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	private void HoldGroundFightOrFlight()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "GetModifiedAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void HoldGroundCommon(float timeStopHoldingGround, float chanceAttackOnTimeout)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	private void HoldGroundSafeHaven()
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForField")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 2)]
	private void HoldGroundInsideAuroraField()
	{
	}

	[CallerCount(Count = 0)]
	private bool CurrentAiModeAllowsHoldGround()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsTargetGoneOrOutOfRange()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeFleeFromHoldGround()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "InitializeHoldForFieldTimers")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetPlayerSafeHaven")]
	private void MaybeEnterHoldGroundForAuroraField()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrFleeIfHoldGroundForFieldChanged")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterHoldGroundForAuroraField")]
	[CallsUnknownMethods(Count = 12)]
	private void InitializeHoldForFieldTimers()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ClearHowlStartDelay()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetRemainingHowlDelay()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_HowlComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public float SetHowlStartDelay(float baseTime)
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	private void EnterHowl()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ExitHowl()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AdvanceToNextBehavior")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	private void ProcessHowl()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void AdvanceToNextBehavior()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterIdle()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void ExitIdle()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void ProcessIdle()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterInteractWithProp()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ExitInteractWithProp()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ProcessInteractWithProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnInteractWithPropComplete()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAttachPropInMarker")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public Transform FindTransform(string transformName)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "FindTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void OnAttachPropInMarker()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	public void EnterInvestigate()
	{
	}

	[CallerCount(Count = 0)]
	public void ExitInvestigate()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Time), Member = "get_time")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldExtent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	private void MaybeMoveInvestigationPositionOutsideOfField()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 1)]
	public void EnterInvestigateFood()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void ExitInvestigateFood()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void StopInvestigateFoodAudio()
	{
	}

	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(BaseAi), Member = "CloseEnoughToEatObject")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ProcessInvestigateFood()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CloseEnoughToEatObject(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	private void MaybeClearTarget()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnterInvestigateSmell()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	public void ExitInvestigateSmell()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SmellLost")]
	public void ProcessInvestigateSmell()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanSmellSource")]
	[Calls(Type = typeof(AiTarget), Member = "EmitsTrackableSmell")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	private bool SmellLost()
	{
		return default(bool);
	}

	[Calls(Type = typeof(WolfHowlController), Member = "StartResponseHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	public bool MaybeStartOrJoinPackHowl()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void EnterJoinPack()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(BaseAi), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CallerCount(Count = 1)]
	private void ProcessJoinPack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	private void ExitJoinPack()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
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

	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_OnPassingAttackChomp")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	private void DoPassingAttackDamage()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void ExitPassingAttack()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Start_Pathfinding()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	public bool TryGetClosestNavmeshPoint(Vector3 position, out Vector3 result)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref result) = null;
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPlayerInStealthArea")]
	public bool CanPlayerBeReached(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGenericAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalkingModeIfPossible")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	public bool CanPathfindToPosition(Vector3 pos)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	public void MoveAgentStop()
	{
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(MoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "SetMoveSpeed")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
	[CallerCount(Count = 0)]
	public void OrientPivotToGroundImmediate()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	public void StickCharacterControllerToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	public void OrientCharacterControllerToGroundImmediate()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterControllerFromBatch")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "LateUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	public void OrientCharacterControllerToGround()
	{
	}

	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	private bool GetHitInfoUnderCharacterController(out RaycastHit hitInfo, FindGroundType findGroundType)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallsUnknownMethods(Count = 3)]
	public SpherecastCommand GetCommandUnderCharacterController()
	{
		return default(SpherecastCommand);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[CalledBy(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	private bool GetHitInfoUnderPivot(out RaycastHit hitInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGroundImmediate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "SetLookRotation")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientCharacterControllerToGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "OrientPivotToGroundImmediate")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	private void AlignTransformWithNormal(Vector3 terrainPoint, Vector3 normal, bool isRollConstrained, bool isImmediate)
	{
	}

	[CallerCount(Count = 0)]
	public void SetJobGroundRaycastId(int id)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallerCount(Count = 0)]
	public void EnterRooted()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "IsOrientationValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "OnStumpApproached")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	public void ProcessScratchingAntlers()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool CanStickToGround(out Vector3 newPosition, Vector3 desiredPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref newPosition) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 5)]
	public bool IsOrientationValid(ScratchingStump stump)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public void OnStumpApproached(ScratchingStump stump)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnStumpMissed()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnStumpReached()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScratchingStump), Member = "SelectRandomStump")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitScriptedSequence()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void ProcessScriptedSequence()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	public void EnterSleep()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitSleep()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	public void StopSleepingAudio()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void ProcessSleep()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallerCount(Count = 1)]
	public void EnterStalking()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ExitStalking()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public void StopStalkingAudio()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomWanderDuration")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateStalkingFollowDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateScent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void ProcessStalking()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void MaybeForceStalkPlayer()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	private void UpdateScent()
	{
	}

	[Calls(Type = typeof(AiTarget), Member = "IsVulnerable")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	private void MaybeEnterAttackModeWhenStalking()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(FireManager), Member = "GetDistanceToClosestFire")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private void MaybeInvestigateMeatWhenStalking()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPlayerBeReached")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 3)]
	private bool CanEnterStalking()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateStalkingAudio()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateStalkingFollowDistance()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetStalkSpeedWhenTrackingPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	private void UpdatePathfinding()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private float GetStalkSpeedWhenTrackingPlayer(AiTarget playerTarget)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextChangeCuriousStateCheckTime")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeChangeCuriousState()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeRestoreTargetAfterSpear")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	public bool EnterStalkingModeIfPossible(Vector3 targetPos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextLoseInterestCheckTime")]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeLoseInterestWhileStalking()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeChangeCuriousState")]
	[CallsUnknownMethods(Count = 3)]
	private void SetNextChangeCuriousStateCheckTime()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeLoseInterestWhileStalking")]
	private void SetNextLoseInterestCheckTime()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetRandomNavmeshPos(Vector3 pos)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BaseAi), Member = "UseFixedStalkingSpeed")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeForceFasterStalkingSpeed()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdatePathfinding")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceFasterStalkingSpeed")]
	private bool UseFixedStalkingSpeed()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AnimationUtils), Member = "HasParameter")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void EnterStruggle()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProcessStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void ExitStruggle()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	public void StopStruggleAudio()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public bool CanEnterPlayerStruggle()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnBearBreakStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "FleeFrom")]
	private void DoPostSpearStruggleBehavior()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private float GetIgnoreFootStepsAndSmellsAfterStruggleSeconds()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnAnimationEvent_SpearStruggleComplete")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "ResetHipAndShoulderOffsetLayer")]
	public void OnSpearStruggleEnd()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "OnPlayerDazed")]
	[Calls(Type = typeof(BaseAi), Member = "DoPostSpearStruggleBehavior")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_MooseButtHeadAttackComplete()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void OnAnimationEvent_PlayMauledMuffle()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_StopMauledMuffle()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "OnSpearStruggleEnd")]
	[CallerCount(Count = 0)]
	public void OnAnimationEvent_SpearStruggleComplete()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "SpearDisengageReady")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextWanderPauseTime")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void EnterWander()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	public void ExitWander()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWanderPaused")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	private bool MaybeHoldGroundAuroraField()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetClosestActiveFieldDistance")]
	[Calls(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiUtils), Member = "GetPointsForGradualTurn")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceStalkPlayer")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSelectScratchingStump")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	public void ProcessWander()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnDisable")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "StopLoopingAudio")]
	public void StopWanderAudio()
	{
	}

	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraField), Member = "GetClosestPointOnFieldBorder")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 10)]
	private bool MaybeMoveWanderPosOutsideOfField(out Vector3 wanderToPos, Vector3 originalPosition)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderToPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 3)]
	public float GetRandomWanderDuration()
	{
		return default(float);
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	private bool PickWanderDestinationAwayFromPoint(out Vector3 wanderPos, Vector3 awayPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetWanderPosAfterStruggle(Vector3 pos)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 5)]
	private bool PickClosestWanderDestinationAtPoint(out Vector3 wanderPos, Vector3 toPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenMarkupGenerator")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindRandomAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool PickWanderDestination(out Vector3 wanderPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallerCount(Count = 1)]
	private bool PickEmergencyWanderDestination(out Vector3 wanderPos, Vector3 toPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref wanderPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeImposter()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsUnknownMethods(Count = 1)]
	public void EnterWanderPaused()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallerCount(Count = 0)]
	public void ProcessWanderPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ExitWanderPaused()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetNextWanderPauseTime()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void OnWanderPauseComplete()
	{
	}

	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	private void DebugAiStateTrace(AiMode mode, string locationTag)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(MatchTransform), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeMakeWildlifeFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ExitWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateImposterAnimatorCulling")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCommonPost")]
	public bool IsImposter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasUpdated()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(MoveAgent), Member = "Initialize")]
	public bool CreateMoveAgent(Transform parent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "Start_Anim")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAiManager), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CapsuleCollider), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "Start_Pathfinding")]
	[CallerCount(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[Calls(Type = typeof(Animator), Member = "set_cullingMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "StickCharacterControllerToGround")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StickPivotToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderPivot")]
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
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsUnknownMethods(Count = 1)]
	public void SetPosition(Vector3 position)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "UpdateCollisionMode")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	public void SetCollisionMode(CollisionDetectionMode mode)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	public bool IsMoveAgent()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 22)]
	public MoveAgent GetMoveAgent()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool IsMoveAgentEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 4)]
	public bool IsPlayerFacingAi()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttemptDodge")]
	public bool IsPlayerFacingAi(Vector3 aiToTarget, float dotProductThreshold)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "UpdateHeadTrackingIk")]
	[Calls(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	private void OnAnimatorIK()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void DeferredDeserialize(BaseAiData bad)
	{
	}

	[Calls(Type = typeof(BearHuntAiRedux), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(PackAnimal), Member = "Serialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallsUnknownMethods(Count = 45)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	public static BaseAiDataProxy GetBaseAiDataProxyFromText(string text)
	{
		return null;
	}

	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BaseAi), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	public void DeserializeUsingBaseAiDataProxy(BaseAiDataProxy proxy)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraField")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessSleep")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessScratchingAntlers")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpeedForPathfindingSystem")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessCommonPre")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "HandleAuroraMaterials")]
	[Calls(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "ReachedTargetWaypoint")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeWander")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeEnterWanderPause")]
	[Calls(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	public void ProcessCurrentAiMode()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundAuroraFieldForAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateForHoldWithSlowdown")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	public bool IsInFlashLight()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "OverrideXpModeAttackRestrictions")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromHeldItem")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "CanBeStunned")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "GetChanceFleeFromNearbyThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetFleeProximityFromNearbyThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	public bool IsTimberwolf()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigateFood")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "EnterHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(BaseAi), Member = "EnterFeeding")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterProxyFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "EnterHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "EnterInteractWithProp")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "EnterWander")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "EnterStalking")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(BaseAi), Member = "ExitStruggle")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 193)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAiStateSwitch")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseAi), Member = "SetNextSmellCheckTime")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "ExitFlee")]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "InRangeOfTargetWaypoint")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(BaseAi), Member = "IsStunTimerActive")]
	[Calls(Type = typeof(BaseAi), Member = "ExitAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "GoToCurrentWaypoint")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	public void EnableAuroraMaterials(bool enable)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[CalledBy(Type = typeof(AiUtils), Member = "DespawnHostileAiAroundPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnCarcassPickedUp")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetActive")]
	[CalledBy(Type = typeof(WildlifeItem), Member = "OnKilled")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessBodyHarvestInteraction")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "OnDespawn")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAllSoundsFromGameObject")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 13)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetBaseAiSpeedOverride), Member = "DoWork")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = "OnExecute")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 15)]
	private void OnDrawGizmos()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(BaseAiManager), Member = "Remove")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopWanderAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStalkingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopSleepingAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopInvestigateFoodAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopFeedingAudio")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void StopLoopingAudio()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWolfFleeModifier")]
	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomWildlifeDetectionModifier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private void DoCustomModeModifiers()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "ClearAttackCooldownTimeOnAttackFailed")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	private void CantReachTarget()
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BaseAi()
	{
	}
}
