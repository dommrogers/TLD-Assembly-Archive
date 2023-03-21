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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[CalledBy(Type = typeof(BloodTrail), Member = "Start")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "LookupUVRectangleIndex")]
	private void MaybeInitializeBloodDecalIndexes()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MovedDistance")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	[CalledBy(Type = typeof(MoveAgent), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	public void AddMoveDistance(float dist)
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void LeaveBloodDrop(Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public void LeaveBloodStain(Vector3 pos, float scaleMin, float scaleMax)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public void LeaveStruggleBloodStain()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	public void LeaveHarvestBloodStain()
	{
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "AddMoveDistance")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "CreateDecal")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(BloodTrail), Member = "GetDecalProjectorType")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(BloodTrail), Member = "MaybeInitializeBloodDecalIndexes")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void LeaveBloodCluster(Vector3 pos, int dropCount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldLeaveBloodDrop(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodCluster")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveHarvestBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveStruggleBloodStain")]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodStain")]
	[Calls(Type = typeof(HuntedPart2WaypointController), Member = "IsHuntedBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsHuntedBear")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BloodTrail), Member = "LeaveBloodDrop")]
	private DecalProjectorType GetDecalProjectorType()
	{
		return default(DecalProjectorType);
	}

	[CallerCount(Count = 0)]
	public BloodTrail()
	{
	}
}
