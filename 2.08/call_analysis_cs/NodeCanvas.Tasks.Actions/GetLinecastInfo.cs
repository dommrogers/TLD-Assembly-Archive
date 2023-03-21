using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetLinecastInfo : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public BBParameter<LayerMask> layerMask;

	public BBParameter<GameObject> saveHitGameObjectAs;

	public BBParameter<float> saveDistanceAs;

	public BBParameter<Vector3> savePointAs;

	public BBParameter<Vector3> saveNormalAs;

	private RaycastHit hit;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public GetLinecastInfo()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
