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
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 8)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[CallsUnknownMethods(Count = 1)]
	public CurveTransformTween()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
