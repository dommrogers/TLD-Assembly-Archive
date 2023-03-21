using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

public class ClickToStartDialogue : MonoBehaviour
{
	public DialogueTree dialogue;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 4)]
	private void OnMouseDown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDialogueEnd(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ClickToStartDialogue()
	{
	}
}
