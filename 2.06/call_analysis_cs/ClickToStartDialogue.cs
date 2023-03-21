using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

public class ClickToStartDialogue : MonoBehaviour
{
	public DialogueTree dialogue;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "get_localBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 9)]
	private void OnMouseDown()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDialogueEnd(bool success)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ClickToStartDialogue()
	{
	}
}
