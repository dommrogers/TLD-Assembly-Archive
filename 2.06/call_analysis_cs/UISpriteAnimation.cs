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
			return 0;
		}
	}

	public int framesPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return 0;
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
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeScale")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Update()
	{
	}

	[CalledBy(Type = typeof(UISpriteAnimation), Member = "set_namePrefix")]
	[CalledBy(Type = typeof(UISpriteAnimation), Member = "Start")]
	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PlayReverseFromFrame(int frameVal)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateFadeOverlay")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCurrentFrame()
	{
		return 0;
	}

	[CalledBy(Type = typeof(LoadingAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "OnBack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPixelSnap(bool pixelSnap)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public UISpriteAnimation()
	{
	}
}
