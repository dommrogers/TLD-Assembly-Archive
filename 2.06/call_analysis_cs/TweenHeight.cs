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
		[CalledBy(Type = typeof(TweenHeight), Member = "set_height")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetEndToCurrentValue")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenHeight), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenHeight), Member = "set_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_height")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToStart")]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	public int height
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int value
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallsUnknownMethods(Count = 1)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'To'")]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenHeight()
	{
	}
}
