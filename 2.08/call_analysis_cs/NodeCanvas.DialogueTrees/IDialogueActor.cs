using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IDialogueActor
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	Sprite portraitSprite
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
	}

	Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	Vector3 dialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}
}
