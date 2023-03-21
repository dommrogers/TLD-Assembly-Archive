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

	[Calls(Type = typeof(AnimationState), Member = "set_layer")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(AnimationState), Member = "set_layer")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(Animation), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimationState), Member = "get_clip")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Animation), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Animation), Member = "CrossFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public PlayIdleAnimations()
	{
	}
}
