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

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	public static bool PositionVisible(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov, float raycastRadius, int layerMask)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static Fire GetClosestVisibleBurningFire(BaseAi bai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool InSameNavmeshArea(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "TryGetClosestNavmeshPoint")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "CanPathfindToPosition")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
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

	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	public static int GetNavmeshArea(Vector3 pos)
	{
		return default(int);
	}

	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 8)]
	public static void DrawDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public static bool FindNearestGroundAndNavmeshFor(Vector3 pos, out Vector3 groundPos, out Vector3 navmeshPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "FindNearestGroundAndNavmeshFor")]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	private static bool GetNavmeshClampedPosition(out Vector3 clampedPosition, Vector3 pos, Vector3 constraintPos, float heightOffset, float radius, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref clampedPosition) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	private static bool GetValidPositionUnder(out Vector3 validPosition, Vector3 raycastStart, Vector3 clampedPosition, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref validPosition) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[CalledBy(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CallerCount(Count = 12)]
	public static bool GetClosestNavmeshPos(out Vector3 navmeshPos, Vector3 pos, Vector3 constraintPos, float radius = 2f, float heightOffset = 100f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
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

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	public static bool GetRandomPointOnNavmesh(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly = false, float liftDistance = 0.2f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmeshWithDistance")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 10)]
	public static bool GetRandomPointAndNormalOnNavmeshNoPadding(out Vector3 outPos, out Vector3 outNormal, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float raycastDistance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outNormal) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
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

	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClear")]
	public static bool PositionIsClearGivenCollisionMask(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf, int collisionMask)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static BaseAi GetAiFeedingOnCarcass(BodyHarvest bh)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CallerCount(Count = 1)]
	public static void DespawnHostileAiAroundPoint(Vector3 pos, float radius)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 3)]
	public static void TurnTowardsTarget(BaseAi bai)
	{
	}

	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsUnknownMethods(Count = 1)]
	public static void PointTowardsDirection(BaseAi bai, Vector3 dir)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static List<BaseAi> GetAisWithinRange(Vector3 position, float range)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public static BaseAi FindClosestAiWithinCone(Vector3 position, Vector3 direction, float minDistance, float maxDistance, float maxAngleDegrees)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static BaseAi GetBaseAiFromObject(GameObject go)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "FindClosestAiWithinCone")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[Calls(Type = typeof(AiUtils), Member = "GetBaseAiFromObject")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	public static bool RaycastWithAimAssist(Vector3 position, Vector3 direction, out RaycastHit hit, float maxDistance, float minDistanceForAssist, float maxDistanceForAssist, float maxAngleDegrees, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public AiUtils()
	{
	}
}
