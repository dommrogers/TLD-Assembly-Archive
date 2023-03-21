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
		[CalledBy(Type = typeof(TweenScale), Member = "Begin")]
		[CalledBy(Type = typeof(TweenScale), Member = "OnUpdate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenScale), Member = "set_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "set_value")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_value")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToStart")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(TweenScale), Member = "SetEndToCurrentValue")]
		get
		{
			return null;
		}
	}

	public Vector3 value
	{
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector3);
		}
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public Vector3 scale
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'From'")]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenScale()
	{
	}
}
