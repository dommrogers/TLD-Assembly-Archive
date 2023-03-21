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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public Texture2D portrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public Sprite portraitSprite
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Sprite), Member = "Create")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public Color dialogueColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Color);
		}
	}

	public Vector3 dialoguePosition
	{
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DialogueActor()
	{
	}

	[SpecialName]
	[DeduplicatedMethod]
	[CallerCount(Count = 1326)]
	[CallsUnknownMethods(Count = 1)]
	private Transform NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Eget_transform()
	{
		return null;
	}
}
