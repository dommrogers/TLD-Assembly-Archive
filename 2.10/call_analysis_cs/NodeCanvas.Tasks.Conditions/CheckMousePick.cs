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
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckMousePick()
	{
	}
}