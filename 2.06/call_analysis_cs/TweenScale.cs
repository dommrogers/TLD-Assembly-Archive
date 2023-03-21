using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenScale : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool updateTable;

	private Transform mTrans;

	private UITable mTable;

	public Transform cachedTransform
	{
		[CalledBy(Type = typeof(TweenScale), Member = "get_value")]
		[CalledBy(Type = typeof(TweenScale), Member = "set_value")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "set_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenScale), Member = "Begin")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Vector3 value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Vector3 scale
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenScale()
	{
	}
}
