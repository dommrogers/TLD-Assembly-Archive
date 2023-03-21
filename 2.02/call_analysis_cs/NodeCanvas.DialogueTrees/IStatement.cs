using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IStatement
{
	string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	string meta
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	VoiceOverAnimationState anim
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}
}
