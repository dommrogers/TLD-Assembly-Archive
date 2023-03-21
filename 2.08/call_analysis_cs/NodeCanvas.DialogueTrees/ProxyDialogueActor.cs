using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
public class ProxyDialogueActor : IDialogueActor
{
	private string _name;

	private Transform _transform;

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
	}

	public Texture2D portrait
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public Sprite portraitSprite
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return default(Color);
		}
	}

	public Vector3 dialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 263)]
	public ProxyDialogueActor(string name, Transform transform)
	{
	}
}
