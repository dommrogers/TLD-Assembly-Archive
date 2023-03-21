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
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 40)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Calls(Type = typeof(TweenTransform), Member = "Begin")]
	[CallerCount(Count = 0)]
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TweenTransform), Member = "Begin")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 1)]
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		return null;
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TweenTransform()
	{
	}
}
