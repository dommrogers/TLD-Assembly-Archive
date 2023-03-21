using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using UnityEngine;

public class InvisibleEntityManager : MonoBehaviour
{
	public enum Behavior
	{
		Attack,
		Countdown,
		CountdownCompleted,
		Done,
		Init,
		Load,
		Move,
		Ward
	}

	[Serializable]
	public class BehaviorRange
	{
		public LocalizedString m_DisplayName;

		public AfflictionType m_Affliction;

		public float m_MinRadius;

		public float m_MaxRadius;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public BehaviorRange()
		{
		}
	}

	private enum TargetType
	{
		Lure,
		Player
	}

	private struct WardData
	{
		public string m_Guid;

		public Vector3 m_Position;

		public float m_Radius;
	}

	public float m_MovementSpeedMin;

	public float m_MovementSpeedMax;

	public AnimationCurve m_MovementSpeedCurve;

	public float m_MaxMovementSpeedTimeMinutes;

	public List<BehaviorRange> m_BehaviorRanges;

	public GameObject m_WorldEntityPrefab;

	public float m_StartMovementDelayTimerMinutes;

	public float m_TimePassingScalar;

	public float m_WildlifeFleeRange;

	public SnowImprintType m_SnowImprintType;

	public float m_FootstepDistance;

	public float m_AttackCountdownTime;

	public float m_AttackRadius;

	public float m_SpawnDistanceFromPlayer;

	public float m_HoverRotationSpeedDegrees;

	public float m_SprayWardRadius;

	public float m_WardHoverAddedRadius;

	public float m_WardTransitionAreaRadius;

	public float m_IndicatorMinDistanceMeters;

	public float m_IndicatorMaxDistanceMeters;

	public float m_AudioIntesity;

	public string m_AttackFailureEvent;

	public string m_AttackStartEvent;

	public string m_AttackSuccessEvent;

	public string m_AttackWindupEvent;

	public string m_FootstepEvent;

	public string m_LureDestroyedEvent;

	public float m_AttackWindupTime;

	public string m_CountdownAudioEvent;

	public float m_DelayBetweenCaptions;

	public float m_CaptionDisplayTime;

	public float m_SuppressPlayerVoiceAtDistance;

	public string m_IndoorFootstepDefaultSurfaceTag;

	public float m_DarkWalkerDeathAnimationSafeDistance;

	public float m_DarkWalkerDeathAnimationSafeRadius;

	public List<string> m_AudioStartEvents;

	public List<string> m_AudioStopEvents;

	public static bool s_IsPaused;

	public static bool s_DebugEnable;

	private const int INVALID_INDEX = -1;

	private DarkWalker m_DarkWalker;

	private float m_AttackMovementSpeed;

	private float m_AttackTime;

	private Behavior m_BehaviorState;

	private int m_BehaviorIndex;

	private uint m_CountdownAudioID;

	private float m_DistanceToTarget;

	private float m_DistanceToPlayer;

	private string m_LastFootstepTag;

	private float m_MovementSpeedScalar;

	private Vector3 m_TargetLocation;

	private TargetType m_TargetType;

	private GameObject m_WorldEntityInstance;

	private Vector3 m_WorldPosition;

	private Vector3 m_WorldPositionPrevious;

	private float m_DistanceSinceLastFootstep;

	private bool m_IsLeftFoot;

	private FootstepTrail m_FootstepTrail;

	private BehaviorRange m_CurrentRange;

	private Vector3 m_EntityToPlayerPosition;

	public float m_EntityToPlayerOrientation;

	private float m_LastMovementSpeed;

	private float m_FearMaxRange;

	private float m_AnxietyMaxRange;

	private float m_FearAlpha;

	private float m_AnxietyAlpha;

	private float m_StartMovementDelayTimeSeconds;

	private float m_AccumulatedTimeSeconds;

	private float m_AccumulatedRealTimeSeconds;

	private List<WardData> m_Wards;

	private List<IndoorWardData> m_IndoorWardLocations;

	private List<string> m_RemoveGuids;

	private int m_ActiveWard;

	private float m_HoverRotationDirection;

	private List<DecalProjectorInstance> m_PlacedGlyphsDeserialize;

	private int m_PlayerInsideWard;

	private SphereCollider m_BanishmentAreaCollider;

	private static Collider[] s_transitionAreaColliders;

	private float m_MovementSpeedOverride;

