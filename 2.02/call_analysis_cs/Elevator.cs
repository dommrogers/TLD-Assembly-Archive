using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class Elevator : MonoBehaviour
{
	public enum EntranceSide
	{
		Left,
		Right
	}

	[Serializable]
	public class FloorData
	{
		public int m_RevsFromPrevFloor;

		public int m_FinalRev;

		public EntranceSide m_EntranceSide;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public FloorData()
		{
		}
	}

	private enum State
	{
		WaitingForPlayer,
		Entering,
		IdleDockedAtFloor,
		IdleMidProgress,
		MovingUp,
		MovingDown,
		CrashingDown,
		Exiting
	}

	public static bool s_ElevatorDebug;

	public LocalizedString m_LocalizedDisplayName;

	public EntranceSide m_BaseFloorEntranceSide;

	public List<FloorData> m_FloorsUp;

	public List<FloorData> m_FloorsDown;

	public GameObject m_LeftDoorInteractionCollider;

	public GameObject m_RightDoorInteractionCollider;

	public float m_StaminaCostToMove;

	public bool m_OnlyAllowMoveIfHasRequiredStamina;

	public float m_StaminaRequiredForFullSpeed;

	public float m_StaminaThresholdForPotentialDrop;

	public float m_StaminaDropChanceBelowThreshold;

	public float m_LowStaminaAnimationSpeed;

	public float m_MovingProgressBeforePotentialDrop;

	public AnimationCurve m_CrashDownCurve;

	public float m_MinDamageHeightDrop;

	public float m_MinDamageAmount;

	public float m_MaxDamageHeightDrop;

	public float m_MaxDamageAmount;

	public float m_CrashDownDuration;

	public LocalizedString m_ExitText;

	public LocalizedString m_GoUpText;

	public LocalizedString m_GoDownText;

	public string[] m_ValidCrankGearItems;

	public bool m_ElevatorHasCrank;

	public GameObject m_CrankObject;

	private Vector3 m_CrankAnimationDisplacement;

	private TimelinePlayback.TimelineInfo m_EnterTimeline;

	private TimelinePlayback.TimelineInfo m_EnterRightTimeline;

	private TimelinePlayback.TimelineInfo m_EnterNoCrankTimeline;

	private TimelinePlayback.TimelineInfo m_EnterRightNoCrankTimeline;

	private TimelinePlayback.TimelineInfo m_WaitAtFloorLoopTimeline;

	private TimelinePlayback.TimelineInfo m_WaitMidProgressLoopTimeline;

	private TimelinePlayback.TimelineInfo m_LoopUpTimeline;

	private TimelinePlayback.TimelineInfo m_FinalLoopUpTimeline;

	private TimelinePlayback.TimelineInfo m_LoopDownTimeline;

	private TimelinePlayback.TimelineInfo m_FinalLoopDownTimeline;

	private TimelinePlayback.TimelineInfo m_CrashDownTimeline;

	private TimelinePlayback.TimelineInfo m_ExitTimeline;

	private TimelinePlayback.TimelineInfo m_ExitRightTimeline;

	private TimelinePlayback.TimelineInfo m_ExitNoCrankTimeline;

	private TimelinePlayback.TimelineInfo m_ExitRightNoCrankTimeline;

	private string m_ArriveAtFloorAudio;

	private string m_DepartFromFloorAudio;

	private string m_EnteredCrashDownThresholdAudio;

	private string m_ExitedCrashDownThresholdAudio;

	private string m_CrashDownStartAudio;

	private string m_CrashDownEndAudio;

	private string m_CrashAudio;

	private State m_StateInternal;

	private int m_LastFloorIndex;

	private int m_NextFloorIndex;

	private int m_RevsSinceLastFloor;

	private Vector3 m_PositionOnExit;

	public TimelinePlayback m_TimelinePlayback;

	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

	public Transform m_AnimatedObject;

	private float m_MoveAxisThreshold;

	private bool m_RolledForStaminaDrop;

	private float m_TimeSpentInCrashDown;

	private Vector3 m_InitialPosBeforeCrashDown;

	private Vector3 m_CrashDownTargetPosition;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	private bool m_CurrentlyUnderStaminaThreshold;

	private static List<Elevator> s_StaticElevators;

	private static ElevatorSaveDataProxy m_ElevatorSaveDataProxy;

	private State m_State
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(State);
		}
		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetDisplayName()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "CanInteract")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Elevator), Member = "CanInteract")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool HasValidCrankItem()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public bool IsMoving()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsWaitingForPlayerInput()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResetAll()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Elevator), Member = "SerializeAll")]
	private string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Elevator), Member = "FindElevatorByGuid")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Elevator), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static Elevator FindElevatorByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleLowStaminaAudio()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private GameObject GetInteractedDoor()
	{
		return null;
	}

	[CalledBy(Type = typeof(Elevator), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "GetHoverText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private bool CanInteract()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	private void Move(State direction)
	{
	}

	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void StartCrashDownSequence()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	private void UpdateIdleDockedAtFloor()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	private bool UpdateWaitForPlayerMovement()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private void GetRevsRequiredToNextFloor(State direction, ref int revsRequiredToNextFloor, ref int finalRevs)
	{
	}

	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallerCount(Count = 0)]
	private EntranceSide GetEntranceUsedForCurrentFloor()
	{
		return default(EntranceSide);
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoUp")]
	[CalledBy(Type = typeof(Elevator), Member = "GetEntranceUsedForCurrentFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoDown")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Elevator), Member = "GetRevsRequiredToNextFloor")]
	private FloorData GetFloorIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private bool CanGoUp()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private bool CanGoDown()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(TimelinePlayback), Member = "GetCurrentTimelineNormalizedProgress")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "SetTimelineSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void UpdateMoving()
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "GetCurrentTimelineNormalizedProgress")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldRollForDrop(float stamina)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumCranksFromMiddleFloor()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	private int GetNumCranksFromBottomFloor()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private Vector3 GetDistanceForNumberOfCranks(int numCranks)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void UpdateCrashingDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Elevator), Member = "LoadElevatorTimelines")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[CalledBy(Type = typeof(Elevator), Member = "ProcessInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnterPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	private void CommenceExitPlayer()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitPlayer()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateCrashingDown")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onTimelineComplete, Action onTimelineInterrupted = null)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallerCount(Count = 0)]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	private void UnloadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnterAnimationComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnExitAnimationComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsUnknownMethods(Count = 3)]
	private void OnMoved()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "GetRealPosition")]
	private void ApplyPositionFromAnimation()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(Elevator), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdatePlacementZoneParent()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Vector3 GetRealPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private bool IsCurrentlyAtAFloor()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private void UpdateButtonPrompts(bool isGamepadActive)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	private void LoadElevatorTimelines()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelineRef), Member = "Unload")]
	private void UnloadElevatorTimelines()
	{
	}

	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 127)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	public Elevator()
	{
	}
}
