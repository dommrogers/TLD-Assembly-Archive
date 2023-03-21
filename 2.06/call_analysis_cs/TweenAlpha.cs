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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
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
		[CalledBy(Type = typeof(StatusBar), Member = "SetAlpha")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "get_alpha")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "Begin")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Panel_HUD), Member = "HideNewLocationDiscovered")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "set_alpha")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TweenAlpha), Member = "set_value")]
	[CalledBy(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	private void Cache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeOut")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
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
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TweenAlpha()
	{
	}
}
