using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using TLD.Serialization;
using TLD.UI.Generics;
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
		[CallerCount(Count = 6)]
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

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Subtitles> m_Subtitles;

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CallsUnknownMethods(Count = 1)]
	public void AddWardIncludingForNearbyTransitions(DecalProjectorInstance instance, float radius)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CalledBy(Type = typeof(EntityWard), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(EntityWard), Member = "UpdateAwake")]
	public void AddWard(string guid, Vector3 position, float radius)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetPlayerInsideWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetActiveWardGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	public string GetDebugText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetDistanceToPlayer()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlaceGlyphDeserialize(DecalProjectorInstance instance)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDecalRemoved")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	public void RemoveGlyph(DecalProjectorInstance instance)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_BanishDarkwalker), Member = "OnExecute")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(Utils), Member = "IsSceneTransition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public void Move(float distance)
	{
	}

	[CallerCount(Count = 0)]
	public float GetRealTimeHoursPlayedUnpaused()
	{
		return default(float);
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallerCount(Count = 0)]
	public bool IsInAreaOfSceneTransition(Vector3 position)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void SetBanishmentArea(NowhereToHide_BanishmentArea banishmentArea)
	{
	}

	[CallerCount(Count = 0)]
	public void SetMovementSpeedOverride(float speed)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_IsDarkwalkerInBanishmentArea), Member = "OnCheck")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityInBanishmentArea")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsInsideBanishmentArea(Vector3 position)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsInsideBanishmentArea")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEntityInBanishmentArea()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public float GetWardTimeRemainingScale(string guid)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsInAreaOfSceneTransition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AttemptToPlaceIndoorLocationWard")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "HandleNowhereToHideEventSpecificBehaviour")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private IndoorWardData FindNearestSceneTransition(Vector3 position)
	{
		return default(IndoorWardData);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "AddWardIncludingForNearbyTransitions")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindNearestSceneTransition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void AttemptToPlaceIndoorLocationWard(Vector3 position, string guid, float radius, float lifetimeHours, float hoursAtCreateTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool IsIndoorWardLocationForCurrentScene(IndoorWardData wardData)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[CallsUnknownMethods(Count = 10)]
	public bool HasIndoorWardProtectionForCurrentScene()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "AddWard")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[CallerCount(Count = 1)]
	private void MaybeApplyIndoorWardProtection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallsUnknownMethods(Count = 1)]
	private float DetermineDistanceToPlayer()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Anxiety), Member = "StopAffliction")]
	[Calls(Type = typeof(Fear), Member = "StopAffliction")]
	[Calls(Type = typeof(Fear), Member = "StopAffliction")]
	[Calls(Type = typeof(Anxiety), Member = "StartAffliction")]
	[Calls(Type = typeof(Anxiety), Member = "StopAffliction")]
	[Calls(Type = typeof(Fear), Member = "StartAffliction")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybeMakeWildlifeFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeMakeWildlifeFlee()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallerCount(Count = 2)]
	private float DetermineMovementSpeed()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdown")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	private float DetermineScaledDeltaTime()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "FindWardThatOverlapsPosition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	private bool DeterminePlayerActiveWard()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "CanPlayDarkWalkerDeathAnimation")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetRange")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "MoveAwayFromTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CallerCount(Count = 18)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_addspace")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Move")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineTargetPosition")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DetermineDistanceToPlayer")]
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

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "GetActiveGlyph")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Start")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	private int FindWardThatOverlapsPosition(Vector3 pos)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsEntityWithinCurrentRange")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallsUnknownMethods(Count = 2)]
	private BehaviorRange GetCurrentRange()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetMovementSpeedScalar()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 1)]
	private void MoveAwayFromTarget(float speed)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private void MoveTowardsTarget(float speed)
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
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	private bool IsEntityWithinCurrentRange()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(RaycastManager), Member = "RequestAsyncRaycast")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "AddFootstepTrail")]
	[Calls(Type = typeof(FootstepTrail), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	private void MaybePlaceFootstep()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AddImpactDecal")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetHeavyFootstepEffectTypeBasedOnMaterial")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FootstepTrail), Member = "AddFootstep")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private void PlaceFootstep(RaycastHit hitOut)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	private static HeavyFootstepEffectType GetHeavyFootstepEffectTypeBasedOnMaterial(string tag)
	{
		return default(HeavyFootstepEffectType);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "AreSubtitlesVisible")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 6)]
	private void PlayAudioEvent(string evt)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	private void PlayStartAudio()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayStopAudio()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateMovement")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAttack")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStopAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Fear), Member = "StopAffliction")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Anxiety), Member = "StopAffliction")]
	private void SetBehaviour(Behavior newBehaviour)
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateIndoorWardLifetime")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "RemoveGlyph")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void RemoveWardByGuid(string guid)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateCountdownCompleted")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_invisibleentity_spawn")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	public void Spawn()
	{
	}

	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public void SetRange(bool isNear)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateAttack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateAudio()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	private void UpdateCountdown()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(ToxicFogManager), Member = "InitCurrentRegion")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Spawn")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCountdownCompleted()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	private void UpdateInit()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayStartAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "CalculateAfflictionRanges")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybeApplyIndoorWardProtection")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlaceGlyph")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateLoad()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetCurrentRange")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MaybePlaceFootstep")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "MoveTowardsTarget")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SetBehaviour")]
	private void UpdateMovement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveDecal(ProjectileType projectileType)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "RemoveWardByGuid")]
	private void UpdateIndoorWardLifetime()
	{
	}

	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineMovementSpeed")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DetermineScaledDeltaTime")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerActiveWard")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "RotateAround")]
	private void UpdateWard()
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Update")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateAfflictionUI()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateLoad")]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateAfflictionRanges()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "PlayAudioEvent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Condition_CanPlayDarkWalkerDeathAnimation), Member = "OnCheck")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "HasHeadRoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeterminePlayerPosition")]
	public bool CanPlayDarkWalkerDeathAnimation()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 40)]
	public InvisibleEntityManager()
	{
	}
}
