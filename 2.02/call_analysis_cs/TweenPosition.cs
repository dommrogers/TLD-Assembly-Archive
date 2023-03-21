using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool worldSpace;

	private Transform mTrans;

	private UIRect mRect;

	public Transform cachedTransform
	{
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	public Vector3 position
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenPosition), Member = "get_value")]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenPosition), Member = "set_value")]
		set
		{
		}
	}

	public Vector3 value
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_position")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		get
		{
			return default(Vector3);
		}
		[Calls(Type = typeof(NGUIMath), Member = "MoveRect")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(UIButtonOffset), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimatePosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CallerCount(Count = 8)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		return null;
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenPosition()
	{
	}
}
