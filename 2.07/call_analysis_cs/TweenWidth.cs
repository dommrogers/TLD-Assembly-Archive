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
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_width")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_width")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_value")]
		get
		{
			return null;
		}
	}

	public int width
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int value
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 3)]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'To' to current value")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'From'")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenWidth()
	{
	}
}
