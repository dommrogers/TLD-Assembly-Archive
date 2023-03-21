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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[CalledBy(Type = typeof(TweenAlpha), Member = "get_alpha")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "Begin")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(StatusBar), Member = "SetAlpha")]
		[CalledBy(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(TweenAlpha), Member = "set_alpha")]
		[CalledBy(Type = typeof(TweenAlpha), Member = "OnUpdate")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "HideNewLocationDiscovered")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TweenAlpha), Member = "Cache")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_color")]
		[Calls(Type = typeof(Material), Member = "set_color")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(TweenAlpha), Member = "get_value")]
	[CalledBy(Type = typeof(TweenAlpha), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Cache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenAlpha), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeOut")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenAlpha()
	{
	}
}
