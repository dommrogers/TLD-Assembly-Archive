using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class DialogueActor : MonoBehaviour, IDialogueActor
{
	protected string _name;

	protected Texture2D _portrait;

	protected Color _dialogueColor;

	protected Vector3 _dialogueOffset;

	private Sprite _portraitSprite;

	public new string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	public Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	public Sprite portraitSprite
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Sprite), Member = "Create")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Color dialogueColor
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Color);
		}
	}

	public Vector3 dialoguePosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
	}

	[CallerCount(Count = 0)]
	public DialogueActor()
	{
	}

	[SpecialName]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1151)]
	private Transform NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Eget_transform()
	{
		return null;
	}
}
