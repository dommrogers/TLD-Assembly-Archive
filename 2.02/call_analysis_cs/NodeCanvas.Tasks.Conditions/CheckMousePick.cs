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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CheckMousePick()
	{
	}
}
