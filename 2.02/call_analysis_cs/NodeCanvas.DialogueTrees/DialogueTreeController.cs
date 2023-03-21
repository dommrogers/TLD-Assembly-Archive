using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor
{
	private string NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Ename
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		get
		{
			return null;
		}
	}

	private Texture2D NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Eportrait
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private Sprite NodeCanvas_002EDialogueTrees_002EIDialogueActor_002EportraitSprite
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private Color NodeCanvas_002EDialogueTrees_002EIDialogueActor_002EdialogueColor
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		get
		{
			return default(Color);
		}
	}

	private Vector3 NodeCanvas_002EDialogueTrees_002EIDialogueActor_002EdialoguePosition
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	private Transform NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Etransform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1326)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	public void StartDialogue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	public void StartDialogue(Action<bool> callback)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartDialogue(IDialogueActor instigator)
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StartDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(StartDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	public void StartDialogue(IDialogueActor instigator, Action<bool> callback)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	public void PauseDialogue()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void StopDialogue()
	{
	}

	[Calls(Type = typeof(DialogueTree), Member = "SetActorReference")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueTree), Member = "SetActorReferences")]
	[CallsUnknownMethods(Count = 1)]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[CallsUnknownMethods(Count = 1)]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DialogueTreeController()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
