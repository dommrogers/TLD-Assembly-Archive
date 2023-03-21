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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	public CurveTransformTween()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
