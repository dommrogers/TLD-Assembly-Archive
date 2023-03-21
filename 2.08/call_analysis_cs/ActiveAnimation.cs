using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActiveAnimation : MonoBehaviour
{
	public static ActiveAnimation current;

	public List<EventDelegate> onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private Animation mAnim;

	private Direction mLastDirection;

	private Direction mDisableDirection;

	private bool mNotify;

	private Animator mAnimator;

	private string mClip;

	private float playbackTime
	{
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public bool isPlaying
	{
		[Calls(Type = typeof(AnimationState), Member = "get_length")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 21)]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Update")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallsUnknownMethods(Count = 14)]
	public void Finish()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Start()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AnimationState), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animation), Member = "IsPlaying")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 2)]
	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveAnimation()
	{
	}
}
