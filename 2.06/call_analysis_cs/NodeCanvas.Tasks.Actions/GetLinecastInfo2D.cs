using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetLinecastInfo2D : ActionTask<Transform>
{
	public BBParameter<GameObject> target;

	public LayerMask mask;

	public BBParameter<GameObject> saveHitGameObjectAs;

	public BBParameter<float> saveDistanceAs;

	public BBParameter<Vector3> savePointAs;

	public BBParameter<Vector3> saveNormalAs;

	private RaycastHit2D hit;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	public GetLinecastInfo2D()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
