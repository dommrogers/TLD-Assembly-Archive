using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElevatorPrototypeController : MonoBehaviour
{
	private enum State
	{
		WaitingForPlayerEnter,
		ClosingDoor,
		OpeningDoor,
		WaitAtFloor,
		WaitForUpOrDown,
		GoingUp,
		GoingDown,
		CrashingDown
	}

	public GameObject m_Door;

	public GameObject m_OptionalDoorSecond;

	public BoxCollider m_PlayerTrigger;

	public Transform m_DoorFrame;

	public Vector3 m_DoorOpenOffset;

	public Vector3 m_SecondDoorOpenOffset;

	public Vector3 m_MovementOffset;

	public float m_MovementDurationMin;

	public float m_MovementDurationMax;

	public AnimationCurve m_MoveUpAndDownCurve;

	public AnimationCurve m_CrashDownCurve;

	public float m_MovingProgressBeforePotentialDrop;

	public float m_FullSpeedStaminaCost;

	public float m_PotentialDropBelowStamina;

	public float m_DropChance;

	public float m_MinDamageHeightDrop;

	public float m_MinDamageAmount;

	public float m_MaxDamageHeightDrop;

	public float m_MaxDamageAmount;

	public float m_CrashDownDuration;

	public List<float> m_Levels;

	private Vector3 m_InitialDoorPosition;

	private Vector3 m_InitialSecondDoorPosition;

	private Vector3 m_InitialElevatorPosition;

	private float m_DurationForThisMove;

	private bool m_ElevatorDebug;

	private State m_StateInternal;

	private float m_TimeInCurrentState;

	private State m_State
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(State);
		}
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnPlayerEntered")]
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
		[CalledBy(Type = typeof(ElevatorTrigger), Member = "OnTriggerEnter")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
		[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 15)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	public void OnPlayerEntered(GameObject playerObject)
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 16)]
	private void CentrePlayerInElevator()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 20)]
	private void OnDoorMoving()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void OnWaitAtFloor()
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void OnWaitForUpOrDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetMovementDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 21)]
	private void OnElevatorMoving()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 23)]
	private void OnCrashingDown()
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoUp")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private float GetHighestFloorHeight()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "GetFallDamageToIssue")]
	[CallerCount(Count = 5)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private float GetLowestFloorHeight()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanGoDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanGoUp()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetFallDamageToIssue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void EnterPlayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ExitPlayer()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsMoving()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ElevatorPrototypeController()
	{
	}
}
