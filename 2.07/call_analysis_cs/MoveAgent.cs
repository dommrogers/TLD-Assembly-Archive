using System.Collections.Generic;
using System.Diagnostics;
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

	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void Initialize(BaseAi owner, Vector3 position)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Enable(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetMaxSpeed()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetRampSpeed()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDesiredSpeed()
	{
		return 0f;
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
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetCurrentSpeed()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "DisableInvalidAi")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsOnNavMesh()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnWanderPauseAnimStateExit")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool HasPath()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetRemainingDistance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public NavMeshPathStatus GetPathState()
	{
		return default(NavMeshPathStatus);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[CalledBy(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[CalledBy(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(AreaMarkupManager), Member = "MaybeUnreserveAreaMarkups")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 GetDestination()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FlareItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "MaybeEnableNavMeshObstacle")]
	[CalledBy(Type = typeof(TorchItem), Member = "MaybeEnableNavMeshObstacle")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public float GetRadius()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	public void SetAnimState(MoveState moveState, int animState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool FindRandomPointWithinRadius(Vector3 center, float radius, out Vector3 result, int areaMask)
	{
		result = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFakeFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "TurnTowardsFeedingPos")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "MoveTowardsAngle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public bool RotateTowards(Vector3 direction)
	{
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "PointTowardsDirection")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public void PointTowardsDirection(Vector3 dir)
	{
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "Warp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void AdjustModelVerticalOnWarp()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetPositionAndRotation")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "TeleportToRandomWaypointAndPathfind")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "set_spawn_position")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "Update")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ForceEndGame")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(MoveAgent), Member = "AdjustModelVerticalOnWarp")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public bool Warp(Vector3 position, float radius, bool findClosestPoint, int areaMask)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttackModeIfPossible")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public bool CanFindPath(Vector3 destination, PathRequirement minPathRequirement = PathRequirement.PartialPath)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public NavMeshPathStatus CanFindPathStatus(Vector3 destination)
	{
		return default(NavMeshPathStatus);
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsDestinationSafe(Vector3 destination)
	{
		return false;
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "IsDestinationSafe")]
	[Calls(Type = typeof(NavMeshPath), Member = ".ctor")]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[Calls(Type = typeof(NavMeshPath), Member = "get_status")]
	[Calls(Type = typeof(NavMeshAgent), Member = "SetPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool ProcessDestination(Vector3 destination, bool processImmediate)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(MoveAgent), Member = "ProcessDestination")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public bool SetDestination(Vector3 destination, float radius, bool findClosestPoint, int areaMask, bool processImmediate, AiTarget overrideTarget)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetSpeedAnimationParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetMoveSpeed(float speed)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "PathfindToNextPointOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_isStopped")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_updateRotation")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
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
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReachedDestination()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimStateForMoveAgent")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoReachedTargetPointOfInterestBehavior")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetAnimState")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Stop")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SwitchToIdleAnim")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetAnimationParameters(int animState, float speed)
	{
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateAnimatedTurns()
	{
	}

	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetFloat")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateAnimatedHeadTurns()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedTurns")]
	[Calls(Type = typeof(MoveAgent), Member = "UpdateAnimatedHeadTurns")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_isOnNavMesh")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathPending")]
	[Calls(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(MoveAgent), Member = "ResetPreviousPosition")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_remainingDistance")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_stoppingDistance")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_hasPath")]
	[Calls(Type = typeof(NavMeshAgent), Member = "get_pathStatus")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_speed")]
	[Calls(Type = typeof(NavMeshAgent), Member = "set_acceleration")]
	[Calls(Type = typeof(Time), Member = "get_smoothDeltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Animator), Member = "set_speed")]
	[Calls(Type = typeof(MoveAgent), Member = "SetAnimationParameters")]
	[Calls(Type = typeof(MoveAgent), Member = "Stop")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void ResetPreviousPosition()
	{
	}

	[CallerCount(Count = 0)]
	public MoveAgent()
	{
	}
}
