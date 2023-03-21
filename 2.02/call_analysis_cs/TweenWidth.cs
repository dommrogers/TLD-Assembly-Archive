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
		[CalledBy(Type = typeof(TweenWidth), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenWidth), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenWidth), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_value")]
		[CalledBy(Type = typeof(TweenWidth), Member = "get_width")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(TweenWidth), Member = "set_width")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public int width
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
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
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIWidget), Member = "set_width")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallsUnknownMethods(Count = 1)]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenWidth), Member = "get_cachedWidget")]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenWidth()
	{
	}
}
