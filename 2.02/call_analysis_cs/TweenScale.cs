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
		[CalledBy(Type = typeof(TweenScale), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenScale), Member = "set_scale")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_scale")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenScale), Member = "set_value")]
		[CalledBy(Type = typeof(TweenScale), Member = "get_value")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(TweenScale), Member = "Begin")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenScale), Member = "SetCurrentValueToStart")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenScale), Member = "SetStartToCurrentValue")]
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
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector3);
		}
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenScale), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	public TweenScale()
	{
	}
}
