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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "CanInteract")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void PerformInteraction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	private bool HasValidCrankItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAll()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	private string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Elevator), Member = "Deserialize")]
	[Calls(Type = typeof(Elevator), Member = "FindElevatorByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static Elevator FindElevatorByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void HandleLowStaminaAudio()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private GameObject GetInteractedDoor()
	{
		return null;
	}

	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	private void Move(State direction)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	private void StartCrashDownSequence()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	private void UpdateIdleDockedAtFloor()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallsUnknownMethods(Count = 1)]
	private bool UpdateWaitForPlayerMovement()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[CallerCount(Count = 0)]
	private void GetRevsRequiredToNextFloor(State direction, ref int revsRequiredToNextFloor, ref int finalRevs)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private EntranceSide GetEntranceUsedForCurrentFloor()
	{
		return default(EntranceSide);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoDown")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoUp")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "GetRevsRequiredToNextFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "GetEntranceUsedForCurrentFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 14)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetSpeed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	private void UpdateMoving()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldRollForDrop(float stamina)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	private int GetNumCranksFromMiddleFloor()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumCranksFromBottomFloor()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	private Vector3 GetDistanceForNumberOfCranks(int numCranks)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	private void UpdateCrashingDown()
	{
	}

	[CallerCount(Count = 0)]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	private void EnterPlayer()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
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

	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateCrashingDown")]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onTimelineComplete, Action onTimelineInterrupted = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
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
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	private void OnExitAnimationComplete()
	{
	}

	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	private void OnMoved()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallsUnknownMethods(Count = 8)]
	private void ApplyPositionFromAnimation()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdatePlacementZoneParent()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 GetRealPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private bool IsCurrentlyAtAFloor()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateButtonPrompts(bool isGamepadActive)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	private void LoadElevatorTimelines()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	private void UnloadElevatorTimelines()
	{
	}

	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
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
	public Elevator()
	{
	}
}
