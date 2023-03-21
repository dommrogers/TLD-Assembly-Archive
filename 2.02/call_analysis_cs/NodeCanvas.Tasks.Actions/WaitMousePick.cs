using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class WaitMousePick : ActionTask
{
	public enum ButtonKeys
	{
		Left,
		Right,
		Middle
	}

	public ButtonKeys buttonKey;

	public LayerMask mask;

	public BBParameter<GameObject> saveObjectAs;

	public BBParameter<float> saveDistanceAs;

	public BBParameter<Vector3> savePositionAs;

	private int buttonID;

	private RaycastHit hit;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public WaitMousePick()
	{
	}
}
