using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckMousePick : ConditionTask
{
	public ButtonKeys buttonKey;

	public int layer;

	public BBParameter<GameObject> saveGoAs;

	public BBParameter<float> saveDistanceAs;

	public BBParameter<Vector3> savePosAs;

	private RaycastHit hit;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckMousePick()
	{
	}
}
