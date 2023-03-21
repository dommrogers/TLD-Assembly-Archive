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
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Physics), Member = "Linecast")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 17)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetLinecastInfo()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
