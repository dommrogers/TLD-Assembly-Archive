using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenHeight : UITweener
{
	public int from;

	public int to;

	public bool updateTable;

	private UIWidget mWidget;

	private UITable mTable;

	public UIWidget cachedWidget
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_height")]
		[CalledBy(Type = typeof(TweenHeight), Member = "set_height")]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "set_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "OnUpdate")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetEndToCurrentValue")]
		get
		{
			return null;
		}
	}

	public int height
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		set
		{
		}
	}

	public int value
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[DeduplicatedMethod]
	public TweenHeight()
	{
	}
}
