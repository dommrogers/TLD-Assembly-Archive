using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class InputMove : ActionTask<Transform>
{
	public BBParameter<float> strafe;

	public BBParameter<float> turn;

	public BBParameter<float> forward;

	public BBParameter<float> up;

	public BBParameter<float> moveSpeed;

	public BBParameter<float> rotationSpeed;

	public bool repeat;

	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public InputMove()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
