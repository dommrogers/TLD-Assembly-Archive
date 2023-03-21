using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueOptionsAnimationTree : MonoBehaviour
{
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	public static string m_DebugCurrentTextSelected;

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Awake")]
	[Calls(Type = typeof(DialogueOptionsAnimationSubTree), Member = "InstantiateLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void InstantiateLabels(GameObject labelPrefab)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private Vector3 GetScreenCenterPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "UpdateClosestToCenter")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStateIdleUI")]
	[CallsUnknownMethods(Count = 17)]
	public void UpdateClosestToCenter()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public DialogueOptionsAnimationTree()
	{
	}
}
