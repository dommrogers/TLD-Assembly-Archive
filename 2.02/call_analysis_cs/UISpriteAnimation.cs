using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISpriteAnimation : MonoBehaviour
{
	protected int mFPS;

	protected string mPrefix;

	protected bool mLoop;

	protected bool mSnap;

	protected UISprite mSprite;

	protected float mDelta;

	protected int mIndex;

	protected bool mActive;

	protected List<string> mSpriteNames;

	private bool mIsReversed;

	public int frames
	{
		[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
		[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
		[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
		get
		{
			return default(int);
		}
	}

	public int framesPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string namePrefix
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool loop
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool isPlaying
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_timeScale")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	protected virtual void Update()
	{
	}

	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UISpriteAnimation), Member = "set_namePrefix")]
	[CalledBy(Type = typeof(UISpriteAnimation), Member = "Start")]
	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	public void RebuildSpriteList()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	public void PlayReverseFromFrame(int frameVal)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CallsUnknownMethods(Count = 1)]
	public int GetCurrentFrame()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPixelSnap(bool pixelSnap)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public UISpriteAnimation()
	{
	}
}
