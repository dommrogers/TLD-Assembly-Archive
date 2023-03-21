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
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CallerCount(Count = 5)]
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
		[Calls(Type = typeof(TweenPosition), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector3 value
	{
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		get
		{
			return default(Vector3);
		}
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_position")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(UIButtonOffset), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenPosition), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NGUIMath), Member = "MoveRect")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimatePosition")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'To'")]
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
