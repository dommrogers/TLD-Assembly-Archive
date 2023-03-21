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
		[CalledBy(Type = typeof(TweenHeight), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "set_value")]
		[CalledBy(Type = typeof(TweenHeight), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenHeight), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenHeight), Member = "set_height")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(TweenHeight), Member = "get_height")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		set
		{
		}
	}

	public int value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
		[Calls(Type = typeof(UIWidget), Member = "set_height")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 1)]
	private void SetCurrentValueToStart()
	{
	}

	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenHeight), Member = "get_cachedWidget")]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenHeight()
	{
	}
}
