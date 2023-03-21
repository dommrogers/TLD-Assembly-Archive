using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
	public enum PathRequirement
	{
		PartialPath,
		FullPath
	}

	public float m_RotationSpeed;

	public float m_MaxSpeed;

	public Transform m_Target;

	public float m_RotationThreshold;

	public float m_SpeedScalar;

	public bool m_AnimatedTurns;

	public float m_AnimatedTurnAngleScalar;

	public bool m_AnimatedHeadTurns;

	public float m_VerticalAdjustmentOnWarp;

	private float m_RotationSpeedScale;

	private BaseAi m_BaseAiOwner;

	private NavMeshAgent m_Agent;

	private Animator m_Animator;

	private int m_AnimParameter_Speed;

	private int m_AnimParameter_AiState;

	private int m_IdleState;

	private int m_MoveState;

	private bool m_DestinationReached;

	private Vector3 m_PreviousPosition;

	private float m_DeltaAngleSmooth;

	private float m_DeltaHeadAngleSmooth;

	private AiTarget m_OverrideAnimatedTurnTarget;

	public List<RampRange> m_RampRanges;

	private float m_RampSpeed;

	private float m_Acceleration;

	private float m_DefaultAcceleration;

	private bool m_Enabled;

	private float m_LastTimeScale;

	private int m_CurrentAnimState;

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 7)]
	public void Initialize(BaseAi owner, Vector3 position)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetMaxSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetRampSpeed()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetDesiredSpeed()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetAcceleration()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetCurrentSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOnNavMesh()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	public bool HasPath()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetRemainingDistance()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public NavMeshPathStatus GetPathState()
	{
		return default(NavMeshPathStatus);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	public Vector3 GetDestination()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	public float GetRadius()
	{
		return default(float);
	}

	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[CallerCount(Count = 0)]
	public void SetAnimState(MoveState moveState, int animState)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static bool FindRandomPointWithinRadius(Vector3 center, float radius, out Vector3 result, int areaMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref result) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Mathf), Member = "MoveTowardsAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	public bool RotateTowards(Vector3 direction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(AiUtils), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	public void PointTowardsDirection(Vector3 dir)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Warp")]
	private void AdjustModelVerticalOnWarp()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetPosition")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[Calls(Type = typeof(MoveAgent), Member = "AdjustModelVerticalOnWarp")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	public bool Warp(Vector3 position, float radius, bool findClosestPoint, int areaMask)
	{
		return default(bool);
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	public bool CanFindPath(Vector3 destination, PathRequirement minPathRequirement = PathRequirement.PartialPath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public NavMeshPathStatus CanFindPathStatus(Vector3 destination)
	{
		return default(NavMeshPathStatus);
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsDestinationSafe(Vector3 destination)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NavMeshAgent), Member = "SetPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(NavMeshPath), Member = "get_status")]
	[Calls(Type = typeof(NavMeshPath), Member = ".ctor")]
	[Calls(Type = typeof(NavMeshAgent), Member = "CalculatePath")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	private bool ProcessDestination(Vector3 destination, bool processImmediate)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	public bool SetDestination(Vector3 destination, float radius, bool findClosestPoint, int areaMask, bool processImmediate, AiTarget overrideTarget)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 5)]
	public void SetMoveSpeed(float speed)
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void SwitchToIdleAnim()
	{
	}

	[CallerCount(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	private void SetDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetAnimState()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReachedDestination()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Stop")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void SetAnimationParameters(int animState, float speed)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallerCount(Count = 1)]
	private void UpdateAnimatedTurns()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void UpdateAnimatedHeadTurns()
	{
	}

	[Calls(Type = typeof(NavMeshAgent), Member = "get_stoppingDistance")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_acceleration")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallerCount(Count = 2)]
	public void ResetPreviousPosition()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public MoveAgent()
	{
	}
}
