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
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		[CalledBy(Type = typeof(ElevatorTrigger), Member = "OnTriggerEnter")]
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
		[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnPlayerEntered")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
		[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
		[Calls(Type = typeof(Transform), Member = "set_parent")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
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
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	private void CentrePlayerInElevator()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 11)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnDoorMoving()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnWaitAtFloor()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "set_m_State")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	private void OnWaitForUpOrDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	public float GetMovementDuration()
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private void OnElevatorMoving()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "CentrePlayerInElevator")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	private void OnCrashingDown()
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoUp")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetHighestFloorHeight()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnCrashingDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "CanGoDown")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "GetFallDamageToIssue")]
	[CallsUnknownMethods(Count = 7)]
	private float GetLowestFloorHeight()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	private bool CanGoDown()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetHighestFloorHeight")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanGoUp()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(ElevatorPrototypeController), Member = "GetLowestFloorHeight")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetFallDamageToIssue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	private void EnterPlayer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 3)]
	private void ExitPlayer()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsMoving()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ElevatorPrototypeController()
	{
	}
}
