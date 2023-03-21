using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private bool mCached;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	private SpriteRenderer mSr;

	public Color color
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenColor), Member = "get_value")]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenColor), Member = "set_value")]
		set
		{
		}
	}

	public Color value
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "Begin")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(TweenColor), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(TweenColor), Member = "get_color")]
		get
		{
			return default(Color);
		}
		[CalledBy(Type = typeof(UIButtonColor), Member = "OnDisable")]
		[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
		[CalledBy(Type = typeof(TweenColor), Member = "set_color")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIWidget), Member = "set_color")]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TweenColor), Member = "set_value")]
	[CalledBy(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Cache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'From'")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenColor()
	{
	}
}
