using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_VisibilityTest : ConditionTask
{
	public bool testFromCamera;

	public BBParameter<string> objectA;

	public BBParameter<string> objectB;

	public Vector3 objectAOffset;

	public Vector3 objectBOffset;

	public float objectBRadius;

	public bool justXZ;

	public float coneAngle;

	public float alwaysVisibleRadius;

	public float maxDistance;

	public float sphereCastRadius;

	public LayerMask sphereCastLayers;

	public bool debugOutput;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Utils), Member = "SphereIntersectsCone")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 16)]
	public Condition_VisibilityTest()
	{
	}
}
