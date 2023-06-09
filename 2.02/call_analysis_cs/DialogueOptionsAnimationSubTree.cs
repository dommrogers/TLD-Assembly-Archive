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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	public List<DialogueSequenceFP> InstantiateLabels(GameObject labelPrefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public DialogueOptionsAnimationSubTree()
	{
	}
}
