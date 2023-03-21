using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenAlpha : UITweener
{
	public float from;

	public float to;

	private bool mCached;

	private UIRect mRect;

	private Material mMat;

	private SpriteRenderer mSr;

	public float alpha
	{
		[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
		[CalledBy(Type = typeof(StatusBar), Member = "SetAlpha")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "get_alpha")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "Begin")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(Panel_HUD), Member = "HideNewLocationDiscovered")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "set_alpha")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(TweenAlpha), Member = "set_value")]
	[CalledBy(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void Cache()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TweenAlpha()
	{
	}
}
