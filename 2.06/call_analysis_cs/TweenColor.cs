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
		[Calls(Type = typeof(TweenColor), Member = "get_value")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
		[Calls(Type = typeof(TweenColor), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Color value
	{
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Light), Member = "get_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "get_color")]
		[CalledBy(Type = typeof(TweenColor), Member = "Begin")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		get
		{
			return default(Color);
		}
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenColor), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenColor), Member = "set_color")]
		[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
		[CalledBy(Type = typeof(UIButtonColor), Member = "OnDisable")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		set
		{
		}
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(TweenColor), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TweenColor), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Cache()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'From'")]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'To'")]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenColor()
	{
	}
}
