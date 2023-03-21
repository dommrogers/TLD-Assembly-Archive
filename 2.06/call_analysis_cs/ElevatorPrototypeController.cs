using System;
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(State);
		}
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnPlayerEntered")]
		[CalledBy(Type = typeof(ElevatorTrigger), Member = "OnTriggerEnter")]
		[CallAnalysisFailed]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	public void OnPlayerEntered(GameObject playerObject)
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void CentrePlayerInElevator()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	private void OnDoorMoving()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void OnWaitAtFloor()
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	private void OnWaitForUpOrDown()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public float GetMovementDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 24)]
	private void OnElevatorMoving()
	{
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void OnCrashingDown()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoUp")]
	[CallsUnknownMethods(Count = 7)]
	private float GetHighestFloorHeight()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "GetFallDamageToIssue")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	private float GetLowestFloorHeight()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanGoDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[CallsUnknownMethods(Count = 3)]
	private bool CanGoUp()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private void EnterPlayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	private void ExitPlayer()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsMoving()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public ElevatorPrototypeController()
	{
	}
}
