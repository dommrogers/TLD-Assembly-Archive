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
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Light), Member = "get_color")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(TweenColor), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenColor), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenColor), Member = "Begin")]
		[CalledBy(Type = typeof(TweenColor), Member = "get_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
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
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(TweenColor), Member = "Cache")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		set
		{
		}
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(TweenColor), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Cache()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "AnimateColor")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Close")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "get_value")]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenColor), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenColor()
	{
	}
}
