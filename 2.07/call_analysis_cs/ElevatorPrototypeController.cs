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
		[CallAnalysisFailed]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnPlayerEntered")]
		[CalledBy(Type = typeof(ElevatorTrigger), Member = "OnTriggerEnter")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnWaitAtFloor()
	{
	}

	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetMovementDuration")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetMovementDuration")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	private void OnWaitForUpOrDown()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	public float GetMovementDuration()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetModifiedMaxSprintStamina")]
	private void OnElevatorMoving()
	{
	}

	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "GetFallDamageToIssue")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
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
