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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(TweenScale), Member = "set_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenScale), Member = "Begin")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenScale), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenScale), Member = "set_value")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_scale")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		set
		{
		}
	}

	public Vector3 scale
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		get
		{
			return default(Vector3);
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'From'")]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
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
