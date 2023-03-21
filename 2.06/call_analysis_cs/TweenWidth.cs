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
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_width")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_width")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	public int width
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		set
		{
		}
	}

	public int value
	{
		[DeduplicatedMethod]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[ContextMenu("Set 'From' to current value")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
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
