using System;
using System.Collections.Generic;
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

	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestVisibleBurningFire")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsFieldVisible")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static bool PositionVisible(Vector3 npcPos, Vector3 npcForward, Vector3 pos, float range, float fov, float raycastRadius, int layerMask)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static Fire GetClosestVisibleBurningFire(BaseAi bai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool InSameNavmeshArea(Vector3 start, Vector3 end)
	{
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "TryGetClosestNavmeshPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "StartPath")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 GetClosestNavmeshPoint(Vector3 pos, int area)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPoint")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool CanPathfindToPosition(Vector3 pos, Vector3 testedPosition, float xzThreshold)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNavmeshArea(Vector3 pos)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	public static void DrawDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[CalledBy(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static bool FindNearestGroundAndNavmeshFor(Vector3 pos, out Vector3 groundPos, out Vector3 navmeshPos)
	{
		groundPos = default(Vector3);
		navmeshPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiUtils), Member = "FindNearestGroundAndNavmeshFor")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool GetNavmeshClampedPosition(out Vector3 clampedPosition, Vector3 pos, Vector3 constraintPos, float heightOffset, float radius, float xzThresholdDist, float thresholdDist)
	{
		clampedPosition = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static bool GetValidPositionUnder(out Vector3 validPosition, Vector3 raycastStart, Vector3 clampedPosition, float xzThresholdDist, float thresholdDist)
	{
		validPosition = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybePickFleeDestinationFromAreaMarkup")]
	[CalledBy(Type = typeof(BaseAi), Member = "CheckFleeAngleIsValid")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeInvestigateMeatWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickClosestWanderDestinationAtPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickEmergencyWanderDestination")]
	[CalledBy(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetClosestNavmeshPos(out Vector3 navmeshPos, Vector3 pos, Vector3 constraintPos, float radius = 2f, float heightOffset = 100f)
	{
		navmeshPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshClampedPosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetValidPositionUnder")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsNavmeshPosValid(Vector3 pos, float radius, float heightOffset)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetRandomPointOnNavmeshWithDistance(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float liftDistance, float raycastDistance)
	{
		outPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetRandomNavmeshPos")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestinationAwayFromPoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "PickWanderDestination")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetRandomPointOnNavmesh(out Vector3 outPos, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly = false, float liftDistance = 0.2f)
	{
		outPos = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmeshWithDistance")]
	[CalledBy(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(MoveAgent), Member = "SetDestination")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static bool GetRandomPointAndNormalOnNavmeshNoPadding(out Vector3 outPos, out Vector3 outNormal, Vector3 origin, float minRadius, float maxRadius, int area, bool testNavMeshSurfaceOnly, float raycastDistance)
	{
		outPos = default(Vector3);
		outNormal = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public static bool OverlapSphereNonSelf(Vector3 position, float radius, int layerMask, Collider[] selfColliders)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(ArrowItem), Member = "DetachIntoWorld")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool PositionIsClear(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf)
	{
		return false;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AiUtils), Member = "OverlapSphereNonSelf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool PositionIsClearGivenCollisionMask(GameObject objectToSpawn, float objectRadius, Vector3 posToSpawn, bool ignoreSelf, int collisionMask)
	{
		return false;
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static BaseAi GetAiFeedingOnCarcass(BodyHarvest bh)
	{
		return null;
	}

	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	[CalledBy(Type = typeof(UnspawnPredatorRadialTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void DespawnHostileAiAroundPoint(Vector3 pos, float radius)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessPatrolPointsOfInterest")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "RotateTowards")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void TurnTowardsTarget(BaseAi bai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "PointTowardsDirection")]
	[CallsUnknownMethods(Count = 1)]
	public static void PointTowardsDirection(BaseAi bai, Vector3 dir)
	{
	}

	[CalledBy(Type = typeof(NoiseMakerItem), Member = "PerformDamageToAllInRange")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public static List<BaseAi> GetAisWithinRange(Vector3 position, float range)
	{
		return null;
	}

	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static BaseAi FindClosestAiWithinCone(Vector3 position, Vector3 direction, float minDistance, float maxDistance, float maxAngleDegrees)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(AiUtils), Member = "RaycastWithAimAssist")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static BaseAi GetBaseAiFromObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetBaseAiFromObject")]
	[Calls(Type = typeof(AiUtils), Member = "FindClosestAiWithinCone")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static bool RaycastWithAimAssist(Vector3 position, Vector3 direction, out RaycastHit hit, float maxDistance, float minDistanceForAssist, float maxDistanceForAssist, float maxAngleDegrees, int layerMask)
	{
		hit = default(RaycastHit);
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 30)]
	public static Vector3[] GetPointsForGradualTurn(Transform transform, Vector3 target, float turnRadius, float maxTurnSegmentAngle)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogWarning(string output)
	{
	}

	[CallerCount(Count = 0)]
	private static bool LayerCanBeGround(int layer)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AiUtils()
	{
	}
}
