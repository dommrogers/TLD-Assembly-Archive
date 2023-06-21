using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckLOS : ConditionTask<Transform>
{
	public BBParameter<GameObject> LOSTarget;

	public BBParameter<LayerMask> layerMask;

	public Vector3 offset;

	public BBParameter<float> saveDistanceAs;

	private RaycastHit hit;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public CheckLOS()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
