using System;
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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics2D), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 6)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public CheckMousePick2D()
	{
	}
}
