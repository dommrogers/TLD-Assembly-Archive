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
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenAlpha), Member = "get_alpha")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "Begin")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(StatusBar), Member = "SetAlpha")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Panel_HUD), Member = "HideNewLocationDiscovered")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "set_alpha")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TweenAlpha), Member = "set_value")]
	[CalledBy(Type = typeof(TweenAlpha), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 5)]
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
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeOut")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallerCount(Count = 6)]
	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	public override void SetStartToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[CallerCount(Count = 0)]
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
