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

	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	public static bool PositionVisible(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov, float raycastRadius, int layerMask)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static Fire GetClosestVisibleBurningFire(BaseAi bai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool InSameNavmeshArea(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "TryGetClosestNavmeshPoint")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AiUtils), Member = "CanPathfindToPosition")]
	public static Vector3 GetClosestNavmeshPoint(Vector3 pos, int area)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	public static bool CanPathfindToPosition(Vector3 pos, Vector3 testedPosition, float xzThreshold)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetNavmeshArea(Vector3 pos)
	{
		return default(int);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static void DrawDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public static bool FindNearestGroundAndNavmeshFor(Vector3 pos, out Vector3 groundPos, out Vector3 navmeshPos)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref groundPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(AiUtils), Member = "FindNearestGroundAndNavmeshFor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private static bool GetNavmeshClampedPosition(out Vector3 clampedPosition, Vector3 pos, Vector3 constraintPos, float heightOffset, float radius, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref clampedPosition) = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private static bool GetValidPositionUnder(out Vector3 validPosition, Vector3 raycastStart, Vector3 clampedPosition, float xzThresholdDist, float thresholdDist)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref validPosition) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[CalledBy(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	public static bool GetClosestNavmeshPos(out Vector3 navmeshPos, Vector3 pos, Vector3 constraintPos, float radius = 2f, float heightOffset = 100f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref navmeshPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsNavmeshPosValid(Vector3 pos, float radius, float heightOffset)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	public static bool GetRandomPointOnNavmeshWithDistance(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float liftDistance, float raycastDistance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	public static bool GetRandomPointOnNavmesh(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly = false, float liftDistance = 0.2f)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		return default(bool);
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmeshWithDistance")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	public static bool GetRandomPointAndNormalOnNavmeshNoPadding(out Vector3 outPos, out Vector3 outNormal, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float raycastDistance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref outNormal) = null;
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallsUnknownMethods(Count = 10)]
	public static bool OverlapSphereNonSelf(Vector3 position, float radius, int layerMask, Collider[] selfColliders)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	public static bool PositionIsClear(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	public static bool PositionIsClearGivenCollisionMask(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf, int collisionMask)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static BaseAi GetAiFeedingOnCarcass(BodyHarvest bh)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(UnspawnPredatorRadialTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DespawnHostileAiAroundPoint(Vector3 pos, float radius)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static List<BaseAi> GetAisWithinRange(Vector3 position, float range)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public static BaseAi FindClosestAiWithinCone(Vector3 position, Vector3 direction, float minDistance, float maxDistance, float maxAngleDegrees)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public static BaseAi GetBaseAiFromObject(GameObject go)
	{
		return null;
	}

	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetBaseAiFromObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(AiUtils), Member = "FindClosestAiWithinCone")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool RaycastWithAimAssist(Vector3 position, Vector3 direction, out RaycastHit hit, float maxDistance, float minDistanceForAssist, float maxDistanceForAssist, float maxAngleDegrees, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public static Vector3[] GetPointsForGradualTurn(Transform transform, Vector3 target, float turnRadius, float maxTurnSegmentAngle)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void LogWarning(string output)
	{
	}

	[CallerCount(Count = 0)]
	private static bool LayerCanBeGround(int layer)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AiUtils()
	{
	}
}
