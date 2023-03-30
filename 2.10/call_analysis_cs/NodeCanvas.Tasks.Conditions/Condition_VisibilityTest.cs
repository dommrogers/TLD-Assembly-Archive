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
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "SphereIntersectsCone")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 16)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	public Condition_VisibilityTest()
	{
	}
}
