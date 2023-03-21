using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class WaitMousePick2D : ActionTask
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

	private RaycastHit2D hit;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(Physics2D), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WaitMousePick2D()
	{
	}
}
