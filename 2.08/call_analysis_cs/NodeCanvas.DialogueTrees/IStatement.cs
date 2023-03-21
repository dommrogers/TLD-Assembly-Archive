using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IStatement
{
	string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	string meta
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	VoiceOverAnimationState anim
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}
}
