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

	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GetLinecastInfo2D()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
