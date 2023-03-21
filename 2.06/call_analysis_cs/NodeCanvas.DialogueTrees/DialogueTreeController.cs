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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 63)]
		get
		{
			return default(Color);
		}
	}

	private Vector3 NodeCanvas_002EDialogueTrees_002EIDialogueActor_002EdialoguePosition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 224)]
		get
		{
			return default(Vector3);
		}
	}

	private Transform NodeCanvas_002EDialogueTrees_002EIDialogueActor_002Etransform
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1207)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallerCount(Count = 0)]
	public void StartDialogue()
	{
	}

	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallerCount(Count = 0)]
	public void StartDialogue(Action<bool> callback)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void StartDialogue(IDialogueActor instigator)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StartDialogueTree), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CalledBy(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CalledBy(Type = typeof(StartDialogueTree), Member = "OnExecute")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStateStart")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	public void StopDialogue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "SetActorReference")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DialogueTree), Member = "SetActorReferences")]
	[CallsUnknownMethods(Count = 1)]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[Calls(Type = typeof(GraphOwner), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public DialogueTreeController()
	{
		((GraphOwner<>)(object)this)._002Ector();
	}
}
