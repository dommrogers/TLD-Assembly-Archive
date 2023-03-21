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
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsUnknownMethods(Count = 6)]
	public void Initialize(BaseAi owner, Vector3 position)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_invalid_ai")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetMaxSpeed()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetRampSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDesiredSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	public float GetCurrentSpeed()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_invalid_ai")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOnNavMesh()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	public bool HasPath()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetRemainingDistance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public NavMeshPathStatus GetPathState()
	{
		return default(NavMeshPathStatus);
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public Vector3 GetDestination()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRadius()
	{
		return default(float);
	}

	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	public void SetAnimState(MoveState moveState, int animState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool FindRandomPointWithinRadius(Vector3 center, float radius, out Vector3 result, int areaMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref result) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[Calls(Type = typeof(Mathf), Member = "MoveTowardsAngle")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public bool RotateTowards(Vector3 direction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(AiUtils), Member = "PointTowardsDirection")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void PointTowardsDirection(Vector3 dir)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsUnknownMethods(Count = 5)]
	private void AdjustModelVerticalOnWarp()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPosition")]
	[Calls(Type = typeof(MoveAgent), Member = "AdjustModelVerticalOnWarp")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	public bool Warp(Vector3 position, float radius, bool findClosestPoint, int areaMask)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	public bool CanFindPath(Vector3 destination, PathRequirement minPathRequirement = PathRequirement.PartialPath)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsUnknownMethods(Count = 9)]
	public NavMeshPathStatus CanFindPathStatus(Vector3 destination)
	{
		return default(NavMeshPathStatus);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private bool IsDestinationSafe(Vector3 destination)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshPath), Member = "get_status")]
	[Calls(Type = typeof(NavMeshAgent), Member = "CalculatePath")]
	[Calls(Type = typeof(NavMeshPath), Member = ".ctor")]
	[Calls(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavMeshAgent), Member = "SetPath")]
	private bool ProcessDestination(Vector3 destination, bool processImmediate)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public bool SetDestination(Vector3 destination, float radius, bool findClosestPoint, int areaMask, bool processImmediate, AiTarget overrideTarget)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CallsUnknownMethods(Count = 5)]
	public void SetMoveSpeed(float speed)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	public void Stop()
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CallerCount(Count = 0)]
	private void SwitchToIdleAnim()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Stop")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SwitchToIdleAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	private void SetAnimationParameters(int animState, float speed)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private void UpdateAnimatedTurns()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private void UpdateAnimatedHeadTurns()
	{
	}

	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_acceleration")]
	[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_stoppingDistance")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void ResetPreviousPosition()
	{
	}

	[CallerCount(Count = 0)]
	public MoveAgent()
	{
	}
}
