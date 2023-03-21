using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class DialogueOptionsAnimationSubTree : MonoBehaviour
{
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	public Dialogue_MultipleChoiceNode.ChoiceCategory m_Category;

	[CalledBy(Type = typeof(DialogueOptionsAnimationTree), Member = "InstantiateLabels")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	public List<DialogueSequenceFP> InstantiateLabels(GameObject labelPrefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DialogueOptionsAnimationSubTree()
	{
	}
}
