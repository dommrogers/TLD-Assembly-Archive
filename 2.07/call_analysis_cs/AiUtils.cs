using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiUtils
{
	private const int MAX_NAVMESH_RAYCAST_HITS = 10;

	private static RaycastHit[] m_GetRandomPointOnNavmeshNoPaddingHits;

	private const float XZTHRESHOLDDIST = 2f;

	private const float THRESHOLDDIST = 5f;

	private static RaycastHit[] s_SphereCastResults;

	private const float NAVMESH_SPHERECAST_RADIUS = 0.1f;

	private const int NAVMESH_SPHERECAST_PHYSICAL_MASK = 269228801;

	private const int NAVMESH_SPHERECAST_NAVMESH_MASK = 2817;

	private static Collider[] s_CollidersForOverlapSphereNonSelf;

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public static bool PositionVisible(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov, float raycastRadius, int layerMask)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	public static Fire GetClosestVisibleBurningFire(BaseAi bai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool InSameNavmeshArea(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AiUtils), Member = "CanPathfindToPosition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "TryGetClosestNavmeshPoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public static Vector3 GetClosestNavmeshPoint(Vector3 pos, int area)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[CallerCount(Count = 0)]
	public static bool CanPathfindToPosition(Vector3 pos, Vector3 testedPosition, float xzThreshold)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	public static int GetNavmeshArea(Vector3 pos)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("__DEBUG")]
	public static void DrawDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool FindNearestGroundAndNavmeshFor(Vector3 pos, out Vector3 groundPos, out Vector3 navmeshPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "FindNearestGroundAndNavmeshFor")]
	private static bool GetNavmeshClampedPosition(out Vector3 clampedPosition, Vector3 pos, Vector3 constraintPos, float heightOffset, float radius, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref clampedPosition) = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static bool GetValidPositionUnder(out Vector3 validPosition, Vector3 raycastStart, Vector3 clampedPosition, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref validPosition) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CalledBy(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	public static bool GetClosestNavmeshPos(out Vector3 navmeshPos, Vector3 pos, Vector3 constraintPos, float radius = 2f, float heightOffset = 100f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallerCount(Count = 2)]
	public static bool IsNavmeshPosValid(Vector3 pos, float radius, float heightOffset)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	public static bool GetRandomPointOnNavmeshWithDistance(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float liftDistance, float raycastDistance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallerCount(Count = 9)]
	public static bool GetRandomPointOnNavmesh(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly = false, float liftDistance = 0.2f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmeshWithDistance")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetRandomPointAndNormalOnNavmeshNoPadding(out Vector3 outPos, out Vector3 outNormal, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float raycastDistance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outNormal) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool OverlapSphereNonSelf(Vector3 position, float radius, int layerMask, Collider[] selfColliders)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	public static bool PositionIsClear(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static bool PositionIsClearGivenCollisionMask(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf, int collisionMask)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	public static BaseAi GetAiFeedingOnCarcass(BodyHarvest bh)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	public static void DespawnHostileAiAroundPoint(Vector3 pos, float radius)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	public static void TurnTowardsTarget(BaseAi bai)
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void PointTowardsDirection(BaseAi bai, Vector3 dir)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static List<BaseAi> GetAisWithinRange(Vector3 position, float range)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	public static BaseAi FindClosestAiWithinCone(Vector3 position, Vector3 direction, float minDistance, float maxDistance, float maxAngleDegrees)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	public static BaseAi GetBaseAiFromObject(GameObject go)
	{
		return null;
	}

	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(AiUtils), Member = "FindClosestAiWithinCone")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AiUtils), Member = "GetBaseAiFromObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool RaycastWithAimAssist(Vector3 position, Vector3 direction, out RaycastHit hit, float maxDistance, float minDistanceForAssist, float maxDistanceForAssist, float maxAngleDegrees, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	public static Vector3[] GetPointsForGradualTurn(Transform transform, Vector3 target, float turnRadius, float maxTurnSegmentAngle)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void LogWarning(string output)
	{
	}

	[CallerCount(Count = 0)]
	private static bool LayerCanBeGround(int layer)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AiUtils()
	{
	}
}
