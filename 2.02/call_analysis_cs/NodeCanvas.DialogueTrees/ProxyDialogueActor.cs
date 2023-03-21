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
		[CallerCount(Count = 52)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return default(Color);
		}
	}

	public Vector3 dialoguePosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		get
		{
			return default(Vector3);
		}
	}

	public Transform transform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 83)]
	public ProxyDialogueActor(string name, Transform transform)
	{
	}
}
