using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public interface IDialogueActor
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Sprite portraitSprite
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Vector3 dialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}
}
