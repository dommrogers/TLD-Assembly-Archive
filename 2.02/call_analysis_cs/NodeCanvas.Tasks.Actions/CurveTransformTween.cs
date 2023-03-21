using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class CurveTransformTween : ActionTask<Transform>
{
	public enum TransformMode
	{
		Position,
		Rotation,
		Scale
	}

	public enum TweenMode
	{
		Absolute,
		Additive
	}

	public enum PlayMode
	{
		Normal,
		PingPong
	}

	public TransformMode transformMode;

	public TweenMode mode;

	public PlayMode playMode;

	public BBParameter<Vector3> targetPosition;

	public BBParameter<AnimationCurve> curve;

	public BBParameter<float> time;

	private Vector3 original;

	private Vector3 final;

	private bool ponging;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public CurveTransformTween()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
