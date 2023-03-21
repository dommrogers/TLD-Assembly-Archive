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

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public InputMove()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
