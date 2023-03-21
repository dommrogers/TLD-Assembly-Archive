using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayIdleAnimations : MonoBehaviour
{
	private Animation mAnim;

	private AnimationClip mIdle;

	private List<AnimationClip> mBreaks;

	private float mNextBreak;

	private int mLastIndex;

	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(AnimationState), Member = "set_layer")]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimationState), Member = "set_layer")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Animation), Member = "CrossFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public PlayIdleAnimations()
	{
	}
}
