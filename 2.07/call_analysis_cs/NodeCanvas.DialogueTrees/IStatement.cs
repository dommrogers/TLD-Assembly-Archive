using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IStatement
{
	string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	AudioClip audio
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	string meta
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	VoiceOverAnimationState anim
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}
}
