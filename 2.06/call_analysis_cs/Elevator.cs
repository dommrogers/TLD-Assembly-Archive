using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	private HeldItemInPlacementZone m_HeldItemInPlacementZone;

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

	public TimelinePlayback m_TimelinePlayback;

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

	private AK.Wwise.Event m_ArriveAtFloorAudioEvent;

	private AK.Wwise.Event m_DepartFromFloorAudioEvent;

	private AK.Wwise.Event m_EnteredCrashDownThresholdAudioEvent;

	private AK.Wwise.Event m_ExitedCrashDownThresholdAudioEvent;

	private AK.Wwise.Event m_CrashDownStartAudioEvent;

	private AK.Wwise.Event m_CrashDownEndAudioEvent;

	private AK.Wwise.Event m_CrashAudioEvent;

	private PanelReference<Panel_HUD> m_HUD;

	private State m_StateInternal;

	private int m_LastFloorIndex;

	private int m_NextFloorIndex;

	private int m_RevsSinceLastFloor;

	private Vector3 m_PositionOnExit;

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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private bool HasValidCrankItem()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsMoving()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsWaitingForPlayerInput()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void ResetAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 11)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	private string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "FindElevatorByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static Elevator FindElevatorByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "UpdateMoving")]
	[Calls(Type = typeof(Elevator), Member = "UpdateCrashingDown")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void HandleLowStaminaAudio()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateInteraction")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private GameObject GetInteractedDoor()
	{
		return null;
	}

	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	private void Move(State direction)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void StartCrashDownSequence()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	private void UpdateIdleDockedAtFloor()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "Update")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallerCount(Count = 4)]
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

	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoDown")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoUp")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "GetRevsRequiredToNextFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "GetEntranceUsedForCurrentFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateInteraction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 15)]
	private FloorData GetFloorIndex(int index)
	{
		return null;
	}

	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Elevator), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMoving()
	{
	}

	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool ShouldRollForDrop(float stamina)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumCranksFromMiddleFloor()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	private int GetNumCranksFromBottomFloor()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	private Vector3 GetDistanceForNumberOfCranks(int numCranks)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(Elevator), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateCrashingDown()
	{
	}

	[CallerCount(Count = 0)]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	private void EnterPlayer()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Elevator), Member = "Update")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void CommenceExitPlayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[CallsUnknownMethods(Count = 1)]
	private void ExitPlayer()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateCrashingDown")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onTimelineComplete, Action onTimelineInterrupted = null)
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UnloadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnterAnimationComplete()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void OnExitAnimationComplete()
	{
	}

	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 3)]
	private void OnMoved()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ApplyPositionFromAnimation()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePlacementZoneParent()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Vector3 GetRealPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private bool IsCurrentlyAtAFloor()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private void UpdateButtonPrompts(bool isGamepadActive)
	{
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	private void LoadElevatorTimelines()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[CallerCount(Count = 1)]
	private void UnloadElevatorTimelines()
	{
	}

	[CallsUnknownMethods(Count = 90)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	public Elevator()
	{
	}
}
