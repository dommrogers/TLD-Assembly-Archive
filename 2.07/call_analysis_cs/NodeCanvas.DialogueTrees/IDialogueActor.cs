using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IDialogueActor
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	Sprite portraitSprite
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	Color dialogueColor
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	Vector3 dialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}
}
