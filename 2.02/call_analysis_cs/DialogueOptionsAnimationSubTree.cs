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
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	public List<DialogueSequenceFP> InstantiateLabels(GameObject labelPrefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public DialogueOptionsAnimationSubTree()
	{
	}
}
