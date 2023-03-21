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
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	public bool isPlaying
	{
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(AnimationState), Member = "get_length")]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[Calls(Type = typeof(Animation), Member = "IsPlaying")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Update")]
		[CallsUnknownMethods(Count = 20)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[CallsUnknownMethods(Count = 16)]
	public void Finish()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[Calls(Type = typeof(Animation), Member = "IsPlaying")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return null;
	}

	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 0)]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ActiveAnimation()
	{
	}
}
