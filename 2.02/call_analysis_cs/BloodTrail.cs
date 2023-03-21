using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BloodTrail : MonoBehaviour
{
	public float m_BloodDropDistanceMin;

	public float m_BloodDropDistanceMax;

	public float m_BloodDropDistanceSlowMin;

	public float m_BloodDropDistanceSlowMax;

	public float m_MinutesToReachSlowBloodLoss;

	public Vector3 m_DecalProjectorScale;

	public Vector3 m_StainOffset;

	public bool m_FirstBleedingDrop;

	private float m_DistanceForNextBloodDrop;

	private Vector3 m_LastBloodDropPos;

	private float m_DistanceMoved;

	private int m_UvRectangleIndexBloodLarge;

	private int m_UvRectangleIndexBloodSmall;

	private int m_UvRectangleIndexBloodStain;

	private bool m_FirstHarvest;

	private BaseAi m_BaseAi;

	private int m_DropCount;

	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "Start")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeInitializeBloodDecalIndexes()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MovedDistance")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void AddMoveDistance(float dist)
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void LeaveBloodDrop(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void LeaveBloodStain(Vector3 pos, float scaleMin, float scaleMax)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 25)]
	public void LeaveStruggleBloodStain()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 24)]
	public void LeaveHarvestBloodStain()
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void LeaveBloodCluster(Vector3 pos, int dropCount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "XZDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldLeaveBloodDrop(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[CallsDeduplicatedMethods(Count = 1)]
	private DecalProjectorType GetDecalProjectorType()
	{
		return default(DecalProjectorType);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public BloodTrail()
	{
	}
}