	private float m_NextCaptionDisplayTime;

	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CallerCount(Count = 0)]
	public NowhereToHide.GlyphTypes GetActiveGlyph()
	{
		return default(NowhereToHide.GlyphTypes);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	public void AddWardIncludingForNearbyTransitions(DecalProjectorInstance instance, float radius)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateAwake")]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CallsUnknownMethods(Count = 14)]
	public void AddWard(string guid, Vector3 position, float radius)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetPlayerInsideWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetActiveWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsUnknownMethods(Count = 2)]
	public bool DoesWardGlyphExist()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsPlayerInsideWard()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsWardActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsLureActive()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Behavior GetBehaviorState()
	{
		return default(Behavior);
	}

	[CallerCount(Count = 0)]
	public float GetStartMovementDelayTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetDebugText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetDistanceToPlayer()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PlaceGlyphDeserialize(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDecalRemoved")]
	[CallsUnknownMethods(Count = 5)]
	public void RemoveGlyph(DecalProjectorInstance instance)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_BanishDarkwalker), Member = "OnExecute")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Move(float distance)
	{
	}

	[CallerCount(Count = 0)]
	public float GetRealTimeHoursPlayedUnpaused()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	public bool IsInAreaOfSceneTransition(Vector3 position)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void SetBanishmentArea(NowhereToHide_BanishmentArea banishmentArea)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMovementSpeedOverride(float speed)
	{
	}

	[CalledBy(Type = typeof(Condition_IsDarkwalkerInBanishmentArea), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityInBanishmentArea")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public bool IsInsideBanishmentArea(Vector3 position)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsEntityInBanishmentArea()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public float GetWardTimeRemainingScale(string guid)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsInAreaOfSceneTransition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleNowhereToHideEventSpecificBehaviour")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallerCount(Count = 4)]
	private IndoorWardData FindNearestSceneTransition(Vector3 position)
	{
		return default(IndoorWardData);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	private void AttemptToPlaceIndoorLocationWard(Vector3 position, string guid, float radius, float lifetimeHours, float hoursAtCreateTime)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsIndoorWardLocationForCurrentScene(IndoorWardData wardData)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	public bool HasIndoorWardProtectionForCurrentScene()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeApplyIndoorWardProtection()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float DetermineDistanceToPlayer()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void MaybeMakeWildlifeFlee()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float DetermineMovementSpeed()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdown")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	private float DetermineScaledDeltaTime()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	private bool DeterminePlayerActiveWard()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineTargetPosition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineDistanceToPlayer")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Move")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	private Vector3 DeterminePlayerPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	private Vector3 DetermineTargetPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "GetActiveGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	private bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CallsUnknownMethods(Count = 3)]
	private int FindWardThatOverlapsPosition(Vector3 pos)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityWithinCurrentRange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private BehaviorRange GetCurrentRange()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetMovementSpeedScalar()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private void MoveAwayFromTarget(float speed)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	private void MoveTowardsTarget(float speed)
	{
	}

	[Calls(Type = typeof(FootstepTrail), Member = "FadeFootprintsAtTrailEnd")]
	[Calls(Type = typeof(FootstepTrail), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FootstepTrail), Member = "IsVisible")]
	private void HandleFootprintsForDespawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	private bool IsEntityWithinCurrentRange()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	private void MaybePlaceFootstep()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void PlaceFootstep(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static HeavyFootstepEffectType GetHeavyFootstepEffectTypeBasedOnMaterial(string tag)
	{
		return default(HeavyFootstepEffectType);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeserializeGlobal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	private void PlayAudioEvent(string evt)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	private void PlayStartAudio()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayStopAudio()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdown")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateInit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(Anxiety), Member = "StopAffliction")]
	[Calls(Type = typeof(Fear), Member = "StopAffliction")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	private void SetBehaviour(Behavior newBehaviour)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void RemoveWardByGuid(string guid)
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_spawn")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	public void Spawn()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EntityDelayVolume), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(EntityDelayVolume), Member = "OnTriggerExit")]
	public void SetMovementSpeedScalar(float scalar)
	{
	}

	[CallerCount(Count = 0)]
	public void SetStartMovementDelayTime(float delayTimeSeconds)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_far")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_near")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public void SetRange(bool isNear)
	{
	}

	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateAttack()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	private void UpdateCountdown()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	private void UpdateCountdownCompleted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	private void UpdateInit()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UpdateLoad()
	{
	}

	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	private void UpdateMovement()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RemoveDecal(ProjectileType projectileType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateIndoorWardLifetime()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	private void UpdateWard()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "NowhereToHideAfflictionAlpha")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	private void UpdateAfflictionUI()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void CalculateAfflictionRanges()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	public string SerializeGlobal()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallerCount(Count = 1)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CalledBy(Type = typeof(Condition_CanPlayDarkWalkerDeathAnimation), Member = "OnCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	public bool CanPlayDarkWalkerDeathAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 59)]
	public InvisibleEntityManager()
	{
	}
}
