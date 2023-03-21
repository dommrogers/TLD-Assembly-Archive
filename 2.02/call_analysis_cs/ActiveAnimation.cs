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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
		[CallerCount(Count = 2)]
		get
		{
			return default(float);
		}
	}

	public bool isPlaying
	{
		[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AnimationState), Member = "get_length")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[Calls(Type = typeof(ActiveAnimation), Member = "get_playbackTime")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Update")]
		[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
		[Calls(Type = typeof(Animation), Member = "IsPlaying")]
		[Calls(Type = typeof(AnimationState), Member = "get_time")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[CallerCount(Count = 1)]
	public void Finish()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(AnimationState), Member = "set_speed")]
	[Calls(Type = typeof(AnimationState), Member = "get_speed")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(AnimationState), Member = "get_name")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(AnimationState), Member = "set_time")]
	[Calls(Type = typeof(AnimationState), Member = "get_length")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[Calls(Type = typeof(AnimationState), Member = "get_time")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ActiveAnimation), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animation), Member = "IsPlaying")]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "Refresh")]
	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public ActiveAnimation()
	{
	}
}
