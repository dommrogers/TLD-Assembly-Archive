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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "CanInteract")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanInteract()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(Elevator), Member = "EnterPlayer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasValidCrankItem()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMoving()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsWaitingForPlayerInput()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Elevator), Member = "FindElevatorByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Elevator), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleLowStaminaAudio()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "RaycastNearest")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private GameObject GetInteractedDoor()
	{
		return null;
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Move(State direction)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateMoving")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "Move")]
	[CallsUnknownMethods(Count = 1)]
	private bool UpdateWaitForPlayerMovement()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private void GetRevsRequiredToNextFloor(State direction, ref int revsRequiredToNextFloor, ref int finalRevs)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private EntranceSide GetEntranceUsedForCurrentFloor()
	{
		return default(EntranceSide);
	}

	[CalledBy(Type = typeof(Elevator), Member = "CanInteract")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(Elevator), Member = "GetRevsRequiredToNextFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "GetEntranceUsedForCurrentFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoUp")]
	[CalledBy(Type = typeof(Elevator), Member = "CanGoDown")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallerCount(Count = 14)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private FloorData GetFloorIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private bool CanGoUp()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	private bool CanGoDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "SetSpeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_duration")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_time")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "GetNumCranksFromBottomFloor")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumCranksFromMiddleFloor()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "GetNumCranksFromMiddleFloor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumCranksFromBottomFloor()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	private Vector3 GetDistanceForNumberOfCranks(int numCranks)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateCrashingDown()
	{
	}

	[CallerCount(Count = 0)]
	private float GetFallDamageToIssue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeHandleItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnterPlayer()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimelinePlayback), Member = "StopCurrentTimeline")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateCrashingDown")]
	[CalledBy(Type = typeof(Elevator), Member = "EnterPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayTimeline(TimelinePlayback.TimelineInfo timeline, Action onTimelineComplete, Action onTimelineInterrupted = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	private void LoadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UnloadTimeline(TimelinePlayback.TimelineInfo timeline)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnterAnimationComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(Elevator), Member = "UnloadElevatorTimelines")]
	[CallsUnknownMethods(Count = 1)]
	private void OnExitAnimationComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Elevator), Member = "ApplyPositionFromAnimation")]
	[Calls(Type = typeof(Elevator), Member = "UpdatePlacementZoneParent")]
	[Calls(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[Calls(Type = typeof(Elevator), Member = "PlayTimeline")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnMoved()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "StartCrashDownSequence")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void ApplyPositionFromAnimation()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePlacementZoneParent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 GetRealPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private bool IsCurrentlyAtAFloor()
	{
		return false;
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnEnterAnimationComplete")]
	[CalledBy(Type = typeof(Elevator), Member = "OnMoved")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(Elevator), Member = "GetFloorIndex")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonPrompts(bool isGamepadActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback), Member = "LoadTimelineOnSelf")]
	[CallsUnknownMethods(Count = 1)]
	private void LoadElevatorTimelines()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "OnExitAnimationComplete")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void UnloadElevatorTimelines()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimelinePlayback.TimelineInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Elevator()
	{
	}
}
