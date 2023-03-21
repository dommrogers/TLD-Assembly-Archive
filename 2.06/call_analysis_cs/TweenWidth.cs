using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenWidth : UITweener
{
	public int from;

	public int to;

	public bool updateTable;

	private UIWidget mWidget;

	private UITable mTable;

	public UIWidget cachedWidget
	{
		[CalledBy(Type = typeof(TweenWidth), Member = "get_width")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_width")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		get
		{
			return null;
		}
	}

	public int width
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenWidth()
	{
	}
}
