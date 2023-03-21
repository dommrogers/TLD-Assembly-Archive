using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CanSeeTarget : ConditionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<float> maxDistance;

	public BBParameter<float> awarnessDistance;

	public BBParameter<float> viewAngle;

	public Vector3 offset;

	private RaycastHit hit;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 17)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public CanSeeTarget()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
