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
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_value")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(TweenPosition), Member = "get_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CalledBy(Type = typeof(TweenPosition), Member = "Begin")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetStartToCurrentValue")]
		get
		{
			return default(Vector3);
		}
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUIMath), Member = "MoveRect")]
		[Calls(Type = typeof(TweenPosition), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_position")]
		[CalledBy(Type = typeof(TweenPosition), Member = "OnUpdate")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenPosition), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(UIButtonOffset), Member = "OnDisable")]
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

	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateScale")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimatePosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Animate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Dequeue")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 8)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "get_value")]
	[ContextMenu("Set 'From' to current value")]
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
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenPosition()
	{
	}
}
