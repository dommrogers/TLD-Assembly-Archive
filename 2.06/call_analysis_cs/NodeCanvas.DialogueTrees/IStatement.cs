using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IStatement
{
	string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	string meta
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	VoiceOverAnimationState anim
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}
}
