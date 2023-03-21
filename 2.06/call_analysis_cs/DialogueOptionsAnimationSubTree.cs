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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 16)]
	public List<DialogueSequenceFP> InstantiateLabels(GameObject labelPrefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public DialogueOptionsAnimationSubTree()
	{
	}
}
