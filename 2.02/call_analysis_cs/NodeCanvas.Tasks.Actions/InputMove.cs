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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 25)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputMove()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
