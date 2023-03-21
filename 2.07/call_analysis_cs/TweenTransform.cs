using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenTransform : UITweener
{
	public Transform from;

	public Transform to;

	public bool parentWhenFinished;

	private Transform mTrans;

	private Vector3 mPos;

	private Quaternion mRot;

	private Vector3 mScale;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 22)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		return null;
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TweenTransform()
	{
	}
}
