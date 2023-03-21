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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(Utils), Member = "SphereIntersectsCone")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Condition_VisibilityTest()
	{
	}
}
