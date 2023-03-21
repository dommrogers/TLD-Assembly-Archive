using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IDialogueActor
{
	string name
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	Sprite portraitSprite
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	Vector3 dialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}
}
