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
		[CalledBy(Type = typeof(TweenColor), Member = "get_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "Begin")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Light), Member = "get_color")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Color);
		}
		[CalledBy(Type = typeof(UIButtonColor), Member = "OnDisable")]
		[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
		[CalledBy(Type = typeof(TweenColor), Member = "set_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(TweenColor), Member = "get_value")]
	[CalledBy(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Cache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenColor()
	{
	}
}
