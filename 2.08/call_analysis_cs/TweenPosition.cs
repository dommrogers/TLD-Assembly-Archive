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
		[CalledBy(Type = typeof(TweenPosition), Member = "get_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CalledBy(Type = typeof(TweenPosition), Member = "get_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
		[CalledBy(Type = typeof(UIButtonOffset), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUIMath), Member = "MoveRect")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimatePosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
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
