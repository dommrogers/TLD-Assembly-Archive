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
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	public NowhereToHide.GlyphTypes GetActiveGlyph()
	{
		return default(NowhereToHide.GlyphTypes);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CallsUnknownMethods(Count = 1)]
	public void AddWardIncludingForNearbyTransitions(DecalProjectorInstance instance, float radius)
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "UpdateAwake")]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void AddWard(string guid, Vector3 position, float radius)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetPlayerInsideWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetActiveWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool DoesWardGlyphExist()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsPlayerInsideWard()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsWardActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLureActive()
	{
		return false;
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
		return 0f;
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void PlaceGlyphDeserialize(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDecalRemoved")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void RemoveGlyph(DecalProjectorInstance instance)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[CalledBy(Type = typeof(Action_BanishDarkwalker), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Move(float distance)
	{
	}

	[CallerCount(Count = 0)]
	public float GetRealTimeHoursPlayedUnpaused()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	public bool IsInAreaOfSceneTransition(Vector3 position)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetBanishmentArea(NowhereToHide_BanishmentArea banishmentArea)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMovementSpeedOverride(float speed)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityInBanishmentArea")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(Condition_IsDarkwalkerInBanishmentArea), Member = "OnCheck")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsInsideBanishmentArea(Vector3 position)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsEntityInBanishmentArea()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public float GetWardTimeRemainingScale(string guid)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsInAreaOfSceneTransition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleNowhereToHideEventSpecificBehaviour")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private IndoorWardData FindNearestSceneTransition(Vector3 position)
	{
		return default(IndoorWardData);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void AttemptToPlaceIndoorLocationWard(Vector3 position, string guid, float radius, float lifetimeHours, float hoursAtCreateTime)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsIndoorWardLocationForCurrentScene(IndoorWardData wardData)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public bool HasIndoorWardProtectionForCurrentScene()
	{
		return false;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeApplyIndoorWardProtection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float DetermineDistanceToPlayer()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybeMakeWildlifeFlee()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float DetermineMovementSpeed()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdown")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private float DetermineScaledDeltaTime()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	private bool DeterminePlayerActiveWard()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Move")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineDistanceToPlayer")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineTargetPosition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private int FindWardThatOverlapsPosition(Vector3 pos)
	{
		return 0;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityWithinCurrentRange")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private BehaviorRange GetCurrentRange()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetMovementSpeedScalar()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MoveAwayFromTarget(float speed)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MoveTowardsTarget(float speed)
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	private bool IsEntityWithinCurrentRange()
	{
		return false;
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 38)]
	private void MaybePlaceFootstep()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void PlaceFootstep(RaycastHit hitOut)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static HeavyFootstepEffectType GetHeavyFootstepEffectTypeBasedOnMaterial(string tag)
	{
		return default(HeavyFootstepEffectType);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeserializeGlobal")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void PlayAudioEvent(string evt)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayStartAudio()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayStopAudio()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdown")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateInit")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(Fear), Member = "StopAffliction")]
	[Calls(Type = typeof(Anxiety), Member = "StopAffliction")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void SetBehaviour(Behavior newBehaviour)
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void RemoveWardByGuid(string guid)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_spawn")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void Spawn()
	{
	}

	[CalledBy(Type = typeof(EntityDelayVolume), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(EntityDelayVolume), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetMovementSpeedScalar(float scalar)
	{
	}

	[CallerCount(Count = 0)]
	public void SetStartMovementDelayTime(float delayTimeSeconds)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_near")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_far")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SetRange(bool isNear)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateCountdown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(ToxicFogManager), Member = "DetermineCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateCountdownCompleted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	private void UpdateInit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateMovement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveDecal(ProjectileType projectileType)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void UpdateIndoorWardLifetime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateWard()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "NowhereToHideAfflictionAlpha")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateAfflictionUI()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void CalculateAfflictionRanges()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CalledBy(Type = typeof(Condition_CanPlayDarkWalkerDeathAnimation), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public bool CanPlayDarkWalkerDeathAnimation()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 59)]
	public InvisibleEntityManager()
	{
	}
}
