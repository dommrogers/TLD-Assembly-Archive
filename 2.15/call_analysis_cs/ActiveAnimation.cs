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
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
	}

	public bool isPlaying
	{
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Update")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[Calls(Type = typeof(AnimationState), Member = "get_length")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 21)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void Finish()
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 20)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animation), Member = "IsPlaying")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 19)]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
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
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
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
