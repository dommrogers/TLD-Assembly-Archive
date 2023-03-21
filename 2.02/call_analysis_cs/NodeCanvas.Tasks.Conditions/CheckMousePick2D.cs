using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckMousePick2D : ConditionTask
{
	public ButtonKeys buttonKey;

	public LayerMask mask;

	public BBParameter<GameObject> saveGoAs;

	public BBParameter<float> saveDistanceAs;

	public BBParameter<Vector3> savePosAs;

	private int buttonID;

	private RaycastHit2D hit;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(Physics2D), Member = "Raycast")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public CheckMousePick2D()
	{
	}
}
