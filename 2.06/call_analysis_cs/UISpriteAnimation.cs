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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int framesPerSecond
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		set
		{
		}
	}

	public bool loop
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_timeScale")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	protected virtual void Update()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UISpriteAnimation), Member = "set_namePrefix")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UISpriteAnimation), Member = "Start")]
	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void RebuildSpriteList()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PlayReverseFromFrame(int frameVal)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	public int GetCurrentFrame()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPixelSnap(bool pixelSnap)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UISpriteAnimation()
	{
	}
}
